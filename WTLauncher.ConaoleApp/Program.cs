// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


//Open windows terminal on a separate process in c:\src
Process.Start("wt.exe", "-d c:\\src");

//Exits the console app freeing all the resources
Environment.Exit(0);