using System;

namespace ExemplosCsharp
{
    class Indices
    {

        public void Iindices()
        {

            var texto = "Este texto é um teste";

            // Posição do array, para trabalhar com lista
            // objeto do mesmo tipo
            Console.WriteLine(texto.IndexOf("é"));
            // Ultima letra que ele encontrou
            Console.WriteLine(texto.LastIndexOf("s"));


        }

    }
}
