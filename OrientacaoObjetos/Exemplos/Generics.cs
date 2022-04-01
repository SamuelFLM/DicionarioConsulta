using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    public class Generics
    {
        public void teste()
        {
            var person = new Person();
            var context = new DataContext<Person>();
            context.Save(person);
        }


    }

    //Class generica
    public class DataContext<T>
        where T : Person
        //Pode ter mais. (limitação) pode ser interface também.
    {
        public void Save(T entity)
        {

        }
    }

    public class Person { }
    public class Payments { }
    public class Subscription { }
}