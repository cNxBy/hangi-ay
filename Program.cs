using System.ComponentModel.Design;

namespace xxtryt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ayları giriniz");

            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Ay=Ocak");
                    break;
                case 2:
                    Console.WriteLine("Ay=Şubat");
                    break;
                case 3:
                    Console.WriteLine("Ay=MArt");
                    break;
                case 4:
                    Console.WriteLine("Ay=Nisan");
                    break;
                case 5:
                    Console.WriteLine("Ay=Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Ay=Haziran");
                    break;
                case 7:
                    Console.WriteLine("Ay=Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ay=Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Ay=Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ay=Ekim");
                    break;
                case 11:
                    Console.WriteLine("Ay=Kasım");
                    break;
                case 12:
                    Console.WriteLine("Ay=Aralık");
                    break;
                default:
                    Console.WriteLine("Girdiğiniz değerda ay yok.");
                        break;
                   
            }
            }
        }
    }
