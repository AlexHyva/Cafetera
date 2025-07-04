namespace Cafetera
{
    public class Deposito 
    {
        public int nivelAgua;

        public Deposito(int nivelAgua_Inicial)
        {
            nivelAgua = nivelAgua_Inicial;
        }

        public void consumirAgua(int cantidad)
        {
            nivelAgua -= cantidad;
            Console.WriteLine($"Se consumieron {cantidad} ml de agua");
        }
    }
}
