using System.Text.Json.Nodes;

namespace OpenClosePrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region BadSample
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public class EmployeeReporter
    {
        public void GenerateReport(Employee employee, int reportType) 
        { 
            //Reporter - Eckpunkte:
            // - Templates werden verwendet
            // - Ausgabeverzeichnis 
            // - Sehr viele Features pro Dll (pro Produkt) 


            if (reportType == 1)
            {
                //Erstelle ein Crystal Report (verwendet eine eigne DLL (Library))
            }
            else if (reportType == 2) 
            { 
                //List10 Report -> Dll wird vom Drittanbieter angesprochen 
            
            }
            else if(reportType == 3)
            {
                //PDF Report
            }
            else
            {
                //Irgendwas anderes
            }
        }
    }


    #endregion


    public abstract class BaseReportGenerator
    {
        public abstract void GenerateReport(Employee employee);
    }

    public class EmployeeCrystalReporter : BaseReportGenerator
    {
        //Properties 
        // - wo liegen die Templates
        // - 
        public override void GenerateReport(Employee employee)
        {
            throw new NotImplementedException();
        }
    }




}