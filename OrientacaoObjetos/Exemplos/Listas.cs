using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    public class Listas
    {
        public void Teste()
        {
            //Tipo list, mas trás so info do IEnumerable.
            // IEnumerable<PaymentsS> paymentsS = new List<PaymentsS>();
            // var payments = new ICollection<PaymentsS>();

            var payments = new List<PaymentsS>();
            payments.Add(new PaymentsS(1));
            payments.Add(new PaymentsS(2));
            payments.Add(new PaymentsS(3));
            payments.Add(new PaymentsS(4));
            payments.Add(new PaymentsS(5));

            foreach (var item in payments)
            {
                Console.WriteLine(item.Id);
            }

            //Consultas sobre objetos -> se quiser trazer apenas uma lista usa o "Frist",
            // e uma lista o Where
            var payment = payments.First(x => x.Id == 3);
            Console.WriteLine(payment.Id);

            payments.Remove(payment);

            //Any = verifica se e verdadeiro ou falso;
            //Skip = quantos numeros quero pular
            //Take = quantos numeros da lista quero pega
            var existe = payments.Any(x => x.Id == 3);

            //Converter
            payments.AsEnumerable();
            payments.ToList();



            //Adiciona varios valores;
            // var paidPayments = new List<PaymentsS>();
            // paidPayments.AddRange(payments);

        }
    }

    public class PaymentsS
    {
        public int Id { get; set; }

        public PaymentsS(int id)
        {
            Id = id;
        }


    }

}