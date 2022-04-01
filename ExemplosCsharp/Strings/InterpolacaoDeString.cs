using System;

namespace ExemplosCsharp
{
    class InterpolacaoDeString
    {

        public void InterpolacaoDeStringExemplo()
        {
            var price = 10.2;

            //Formata uma cadeia de caracteres -- Lembra o C
            // var txt = string.Format("O preço do produto e {1} apenas na promoção {0}", price, true);

            var txt = $"O preço do produto é {price} apenas na promoção";


            Console.WriteLine(txt);



        }

    }
}
