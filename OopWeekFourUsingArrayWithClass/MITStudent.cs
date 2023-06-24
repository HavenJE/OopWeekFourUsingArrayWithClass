using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWeekFourUsingArrayWithClass
{
    internal class MITStudent
    {
        // Data fields - these are non-static 
        private int studentID;
        private string studentName;
        private string[] studentUnits;

        // Data field - static type (ideally are shared and public)
        public static string[] courseUnits = { "IFN501", "IFN502", "IFN503", "IFN504", "IFN505", "IFN506", "IFN701", "IFN702"};

        // Constructor of the class 
        public MITStudent(int id, string name, string[] units)
        {
            this.studentID = id;
            this.studentName = name;
            InputArray(units);
            this.studentUnits = units; // here, the array is passing data by reference, not by value (need to input the values of units)
        }
        // Methods 
        public static void InputArray(string[] arrayUnits)
        {
            // input the list of units for the student & check if the unit inside the list or not
            Console.WriteLine("\n Please input the number of unit codes of the student>>");
            int numOfUnits = Convert.ToInt32(Console.ReadLine());

            for (int count = 0; count < numOfUnits; count++)
            {
                Console.WriteLine("\n Please input unit code {0}>>", count + 1);
                string unitInput = Console.ReadLine();
                bool correctUnit = false;
                int x = 0;

                // Check for the valid unit code
                while ((correctUnit == false) && (x < courseUnits.Length))
                {
                    if (unitInput == courseUnits[x]) // When unit input equals to any unit in the list
                    {
                        correctUnit = true;
                        arrayUnits[count] = unitInput;
                    }
                    else
                    {
                        x++;
                    }
                    if (correctUnit == false && x == courseUnits.Length)
                    {
                        Console.WriteLine("Please input a correct unit code!");
                        unitInput = Console.ReadLine();
                        x = 0;
                    }
                }
            }

        }
        public void Display()
        {
            Console.WriteLine("\n Student ID {0}, name {1, - 10}", studentID, studentName);
            // Below, we have to display the list of the units 
            Console.WriteLine("List of the units of student: "); // This list is an array, therefore, we need a loop
            foreach(string  aUnit in studentUnits) {
                Console.WriteLine("{0,10}", aUnit);

        }

    }
}
