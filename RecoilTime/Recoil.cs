using System;
using System.Threading;

namespace RecoilControl
{
    class Recoil
    {
        public static bool Enabled = false;
        public static int sleeptime = 1;
        public static int verticalStrength = 2;   
        public static int horizontalStrength = 2; 

        private static Random random = new Random();

        public static void Loop()
        {
            while (true)
            {
                Thread.Sleep(sleeptime);
                if ((Win32.GetKeyState(0x70) & 0x8000) > 0 || (Win32.GetKeyState(0x2D) & 0x8000) > 0)
                {
                    Enabled = !Enabled;
                    Win32.Beep(Enabled ? 650u : 200u, 200u); 
                    Thread.Sleep(1000); 
                }

                if (!Enabled) continue;

                if ((Win32.GetKeyState(0x01) & 0x8000) > 0)
                {
                    for (int i = 0; i < verticalStrength; i++)
                    {
                        int vertical = 1;
                        int horizontal = Recoil.horizontalStrength;
                        Win32.Move(horizontal, vertical);
                    }
                }
            }
        }

    }
}
