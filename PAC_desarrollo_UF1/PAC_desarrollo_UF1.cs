using System;

namespace PAC_desarrollo_UF1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************\n" +
                              "*  PAC_desarrollo_UF1\n" +
                              "*  Marco Antonio Moreno López\n" +
                              "*  DAW 2020/2021\n" +
                              "****************************************************\n");

            // 1-Creación de la primera matriz, solicitando el nº de filas y columnas. Tengo en cuenta las excepciones para valores incorrectos introducidos.
            // Además de no permitir introducir valores negativos ya que si no fallaría a la hora de crear la matriz.

            int matriz1Filas = 0;
            int matriz1Columnas = 0;


            bool valor = false;

            do
            {
                Console.WriteLine("- Introduce el nº de FILAS de tu PRIMERA MATRIZ:");

                try
                {
                    matriz1Filas = Convert.ToInt32(Console.ReadLine());
                    if (matriz1Filas > 0)
                    {
                        valor = true;
                    }
                    else
                    {
                        Console.WriteLine("\n¡¡¡Has introducido cero o un valor negativo - Por favor introduce un número positivo que sea mayor o igual a 1!!! \n");
                    }
                }

                catch (Exception e) when (e.GetType() != typeof(OverflowException))
                {
                    Console.WriteLine("\n¡¡¡Has introducido un valor incorrecto - Vuelve a intentarlo!!! \n");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("\n¡¡¡Te has emocionado mucho!!!. El valor máximo es de 2147483647 - Prueba de nuevo \n");
                }

            }
            while (valor == false);

            valor = false;

            do
            {
                Console.WriteLine("- Introduce el nº de COLUMNAS de tu PRIMERA MATRIZ:");

                try
                {
                    matriz1Columnas = Convert.ToInt32(Console.ReadLine());
                    if (matriz1Columnas > 0)
                    {
                        valor = true;
                    }
                    else
                    {
                        Console.WriteLine("\n¡¡¡Has introducido cero o un valor negativo - Por favor introduce un número positivo que sea mayor o igual a 1!!! \n");
                    }
                }

                catch (Exception e) when (e.GetType() != typeof(OverflowException))
                {
                    Console.WriteLine("\n¡¡¡Has introducido un valor incorrecto - Vuelve a intentarlo!!! \n");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("\n¡¡¡Te has emocionado mucho!!!. El valor máximo es de 2147483647 - Prueba de nuevo \n");
                }
            }
            while (valor == false);

            valor = false;


            int[,] matriz1 = new int[matriz1Filas, matriz1Columnas];


            // 2-Creación de la segunda matriz, solicitando el nº de filas y columnas. Tengo en cuenta las excepciones para valores incorrectos introducidos. 
            // Además de no permitir introducir valores negativos ya que si no fallaría a la hora de crear la matriz.

            int matriz2Filas = 0;
            int matriz2Columnas = 0;

            Console.WriteLine("\n****************************************************\n");

            do
            {
                Console.WriteLine("- Introduce el nº de FILAS de tu SEGUNDA MATRIZ:");

                try
                {
                    matriz2Filas = Convert.ToInt32(Console.ReadLine());
                    if (matriz2Filas > 0)
                    {
                        valor = true;
                    }
                    else
                    {
                        Console.WriteLine("\n¡¡¡Has introducido cero o un valor negativo - Por favor introduce un número positivo que sea mayor o igual a 1!!! \n");
                    }
                }

                catch (Exception e) when (e.GetType() != typeof(OverflowException))
                {
                    Console.WriteLine("\n¡¡¡Has introducido un valor incorrecto - Vuelve a intentarlo!!! \n");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("\n¡¡¡Te has emocionado mucho!!!. El valor máximo es de 2147483647 - Prueba de nuevo \n");
                }

            }
            while (valor == false);

            valor = false;

            do
            {
                Console.WriteLine("- Introduce el nº de COLUMNAS de tu SEGUNDA MATRIZ:");

                try
                {
                    matriz2Columnas = Convert.ToInt32(Console.ReadLine());
                    if (matriz2Columnas > 0)
                    {
                        valor = true;
                    }
                    else
                    {
                        Console.WriteLine("\n¡¡¡Has introducido cero o un valor negativo - Por favor introduce un número positivo que sea mayor o igual a 1!!! \n");
                    }
                }

                catch (Exception e) when (e.GetType() != typeof(OverflowException))
                {
                    Console.WriteLine("\n¡¡¡Has introducido un valor incorrecto - Vuelve a intentarlo!!! \n");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("\n¡¡¡Te has emocionado mucho!!!. El valor máximo es de 2147483647 - Prueba de nuevo \n");
                }
            }
            while (valor == false);

            valor = false;

            int[,] matriz2 = new int[matriz2Filas, matriz2Columnas];


            // 3-Introducción de los elementos de la primera matriz.

            Console.WriteLine("\n****************************************************");

            Console.WriteLine("\n => Ahora vamos a introducir elementos de tipo entero a la PRIMERA MATRIZ que tiene {0} FILAS y {1} COLUMNAS", matriz1.GetLength(0), matriz1.GetLength(1));

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("\n- Introduce el valor de la posición en Fila {0} Y Columna {1}", (i + 1), (j + 1));
                            // He sumado +1 a las posiciones preguntadas para que sea mas amigable para el usuario. Conozco que los valores en un array comienzan desde 0.
                            matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                            valor = true;
                        }

                        catch (Exception e) when (e.GetType() != typeof(OverflowException))
                        {
                            Console.WriteLine("\n¡¡¡Has introducido un valor incorrecto - Vuelve a intentarlo!!! \n");
                        }

                        catch (OverflowException)
                        {
                            Console.WriteLine("\n¡¡¡Te has emocionado mucho!!!. Rango de valores (entre -2147483647 y 2147483647) - Prueba de nuevo \n");
                        }
                    }
                    while (valor == false);
                    valor = false;
                }
            }


            // 4-Introducción de los elementos de la segunda matriz.

            Console.WriteLine("\n => Ahora vamos a introducir elementos de tipo entero a la SEGUNDA MATRIZ que tiene {0} FILAS y {1} COLUMNAS", matriz2.GetLength(0), matriz2.GetLength(1));

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("\n- Introduce el valor de la posición en Fila {0} Y Columna {1}", (i + 1), (j + 1));
                            // He sumado +1 a las posiciones preguntadas para que sea mas amigable para el usuario. Conozco que los valores en un array comienzan desde 0.
                            matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                            valor = true;
                        }

                        catch (Exception e) when (e.GetType() != typeof(OverflowException))
                        {
                            Console.WriteLine("\n¡¡¡Has introducido un valor incorrecto - Vuelve a intentarlo!!! \n");
                        }

                        catch (OverflowException)
                        {
                            Console.WriteLine("\n¡¡¡Te has emocionado mucho!!!. Rango de valores (entre -2147483647 y 2147483647) - Prueba de nuevo \n");
                        }
                    }
                    while (valor == false);
                    valor = false;
                }
            }


            // 5-Mostramos por consola el contenido de la primera matriz como se vería en una tabla.

            Console.WriteLine("\n****************************************************");

            Console.WriteLine("\n Mostrando contenido de la PRIMERA MATRIZ:");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("{0, 7}", matriz1[i, j]); // Podemos sustituir el 7 por otro número, ya que se utiliza para crear espacios donde irán los números.
                }
                Console.WriteLine();
            }


            // 6-Mostramos por pantalla el contenido de la segunda matriz como se vería en una tabla.

            Console.WriteLine("\n Mostrando contenido de la SEGUNDA MATRIZ:");

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write("{0, 7}", matriz2[i, j]); // Podemos sustituir el 7 por otro número, ya que se utiliza para crear espacios donde irán los números.
                }
                Console.WriteLine();
            }

            /* 
             7- Si no coincide número de filas y/o el número de columnas entre dos matrices se indica:
                "Las matrices no pueden ser comparadas"

                Si coincide el número de filas y el número de columnas entre las dos matrices se indica:
                "Las matrices pueden ser comparadas"

                Si las matrices pueden ser comparadas, comparamos cada posición de una matriz con la misma posición de la otra matriz, y si los valores son coincidentes se indica:
                "Las matrices son iguales"

                En el caso de que algún valor no coincida se indica:
                "Las matrices no son iguales"
            */

            Console.WriteLine("\n****************************************************");

            if (matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1))
            {
                Console.WriteLine("\nLas matrices no pueden ser comparadas");
            }

            else
            {

                Console.WriteLine(" \nLas matrices pueden ser comparadas\n");

                bool matrizsame = true;

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        if (matriz1[i, j] != matriz2[i, j])
                        {
                            matrizsame = false;
                        }
                    }
                }

                if (matrizsame == true)
                {
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales");
                }
            }

            Console.WriteLine("\n****************************************************\n" +
                              "GRACIAS POR UTILIZAR MI COMPARADOR DE ARRAYS\n" +
                              "Marco Antonio Moreno López 04/11/2020\n" +
                              "****************************************************\n");
        }
    }
}