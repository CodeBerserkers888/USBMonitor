using System;
using System.IO;
using System.Threading;
using Gtk;
using LibUsbDotNet;
using LibUsbDotNet.Main;

class Program
{
    private static readonly string logFile = "usb_log.txt";
    private static bool isRunning = true;
    private static UsbDeviceFinder usbFinder = new UsbDeviceFinder(0x0000, 0x0000);

    static void Main(string[] args)
    {
        Application.Init();

        Console.WriteLine("USB Monitor started.");
        LogEvent("Started USB monitoring.");

        Thread monitorThread = new Thread(MonitorUSB);
        monitorThread.Start();

        var win = new Window("USB Monitor");
        win.SetDefaultSize(400, 300);
        win.DeleteEvent += delegate { Application.Quit(); };

        // Dodanie etykiety i przycisku do interfejsu
        var vbox = new VBox();
        var label = new Label("Monitoring USB devices...");
        var button = new Button("Stop Monitoring");
        button.Clicked += (sender, e) =>
        {
            isRunning = false;
            Application.Quit();
        };

        vbox.PackStart(label, true, true, 0);
        vbox.PackStart(button, false, false, 0);
        win.Add(vbox);

        // Dodajemy obsługę hotkey Ctrl+Shift+Q
        win.KeyPressEvent += (o, e) =>
        {
            if ((e.Event.State & Gdk.ModifierType.ControlMask) != 0 &&
                (e.Event.State & Gdk.ModifierType.ShiftMask) != 0 &&
                e.Event.Key == Gdk.Key.q)
            {
                isRunning = false;
                Application.Quit();
            }
        };

        win.ShowAll();
        Application.Run();

        monitorThread.Join();
        LogEvent("Stopped USB monitoring.");
        Console.WriteLine("USB Monitor stopped.");
    }

    private static void MonitorUSB()
    {
        while (isRunning)
        {
            using (UsbDevice usbDevice = UsbDevice.OpenUsbDevice(usbFinder))
            {
                if (usbDevice != null)
                {
                    LogEvent("USB device inserted.");
                    usbDevice.Close();
                }
            }

            Thread.Sleep(1000);
        }
    }

    private static void LogEvent(string eventMessage)
    {
        using (StreamWriter sw = new StreamWriter(logFile, true))
        {
            sw.WriteLine($"{DateTime.Now} - {eventMessage}");
        }
    }
}
