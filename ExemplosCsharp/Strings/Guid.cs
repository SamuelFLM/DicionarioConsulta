using System;

namespace ExemplosCsharp
{
    class GuidT
    {

        public void GuidTest()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("4b663900-0794-4a1e-a1a7-42905a106f86");

            //Nunca vao se repetir
            // if (id == Guid.NewGuid())

            //Pega so os 8 primeiros caracteres
            Console.WriteLine(id.ToString().Substring(0, 8));
        }

    }
}
