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

        public void prepararCafe() 
        {
            Console.WriteLine("Haciendo el cafesito...");

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
            cafetera.prepararCafe();
        }
    }
}
