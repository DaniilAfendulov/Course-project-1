using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Adventure.Forms
{
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWind, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state) => SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
    }

    

}
