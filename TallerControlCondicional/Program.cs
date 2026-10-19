class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine(CheckNumber(5));
    }
    public static string CheckNumber(int numero)
    {
        if (numero > 0)
        {
            return "El número es positivo";
        }

        else if (numero < 0)
        {

            return "El número es negativo";
        }

        else
        {
            return "El numero es 0";
        }
    }   
}

