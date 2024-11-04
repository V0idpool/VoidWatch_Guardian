# VoidWatch Guardian
![VoidWatch Guardian Logo](https://raw.githubusercontent.com/V0idpool/VoidWatch_Guardian/refs/heads/main/voidwatch.webp)
VoidWatch Guardian is a Windows-based watchdog application designed to automatically monitor and manage Discord bot executables or any other application executables. It provides real-time status updates on program status (running or stopped), attempts to restart processes if they unexpectedly terminate, and logs events and errors.

## Features

- **Monitor Multiple Programs**: Keep an eye on multiple executables (Discord bots, Node.js instances, etc.) at once.
- **Automatic Restart**: Automatically restart any monitored programs that stop unexpectedly.
- **Configurable Monitoring Interval**: Set a custom monitoring interval for how often VoidWatch Guardian checks the status of monitored applications.
- **Logging**: Tracks events such as application crashes, restart attempts, and general error logs.
- **Auto Start Option**: Start monitoring automatically when VoidWatch Guardian launches.
- **Easy Program Addition/Removal**: Add or remove executables with just a few clicks.

## Installation and Setup

1. **Download and Extract**: Dowmload VoidWatch Guardian here: https://github.com/V0idpool/VoidWatch_Guardian/releases/
2. **Open in Visual Studio**: Open `VoidWatch Guardian` in Visual Studio to build and run.
3. **Configure Settings**:
    - **Executable Paths**: Use the `Add` button to add program executables (e.g., `.exe` files) that you want to monitor.
    - **Auto Start**: To enable auto start monitoring, set `AutoStart=True` in the `UserCFG.ini` file.
    - **Monitoring Interval**: Set a custom monitoring interval through the application settings or directly in `UserCFG.ini` under the `MonitoringInterval` setting.

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
- **Program Paths**: Each monitored program has an entry as `Program1`, `Program2`, etc.

Example:
```ini
[Settings]
AutoStart=True
MonitoringInterval=5

[WatchDogPrograms]
Program1=C:\Path\To\DiscordBot.exe
Program2=C:\Path\To\AnotherProgram.exe
