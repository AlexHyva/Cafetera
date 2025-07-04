namespace Cafetera
{
    public partial class Cafetera
    {
        private Deposito deposito;
        private Sensor sensor;
        private Calentador calentador;
        
        public Cafetera()
        {
            sensor = new Sensor();
            deposito = new Deposito(600); //simulamos hechar agua
            calentador = new Calentador();

         }
         public void capuchino()
         {
            Console.WriteLine("\nHaciendo el cafe capuchino...");

            if (!sensor.detectaAgua() || !sensor.detectarTaza())
            {
                Console.WriteLine("Error: verifica la cantidad de agua o la taza");
                return;
            }

            calentador.encender();
            deposito.consumirAgua(500);
            calentador.apagar();

            Console.WriteLine("Cafes capuchino listo");

        }
        public void prepararCafe() 
        {
            Console.WriteLine("\nHaciendo el cafes americano...");

            if (!sensor.detectaAgua() || !sensor.detectarTaza()) 
            {
                Console.WriteLine("Error: verifica la cantidad de agua o la taza");
                return;
            }

            calentador.encender();
            deposito.consumirAgua(500);
            calentador.apagar();

            Console.WriteLine("Cafesito listo");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera();
            Console.WriteLine("americano, capuchino ");
            string cafe = Console.ReadLine();
            if (cafe == "Americano")
            {
                cafetera.prepararCafe();
            }
            else if(cafe== "capuchino")
            {
                cafetera.capuchino();
            }
        }
    }
}
