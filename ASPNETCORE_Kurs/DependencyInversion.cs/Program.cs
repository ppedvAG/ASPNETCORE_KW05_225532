namespace DependencyInversion.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICar car = new Car();
            car.Brand = "BMW";
            car.Model = "Z8";
            car.ConstructionYear = 2021;

            ICarService mockCarService = new MockCarService();
            mockCarService.RepairCar(car);


            //Testbarkeit 
            ICar mockCar = new MockCar();
            ICarService carSerivce = new CarService();
            carSerivce.RepairCar(mockCar);

        }
    }


    #region Bad Sample

    //Probleme: 
    // - paralles Arbeiten 
    // - Unflexibel durch Feste Kopplung 
    // - Wechselwirkungen 


    //Programmierer A: 3 Tage (von Tag 1 bis Tag 3) 
    public class BadCar
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int ConstructionYear { get; set; }
    }

    //Programmierer B: 5 Tage (Tag 3 bis Tag 8)
    public class BadCarService
    {
        public void RepairCar(BadCar car) //Feste Kopplung befindet hier (CarService kennt die Car - Klasse) 
        {
            //repariere ein Auto 

            //Refactoringsgefahr bei 99%
        }
    }
    #endregion


    #region Dependency Inversion Sample
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }

        int ConstructionYear { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
    }

    //Programmierer A: 3 Tage (Tag 1-3)
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }  
    }

    public class MockCar : ICar
    {
        public string Brand { get; set; } = "VW";
        public string Model { get; set; } = "Polo";
        public int ConstructionYear { get; set; } = 2011;
    }



    //Programmierer B: 5 Tage  (Tag 1-5)
    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            //repariere Auto 
        }
    }

    //Pogrammierer A kann an Tag 4 und 5 eine Mock-Klasse ertstellen. Sie simuliert den CarService 

    public class MockCarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            
        }
    }




    #endregion
}