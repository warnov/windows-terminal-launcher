using System;
using System.Diagnostics;
using System.IO;

// Check if an argument is provided
string? initialDirectory = null;

if (args.Length > 0)
{
    initialDirectory = args[0];
}
else
{
    string startupFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "startup");
    if (File.Exists(startupFilePath))
    {
        initialDirectory = File.ReadAllText(startupFilePath).Trim();
    }
}

// Open Windows Terminal in the specified initial directory if available
if (!string.IsNullOrEmpty(initialDirectory))
{
    Process.Start("wt.exe", $"-d {initialDirectory}");
}
else
{
    Process.Start("wt.exe");
}

// Exits the console app freeing all the resources
Environment.Exit(0);