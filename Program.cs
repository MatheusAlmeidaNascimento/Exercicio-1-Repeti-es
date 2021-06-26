using System;

namespace Exercicio_1_Repetições
{
    class Program
    {
        static void Main(string[] args)
        {
           bool respostaCorreta = false;

           while (respostaCorreta == false)
           {
               Console.WriteLine ("Escolha uma nota de 0 a 10");
               int resposta = int.Parse(Console.ReadLine());

               if (resposta < 11)
               {
                  respostaCorreta = true; 
               }
               else if (resposta >= 11)
               {
                   Console.WriteLine("Esse não é um valor válido");
                   Console.WriteLine("Por favor, informe um valor válido");

               }

           } 
                Console.WriteLine("Esse é um valor válido");
            
        }
    }
}

        
    

