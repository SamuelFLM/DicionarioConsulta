using System;

namespace ExemplosCsharp
{
    class ComparacaoDeStrings
    {

        public void CComparacaoDeStrings()
        {

            var texto = "Este texto é um teste";

            // Return bool, se contem um pedaço de uma string
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            //Ignore o Case Sensitive
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Contains(null));

            //Retorna um inteiro
            Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(texto.CompareTo("testando"));

        }

    }
}
