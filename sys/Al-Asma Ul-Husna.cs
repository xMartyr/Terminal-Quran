using static System.Console;
using static System.ConsoleColor;

namespace Terminal_Quran.sys
{
    internal class Al_Asma_Ul_Husna
    {
        public static string[] AllahsNamesEnglish = new string[]
        {
            "",
            "\x1b[1;33mAr-Rahmaan\x1b[1;30m ------------- [\x1b[1;37m The Most or Entirely Merciful\x1b[1;30m ]",
            "\x1b[1;33mAr-Raheem\x1b[1;30m -------------- [\x1b[1;37m The Bestower of Mercy\x1b[1;30m ]",
            "\x1b[1;33mAl-Malik\x1b[1;30m --------------- [\x1b[1;37m The King, The Sovereign\x1b[1;30m ]",
            "\x1b[1;33mAl-Quddus\x1b[1;30m -------------- [\x1b[1;37m The Holy, The Pure\x1b[1;30m ]",
            "\x1b[1;33mAs-Salaam\x1b[1;30m -------------- [\x1b[1;37m The Source of Peace\x1b[1;30m ]",
            "\x1b[1;33mAl-Mu'min\x1b[1;30m -------------- [\x1b[1;37m The Guardian of Faith\x1b[1;30m ]",
            "\x1b[1;33mAl-Muhaymin\x1b[1;30m ------------ [\x1b[1;37m The Protector, The Guardian\x1b[1;30m ]",
            "\x1b[1;33mAl-Azeez\x1b[1;30m --------------- [\x1b[1;37m The Mighty, The Strong\x1b[1;30m ]",
            "\x1b[1;33mAl-Jabbaar\x1b[1;30m ------------- [\x1b[1;37m The Compeller, The Irresistible\x1b[1;30m ]",
            "\x1b[1;33mAl-Mutakabbir\x1b[1;30m --------- [\x1b[1;37m The Majestic, The Supreme\x1b[1;30m ]",
            "\x1b[1;33mAl-Khaaliq\x1b[1;30m ------------ [\x1b[1;37m The Creator\x1b[1;30m ]",
            "\x1b[1;33mAl-Baari'\x1b[1;30m ------------- [\x1b[1;37m The Maker, The Inventor\x1b[1;30m ]",
            "\x1b[1;33mAl-Musawwir\x1b[1;30m ----------- [\x1b[1;37m The Fashioner, The Shaper\x1b[1;30m ]",
            "\x1b[1;33mAl-Ghaffaar\x1b[1;30m ----------- [\x1b[1;37m The Ever-Forgiving\x1b[1;30m ]",
            "\x1b[1;33mAl-Qahhaar\x1b[1;30m ------------ [\x1b[1;37m The Subduer, The Dominant\x1b[1;30m ]",
            "\x1b[1;33mAl-Wahhaab\x1b[1;30m ------------ [\x1b[1;37m The Bestower\x1b[1;30m ]",
            "\x1b[1;33mAr-Razzaaq\x1b[1;30m ------------ [\x1b[1;37m The Provider, The Sustainer\x1b[1;30m ]",
            "\x1b[1;33mAl-Fattaah\x1b[1;30m ------------ [\x1b[1;37m The Opener, The Victory Giver\x1b[1;30m ]",
            "\x1b[1;33mAl-'Aleem\x1b[1;30m ------------- [\x1b[1;37m The All-Knowing, The Omniscient\x1b[1;30m ]",
            "\x1b[1;33mAl-Qaabid\x1b[1;30m ------------- [\x1b[1;37m The Constrictor, The Retainer\x1b[1;30m ]",
            "\x1b[1;33mAl-Baasit\x1b[1;30m ------------- [\x1b[1;37m The Expander, The Munificent\x1b[1;30m ]",
            "\x1b[1;33mAl-Khaafid\x1b[1;30m ------------ [\x1b[1;37m The Abaser, The Humiliator\x1b[1;30m ]",
            "\x1b[1;33mAr-Raafi'\x1b[1;30m ------------- [\x1b[1;37m The Exalter, The Elevator\x1b[1;30m ]",
            "\x1b[1;33mAl-Mu'izz\x1b[1;30m ------------- [\x1b[1;37m The Bestower of Honors\x1b[1;30m ]",
            "\x1b[1;33mAl-Muzil\x1b[1;30m -------------- [\x1b[1;37m The Dishonorer, The Humiliator\x1b[1;30m ]",
            "\x1b[1;33mAs-Samee'\x1b[1;30m ------------- [\x1b[1;37m The All-Hearing\x1b[1;30m ]",
            "\x1b[1;33mAl-Baseer\x1b[1;30m ------------- [\x1b[1;37m The All-Seeing\x1b[1;30m ]",
            "\x1b[1;33mAl-Hakam\x1b[1;30m -------------- [\x1b[1;37m The Judge\x1b[1;30m ]",
            "\x1b[1;33mAl-'Adl\x1b[1;30m --------------- [\x1b[1;37m The Just, The Equitable\x1b[1;30m ]",
            "\x1b[1;33mAl-Lateef\x1b[1;30m ------------- [\x1b[1;37m The Gentle, The Subtle\x1b[1;30m ]",
            "\x1b[1;33mAl-Khabeer\x1b[1;30m ------------ [\x1b[1;37m The Aware, The Acquainted\x1b[1;30m ]",
            "\x1b[1;33mAl-Haleem\x1b[1;30m ------------- [\x1b[1;37m The Forbearing, The Patient\x1b[1;30m ]",
            "\x1b[1;33mAl-'Azeem\x1b[1;30m ------------- [\x1b[1;37m The Magnificent, The Infinite\x1b[1;30m ]",
            "\x1b[1;33mAl-Ghafoor\x1b[1;30m ------------ [\x1b[1;37m The All-Forgiving\x1b[1;30m ]",
            "\x1b[1;33mAsh-Shakoor\x1b[1;30m ----------- [\x1b[1;37m The Appreciative, The Grateful\x1b[1;30m ]",
            "\x1b[1;33mAl-'Aliyy\x1b[1;30m ------------- [\x1b[1;37m The Sublimely Exalted\x1b[1;30m ]",
            "\x1b[1;33mAl-Kabeer\x1b[1;30m ------------- [\x1b[1;37m The Great\x1b[1;30m ]",
            "\x1b[1;33mAl-Hafeez\x1b[1;30m ------------- [\x1b[1;37m The Preserver, The Protector\x1b[1;30m ]",
            "\x1b[1;33mAl-Muqeet\x1b[1;30m ------------- [\x1b[1;37m The Nourisher, The Sustainer\x1b[1;30m ]",
            "\x1b[1;33mAl-Haseeb\x1b[1;30m ------------- [\x1b[1;37m The Reckoner, The Accounter\x1b[1;30m ]",
            "\x1b[1;33mAl-Jaleel\x1b[1;30m ------------- [\x1b[1;37m The Majestic, The Glorious\u001b[1;30m ]",
            "\x1b[1;33mAl-Kareem\x1b[1;30m ------------- [\x1b[1;37m The Generous, The Bountiful\x1b[1;30m ]",
            "\x1b[1;33mAr-Raqeeb\x1b[1;30m ------------- [\x1b[1;37m The Watchful\x1b[1;30m ]",
            "\x1b[1;33mAl-Mujeeb\x1b[1;30m ------------- [\x1b[1;37m The Responsive\x1b[1;30m ]",
            "\x1b[1;33mAl-Wasi'\x1b[1;30m -------------- [\x1b[1;37m The All-Encompassing\x1b[1;30m ]",
            "\x1b[1;33mAl-Hakeem\x1b[1;30m ------------- [\x1b[1;37m The Wise, The Judicious\x1b[1;30m ]",
            "\x1b[1;33mAl-Wadood\x1b[1;30m ------------- [\x1b[1;37m The Loving, The Kind\x1b[1;30m ]",
            "\x1b[1;33mAl-Majeed\x1b[1;30m ------------- [\x1b[1;37m The Glorious, The Noble\x1b[1;30m ]",
            "\x1b[1;33mAl-Ba'ith\x1b[1;30m ------------- [\x1b[1;37m The Resurrector\x1b[1;30m ]",
            "\x1b[1;33mAsh-Shaheed\x1b[1;30m ----------- [\x1b[1;37m The Witness\x1b[1;30m ]",
            "\x1b[1;33mAl-Haqq\x1b[1;30m --------------- [\x1b[1;37m The Truth, The Reality\x1b[1;30m ]",
            "\x1b[1;33mAl-Wakeel\x1b[1;30m ------------- [\x1b[1;37m The Trustee, The Disposer of Affairs\x1b[1;30m ]",
            "\x1b[1;33mAl-Qawiyy\x1b[1;30m ------------- [\x1b[1;37m The Strong\x1b[1;30m ]",
            "\x1b[1;33mAl-Mateen\x1b[1;30m ------------- [\x1b[1;37m The Firm, The Steadfast\x1b[1;30m ]",
            "\x1b[1;33mAl-Waliyy\x1b[1;30m ------------- [\x1b[1;37m The Protecting Friend, The Supporter\x1b[1;30m ]",
            "\x1b[1;33mAl-Hameed\x1b[1;30m ------------- [\x1b[1;37m The Praiseworthy\x1b[1;30m ]",
            "\x1b[1;33mAl-Muhsee\x1b[1;30m ------------- [\x1b[1;37m The Counter\x1b[1;30m ]",
            "\x1b[1;33mAl-Mubdi'\x1b[1;30m ------------- [\x1b[1;37m The Originator\x1b[1;30m ]",
            "\x1b[1;33mAl-Mu'id\x1b[1;30m -------------- [\x1b[1;37m The Restorer\x1b[1;30m ]",
            "\x1b[1;33mAl-Muhyi\x1b[1;30m -------------- [\x1b[1;37m The Giver of Life\x1b[1;30m ]",
            "\x1b[1;33mAl-Mumeet\x1b[1;30m ------------- [\x1b[1;37m The Taker of Life\x1b[1;30m ]",
            "\x1b[1;33mAl-Hayy\x1b[1;30m --------------- [\x1b[1;37m The Ever-Living\x1b[1;30m ]",
            "\x1b[1;33mAl-Qayyum\x1b[1;30m ------------- [\x1b[1;37m The Self-Existing, The Eternal\x1b[1;30m ]",
            "\x1b[1;33mAl-Waajid\x1b[1;30m ------------- [\x1b[1;37m The Finder, The Perceiver\x1b[1;30m ]",
            "\x1b[1;33mAl-Maajid\x1b[1;30m ------------- [\x1b[1;37m The Glorious\x1b[1;30m ]",
            "\x1b[1;33mAl-Waahid\x1b[1;30m ------------- [\x1b[1;37m The Unique, The One\x1b[1;30m ]",
            "\x1b[1;33mAl-Ahad\x1b[1;30m --------------- [\x1b[1;37m The One, The Indivisible\x1b[1;30m ]",
            "\x1b[1;33mAs-Samad\x1b[1;30m -------------- [\x1b[1;37m The Eternal, The Absolute\x1b[1;30m ]",
            "\x1b[1;33mAl-Qaadir\x1b[1;30m ------------- [\x1b[1;37m The Capable, The Powerful\x1b[1;30m ]",
            "\x1b[1;33mAl-Muqtadir\x1b[1;30m ----------- [\x1b[1;37m The Determiner, The Dominant\x1b[1;30m ]",
            "\x1b[1;33mAl-Muqaddim\x1b[1;30m ----------- [\x1b[1;37m The Expediter, He who brings forward\x1b[1;30m ]",
            "\x1b[1;33mAl-Mu'akhkhir\x1b[1;30m --------- [\x1b[1;37m The Delayer, He who puts far away\x1b[1;30m ]",
            "\x1b[1;33mAl-Awwal\x1b[1;30m -------------- [\x1b[1;37m The First\x1b[1;30m ]",
            "\x1b[1;33mAl-Aakhir\x1b[1;30m ------------- [\x1b[1;37m The Last\x1b[1;30m ]",
            "\x1b[1;33mAz-Zahir\x1b[1;30m -------------- [\x1b[1;37m The Manifest\x1b[1;30m ]",
            "\x1b[1;33mAl-Baatin\x1b[1;30m ------------- [\x1b[1;37m The Hidden\x1b[1;30m ]",
            "\x1b[1;33mAl-Waali\x1b[1;30m -------------- [\x1b[1;37m The Governor\x1b[1;30m ]",
            "\x1b[1;33mAl-Muta'aali\x1b[1;30m ---------- [\x1b[1;37m The Most Exalted\x1b[1;30m ]",
            "\x1b[1;33mAl-Barr\x1b[1;30m --------------- [\x1b[1;37m The Source of Goodness\x1b[1;30m ]",
            "\x1b[1;33mAt-Tawwaab\x1b[1;30m ------------ [\x1b[1;37m The Acceptor of Repentance\x1b[1;30m ]",
            "\x1b[1;33mAl-Muntaqim\x1b[1;30m ----------- [\x1b[1;37m The Avenger\x1b[1;30m ]",
            "\x1b[1;33mAl-'Afuww\x1b[1;30m ------------- [\x1b[1;37m The Pardoner\x1b[1;30m ]",
            "\x1b[1;33mAr-Ra'oof\x1b[1;30m ------------- [\x1b[1;37m The Kind, The Compassionate\x1b[1;30m ]",
            "\x1b[1;33mMalik al-Mulk\x1b[1;30m --------- [\x1b[1;37m Master of the Kingdom\x1b[1;30m ]",
            "\x1b[1;33mDhu'l-Jalal wal-Ikram\x1b[1;30m - [\x1b[1;37m The Lord of Majesty and Generosity\x1b[1;30m ]",
            "\x1b[1;33mAl-Muqsit\x1b[1;30m ------------- [\x1b[1;37m The Equitable, The Requiter\x1b[1;30m ]",
            "\x1b[1;33mAl-Jaami'\x1b[1;30m ------------- [\x1b[1;37m The Gatherer, The Unifier\x1b[1;30m ]",
            "\x1b[1;33mAl-Ghaniyy\x1b[1;30m ------------ [\x1b[1;37m The Self-Sufficient\x1b[1;30m ]",
            "\x1b[1;33mAl-Mughni\x1b[1;30m ------------- [\x1b[1;37m The Enricher, The Emancipator\x1b[1;30m ]",
            "\x1b[1;33mAl-Mani'\x1b[1;30m -------------- [\x1b[1;37m The Withholder, The Shielder\x1b[1;30m ]",
            "\x1b[1;33mAd-Daarr\x1b[1;30m -------------- [\x1b[1;37m The Distressor, The Harmer\x1b[1;30m ]",
            "\x1b[1;33mAn-Nafi'\x1b[1;30m -------------- [\x1b[1;37m The Benefactor, The Propitious\x1b[1;30m ]",
            "\x1b[1;33mAn-Noor\x1b[1;30m --------------- [\x1b[1;37m The Light\x1b[1;30m ]",
            "\x1b[1;33mAl-Haadi\x1b[1;30m -------------- [\x1b[1;37m The Guide\x1b[1;30m ]",
            "\x1b[1;33mAl-Badi\x1b[1;30m --------------- [\x1b[1;37m The Incomparable, The Originator\x1b[1;30m ]",
            "\x1b[1;33mAl-Baaqi\x1b[1;30m -------------- [\x1b[1;37m The Everlasting\x1b[1;30m ]",
            "\x1b[1;33mAl-Waarith\x1b[1;30m ------------ [\x1b[1;37m The Inheritor, The Heir\x1b[1;30m ]",
            "\x1b[1;33mAr-Rasheed\x1b[1;30m ------------ [\x1b[1;37m The Guide to the Right Path\x1b[1;30m ]",
            "\x1b[1;33mAs-Saboor\x1b[1;30m ------------- [\x1b[1;37m The Patient\x1b[1;30m ]"
        };

        public static void AlAsma()
        {
            Clear();
            CursorVisible = false;
            ForegroundColor = Yellow;
            WriteLine($"\n{StringLibrary.asciiTitles[9]}");

            StringLibrary.UserInfo5();

            WriteLine("\n\t\x1b[1;37m==========================================================================");

            for (int i = 1; i < AllahsNamesEnglish.Length; i++)
            {
                Write($"\n\n\t\x1b[0;37m{i}\x1b[1;37m. {AllahsNamesEnglish[i]}");
            }

            WriteLine("\n\t\x1b[1;37m==========================================================================");
            CursorVisible = false;

            StringLibrary.UserInfo5();
            ForegroundColor = Black;

            ReadLine();
            UserInterface.StartProgram();
        }
    }
}