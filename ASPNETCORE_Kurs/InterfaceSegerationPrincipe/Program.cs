namespace InterfaceSegerationPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region Bad Sample
    public interface IVehicle
    {
        void Fly();
        void Swimm();
        void Drive();
    }

    public class Vehicle : IVehicle
    {
        public void Drive()
        {
            //Vehicle kann fahren
        }

        public void Fly()
        {
            //kann fliegen
        }

        public void Swimm()
        {
            //kann schwimmen
        }
    }

    public class AmphibischesFahrzeug : IVehicle
    {
        public void Drive()
        {
            //Kann fahren
        }



        public void Swimm()
        {
            // kann schwimmen 
        }

        //Amphibisches Fahrzeug kann nicht fliegen, also warum muss diese Methode hier stehen 
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Good Sample

    public interface IDrive
    {
        void Drive();
    }

    public interface IFly
    {
        void Fly();
    }

    public interface ISwim
    {
        void Swimm();
    }


    public class AmbhipischesFahrzeug : IDrive, ISwim
    {
        public void Drive()
        {
            // Drive
        }

        public void Swimm()
        {
            // Swim 
        }
    }
    #endregion
}