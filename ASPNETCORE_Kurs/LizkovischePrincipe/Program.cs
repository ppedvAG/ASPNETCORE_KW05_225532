namespace LizkovischePrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region Bad Sample


    public class BadErbeere
    {
        public string GetColor()
        {
            return "rot";
        }
    }

    public class BadKirsche: BadErbeere
    {
        //Auch hier wird GetColor mit rot zurück gegeben 
    }

    #endregion


    #region Bessere Variante
    //Open Part
    public abstract class Fruit
    {

        protected void Wachsen()
        {
            //Frucht wächse
        }


        public abstract string GetColor();
    }

    public interface IFruit
    {
        string GetColor();
    }


    //Close Part = Implementierung
    public class Erdbeere : Fruit
    {
        public override string GetColor()
        {
            return "rot";
        }
    }

    public class Kirsche : Fruit
    {
        public override string GetColor()
        {
            return "rot";
        }
    }


    //Beispiel für die Interface Variante
    public class Banana : IFruit
    {
        public string GetColor()
        {
            return "gelb";
        }
    }
    #endregion

}