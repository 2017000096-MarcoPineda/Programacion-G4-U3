internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;


        Console.WriteLine("Ingrese el numero de la lista:");
        Console.WriteLine("1. Fatima Lourdes: 4354-5321");
        Console.WriteLine("2. Camila Almeda: 4923-1293");
        Console.WriteLine("3. Daniela Moguel: 6767-6767");
        Console.WriteLine("4. Ivette Cardona: 4398-3294");
        Console.WriteLine("5. Sofia Arana: 4385-0082");
        Console.WriteLine("6. Marco Pineda 6734-2923\"");
        Console.WriteLine("7. Carlos Ramirez: 4343-5342");
        Console.WriteLine("8. Sergio Calderon: 5333-4323");
        Console.WriteLine("9. Andres Snaidjer 4785-0303");
        Console.WriteLine("10. Pablo Herrera 3242-3234");
        Console.Write("Seleccione un numero: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Niñera");
                break;
            case 2:
                Console.WriteLine("MyLove");
                break;
            case 3:
                Console.WriteLine("Cobrador del apartamento");
                break;
            case 4:
                Console.WriteLine("Arquitecto");
                break;
            case 5:
                Console.WriteLine("Veterinario");
                break;
            case 6:
                Console.WriteLine("Amigo de la secu");
                break;
            case 7:
                Console.WriteLine("Profesor de mi hija");
                break;
            case 8:
                Console.WriteLine("Dentista");
                break;
            case 9:
                Console.WriteLine("Barbero");
                break;
            case 10:
                Console.WriteLine("Paseador del perro");
                break;
            default:
                Console.WriteLine("No esta añadido este numero");
                break;
        }
    }
}