using System;

namespace ExemplosCsharp
{
    class ManipulandoString
    {

        public void ManipulandoStringExample()
        {

            var texto = " Este texto é um teste ";

            Console.WriteLine(texto.Replace("Este", "isto"));

            //Quebra cadeia de caracteres
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            //Pega uma palavra especifica do texto
            // var resultado = texto.Substring(5, 5);
            var resultado = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);

            // Limpar os espaços do começo ao fim
            Console.WriteLine(texto.Trim());
        }

    }
}
