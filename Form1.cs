using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace bapp
{
    public partial class bapp : Form
    {
        public bapp()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        string GetProcessNameOfActiveApp()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process processActive = Process.GetProcessById((int)pid);
            return processActive.ProcessName;
        }

        int GetProcessIdOfActiveApp()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process processActive = Process.GetProcessById((int)pid);
            return processActive.Id;
        }

        private void scanApp_Tick(object sender, EventArgs e)
        {
            string procName = GetProcessNameOfActiveApp();
            if (procName == "chrome" || procName == "iexplore" || procName == "firefox" || procName == "opera")
            {
                Process proc = Process.GetProcessById(GetProcessIdOfActiveApp());
                proc.Kill();
            }
        }
    }
}
