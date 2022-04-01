using System;

namespace ExemplosCsharp
{
    class MetodosAdicional
    {

        public void ToLowerEToUpper()
        {

            var texto = "Este texto é um teste";

            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            // Insere um texto na frase, numero da posicao, e texto;
            Console.WriteLine(texto.Insert(5, "Aqui"));
            //Remove, posicao, ate quando voce quer tirar;
            Console.WriteLine(texto.Remove(5, 5));
            //Tamanho string;
            Console.WriteLine(texto.Length);

        }

    }
}
