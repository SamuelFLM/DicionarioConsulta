using System;
using static System.Console;

namespace ExemplosCsharp
{
    public class TratamentoErros
    {

        public void EstruturaTry()
        {

            var arr = new int[3];


            try
            {
                // for (int index = 0; index <= 10; index++)
                // {
                //     Console.WriteLine(arr[index]);
                // }
                Cadastrar("");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar Texto");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Excecao Customizada");
            }
            catch (Exception ex)
            {
                // TODO
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }

        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
        }


        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }

    }
}