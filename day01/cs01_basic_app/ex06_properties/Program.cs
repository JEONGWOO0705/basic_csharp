namespace ex06_properties
{   

    class Kiturami
    {
        private int temperature;
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value;}
        } // 일반 프로퍼티

        // Rosalyn 개발 서포터
        public int Temperature
        {
            get { // 값을 리턴하니깐 특별한 기능이 없음
                return temperature;
            }
            set
            {   // 잘못된 값이 들어오면 안되기 때문에 여러 제약을 걸어둠
                if (value < 10)
                {
                    temperature = 20; // 10도 이하는 허용안함
                }
                else if (value > 70) {
                    temperature = 50; // 70도 초과는 허용안함
                }
                else
                {
                    temperature = value;
                }
                
            }
        }

        public string Name { get; set; } // 자동 프로퍼티

        // 생성자
        public Kiturami(int year, int temperature, string name)
        {
            Year = year;
            Temperature = temperature;
            Name = name;
        }



        //public void SetTemperature(int temp)
        //{
        //    if (temp > 70)
        //    {
        //        Console.WriteLine("온도가 너무 높습니다. 50도로 조정합니다.");
        //        this.temperature = 50;
        //    }
        //    else if(temp<10){
        //        Console.WriteLine("온도가 너무 낮습니다. 20도로 조정합니다");
        //        this.temperature = 20;
        //    }
        //    else
        //    {
        //        this.temperature = temp;
        //    }

        //}
        //public int GetTemperature()
        //{
        //    return this.temperature;
        //}
        public void On()
        {
            Console.WriteLine("보일러 On");
        }
        public void Off()
        {
            Console.WriteLine("보일러 Off");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("보일러 시작!");
            //Kiturami boiler = new Kiturami();
            //boiler.temperature = 40; -> 막아버림
            //Console.WriteLine($"보일러 온도 : {boiler.temperature}도");
            //boiler.SetTemperature(60);
            //Console.WriteLine($"보일러 온도 : {boiler.GetTemperature()}도");
            //boiler.Temperature = 400;
            //Console.WriteLine($"보일러 온도 : {boiler.Temperature}도");
            //boiler.On();
            //boiler.Name = "귀뚜라미";
            //Console.WriteLine($"보일러 이름 : {boiler.Name}");

            Kiturami kiturami = new Kiturami(name: "라미", temperature: 25, year: 2023);
            Console.WriteLine(kiturami.Name);
            Console.WriteLine($"제작년도 : {kiturami.Year}");
            Console.WriteLine($"현재 온도 : {kiturami.Temperature}");
        }
    }
}
