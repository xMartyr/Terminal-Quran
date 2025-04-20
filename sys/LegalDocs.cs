using static System.Console;
using static System.ConsoleColor;

namespace Terminal_Quran.sys
{
    internal class LegalDocs
    {
        public static void About()
        {
            Clear();
            CursorVisible = false;
            ForegroundColor = Yellow;
            WriteLine($"\n{StringLibrary.asciiTitles[7]}\n\n\t\x1b[1;33mTerminal Qur'an \x1b[1;37m-\x1b[0;34m designed & developed by \x1b[1;32mxMartyr\x1b[1;37m.");

            StringLibrary.UserInfo5();

            WriteLine("\n\t\x1b[0;37m================================================================");

            WriteLine("\n\t\x1b[1;37mThe \x1b[1;33mTerminal Qur'an\x1b[1;37m is a .NET 9 Console Application that provides\n\t\x1b[1;33mPrayer Times\x1b[1;37m and easy offline-access to the \x1b[1;33mHoly Qur'an\x1b[1;37m.");

            WriteLine("\n\tFeatures includes;\n\t\x1b[0;31m-\x1b[1;37m get prayer times\n\t\x1b[0;31m-\x1b[1;37m a list of the 99 names of Allah\n\t\x1b[0;31m-\x1b[1;37m read the Qur'an by a simple index input\n\t\x1b[0;31m-\x1b[1;37m search for verses with a prompt\n\t\x1b[0;31m-\x1b[1;37m get random verses with an index");
            
            WriteLine("\n\tInSha'Allah (God Willing), that the application\n\tis beneficial to you in knowledge and truth.");

            WriteLine("\n\t\x1b[1;37mAny donation to my \x1b[1;34mPayPal\x1b[1;37m would be greatly appreciated\n\tfor the time and effort I’ve put into this project:\n\t\x1b[0;31m- \x1b[1;32mhttps://paypal.me/jetbl7ck\x1b[1;37m\n\tThank you.");

            WriteLine("\n\t\x1b[0;37m================================================================");

            StringLibrary.UserInfo5();

            ReadLine();
            UserInterface.StartProgram();
        }

        public static void CopyrightAndPrivacyPolicy()
        {
            Clear();
            CursorVisible = false;
            ForegroundColor = Yellow;
            WriteLine($"\n{StringLibrary.asciiTitles[8]}\n\n\t\x1b[1;33mTerminal Qur'an \x1b[1;37m-\x1b[1;32m Copyright\x1b[0;34m &\x1b[1;32m Privacy Policy\x1b[1;37m.");
            
            StringLibrary.UserInfo5();

            WriteLine("\n\t\x1b[0;37m=====================================================================");

            WriteLine($"\n\t©\x1b[1;32m {DateTime.Now.Year}\x1b[1;37m xMartyr - All Rights Reserved.");

            WriteLine("\n\t\x1b[1;37mTerminal Qur'an is a C# Console Application that\n\tprovides access to the Holy Qur'an.");

            WriteLine("\n\t| We do NOT collect any user or device data!\n\t| The certainty of this claim can be confirmed by examining the code.");
            
            WriteLine("\n\tPlease note that the Qur'an Library content script is open-source\n\tand may be copied to be used for other projects.");

            WriteLine("\n\tHowever, the Terminal Qur'an application may NOT be edited, modified,\n\tor distributed in any way without our express written permission.");
            
            WriteLine("\n\tIf you have any questions or concerns about our Privacy Policy,\n\tplease don't hesitate to contact us on \x1b[1;36mDiscord\x1b[1;37m.");

            WriteLine("\n\tAn expanded contact information is listed in the \"\x1b[1;32m5\x1b[1;37m.\x1b[1;33m About\x1b[1;37m\"\x1b[1;37m section,\n\tthrough the Main menu.");
            
            WriteLine($"\n\t©\x1b[1;32m {DateTime.Now.Year}\x1b[1;37m xMartyr - All Rights Reserved.");

            WriteLine("\n\t\x1b[0;37m=====================================================================");

            StringLibrary.UserInfo5();

            ReadLine();
            UserInterface.StartProgram();
        }
    }
}