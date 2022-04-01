using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    public class UpcastEDownCast
    {
        public void Teste()
        {
            var pessoa = new Pessoa();

            //Downcast
            var pessoaFisica = new Pessoa();

            //Upcast
            pessoa = new PessoaFisica();
            pessoa = new PessoaJuridica();
        }
    }



    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        public string CPF { get; set; }
    }

}