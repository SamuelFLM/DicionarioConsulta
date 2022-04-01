using System;

namespace ExemplosCsharp
{
    class Equals
    {

        public void EEquals()
        {

            var texto = "Este texto é um teste";

            //return bool, Comparar com o mesmo tipo.
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));


        }

    }
}
