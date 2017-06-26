namespace ConsoleColors
{
    public class Bkgrd
    {
        public static readonly string Default = @"\e[49m";
        public static readonly string Black = @"\e[40m";
        public static readonly string White = @"\e[107m";
        public static readonly string Red = @"\e[41m";
        public static readonly string Green = @"\e[42m";
        public static readonly string Yellow = @"\e[43m";
        public static readonly string Blue = @"\e[44m";
        public static readonly string Magenta = @"\e[45m";
        public static readonly string Cyan = @"\e[46m";
        public static readonly string LtGray = @"\e[47m";
        public static readonly string DrkGray = @"\e[100m";
        public static readonly string LtRed = @"\e[91m";
        public static readonly string LtGreen = @"\e[102m";
        public static readonly string LtYellow = @"\e[103m";
        public static readonly string LtBlue = @"\e[104m";
        public static readonly string LtMagenta = @"\e[105m";
        public static readonly string LtCyan = @"\e[106m";

        public static void SetDefault() => Printer._bash.Echo(Default, "-en");
        public static void SetBlack() => Printer._bash.Echo(Black, "-en");
        public static void SetWhite() => Printer._bash.Echo(White, "-en");
        public static void SetRed() => Printer._bash.Echo(Red, "-en");
        public static void SetGreen() => Printer._bash.Echo(Green, "-en");
        public static void SetYellow() => Printer._bash.Echo(Yellow, "-en");
        public static void SetBlue() => Printer._bash.Echo(Blue, "-en");
        public static void SetMagenta() => Printer._bash.Echo(Magenta, "-en");
        public static void SetCyan() => Printer._bash.Echo(Cyan, "-en");
        public static void SetLtGray() => Printer._bash.Echo(LtGray, "-en");
        public static void SetDrkGray() => Printer._bash.Echo(DrkGray, "-en");
        public static void SetLtRed() => Printer._bash.Echo(LtRed, "-en");
        public static void SetLtGreen() => Printer._bash.Echo(LtGreen, "-en");
        public static void SetLtYellow() => Printer._bash.Echo(LtYellow, "-en");
        public static void SetLtBlue() => Printer._bash.Echo(LtBlue, "-en");
        public static void SetLtMagenta() => Printer._bash.Echo(LtMagenta, "-en");
        
        public static string[] ToArray() => new string[]
        {
            Default,
            Black,
            White,
            Red,
            Green,
            Yellow,
            Blue,
            Magenta,
            Cyan,
            LtGray,
            DrkGray,
            LtRed,
            LtGreen,
            LtYellow,
            LtBlue,
            LtMagenta,
            LtCyan,
        };
    }
}