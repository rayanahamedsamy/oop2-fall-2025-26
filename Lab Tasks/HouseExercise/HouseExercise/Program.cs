using System;

namespace HouseExercise
{
    public class House
    {
        public int YearBuilt { get; private set; }
        public double Size { get; private set; }
        public string SizeUnit { get; private set; }

        public House(int yearBuilt, double size, string sizeUnit = "sq m")
        {
            YearBuilt = yearBuilt;
            Size = size;
            SizeUnit = string.IsNullOrWhiteSpace(sizeUnit) ? "sq m" : sizeUnit;
        }

        public bool CanBeSold()
        {
            int age = HowOld();
            return age > 15;
        }

        private int HowOld()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - YearBuilt;
        }

        public string Describe()
        {
            int age = HowOld();
            string canBeSoldText = CanBeSold() ? "can be sold" : "is not old enough to be sold (less than or equal to 15 years)";
            return $"This house was built in {YearBuilt}, is {Size} {SizeUnit}, and is {age} year{(age == 1 ? "" : "s")} old — it {canBeSoldText}.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }