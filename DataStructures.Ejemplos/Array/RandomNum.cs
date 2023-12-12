using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Ejemplos.Array
{
    public static class RandomNum
    {
        // Genera un numero decimal random hasta el parametro maximo.
        public static double[] Generate(int maximo)
        {
            double[] numerosGenerados = new double[maximo];
            Random rand = new Random();

            // Genera numero decimal random buscando que sea hasta 5.0.
            for (int i = 0; i < maximo; i++)
            {
                double numeroAleatorio = rand.NextDouble() * 5.0;

                //Redondea el numero aleatorio a un decimal (.0)
                numeroAleatorio = Math.Round(numeroAleatorio, 1);

                numerosGenerados[i] = numeroAleatorio;
            }

            return numerosGenerados;
        }
    }
}
