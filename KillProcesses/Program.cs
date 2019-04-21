using System.Diagnostics;
using System;
using System.Windows.Forms;

namespace KillProcesses
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                var processes = Process.GetProcessesByName(args[0]);
                foreach (var process in processes)
                {
                    process.Kill();
                    process.Close();
                }
            }
            else
            {
                Console.WriteLine("Process name should be provided. Eg.: {0} notepad", Application.ProductName);
            }
        }
    }
}
