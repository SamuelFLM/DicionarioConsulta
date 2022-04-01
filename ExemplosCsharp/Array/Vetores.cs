using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosCsharp.Array
{
    public class Vetores
    {

        public void CriarVetor()
        {
            Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            WriteLine(meuArray[0]);
        }

        public void AdicionandoValores()
        {
            Clear();

            /*
            var primeiro = new int[4];
            //Apontando mesmo endereço na memoria
            var segundo = primeiro;
            primeiro[0] = 23;
            WriteLine(segundo[0]);
            */

            //Objetos de referencia não de valor
            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];

            primeiro[0] = 23;

            WriteLine(segundo[0]);



        }

        public void PecorrendoArray()
        {
            Clear();

            //Numeros
            // var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            // meuArray[0] = 12;


            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2222, Nome = "Samu" };

            foreach (var funcionario in funcionarios)
            {
                WriteLine(funcionario.Id);
                WriteLine(funcionario.Nome);
            }
        }
    }







    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }




    }


}