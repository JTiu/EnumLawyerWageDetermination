using System;

namespace enumPractice
{
    internal class ProgramBase
    {
       
      
        public static void CalculateWage(int baseWage, EmployeeType employeeType, CourtType courtType, string motion)
        {
            int calculateWage = 0;

            if (employeeType == EmployeeType.Litigator)
            {
                calculateWage = baseWage * 4;
                Console.WriteLine("Litigator, base (1000) * 4");
            }
            if (employeeType == EmployeeType.Lawyer)
            {
                calculateWage = baseWage * 3;
                Console.WriteLine("Lawyer, base (1000)* 3");
            }

            if (employeeType == EmployeeType.Paralegal)
                
            {
                calculateWage = baseWage * 2;
                Console.WriteLine("Paralegal, base (1000) * 2");
            }
            
            if (courtType == CourtType.Federal)
            {

                calculateWage += 500;
                Console.WriteLine($"If federal, add 500: {calculateWage}");
            }
            if (courtType == CourtType.State)
            {
                calculateWage += 300;
                Console.WriteLine($"If state, add 300: {calculateWage}");
            }
                
            if (courtType == CourtType.Municipal)
            {
                calculateWage += 200;
                Console.WriteLine($"If municipal, add 200: {calculateWage}");
            }
            if (motion =="Discovery")
            {

                calculateWage += 75;
                Console.WriteLine($"If discovery, add 25: {calculateWage}\n");
            }
            if (motion == "Appeal")
            {

                calculateWage += 175;
                Console.WriteLine($"If appeal, add 175: {calculateWage}\n");
            }
            if (motion == "Habeas")
            {

                calculateWage += 50;
                Console.WriteLine($"If Habeas, add 50: {calculateWage}\n");
            }
            
            if (motion == "Limine")
            {

                calculateWage += 175;
                Console.WriteLine($"If limine, add 175: {calculateWage}\n");
            }
            if (motion == "Response")
            {

                calculateWage += 155;
                Console.WriteLine($"If appeal, add 175: {calculateWage}\n");
            }
            
            else
            {
                calculateWage *= 1;
            }
        }
    }
}