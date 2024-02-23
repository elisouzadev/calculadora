using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("Escolha um operador: ");
            string opcao = Console.ReadLine();
            

            switch (opcao) 
            {
                case "1":
                    Somar();
                break;
                
                case "2":
                    Subtrair();
                break; 
                
                case "3":
                    Multiplicar();
                break;
                
                case "4":
                    Dividir();
                break;
                
                case "0":
                break;

                default:
                    Menu();
                break;
            }
        }

        public static void Somar()
        {
            double Valor1, Valor2;

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado de {Valor1} + {Valor2} = {Valor1 + Valor2}");
            Console.WriteLine("Digite enter para fazer uma nova operação: ");
            Console.ReadLine();
            Menu();
        }
        public static void Subtrair()
        {
            double Valor1, Valor2;

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado de {Valor1} - {Valor2} = {Valor1 - Valor2}");
            Console.WriteLine("Digite enter para fazer uma nova operação: ");
            Console.ReadLine();
            Menu();
        }
        public static void Multiplicar()
        {
            double Valor1, Valor2;

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado de {Valor1} * {Valor2} = {Valor1 * Valor2}");
            Console.WriteLine("Digite enter para fazer uma nova operação: ");
            Console.ReadLine();
            Menu();
        }
        public static void Dividir()
        {
            double Valor1, Valor2;

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peimeiro valor: ");
            Valor2 = double.Parse(Console.ReadLine());
            if ( Valor2 <= 0 ) 
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else 
            {
                Console.WriteLine($"O resultado de {Valor1} / {Valor2} = {Valor1 / Valor2}");
            }
            
            Console.WriteLine("Digite enter para fazer uma nova operação: ");
            Console.ReadLine();
            Menu();
        }
    }
}
