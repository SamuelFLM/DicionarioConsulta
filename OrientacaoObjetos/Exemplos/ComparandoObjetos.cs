using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    public class ComparandoObjetos
    {
        public void Test()
        {
            var pessoaA = new PessoaA(1, "Samuel");
            var pessoaB = new PessoaA(1, "Samuel");

            Console.WriteLine(pessoaA.Equals(pessoaB));
        }
    }

    public class PessoaA : IEquatable<PessoaA>
    {
        public PessoaA(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(PessoaA pessoaA)
        {
            return Id == pessoaA.Id;
        }
    }



}