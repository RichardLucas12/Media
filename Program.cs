using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a primeira nota");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota");

            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine( "digite a terceira nota");

            double nota3 = double.Parse(Console.ReadLine());
            double media = ((nota1 +nota2 +nota3)/3);

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
