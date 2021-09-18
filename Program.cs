using System;
using System.Runtime.InteropServices;

class Example
{
    // Use DllImport to import the Win32 MessageBox function.
    [DllImport("OWire_Module_x64.dll", CharSet = CharSet.Unicode)]
    public static extern int OW_OpenPort();
    
    static void Main()
    {
        // Call the MessageBox function using platform invoke.
        Console.WriteLine(OW_OpenPort());
    }
}