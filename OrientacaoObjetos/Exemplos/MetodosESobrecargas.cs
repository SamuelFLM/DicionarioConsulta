using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    public class MetodosESobrecargas
    {
        public void retornoMetodo()
        {
            var retorno = new MetodosSobrescrito(DateTime.Now);

            retorno.Pagar("1234");
        }
    }

    class Metodos
    {
        public DateTime DataPagamento { get; set; }

        //ctor -> Metodo Construtor
        public Metodos(DateTime vencimento)
        {
            Console.WriteLine("Iniciando o pagamento");
            DataPagamento = DateTime.Now;
        }
        //Sobrecargas de metodos
        public virtual void Pagar(string numero)
        {
            Console.WriteLine("Pagar");
        }
        public void Pagar(string numero, DateTime vencimento) { }
        public void Pagar(string numero, DateTime vencimento, bool pagarAposVencimento = false) { }
    }

    class MetodosSobrescrito : Metodos
    {
        public MetodosSobrescrito(DateTime vencimento)
        : base(vencimento)
        {

        }
        //Pode ser Sobrescrito -> rescrita do metodo
        public override void Pagar(string numero)
        {
            base.Pagar(numero);
            Console.WriteLine("Pagar cartao");
        }

    }

}