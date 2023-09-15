using System;

class Matriz
{
    private int filas;
    private int columnas;
    private double[,] datos;

    public Matriz(int filas, int columnas)
    {
        this.filas = filas;
        this.columnas = columnas;
        this.datos = new double[filas, columnas];
    }

    public Matriz(int filas, int columnas, double[,] datos)
    {
        if (filas != datos.GetLength(0) || columnas != datos.GetLength(1))
        {
            throw new ArgumentException("Las dimensiones de la matriz no coinciden con los datos proporcionados.");
        }

        this.filas = filas;
        this.columnas = columnas;
        this.datos = datos;
    }

    public double this[int fila, int columna]
    {
        get { return datos[fila, columna]; }
        set { datos[fila, columna] = value; }
    }

    public int Filas
    {
        get { return filas; }
    }

    public int Columnas
    {
        get { return columnas; }
    }

    public Matriz Sumar(Matriz otra)
    {
        if (this.filas != otra.filas || this.columnas != otra.columnas)
        {
            throw new InvalidOperationException("Las matrices deben tener las mismas dimensiones para la suma.");
        }

        Matriz resultado = new Matriz(filas, columnas);
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = this[i, j] + otra[i, j];
            }
        }
        return resultado;
    }

    public Matriz Restar(Matriz otra)
    {
        if (this.filas != otra.filas || this.columnas != otra.columnas)
        {
            throw new InvalidOperationException("Las matrices deben tener las mismas dimensiones para la resta.");
        }

        Matriz resultado = new Matriz(filas, columnas);
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = this[i, j] - otra[i, j];
            }
        }
        return resultado;
    }

    public Matriz Multiplicar(Matriz otra)
    {
        if (this.columnas != otra.filas)
        {
            throw new InvalidOperationException("El número de columnas de la primera matriz debe ser igual al número de filas de la segunda matriz para la multiplicación.");
        }

        Matriz resultado = new Matriz(this.filas, otra.columnas);
        for (int i = 0; i < this.filas; i++)
        {
            for (int j = 0; j < otra.columnas; j++)
            {
                double suma = 0;
                for (int k = 0; k < this.columnas; k++)
                {
                    suma += this[i, k] * otra[k, j];
                }
                resultado[i, j] = suma;
            }
        }
        return resultado;
    }

    public void Imprimir()
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(datos[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class PruebaMatriz
{
    static void Main()
    {
        // Ejemplo de uso
        double[,] datos1 = { { 1, 2 }, { 3, 4 } };
        double[,] datos2 = { { 9, 4 }, { 2, 6 } };

        Matriz matriz1 = new Matriz(2, 2, datos1);
        Matriz matriz2 = new Matriz(2, 2, datos2);

        Console.WriteLine("Matriz 1:");
        matriz1.Imprimir();
        Console.WriteLine("Matriz 2:");
        matriz2.Imprimir();

        Matriz suma = matriz1.Sumar(matriz2);
        Matriz diferencia = matriz1.Restar(matriz2);
        Matriz producto = matriz1.Multiplicar(matriz2);

        Console.WriteLine("Suma:");
        suma.Imprimir();
        Console.WriteLine("Diferencia:");
        diferencia.Imprimir();
        Console.WriteLine("Producto:");
        producto.Imprimir();
    }
}

