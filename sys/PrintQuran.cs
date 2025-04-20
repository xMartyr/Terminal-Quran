using static System.Console;
using static System.ConsoleColor;

namespace Terminal_Quran.sys
{
    internal class PrintQuran
    {
        
        private static string word = "Allah";
        private static string coloredWord = $"\x1b[1;33m{word}\x1b[1;37m";

        private static List<Dictionary<int, string>> allDictionaries = new List<Dictionary<int, string>>()
        { 
            QuranLibrary.fatiha, QuranLibrary.baqarah, QuranLibrary.aliImran, QuranLibrary.anNisa, QuranLibrary.alMaidah, QuranLibrary.alAnaam, QuranLibrary.alAraf,
            QuranLibrary.alAnfal, QuranLibrary.atTawbah, QuranLibrary.yunus, QuranLibrary.hud, QuranLibrary.yusuf, QuranLibrary.arRad, QuranLibrary.ibrahim, QuranLibrary.alHijr, QuranLibrary.anNahl,
            QuranLibrary.alIsra, QuranLibrary.alKahf, QuranLibrary.maryam, QuranLibrary.taHa, QuranLibrary.alAnbiya, QuranLibrary.alHajj, QuranLibrary.alMuminun, QuranLibrary.anNur, QuranLibrary.alFurqan,
            QuranLibrary.ashShuara, QuranLibrary.anNaml, QuranLibrary.alQasas, QuranLibrary.alAnkabut, QuranLibrary.arRum, QuranLibrary.luqman, QuranLibrary.asSajdah, QuranLibrary.alAhzab, QuranLibrary.saba,
            QuranLibrary.fatir, QuranLibrary.yaSin, QuranLibrary.asSaffat, QuranLibrary.saad, QuranLibrary.azZumar, QuranLibrary.ghafir, QuranLibrary.fussilat, QuranLibrary.ashShuraa, QuranLibrary.azZukhruf,
            QuranLibrary.adDukhan, QuranLibrary.alJathiyah, QuranLibrary.alAhqaf, QuranLibrary.muhammad, QuranLibrary.alFath, QuranLibrary.alHujurat, QuranLibrary.qaaf, QuranLibrary.adhDhariyat, QuranLibrary.atTur,
            QuranLibrary.anNajm, QuranLibrary.alQamar, QuranLibrary.arRahman, QuranLibrary.alWaqiah, QuranLibrary.alHadid, QuranLibrary.alMujadila, QuranLibrary.alHashr, QuranLibrary.alMumtahanah, QuranLibrary.asSaf,
            QuranLibrary.alJumuah, QuranLibrary.alMunafiqun, QuranLibrary.atTaghabun, QuranLibrary.atTalaq, QuranLibrary.atTahrim, QuranLibrary.alMulk, QuranLibrary.alQalam, QuranLibrary.alHaqqah, QuranLibrary.alMaarij,
            QuranLibrary.nuh, QuranLibrary.alJinn, QuranLibrary.alMuzzammil, QuranLibrary.alMuddaththir, QuranLibrary.alQiyamah, QuranLibrary.alInsan, QuranLibrary.alMursalat, QuranLibrary.anNaba, QuranLibrary.anNaziat,
            QuranLibrary.abasa, QuranLibrary.atTakwir, QuranLibrary.alInfitar, QuranLibrary.alMutaffifin, QuranLibrary.alInshiqaq, QuranLibrary.alBuruj, QuranLibrary.atTariq, QuranLibrary.alAla, QuranLibrary.alGhashiyah,
            QuranLibrary.alFajr, QuranLibrary.alBalad, QuranLibrary.ashShams, QuranLibrary.alLayl, QuranLibrary.adhDuhaa, QuranLibrary.ashSharh, QuranLibrary.atTin, QuranLibrary.alAlaq, QuranLibrary.alQadr,
            QuranLibrary.alBayyinah, QuranLibrary.azZalzalah, QuranLibrary.alAdiyat, QuranLibrary.alQariah, QuranLibrary.atTakathur, QuranLibrary.alAsr, QuranLibrary.alHumazah, QuranLibrary.alFil, QuranLibrary.quraysh,
            QuranLibrary.alMaun, QuranLibrary.alKawthar, QuranLibrary.alKafirun, QuranLibrary.anNasr, QuranLibrary.alMasad, QuranLibrary.alIkhlas, QuranLibrary.alFalaq, QuranLibrary.anNas
        };

        public static void PrintEntry()
        {
            Clear();
            ForegroundColor = Yellow;

            if (UserInterface.surahEnabled == true)
            {
                SurahPrint(allDictionaries[QuranLibrary.getSurahIndex - 1]);
            }
            else if (UserInterface.searchEnabled == true)
            {
                PrintSearchedAyat();
            }
            else if (UserInterface.randomEnabled == true)
            {
                PrintRandomAyat();
            }
        }
        private static void SurahPrint(Dictionary<int, string> selectedDictionary)
        {
            WriteLine($"\n{StringLibrary.asciiTitles[4]}\n");

            StringLibrary.UserInfo1();

            WriteLine("\n\t\x1b[1;37m==========================================================================");

            foreach (KeyValuePair<int, string> element in selectedDictionary)
            {
                Write($"\n\t{QuranLibrary.SurahInfoList[QuranLibrary.getSurahIndex].SurahName}\x1b[1;37m {QuranLibrary.SurahInfoList[QuranLibrary.getSurahIndex].SurahNumber}:{element.Key}\x1b[1;30m / {QuranLibrary.getSurahIndex}:{QuranLibrary.SurahInfoList[QuranLibrary.getSurahIndex].TotalAyat}\n\t\x1b[1;33m*\x1b[1;37m ");
                var coloredVerse = element.Value.Replace(word, coloredWord);
                WriteLine(TextFormatter.BreakEveryNWords(coloredVerse, 10));
            }

            WriteLine("\n\t\x1b[1;37m==========================================================================");
            CursorVisible = false;

            StringLibrary.UserInfo1();
            ForegroundColor = Black;

            ReadLine();
            UserInterface.QuranListMenu();
        }

        private static void PrintSearchedAyat()
        {
            Clear();
            ForegroundColor = Yellow;
            WriteLine($"\n{StringLibrary.asciiTitles[5]}\n");

            StringLibrary.UserInfo2();

            WriteLine("\n\t\x1b[1;34mEnter a \x1b[1;32msearch\x1b[1;34m term:");
            ForegroundColor = Magenta;
            Write("\n\t\t>>> ");

            ForegroundColor = Green;
            CursorVisible = true;
            string searchTerm = ReadLine();
            CursorVisible = false;
            ResetColor();
        foreachLabel:
            var matches = allDictionaries
                .SelectMany((d, i) => d.Select(kvp => new { QuranLibrary.SurahInfoList[i].SurahName, SurahNumber = i + 1, TotalAyat = kvp }))
                .Where(line => line.TotalAyat.Value.ToLower().Contains(searchTerm.ToLower()));

            Clear();
            ForegroundColor = Yellow;
            WriteLine($"\n{StringLibrary.asciiTitles[5]}\n");

            StringLibrary.UserInfo2();

            WriteLine("\n\t\x1b[1;34mEntered \x1b[1;32msearch\x1b[1;34m term:");

            ForegroundColor = Magenta;
            Write($"\n\t\t>>> ");
            ForegroundColor = Yellow;
            Write(searchTerm);


            if (matches.Count() >= 1 && searchTerm != string.Empty)
            {
                WriteLine("\n\n\t\x1b[1;37m==========================================================================");

                foreach (var match in matches)
                {
                    var surahInfo = QuranLibrary.SurahInfoList[match.SurahNumber];
                    var colored = match.TotalAyat.Value.Replace(word, coloredWord);

                    string greenPrompt = $"\x1b[1;32m{searchTerm}\x1b[1;37m";
                    string finalOutput = colored.Replace(searchTerm, greenPrompt);

                    Write($"\n\t{surahInfo.SurahName}\x1b[1;37m {match.SurahNumber}:{match.TotalAyat.Key}\x1b[1;30m / {match.SurahNumber}:{surahInfo.TotalAyat}\n\t\x1b[1;33m*\x1b[1;37m ");
                    WriteLine(TextFormatter.BreakEveryNWords(finalOutput, 10));
                }

                while (true)
                {
                    WriteLine("\n\t\x1b[1;37m==========================================================================");

                    StringLibrary.UserInfo2();

                    WriteLine("\n\t\x1b[1;34mNew \x1b[1;32msearch\x1b[1;34m term:");

                    ForegroundColor = Magenta;
                    Write("\n\t\t>>> ");
                    ForegroundColor = Green;
                    CursorVisible = true;
                    searchTerm = ReadLine();
                    CursorVisible = false;
                    ResetColor();
                    break;
                }
            }

            if (matches.Count() >= 1 && searchTerm != string.Empty)
            {
                goto foreachLabel;
            }
            else if (searchTerm == string.Empty || searchTerm == "0")
            {
                UserInterface.StartProgram();
            }
            else
            {
                ForegroundColor = DarkRed;
                WriteLine("\n\n\t// Invalid input!");
                WriteLine("\n\t// Search term not found!");
                Thread.Sleep(1750);
                PrintSearchedAyat();
            }
        }
        private static string ReplaceColoredWord(string input)
        {
            return input.Replace(word, coloredWord);
        }

        public static void PrintRandomAyat()
        {
            while (true)
            {
                Clear();

                Random rand = new Random();
                Dictionary<int, string> selectedDict;
                SurahInfo selectedSurah;
                int intRandAyat;
                ForegroundColor = Yellow;
                WriteLine($"\n{StringLibrary.asciiTitles[6]}\n");

                StringLibrary.UserInfo3();

            nextInput:
                WriteLine("\n\t\x1b[1;34m// Input an \x1b[1;32mindex\x1b[1;34m between \"\x1b[1;32m1\x1b[1;34m\"\x1b[1;34m to \"\x1b[1;32m20\x1b[1;34m\"\x1b[1;34m for a new randomization.");
                ForegroundColor = Magenta;
                Write("\n\t\t>>> ");
                ForegroundColor = Green;
                CursorVisible = true;
                string stringRandAyat = ReadLine();
                int.TryParse(stringRandAyat, out intRandAyat);
                CursorVisible = false;
                ResetColor();

                if (intRandAyat >= 1 && intRandAyat <= 20)
                {
                    Clear();
                    ForegroundColor = Yellow;
                    WriteLine($"\n{StringLibrary.asciiTitles[6]}\n");
                    StringLibrary.UserInfo3();

                    WriteLine("\n\t\x1b[1;37m==========================================================================");

                    for (int i = 0; i < intRandAyat; i++)
                    {
                        Thread.Sleep(200);
                        int randomSurahIndex = rand.Next(1, QuranLibrary.SurahInfoList.Count);
                        selectedSurah = QuranLibrary.SurahInfoList[randomSurahIndex];

                        selectedDict = allDictionaries[selectedSurah.SurahNumber - 1];

                        int randVerse = rand.Next(1, selectedDict.Count + 1);
                        string selectedVerse = selectedDict[randVerse];

                        int verseCount = selectedDict.Count;
                        
                        Write($"\n\t{selectedSurah.SurahName}\x1b[1;37m {selectedSurah.SurahNumber}:{randVerse}\x1b[1;30m / {selectedSurah.SurahNumber}:{verseCount}\n\t\x1b[1;33m*\x1b[1;37m ");
                        var verseColored = ReplaceColoredWord(selectedVerse);
                        WriteLine(TextFormatter.BreakEveryNWords(verseColored, 10));

                    }
                    WriteLine("\n\t\x1b[1;37m==========================================================================");

                    StringLibrary.UserInfo3();

                    goto nextInput;
                }
                else if (stringRandAyat == "0" || intRandAyat == 0 && string.IsNullOrEmpty(stringRandAyat))
                {
                    UserInterface.StartProgram();
                }
                else if (intRandAyat < 1 || intRandAyat > 20 || !int.TryParse(stringRandAyat, out _))
                {
                    ForegroundColor = DarkRed;
                    WriteLine("\n\n\t// Invalid input!");
                    WriteLine("\n\t// Try an index between 1 to 20.");
                    Thread.Sleep(1750);
                    PrintRandomAyat();
                }
            }
        }
    }
}