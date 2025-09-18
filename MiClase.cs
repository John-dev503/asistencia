using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class MiClase
    {
        public double PromedioPositivos(double[] numeros)
        {
            double suma = 0;
            int contador = 0;

            for(int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    suma += numeros[i];
                    contador ++;
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay numeros positivos ni nrgativos");
                return 0;
            }

            double promedio = suma / contador;

            return promedio;
        }

        public double PromedioNegativos(double[] numeros)
        {
            double suma_negativos = 0;
            int contador_negativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    suma_negativos += numeros[i];
                    contador_negativos++;
                }
            }

            if (contador_negativos == 0)
            {
                Console.WriteLine("No hay numeros negativos");
                return 0;
            }

            double promedio_negativos = suma_negativos / contador_negativos;
            return promedio_negativos;
        }

        public double NumerosMayores(double[] numeros)
        {
            int contador_mayores = 0;

            for (int i = 0;i < numeros.Length; i++)
            {
                if(numeros[i] > 100)
                {
                    contador_mayores++;
                }
            }

            return contador_mayores;
        }

        public double NumerosMenores(double[] numeros)
        {
            int contador_menores = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] <= 0)
                {
                    contador_menores++;
                }
            }

            return contador_menores;
        }
    }
}
