namespace SingleResponsibilityPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region Anti-Beispiel
    public class BadEmployee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Salary { get; set; }


        public void GenerateReport()
        {

            //Mehr Logik
            Console.WriteLine("Ein Report über den Mitarbeiter wird erstelle");
        }

        public void InsertEmployeeToDb (Employee employee)
        {
            //Speichere den Datensatz EMployee in DB
        }
    }


    #endregion

    #region Good Sample

    //In EF wäre die ein POCO - Object 
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

   


    //Data Access Layer -> z.B in Anlehnung an Repository Pattern

    public class EmployeeRepository
    {
        public void Insert(Employee employee)
        {
            // Employee wird in die DB hinzugefügt
        }

        // Update

        //Get 

        //Delete 
    }

    public class EmployeeReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            //
        }
    }

    #endregion

}