using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine( "digite a terceira nota");
            int nota3 = int.Parse(Console.ReadLine());
            int media = (nota1 +nota2 +nota3)/3;
            Console.WriteLine("sua media é = " + media );
            
            if
                (media>5)
            {
                Console.WriteLine("Aprovado, Parabéns");
            }
            else
             {
                Console.WriteLine("Reporvado, Estude mais"); 
            }
        }
    }
}
