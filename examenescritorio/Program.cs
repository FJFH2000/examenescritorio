namespace examenescritorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir los datos dados de la tabla
            int[] claves = { 12, 15, 18, 19, 23 };
            string[] zonas = { "América del norte", "América central", "América del sur", "Europa", "Asia" };
            double[] precios = { 2, 2.2, 4.5, 3.5, 6 };

            //Solitar los datos de la clave y los minutos
            Console.WriteLine("Ingrese la clave de la zona (12, 15, 18, 19, 23): ");
            int clave = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de minutos hablados: ");
            double minutos = double.Parse(Console.ReadLine());

            // Buscar la clave en el arreglo de claves
            int indice = Array.IndexOf(claves, clave);

            // Calcular el costo
            if (indice != -1)
            {
                double costo = precios[indice] * minutos;
                Console.WriteLine($"El costo de la llamada a {zonas[indice]} es: {costo:C}");
            }
            else
            {
                Console.WriteLine("Clave Invalida");
            }

            Console.ReadKey();
        }

    }
}
