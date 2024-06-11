<h1 align="center" style="font-weight: bold;">USBMonitor </h1>

<p align="center">
  <img src="UsbMonitor-Logo.jpg" alt="USBMonitor Logo" width="200px">
</p>



<p id="description">USBMonitor is a powerful tool designed to monitor and log USB device connections on both Windows and macOS. It helps you keep track of all USB devices that are connected to your system providing you with detailed logs and notifications.</p>

<p align="center">
	<img src="https://img.shields.io/github/license/CodeBerserkers888/USBMonitor?style=flat&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/CodeBerserkers888/USBMonitor?style=flat&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/CodeBerserkers888/USBMonitor?style=flat&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/CodeBerserkers888/USBMonitor?style=flat&color=0080ff" alt="repo-language-count">
<p>
<p align="center">
		<em>Developed with the software and tools below.</em>
</p>
<p align="center">
	<img src="https://img.shields.io/badge/GitHub%20Actions-2088FF.svg?style=flat&logo=GitHub-Actions&logoColor=white" alt="GitHub%20Actions">
</p>
<hr>

##  Quick Links

> - [ Overview](#-overview)
> - [ Features](#-features)
> - [ Repository Structure](#-repository-structure)
> - [ Modules](#-modules)
> - [ Getting Started](#-getting-started)
>   - [ Installation](#-installation)
>   - [ Running USBMonitor](#-running-USBMonitor)
>   - [ Tests](#-tests)
> - [ Project Roadmap](#-project-roadmap)
> - [ Contributing](#-contributing)
> - [ License](#-license)
> - [ Acknowledgments](#-acknowledgments)

---

##  Features

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


##  Repository Structure

```sh
└── USBMonitor/
    ├── .github
    │   └── workflows
    │       └── dotnet-desktop.yml
    ├── Program.cs
    ├── README.md
    ├── USBMonitor.csproj
    ├── USBMonitor.sln
    ├── UsbMonitor-Logo.jpg
    └── usb_log.txt
```

---

##  Modules

<details closed><summary>.</summary>

| File                                                                                               | Summary                                       |
| ---                                                                                                | ---                                           |
| [USBMonitor.sln](https://github.com/CodeBerserkers888/USBMonitor/blob/master/USBMonitor.sln)       | HTTP error 401 for prompt `USBMonitor.sln`    |
| [USBMonitor.csproj](https://github.com/CodeBerserkers888/USBMonitor/blob/master/USBMonitor.csproj) | HTTP error 401 for prompt `USBMonitor.csproj` |
| [usb_log.txt](https://github.com/CodeBerserkers888/USBMonitor/blob/master/usb_log.txt)             | HTTP error 401 for prompt `usb_log.txt`       |
| [Program.cs](https://github.com/CodeBerserkers888/USBMonitor/blob/master/Program.cs)               | HTTP error 401 for prompt `Program.cs`        |

</details>

<details closed><summary>.github.workflows</summary>

| File                                                                                                                   | Summary                                                          |
| ---                                                                                                                    | ---                                                              |
| [dotnet-desktop.yml](https://github.com/CodeBerserkers888/USBMonitor/blob/master/.github/workflows/dotnet-desktop.yml) | HTTP error 401 for prompt `.github/workflows/dotnet-desktop.yml` |

</details>

---

##  Getting Started

***Requirements***

Ensure you have the following dependencies installed on your system:

* **CSharp**: `version 1.1.0`

###  Installation

1. Clone the USBMonitor repository:

```sh
git clone https://github.com/CodeBerserkers888/USBMonitor
```

2. Change to the project directory:

```sh
cd USBMonitor
```

3. Install the dependencies:

```sh
dotnet build
```

###  Running USBMonitor

Use the following command to run USBMonitor:

```sh
dotnet run
```

###  Tests

To execute tests, run:

```sh
dotnet test
```

---

##  Project Roadmap

- [X] `► SOURCE CODE DEV `
- [X] `► WINX64 VER. with GUI`
- [ ] `► ...`

---

##  Contributing

Contributions are welcome! Here are several ways you can contribute:

- **[Submit Pull Requests](https://github.com/CodeBerserkers888/USBMonitor/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.
- **[Join the Discussions](https://github.com/CodeBerserkers888/USBMonitor/discussions)**: Share your insights, provide feedback, or ask questions.
- **[Report Issues](https://github.com/CodeBerserkers888/USBMonitor/issues)**: Submit bugs found or log feature requests for Usbmonitor.

<details closed>
    <summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your GitHub account.
2. **Clone Locally**: Clone the forked repository to your local machine using a Git client.
   ```sh
   git clone https://github.com/CodeBerserkers888/USBMonitor
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to GitHub**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.

Once your PR is reviewed and approved, it will be merged into the main branch.

</details>

---

##  License

This project is protected under the MIT License

---

##  Acknowledgments

- List any resources, contributors, inspiration, etc. here.

[**Return**](#-quick-links)

---
