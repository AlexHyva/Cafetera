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
            Console.WriteLine("Haciendo el cafes capuchino...");

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
            Console.WriteLine("Haciendo el cafe americano...");

            if (!sensor.detectaAgua() || !sensor.detectarTaza()) 
            {
                Console.WriteLine("Error: verifica la cantidad de agua o la taza");
                return;
            }

            calentador.encender();
            deposito.consumirAgua(500);
            calentador.apagar();

            Console.WriteLine("Cafes americano listo");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera();
            Console.WriteLine("Americano o capuchino");
            string cafe = Console.ReadLine();
            if (cafe=="americano")
            {
                cafetera.prepararCafe();
            }
            else if (cafe=="capuchino")
            {
              
                cafetera.capuchino();
            }
            else { Console.WriteLine("no tenemos de ese cafe"); }
                
        
        }
    }
}
