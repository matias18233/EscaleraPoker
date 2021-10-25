using System;

namespace ejercicioEscalera
{
    public class Program
    {

        int[] cartas = new int[7];
        int nroCartasEscalera;

        public Program(int[] cartas) {
            this.cartas = ordenarArreglo(cartas);
            nroCartasEscalera = 1;
        }

        static void Main(string[] args)
        {

        }

        private int[] ordenarArreglo(int[] arregloCartas)
        {
            Array.Sort(arregloCartas);
            if ((Array.IndexOf(arregloCartas, 2)) != -1)
            {
                int indice = Array.IndexOf(arregloCartas, 14);
                if (indice != -1)
                {
                    arregloCartas[indice] = 1;
                    Array.Sort(arregloCartas);
                }
            }
            return arregloCartas;
        }

        public bool comprobarEscalera()
        {
            int cartaPrevia = 0;
            for (int i = 0; i < cartas.Length; i++)
            {
                if (cartaPrevia != 0)
                {
                    if (cartasIguales(cartaPrevia, cartas[i]))
                    {
                        nroCartasEscalera += 1;
                    } else if (!esEscalera())
                    {
                        nroCartasEscalera = 1;
                        cartaPrevia = 0;
                    }
                }
                cartaPrevia = cartas[i];
            }
            return esEscalera();
        }

        private bool cartasIguales(int cartaAnterior, int cartaSiguiente)
        {
            cartaAnterior += 1;
            if (cartaAnterior == cartaSiguiente)
            {
                return true;
            }
            return false;
        }

        private bool esEscalera()
        {
            if (nroCartasEscalera >= 5)
            {
                return true;
            }
            return false;
        }
    }
}
