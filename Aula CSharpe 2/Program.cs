namespace Aula_CSharpe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
           

            Console.WriteLine("Bem vindo as forças armadas");

            Console.WriteLine($"Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você já pode servir as forças armadas");
            }
            else
            {
                Console.WriteLine("Você ainda não pode servir");
            }
             
        }
    }
}
