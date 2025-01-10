using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ꜱꜱᴏ.ᴜᴛɪʟꜱ
{
    internal class ᴄᴏɴꜱᴏʟᴇ
    {
        public enum ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ
        {
            ᴄᴏɴꜱᴏʟᴇ_ꜱᴜᴄᴄᴇꜱꜱꜰᴜʟʟʏ,
            ᴄᴏɴꜱᴏʟᴇ_ꜰᴀɪʟᴇᴅ
        }

        public static ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ ɪɴɪᴛɪᴀʟɪᴢᴇ()
        {
            try
            {
                ᴡɪɴᴀᴘɪ.AllocConsole();
                IntPtr console = ᴡɪɴᴀᴘɪ.GetStdHandle(ᴡɪɴᴀᴘɪ.STD_OUTPUT_HANDLE);
                ᴡɪɴᴀᴘɪ.GetConsoleMode(console, out var mode);
                ᴡɪɴᴀᴘɪ.SetConsoleMode(console, mode | ᴡɪɴᴀᴘɪ.ENABLE_VIRTUAL_TERMINAL_PROCESSING);
                ᴡɪɴᴀᴘɪ.SetConsoleTitle("https://github.com/iBadassCheats/SSOCheat");
                ᴡɪɴᴀᴘɪ.SetConsoleTextAttribute(console, (ushort)ConsoleColor.White);
                ɪɴꜰᴏ("https://github.com/iBadassCheats/SSOCheat");

                return ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ.ᴄᴏɴꜱᴏʟᴇ_ꜱᴜᴄᴄᴇꜱꜱꜰᴜʟʟʏ;
            }
            catch
            {
                return ɪɴɪᴛɪᴀʟɪᴢᴇʀᴇꜱᴜʟᴛ.ᴄᴏɴꜱᴏʟᴇ_ꜰᴀɪʟᴇᴅ;
            }
        }

        public static void ɪɴꜰᴏ(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"  [{DateTime.Now.ToLongTimeString()}] [Info]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public static void ᴇʀʀᴏʀ(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"  [{DateTime.Now.ToLongTimeString()}] [Error]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public static void ᴡᴏʀᴋɪɴɢ(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"  [{DateTime.Now.ToLongTimeString()}] [Working]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public static void ʟᴏᴀᴅᴇʀ(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"  [{DateTime.Now.ToLongTimeString()}] [Loader]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public static void ᴅᴇʙᴜɢ(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"  [{DateTime.Now.ToLongTimeString()}] [Debug]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public static void ꜱʜᴏʀᴛ(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"  [{DateTime.Now.ToLongTimeString()}] [Debug]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Thread.Sleep(2500);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, currentLineCursor - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor - 1);
        }
    }
}
