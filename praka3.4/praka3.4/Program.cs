namespace PW3_1
{
    class programm
    {
        static void Main()
        {
            MyintList numbers = new MyintList();
            numbers.AddNumber(1);
            numbers.AddNumber(20);
            numbers.AddNumber(35);
            Console.WriteLine("Ср.Ариф: " + numbers.Average);
            Console.WriteLine("Ср.Геомтр: " + numbers.AverageGeometric);

        }
    }
    class MyintList
    {
        private List<int> numberList = new List<int>();
        public double Average
        {
            get
            {
                return CalculateAveragre();
            }
        }
        public double AverageGeometric
        {
            get
            {
                return CalculateAverageGeometric();
            }
        }
        public void AddNumber(int number)
        {
            numberList.Add(number);
        }
        public void RemoveNumber(int number)
        {
            numberList.Remove(number);
        }
        private double CalculateAveragre()
        {
            int sum = 0;
            foreach (int number in numberList)
            {
                sum += number;
            }
            return sum / numberList.Count;
        }
        private double CalculateAverageGeometric()
        {
            int sum = 1;
            foreach (int number in numberList)
            {
                sum = sum * number;
            }
            return Math.Pow(sum, 1.0 / numberList.Count);
        }
    }


}
