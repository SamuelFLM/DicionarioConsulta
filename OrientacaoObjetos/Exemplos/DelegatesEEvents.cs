using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Exemplos
{
    public delegate void Pagar(double valor);
    public class Delegates
    {
        // Delegates -> Anonymous Metodos
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }
        public void teste()
        {
            var pagar = new Pagar(RealizarPagamento);
            pagar(25);

            var room = new Room(3);
            room.RoomSoldOut += OnRoomSoldOut;
            room.ReservaAssentos();
            room.ReservaAssentos();
            room.ReservaAssentos();
            room.ReservaAssentos();
            room.ReservaAssentos();

        }
        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }
    }

    public class Room
    {
        public Room(int assentos)
        {
            Assentos = assentos;
            assentosUsados = 0;

        }
        private int assentosUsados = 0;
        public int Assentos { get; private set; }
        public void ReservaAssentos()
        {
            assentosUsados++;
            if (assentosUsados >= Assentos)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
                Console.WriteLine("Assento reservado");
        }

        public event EventHandler RoomSoldOut;
        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOut;
            handler.Invoke(this, e);
        }
    }
}