namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cita producto1 = new Cita();
            producto1.Lugar = "centro";
            producto1.Zona = "piernas";
            Console.WriteLine(producto1.Lugar +" "+ producto1.Zona) ;
        }
    }



}