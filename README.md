# Windows Terminal Launcher Proxy

## Overview
This repository hosts a .NET 8 application designed to serve as a proxy for launching Windows Terminal through various hardware devices that execute actions with a single button press, such as Razer keyboards, Elgato stream controllers, and numerous macro keyboards.

## Problem Statement
Accessing Windows Terminal programmatically can be cumbersome due to its installation path complexities. This often complicates integration with hardware controllers that enhance productivity by triggering software actions through dedicated keys.

## Solution
This application simplifies the process by creating an easily accessible `.exe` file that allows hardware devices to launch Windows Terminal seamlessly. When a button on the hardware is pressed, it triggers this application, which then immediately launches Windows Terminal, bypassing the typical path discovery issues.

## Usage
Integrate this executable with your hardware device's configuration software by setting it as the target action for a button or key press. Once set up, pressing the configured button on your hardware will directly open Windows Terminal through this proxy.

## Highlights
- **Seamless Integration**: Works out of the box with a variety of hardware controllers.
- **Easy Setup**: Minimal configuration required, just link the `.exe` in your device’s software.
- **Open Source**: Modify and extend the codebase to suit your specific needs.

Interestingly, this is the first repository I've created where the description is longer than the program itself—a reflection of the simplicity and focused utility of the application.
