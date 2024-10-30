class Program
{
    static void Main(string[] args)
    {
        
        Vehiculo[] vehiculos = { new Auto(), new Camioneta(), new Motocicleta() };

        
        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.Acelerar();
            vehiculo.Frenar();
            Console.WriteLine();
        }
    }
}