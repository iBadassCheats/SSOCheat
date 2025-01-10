using System.Runtime.InteropServices;

namespace ꜱꜱᴏ.ᴜᴛɪʟꜱ
{
    internal class ᴡɪɴᴀᴘɪ
    {
        public const int STD_OUTPUT_HANDLE = -11;
        public const int STD_INPUT_HANDLE = -10;
        public const int ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleTitle(string lpConsoleTitle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteConsole(IntPtr hConsoleOutput, string lpBuffer, uint nNumberOfCharsToWrite, out uint lpNumberOfCharsWritten, IntPtr lpReserved);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll")]
        public static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, ushort wAttributes);

        [DllImport("kernel32.dll", SetLastError = true)]
        [PreserveSig]
        public static extern bool DisableThreadLibraryCalls([In] IntPtr hModule);
    }
}
