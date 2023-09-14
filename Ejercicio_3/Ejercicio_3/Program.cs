        Console.Write("Por favor, ingresa un número entero: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int limiteSuperior))
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }

        int suma = 0;
        int contador = 1;

        // Calcula la suma de los números del 1 al 100 usando un bucle for
        for (int i = 1; i <= limiteSuperior; i++)
        {
            suma += i;
        }

        // Calcula el promedio
        double promedio = (double)suma / limiteSuperior;

        Console.WriteLine("La suma es " + suma);
        Console.WriteLine("El promedio es " + promedio);

        // Reinicializa la suma y el contador para los siguientes cálculos
        suma = 0;
        contador = 1;

        // Calcula la suma de los números del 1 al 100 usando un bucle while
        while (contador <= limiteSuperior)
        {
            suma += contador;
            contador++;
        }

        promedio = (double)suma / limiteSuperior;

        Console.WriteLine("\nUsando un bucle while:");
        Console.WriteLine("La suma es " + suma);
        Console.WriteLine("El promedio es " + promedio);

        // Reinicializa la suma y el contador para los siguientes cálculos
        suma = 0;
        contador = 1;

        // Calcula la suma de los números impares del 1 al 100
        do
        {
            if (contador % 2 != 0)
            {
                suma += contador;
            }
            contador++;
        } while (contador <= limiteSuperior);

        promedio = (double)suma / (limiteSuperior / 2); // Solo cuenta números impares

        Console.WriteLine("\nUsando un bucle do-while para sumar números impares:");
        Console.WriteLine("La suma de los impares es " + suma);
        Console.WriteLine("El promedio de los impares es " + promedio);

        // Reinicializa la suma y el contador para los siguientes cálculos
        suma = 0;
        contador = 1;

        // Calcula la suma de los números divisibles por 7 del 1 al 100
        do
        {
            if (contador % 7 == 0)
            {
                suma += contador;
            }
            contador++;
        } while (contador <= limiteSuperior);

        promedio = (double)suma / (limiteSuperior / 7); // Solo cuenta números divisibles por 7

        Console.WriteLine("\nUsando un bucle do-while para sumar números divisibles por 7:");
        Console.WriteLine("La suma de los divisibles por 7 es " + suma);
        Console.WriteLine("El promedio de los divisibles por 7 es " + promedio);

        // Calcula la suma de los cuadrados de los números del 1 al 100
        suma = 0;
        contador = 1;

        while (contador <= limiteSuperior)
        {
            suma += contador * contador;
            contador++;
        }

        Console.WriteLine("\nLa suma de los cuadrados es " + suma);
