using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    public class UsingEDispose
    {
        public void test()
        {
            using (var pagamento = new PagamentoT())
            {
                Console.WriteLine("Processando o pagamento");
            }
        }
    }

    public class PagamentoT : IDisposable
    {
        public PagamentoT()
        {
            Console.WriteLine("Iniciando o pagamento");
        }

        //Destruindo o objeto
        public void Dispose()
        {
            Console.WriteLine("Finalizando o pagamento");
        }
    }
}