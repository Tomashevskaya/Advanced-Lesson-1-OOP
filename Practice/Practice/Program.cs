using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static partial class Program

        public static void A_L2_P1_1()
        {
        Console.WriteLine("Введите текст для печати");
        var text = Console.ReadLine();

        Console.WriteLine("Выберите метод печати");
        Console.WriteLine("1 - Консоль");
        Console.WriteLine("2 - Файл");
        Console.WriteLine("3 - Картинка");

        var printingType = Console.ReadLine();
        Printer printer = GetPrinterByType(printingType);
        printer.Print(text);
    }
    private static Printer GetPrinterByType(string printingType)
    {
        switch (printingType) {
            case "1":
                return new ConsolePrinter();
            case "2":
                return new FilePrinter();
            case "1":
                return new ImagePrinter();


        }




    }
    public abstract class Printer
    {
        public abstract void print
    }
    public class ConsolePrinter : Printer
        public override void Print(string text)
        {
        throw new NotImplementedException();
        }
    public class FilePrinter : Printer
        public override void Print(string text)
        {
        System.IO.File.WriteAllText("d:\\students\\, text");
        }

}
