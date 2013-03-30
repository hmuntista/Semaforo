using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Semaforo
{
    public class Carro
    {
        public Point PosicionActual { get; set; }
        public int Direccion { get; set; }
        public int ListaInicial;

        public Carro(Point posicionActual, int direccion, int listaInicial)
        {
            PosicionActual = posicionActual;
            Direccion = direccion;
            ListaInicial = listaInicial;
        }

        public void Mover()
        {
            if (Direccion == 0) 
            {
                PosicionActual = new Point(PosicionActual.X, PosicionActual.Y+3);
            }
            else if (Direccion == 1)
            {
                PosicionActual = new Point(PosicionActual.X-3, PosicionActual.Y);
            }
            else if (Direccion == 2)
            {
                PosicionActual = new Point(PosicionActual.X, PosicionActual.Y-3);
            }
            else if (Direccion == 3)
            {
                PosicionActual = new Point(PosicionActual.X+3, PosicionActual.Y);
            }

        }

    }
}
