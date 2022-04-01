using System;

namespace ExemplosCsharp
{
    class StartsWith
    {

        public void StartsWithAndEndsWith()
        {

            var texto = "Este texto é um teste";

            //Return bool, Meu texto começa com 
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("teste"));


        }

    }
}
