using System;
namespace switchCase{
    class Program{
        public static void Main(string[] args){
            int month = DateTime.Now.Month;

            switch(month)
            {
                case 1:
                Console.WriteLine("Ocak ayındasiniz");               
                break;

                case 2:
                Console.WriteLine("Subat ayindasiniz");
                break;

                case 4:
                Console.WriteLine("Nisan ayindasiniz");
                break;

                default:
                Console.WriteLine("Yanlis veri girisi");
                break;
            }
            switch(month){
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Ayi");
                    break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("ilk bahar ayi");
                break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("yaz ayi");
                break;

                case 9:
                case 10:
                case 11:
                Console.WriteLine("Sonbahar ayi");
                break;
                default:
                Console.WriteLine("default");
                break;
            }
        }
    }
}