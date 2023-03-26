namespace praka3_5
{
    class programma
    {
        static void Main()
        {

            Console.WriteLine("Введите Сообщение");
            string sms = Console.ReadLine();
            Console.WriteLine("Введите цену");
            double Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную длинну");
            double MaxLenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену за символ");
            double Charprice = Convert.ToDouble(Console.ReadLine());
            SmsMessage message = new SmsMessage(sms, Price, MaxLenght, Charprice);
            message.Displayinfo();


        }
    }
    class SmsMessage
    {
        private string Messagetext;
        public double Price;
        public double MaxLenght;
        public double Charprice;


        public SmsMessage(string smstext, double Price, double MaxLenght, double Charprice)
        {
            Messagetext = smstext;
            this.Price = Price;
            this.Charprice = Charprice;
            this.MaxLenght = MaxLenght;

        }
        public string smstext
        {
            get { return smstext; }
            set { smstext = Normalsizesms(value); }
        }


        public string Normalsizesms(string value)
        {
            string S = value;
            char[] A_S = new char[S.Length];
            for (int i = 0; i < A_S.Length; i++)
            {
                A_S[i] = S[i];
            }
            if (S.Length < 65)
            {

                Console.WriteLine("1ая цена: " + Price + " ");


            }
            else
            {
                if ((S.Length > 65) && (S.Length < MaxLenght))
                {
                    double n = 0;
                    for (int i = 0; i < A_S.Length - 65; i++)
                    {
                        n = n + Charprice;
                    }
                    Price = Price + n;
                    Console.WriteLine("2 цена: " + Price + " ");


                }
                else
                {
                    value = "";
                    double n = 0;

                    for (int i = 0; i < MaxLenght; i++)
                    {
                        value = value + Convert.ToString(A_S[i]);
                        n = n + Charprice;
                    }
                    Price = Price + n;
                    Console.WriteLine("3 цена: " + Price + " ");
                }
            }

            return value;
        }
        public void Displayinfo()
        {
            Console.WriteLine($"{Normalsizesms(Messagetext)}");
        }
    }
}