using System;
using System.Globalization;
using static System.Console;

namespace ExemplosCsharp
{
    class Moedas
    {

        public void FormatandoMoedas()
        {
            Clear();
            //C or G/F/N/P(porcentagem)
            decimal valor = 10.25m;

            //Iguais
            string.Format("{0:C}", valor);
            WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")));
        }

        public void MathMetodo()
        {
            Clear();
            decimal valor = 10250.23m;

            WriteLine(valor);

            //Arrendondar
            Math.Round(valor);
            //Redonda para cima
            Math.Ceiling(valor);
            //Redonda para baixo
            Math.Floor(valor);
        }

    }
}
