namespace examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiClase Operaciones = new MiClase();

            double[] numeros = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nIngrese un numero decimal: ");

                try
                {
                    numeros[i] = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese solamente numeros.");
                    i--;
                }
                

            }

            int opcion = 0;
            double resultado = 0;
            do
            {
                Console.WriteLine("\n---Menu---");
                Console.WriteLine("1.Calcular el promedio de los numeros positivos");
                Console.WriteLine("2.Calcular el promedio de los numeros negativos");
                Console.WriteLine("3.Contar cuantos numeros son mayores a 100");
                Console.WriteLine("4.Contar cuantos numeros son menores o iguales a 0");
                Console.WriteLine("5.Salir");

                Console.Write("\nIngrese una opcion: ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor ingresar una opcion valida del menu.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n---Promedio de los numeros positivo---");
                        resultado = Operaciones.PromedioPositivos(numeros);
                        Console.WriteLine($"El promedio de los numeros positivos es: {resultado}");
                        break;
                    case 2:
                        Console.WriteLine("\n---Promedio de los numeros negativos---");
                        resultado = Operaciones.PromedioNegativos(numeros);
                        Console.WriteLine($"El promedio de los numeros negativos es: {resultado}");
                        break;
                    case 3:
                        Console.WriteLine("\n---Numeros mayores a 100---");
                        resultado = Operaciones.NumerosMayores(numeros);
                        Console.WriteLine($"La cantidad de numeros mayores a 100 que ingreso son: {resultado}");
                        break;
                    case 4:
                        Console.WriteLine("\n---Numero menores o iguales a 0---");
                        resultado = Operaciones.NumerosMenores(numeros);
                        Console.WriteLine($"La cantidad de numeros menores o igual a cero que ingreso son: {resultado}");
                        break;
                    case 5:
                        Console.WriteLine("\nNos vemos...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente nuevamente. ");
                        break;

                }
            

            } while (opcion != 5);
        }
    }
}
