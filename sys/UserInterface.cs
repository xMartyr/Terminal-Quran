using static System.Console;
using static System.ConsoleColor;
using System.Net.NetworkInformation;
using System.Net;

namespace Terminal_Quran.sys
{
    internal class UserInterface
    {
        public static bool surahEnabled;
        public static bool searchEnabled;
        public static bool randomEnabled;

        private static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static void StartProgram()
        {
            ResetColor();
            MainMenu();
        }

        private static void MainMenu()
        {
            CursorVisible = false;
            while (true)
            {
                surahEnabled = false;
                searchEnabled = false;
                randomEnabled = false;

                Clear();

                ForegroundColor = Yellow;
                WriteLine($"\n{StringLibrary.asciiTitles[2]}");
                ForegroundColor = DarkGray;
                WriteLine("\t   v.1.0.0.0 | xMartyr");
                ResetColor();

                WriteLine("\n\t\x1b[0;31m--- \x1b[1;36mAs-salamu'Alaikum wa Rahmatullahi wa Barakatuh\x1b[0;31m ---");
                WriteLine("\n\t\x1b[1;36mWelcome to the \x1b[1;33mTerminal Qur'an\x1b[1;36m Console Application!");

                WriteLine("\n\t\x1b[1;37mAny donation to my \x1b[1;34mPayPal\x1b[1;37m would be greatly appreciated\n\tfor the time and effort I’ve put into this project:\n\t\x1b[0;31m- \x1b[1;32mhttps://paypal.me/jetbl7ck\x1b[1;37m\n\tThank you.");

                WriteLine("\n\t\x1b[1;34mMake a \x1b[1;32mchoice\x1b[1;34m to proceed:");

                Write("\n\t\x1b[1;32m1\x1b[1;37m. Get \x1b[1;36mPrayer\x1b[1;37m times.");

                if (!CheckInternetConnection())
                {
                    ForegroundColor = DarkRed;
                    Write(" (NETWORK FAILED)");
                }
                Write("\n");

                WriteLine("\n\t\x1b[1;32m2\x1b[1;37m. \x1b[1;36mAl-Asma Ul-Husna \x1b[0;37m(The 99 Names of Allah)\x1b[1;37m.");
                WriteLine("\n\t\x1b[1;32m3\x1b[1;37m. \x1b[1;36mSurah \x1b[0;37m(chapter)\x1b[1;37m list.");
                WriteLine("\n\t\x1b[1;32m4\x1b[1;37m. Search for \x1b[1;36mAyat \x1b[0;37m(verses)\x1b[1;37m.");
                WriteLine("\n\t\x1b[1;32m5\x1b[1;37m. Get Random \x1b[1;36mAyat \x1b[0;37m(verses)\x1b[1;37m.");
                WriteLine("\n\t\x1b[1;32m6\x1b[1;37m. About \x1b[1;33mTerminal Qur'an\x1b[1;37m.");
                WriteLine("\n\t\x1b[1;32m7\x1b[1;37m. Copyright & Privacy Policy.");
                WriteLine("\n\t\x1b[1;32m8\x1b[1;37m. \x1b[0;31mExit\x1b[1;37m.");
                ForegroundColor = Magenta;
                Write("\n\t\t>>> ");
                ForegroundColor = Green;
                CursorVisible = true;
                string menuChoice = ReadLine();
                CursorVisible = false;
                ResetColor();

                switch (menuChoice)
                {
                    case "1":
                        if (!CheckInternetConnection())
                        {
                            ForegroundColor = DarkRed;
                            WriteLine("\n\t// No internet connection");
                            Thread.Sleep(1000);
                            WriteLine("\t// Cancelling process...");
                            ResetColor();
                            Thread.Sleep(1750);
                            StartProgram();
                        }
                        else if (NetworkInterface.GetIsNetworkAvailable())
                        {
                            Salah();
                        }
                        break;

                    case "2":
                        Al_Asma_Ul_Husna.AlAsma();
                        break;

                    case "3":
                        QuranListMenu();
                        break;

                    case "4":
                        searchEnabled = true;
                        PrintQuran.PrintEntry();
                        break;

                    case "5":
                        randomEnabled = true;
                        PrintQuran.PrintEntry();
                        break;

                    case "6":
                        LegalDocs.About();
                        break;

                    case "7":
                        LegalDocs.CopyrightAndPrivacyPolicy();
                        break;

                    case "8":
                        ExitTerminalQuran();
                        break;
                }
            }
        }

        private static void Salah()
        {
            Clear();
            bool firstStart = true;
            ForegroundColor = Yellow;
            WriteLine($"\n{StringLibrary.asciiTitles[3]}\n");

            while (true)
            {
                if (firstStart == true)
                {
                    WriteLine($"\n\t\x1b[1;34m// Waiting for your \x1b[1;32mLocation\x1b[1;34m prompt...");
                    ForegroundColor = Gray;
                    WriteLine($"\n\t\x1b[0;37mFajr     \x1b[1;30m------------  >\x1b[0;37m  N/A");
                    ForegroundColor = DarkGray;
                    WriteLine($"\t\x1b[1;30mSunrise  ------------  >  N/A");
                    ForegroundColor = Gray;
                    WriteLine($"\t\x1b[0;37mDhuhr    \x1b[1;30m------------  >\x1b[0;37m  N/A");
                    WriteLine($"\t\x1b[0;37m'Asr     \x1b[1;30m------------  >\x1b[0;37m  N/A");
                    WriteLine($"\t\x1b[0;37mMaghrib  \x1b[1;30m------------  >\x1b[0;37m  N/A");
                    WriteLine($"\t\x1b[0;37mIsha'    \x1b[1;30m------------  >\x1b[0;37m  N/A");
                }

                StringLibrary.UserInfo2();
                WriteLine("\n\t\x1b[1;34mEnter a \x1b[1;32mcity\x1b[1;34m/\x1b[1;32mlocation\x1b[1;34m:");
                
                ForegroundColor = Magenta;
                Write("\n\t\t>>> ");
                ForegroundColor = Green;
                CursorVisible = true;
                string city = ReadLine();
                string savedCity;
                CursorVisible = false;
                firstStart = false;
                ResetColor();

                bool isInvalidInput = city.Any(c => char.IsDigit(c) || char.IsSymbol(c));

                var prayerTimes = PrayerTimesApi.GetPrayerTimes(city).Result;

                if (city == "" || city == "0")
                {
                    StartProgram();
                    break;
                }
                else if (prayerTimes == null || isInvalidInput)
                {
                    firstStart = true;
                    ForegroundColor = DarkRed;
                    WriteLine("\n\n\t// Invalid input!");
                    Write($"\n\t// Could not find prayer times for \"\x1b[1;32m{city}");
                    ForegroundColor = DarkRed;
                    WriteLine("\".");
                    WriteLine("\n\t// Please enter a city or location.");

                    Thread.Sleep(1750);

                    Clear();
                    ForegroundColor = Yellow;
                    WriteLine($"\n{StringLibrary.asciiTitles[3]}\n");
                }
                else
                {
                    int sleep = 200;
                    Clear();
                    ForegroundColor = Yellow;
                    WriteLine($"\n{StringLibrary.asciiTitles[3]}\n");
                    Thread.Sleep(sleep);
                    WriteLine($"\n\tPrayer \x1b[1;34mtimes for \x1b[1;32m{city}\x1b[1;30m (\x1b[1;37m{prayerTimes.GregorianDate:dd/MM/yyyy}\x1b[1;30m)\x1b[1;34m:");
                    Thread.Sleep(sleep);
                    WriteLine($"\n\t\x1b[1;32mFajr     \x1b[1;30m------------  >\x1b[1;32m  {prayerTimes.data.timings.Fajr}");
                    Thread.Sleep(sleep);
                    WriteLine($"\t\x1b[1;36mSunrise  \x1b[1;30m------------  >\x1b[1;36m  {prayerTimes.data.timings.Sunrise}");
                    Thread.Sleep(sleep);
                    WriteLine($"\t\x1b[1;33mDhuhr    \x1b[1;30m------------  >\x1b[1;33m  {prayerTimes.data.timings.Dhuhr}");
                    Thread.Sleep(sleep);                                     
                    WriteLine($"\t\x1b[1;33m'Asr     \x1b[1;30m------------  >\x1b[1;33m  {prayerTimes.data.timings.Asr}");
                    Thread.Sleep(sleep);                                     
                    WriteLine($"\t\x1b[1;34mMaghrib  \x1b[1;30m------------  >\x1b[1;34m  {prayerTimes.data.timings.Maghrib}");
                    Thread.Sleep(sleep);                                     
                    WriteLine($"\t\x1b[1;31mIsha'    \x1b[1;30m------------  >\x1b[1;31m  {prayerTimes.data.timings.Isha}");
                    
                    Thread.Sleep(sleep);
                }
            }
        }

        public static void QuranListMenu()
        {
            while (true)
            {
                surahEnabled = true;
                Clear();

                ForegroundColor = Yellow;
                WriteLine($"\n{StringLibrary.asciiTitles[4]}\n");

                StringLibrary.UserInfo2();
                
                for (int i = 1; i < QuranLibrary.SurahInfoList.Count; i++)
                {
                    WriteLine($"\n\t\x1b[1;32m{i}\x1b[1;37m. {QuranLibrary.SurahInfoList[i].SurahName}");
                }

                StringLibrary.UserInfo2();

                WriteLine("\n\t\x1b[1;34mInput a \x1b[1;36mSurah \x1b[0;37m(chapter) \x1b[1;32mindex \x1b[1;34mto read.");
                ForegroundColor = Magenta;
                Write("\n\t\t>>> ");

                ForegroundColor = Green;
                CursorVisible = true;
                string surahChoice = ReadLine();
                CursorVisible = false;

                switch (surahChoice)
                {
                    case "":
                        StartProgram();
                        break;

                    case "0":
                        StartProgram();
                        break;

                    default:
                        int.TryParse(surahChoice, out QuranLibrary.getSurahIndex);
                        CheckSurahIndex();
                        break;
                }
            }
        }

        private static void CheckSurahIndex()
        {
            if (QuranLibrary.getSurahIndex >= 1 && QuranLibrary.getSurahIndex <= 114)
            {
                PrintQuran.PrintEntry();
            }
            else
            {
                QuranListMenu();
            }
        }

        private static void ExitTerminalQuran()
        {
            Clear();

            Thread.Sleep(200);
            WriteLine($"\n\n\n\n\n\t\t\x1b[1;37mMay \x1b[1;33mAllah\x1b[1;37m (swt) guide you.");
            Thread.Sleep(1000);
            WriteLine($"\n\t\tAmeen.");

            Thread.Sleep(1000);
            WriteLine($"\n\t\t\x1b[1;30mAssalamu'Alaikum wa Rahmatullahi wa Barakatuh.");

            Thread.Sleep(1000);

            ResetColor();
            Environment.Exit(0);
        }
    }
}