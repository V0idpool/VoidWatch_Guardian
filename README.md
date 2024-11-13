# VoidWatch Guardian
![VoidWatchGuardian](https://img.shields.io/badge/version-1.3-brightgreen)
![Release](https://img.shields.io/badge/Release-11%2F13%2F2024-blue)

![VoidWatch Guardian Logo](https://raw.githubusercontent.com/V0idpool/VoidWatch_Guardian/refs/heads/main/voidwatch.webp)

VoidWatch Guardian is a Windows-based watchdog application designed to automatically monitor, restart, and manage Discord bot executables or any other application executables. It provides real-time status updates on program status (running or stopped), automatically restarts programs if they unexpectedly terminate, and logs events and errors.

## ⚙️ **Version**: 1.3 (Public Release)  
## 👨‍💻 **Author**: VoidBot Development Team ([@VoidPool](https://github.com/V0idpool))  
## 📅 **Release Date**: 11/13/2024  

## Features

- **Monitor Multiple Programs**: Keep an eye on multiple executables (Discord bots, Node.js instances, etc.) simultaneously.
- **Automatic Restart**: Automatically restart any monitored programs that stop unexpectedly.
- **Configurable Monitoring Interval**: Set a custom monitoring interval to specify how often VoidWatch Guardian checks the status of monitored applications.
- **Periodic Auto-Restart**: Option to periodically restart programs based on a user-defined interval.
- **Logging**: Tracks events such as application crashes, restart attempts, and general errors.
- **Auto Start Option**: Start monitoring automatically when VoidWatch Guardian launches.
- **Easy Program Addition/Removal**: Add or remove executables with just a few clicks directly in the application, no need to manually edit configuration files.

## Installation and Setup

1. **Download Source and Extract** Download VoidWatch Guardian here: [VoidWatch Guardian Releases](https://github.com/V0idpool/VoidWatch_Guardian/releases/)
2. **Open in Visual Studio**: Open `VoidWatch Guardian` in Visual Studio to build and run.
3. **Configure Settings in the App**:
    - **Executable Paths**: Use the `Add` button to add program executables (e.g., `.exe` files) that you want to monitor.
    - **Auto Start Monitoring**: Toggle in the app to start monitoring automatically on launch.
    - **Monitoring Interval**: Set a custom monitoring interval through the application’s settings form or edit it directly in `UserCFG.ini` under the `MonitoringInterval` setting.
    - **Auto-Restart and Interval**: Enable periodic auto-restart and specify the interval in hours through the app or by setting `EnablePeriodicRestart=True` in `UserCFG.ini` and adjusting `RestartInterval`.

**Download pre-built releases here:** [VoidWatch Guardian Releases](https://github.com/V0idpool/VoidWatch_Guardian/releases/)

## Usage

### Adding Programs to Monitor

1. Launch VoidWatch Guardian.
2. Click the `Add` button.
3. Browse and select the executable file you wish to monitor.
4. The application will automatically display the program name in the grid and start monitoring based on your chosen settings.

### Removing Programs

1. Select a program in the monitored list.
2. Click the `Remove` button to stop monitoring and remove the program from both the list and configuration file.

### Starting and Stopping Monitoring

- **Start Monitoring**: Click `Start Monitoring` to begin tracking the status of all added programs, and restart them if they crash or close.
- **Stop Monitoring**: Click `Stop Monitoring` to halt all monitoring and set the monitoring status of each program to `Stopped`.

### Logging

Logs are saved to a file named `log_file.txt` located in the application directory. Each log entry includes the date, event type, program name, and additional information, such as restart attempts and errors.

## Configuration File (UserCFG.ini)

The `UserCFG.ini` file stores essential settings and program paths. Here’s a breakdown of key settings:

- **AutoStart**: `True` to enable automatic monitoring upon application launch.
- **MonitoringInterval**: The interval in seconds for the monitoring timer.
- **EnablePeriodicRestart**: `True` to enable periodic program restarts based on the set `RestartInterval`.
- **RestartInterval**: The interval in hours for periodically restarting all monitored programs.
- **Program Paths**: Each monitored program has an entry as `Program1`, `Program2`, etc.

Example:
```ini
[Settings]
AutoStart=True
MonitoringInterval=5
EnablePeriodicRestart=True
RestartInterval=24

[WatchDogPrograms]
Program1=C:\Path\To\DiscordBot.exe
Program2=C:\Path\To\AnotherProgram.exe
