using System;
using System.Text;

namespace ExemplosCsharp
{
    class StringBuilderr
    {

        public void StringBuilderR()
        {
            // Construtor
            var texto = new StringBuilder();

            // Append = anexar item ao texto;
            texto.Append("Este texto e um teste");
            texto.Append("e teste");
            texto.Append("Este e um teste");
            texto.Append("Este teste");

            //Obter o valor dele para string;
            texto.ToString();
            Console.WriteLine(texto);
        }

    }
}
