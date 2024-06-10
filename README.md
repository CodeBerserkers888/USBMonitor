<h1 align="center" style="font-weight: bold;">USBMonitor 💻</h1>

<p align="center">
  <img src="UsbMonitor-Logo.jpg" alt="USBMonitor Logo" width="200px">
</p>



<p id="description">USBMonitor is a powerful tool designed to monitor and log USB device connections on both Windows and macOS. It helps you keep track of all USB devices that are connected to your system providing you with detailed logs and notifications.</p>

<p align="center"><img src="https://img.shields.io/badge/DefensePayload-AntyBadUSB-green" alt="shields"></p>
<p align="center"><img src="https://img.shields.io/github/release-date/CodeBerserkers888/USBMonitor" alt="shields"></p>

<p align="center">
<a href="#technologies">Technologies</a>
<a href="#getting-started">Getting Started</a>
<a href="#collaborators">Collaborators</a>
<a href="#contribute">Contribute</a> 
</p>
 
  
<h2>🧐 Features</h2>

Here're some of the project's best features:

*   Real-Time Monitoring: Continuously monitors USB device connections and disconnections in real-time.
*   Detailed Logging: Logs detailed information about each USB device connection including timestamp device name and serial number.
*   Cross-Platform Support: Fully supports both Windows and macOS platforms.
*   Secure Logging: Encrypts log files to protect sensitive information about connected devices.
*   Custom Log Location: Allows users to specify a custom location for saving log files.
*   Device Whitelisting: Enables users to whitelist trusted USB devices ignoring them in the logs.
*   Graphical User Interface (GUI): Includes a user-friendly GUI for easy access and control over the monitoring process.
*   Hotkey Support: Allows users to quickly enable or disable monitoring using configurable hotkeys.
*   Email Alerts: Sends email alerts when a new USB device is connected to the system.
*   Auto-Start on Boot: Configures the application to start automatically when the system boots up.
*   Customizable Settings: Provides an easy way to customize various settings such as notification preferences and log file formats.
*   Language Support: Supports multiple languages for user notifications and interface. First: Germany Norwegian Spanish

<h2>🛠️ Installation Steps:</h2>

<p>1. Clone Rep.</p>

```
git clone https://github.com/CodeBerserkers888/USBMonitor.git cd USBMonitor
```

<p>2. Install dependencies</p>

```
sh copy dotnet add package LibUsbDotNet dotnet add package GtkSharp dotnet add package System.Management
```

<p>3. Build the project</p>

```
dotnet build
```

<p>4. Run</p>

```
dotnet run
```

<h2>🍰 Contribution Guidelines:</h2>

We welcome contributions from the community! If you want to contribute to this project please follow these steps: 1. git clone https://github.com/CodeBerserkers888/USBMonitor.git 2. git checkout -b feature/NAME 3. Follow commit patterns 4. Open a Pull Request explaining the problem solved or feature made if exists append screenshot of visual modifications and wait for the review!

  
  
<h2>💻 Built with</h2>

Technologies used in the project:

*   .NET Core
*   LibUsbDotNet library
*   GtkSharp library

<h2>🛡️ License:</h2>

This project is licensed under the This project is licensed under the MIT License.

<h2>💖Like my work?</h2>

If you have any questions or suggestions feel free to reach out to us through GitHub Issues or directly on our GitHub profiles.
