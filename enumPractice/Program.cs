using System;

namespace enumPractice
{
    class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            UsingEnumerations();
            Console.ReadLine();
        }
        

        private static void UsingEnumerations()
        {
            EmployeeType employeeTypeLAW = EmployeeType.Lawyer;
            EmployeeType employeeTypeLIT = EmployeeType.Litigator;
            EmployeeType employeeTypePAR = EmployeeType.Paralegal;

            CourtType courtTypeMun = CourtType.Municipal;
            CourtType courtTypeFed = CourtType.Federal;
            CourtType courtTypeSta = CourtType.State;

            int baseWage = 1000;
           //GiveName();
            CalculateWage(baseWage, employeeTypePAR, courtTypeFed, "Discovery");
            CalculateWage(baseWage, employeeTypeLIT, courtTypeMun, "Habeas");
            CalculateWage(baseWage, employeeTypeLAW, courtTypeSta, "Limine");
            CalculateWage(baseWage, employeeTypeLIT, courtTypeFed, "Response");

        }

        private static void GiveName()
        {
            string name = "Jose";

            Console.WriteLine($"the name is: {name}");
            
        }
    }
}
