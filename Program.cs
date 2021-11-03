using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Avaliação para Doador de Sangue --");
            Console.Write("Usuário, qual sua idade ? ");
            int _idade = int.Parse(Console.ReadLine());

            if(_idade > 67 || _idade < 18){
                Console.WriteLine("Você não pode ser doador de sangue.");
            }
            else{
                Console.WriteLine("Você pode ser doador de sangue.");
            }
        }
    }
}
