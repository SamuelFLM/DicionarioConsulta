using OrientacaoObjetos.Exemplos;

// var pagamentoBoleto = new PagamentoBoleto();

// pagamentoBoleto.Pagar();
// pagamentoBoleto.Vencimento = DateTime.Now;
// pagamentoBoleto.NumeroBoleto = "1234";

// var pagamento = new Pagamento();
// //Return do Polimorfismo
// pagamento.ToString();




// Interface
//Pagamento só , e abstrato. -> so pode ser herdada.
//Tem implementação base.
public abstract class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(double valor)
    {
        //Executar
    }
}

public class PagamentoCartaoCredito : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}
// Interface apenas um contrato -> So carrega definição.
public interface IPagamento
{
    DateTime Vencimento { get; set; }
    void Pagar(double valor);
}