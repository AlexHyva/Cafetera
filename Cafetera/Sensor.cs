namespace Cafetera
{
    public class Sensor
    {
        public bool detectaAgua()
        {
            Console.WriteLine("Sensor: hay agua suficiente para el cafe");
            return true;
        }
        public bool Agregarlataza()
        {
            Console.WriteLine("coloca la taza");
            return true;
        }

        public bool detectarTaza()
        {
            Console.WriteLine("Sensor: Taza puesta correctamente");
            return true;
        }
    }
}
