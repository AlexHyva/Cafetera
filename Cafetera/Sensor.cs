namespace Cafetera
{
    public class Sensor
    {
        public bool detectaAgua()
        {
            Console.WriteLine("Sensor: Hay suficiente agua");
            return true;
        }

        public bool detectarTaza()
        {
            Console.WriteLine("Sensor: Taza colocada");
            return true;
        }
    }
}
