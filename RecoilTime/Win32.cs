using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RecoilControl
{
    class Win32
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Beep(uint dwFreq, uint dwDuration);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.Dll")]
        public static extern short GetKeyState(uint nVirtKey);
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_XDOWN = 0x0080;
        const uint MOUSEEVENTF_XUP = 0x0100;
        const uint MOUSEEVENTF_WHEEL = 0x0800;
        const uint MOUSEEVENTF_HWHEEL = 0x01000;
        public const int HOTKEY_F2 = 1;
        public const int HOTKEY_F3 = 2;
        public static void Move(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
        }
        public static bool RegisterGlobalHotkeys(IntPtr hWnd)
        {
            bool f2Hotkey = RegisterHotKey(hWnd, HOTKEY_F2, 0, (uint)Keys.F2);
            bool f3Hotkey = RegisterHotKey(hWnd, HOTKEY_F3, 0, (uint)Keys.F3);

            return f2Hotkey && f3Hotkey;
        }
        public static void UnregisterGlobalHotkeys(IntPtr hWnd)
        {
            UnregisterHotKey(hWnd, HOTKEY_F2);
            UnregisterHotKey(hWnd, HOTKEY_F3);
        }
    }
}
