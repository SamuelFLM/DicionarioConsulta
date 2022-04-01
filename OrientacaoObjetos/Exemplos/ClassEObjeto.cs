using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    /*
        // Tipo de Referencia
        // -> Endereço dos dados -> Heap
        --Encapsulamento  -> Primeiro Pilar
        --Abstração -> Segundo Pilar -> Previne quebra de codigo
        --Herença -> Terceiro Pilar -> Reutilizar os codigos.
        --Polimorfismo -> Quarto Pilar -> Pode ter multiplas formas.
    */
    /*
        --MODIFICADORES DE ACESSO
            --Private : propriedade/metodo privado(So consegue utilizar na mesma class);
            --Protected : Todos os filhos da class pai, consegue acessar o modificador de acesso protected
            , e para conseguir acesso utiliza-se (base . );
            --Internal : Fica disponivel dentro do mesmo Assembly(namespace).
            --Public : Fica aberto para tudo.
    */

    public class ClassEObjeto
    {

    }

    //Tipo complexo.
    class Pagamento
    {
        //Propriedades
        public DateTime Vencimento { get; set; }

        //Métodos
        public virtual void Pagar()
        {
            ConsultarSaldoDoCartao();
        }
        //Polimorfismo
        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy");
        }

        private void ConsultarSaldoDoCartao()
        {

        }
    }

    //Herança
    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;
        public override void Pagar()
        {
            //Regra do boleto
        }
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero;
        public override void Pagar()
        {
            //Regra do cartão de credito
        }
    }

}