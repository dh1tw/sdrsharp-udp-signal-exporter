# UDPSignalExporter Plugin for SDR#

![Screenshot](docs/sdrsharp-udp-signal-exporter.png?raw=true)

This is a simple plugin that captures periodically signal information from SDR# and sends it via UDP to other applications.

Currently, the following parameters are captured:
1. Noise Floor [dbFS]
2. Signal Peak [dbFS]
3. Signal / Noise ratio [db]

The values are rounded to one decimal and concatenated into a string in the order shown above. The values are separated by a semicolon (';'). The string is terminated with a newline character ('\n').

## Build System

This plugin is based on the Template provided by the [SDR# SDK for Plugin Developers](https://airspy.com/download/).

The plugin was built with [Visual Studio 2022](https://visualstudio.microsoft.com/de/vs/) against the [.NET7 Windows x86 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.100-windows-x86-installer). It has been tested with SDR# Version 1.0.0.1919.

## Install

[Download]() or fetch from the `Release/net7.0-windows` folder the file `SDRSharp.UDPSignalExporter.dll` and drop it into the plugin directory of your SDR# installation. The plugin will then become available with SDR#'s plugin menu.

## Capture the data

### CLI (Linux & MacOS)

You can easily capture the UDP broadcast with `netcat` or `socat` on any Linux / MacOS.

```` bash

$ socat - udp-recv:9988

-118.4;-102.8;15.6
-118.6;-104.2;14.4
-118.6;-105.5;13.2
-118.6;-107.7;10.9
-118.8;-108.7;10.1
-118.9;-110.4;8.5
-118.8;-111.2;7.7
[...]

````

### CLI (Windows)

On Windows, execute the powershell script [demo/listen-udp.ps1](demo/listen-udp.ps1)

```` powershell

PS C:\> .\listen-udp.ps1
Receive-UDP:Wait for Data on Port: 9988
Received packet from IP  192.168.1.110 : 59321
Content -100;-96.1;3.9

Receive-UDP:Wait for Data on Port: 9988
Received packet from IP  192.168.1.110 : 59321
Content -101.1;-96.8;4.3

[...]

````

### Python

You can find in [demo/listen-udp.py](demo/listen-udp.py) an example python3 script on how to receive and further process the data.