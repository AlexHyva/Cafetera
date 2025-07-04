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

        public void temperatura(bool calentador)
        {
            if (calentador = true)
            {
                Console.WriteLine("Pecalentando agua para el cafe...");
            }
        }
    }

    public class DepositoLeche
    {
        public int nivelLeche;

        public DepositoLeche(int nivelLeche_Inicial)
        {
            nivelLeche = nivelLeche_Inicial;
        }

        public void consumirAgua(int cantidadL)
        {
            nivelLeche -= cantidadL;
            Console.WriteLine($"Se consumieron {cantidadL} ml de agua");
        }

        public void temperatura(bool calentador)
        {
            if (calentador = true)
            {
                Console.WriteLine("Pecalentando leche para el cafe...");
            }
        }
    }
}
