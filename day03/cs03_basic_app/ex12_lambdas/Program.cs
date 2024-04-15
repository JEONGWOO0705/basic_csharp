namespace ex12_lambdas
{
    delegate int Calculate(int a, int b); // 대리자 선언, 정수값 두개받아서 정수값을 리턴해주는 함수들은 내가 대신 실행해줄게
    internal class Program
    {
        static object Main(string[] args)
        {
            Console.WriteLine("익명 메서드");

            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine($"계산 결과 : {calc(10, 4)}");

            // 람다식을 쓰면 훨씬 짧아진다
            //Calculate calc2 = (int a, int b) => a+ b;

            Calculate calc2 = (a,b) => a + b;
            Calculate calc3 = (a,b) => a * b;
            Console.WriteLine($"계산 결과 : {calc2(10, 4)}");
            Console.WriteLine($"계산 결과 : {calc3(10, 4)}");

            // 문장형식의 람다식
            Calculate cal4 = (a, b) =>
            {
                Console.WriteLine("이런 식으로 뺼셈이 됩니다");
                var sum = a - b; return sum;
            };
            Console.WriteLine($"계산 결과 : {cal4(10, 5)}");


            // Func, Action 빌트인 대리자 사용
            // Func 는 리턴값이 있기 때문에 <int> 는 리턴값이 int라는 말
            // <int,int>는 매개변수 하나 , 리턴값 하나 라는 뜻

            Func<int> func1 = () => 10;
            Console.WriteLine($"func1의 값 : {func1()}");

            Func<int, int> func2 = (x) => x * 2; // Func<입력값, 출력값>
            Console.WriteLine($"func2의 값 : {func2(4)}");

            Func<int, int, double> func3 = (x, y) => (double)x / y;
            Console.WriteLine($"func2의 값 : {func3(22,7)}");

            // Action은 리턴값이 없음
            int result = 0;
            Action<int> act1 = (x) => result = x * x;
            Console.WriteLine($"act1 값 : {result}");



        }
    }
    class Test
    {
        private int name;
        private double point;

        public int Name // 기존의 프로퍼티
        {
            get { return name; }
            set { name = value; }
        }

        public double Point // 람다식을 사용한 프로퍼티, 코딩이 간단해짐
        {
            get => point;
            set => point = value;
        }
    }
}
