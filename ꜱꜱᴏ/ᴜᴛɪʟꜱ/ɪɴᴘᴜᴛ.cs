using System.Runtime.InteropServices;


namespace ꜱꜱᴏ.ᴜᴛɪʟꜱ
{
    internal class ɪɴᴘᴜᴛ
    {
        [DllImport("USER32.dll")]
        private static extern short GetKeyState(int nVirtKey);

        public static bool isKeyPress(int nVirtKey)
        {
            return Convert.ToBoolean(GetKeyState(nVirtKey) & 0x8000);
        }
    }
}
