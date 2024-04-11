namespace ex04_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3; int y = 4;
            BasicSwap(x, y);
            Console.WriteLine($"BasicSwap -> x = {x}, y = {y}");

            RefSwap(ref x, ref y);  // 참조로 매개 변수 사용할때는 ref를 사용해야함
            Console.WriteLine($"RefSwap -> x = {x}, y = {y}");

            int a = 10; int b = 3;
            int 값 = 0; int 나머지 = 0;
            Divide(a, b, out 값, out 나머지);
            Console.WriteLine($"{a}/{b} = {값}, {나머지}");
            Console.WriteLine(Sum(1, 2, 3, 4));
            Console.WriteLine(Sum(1, 2, 3, 4, 546,4,22));
            PrintProfile(phone: "010-8790-2222", name: "황정우");
            
        }
        public static void BasicSwap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static void RefSwap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        // quotient 나누기 값, remainder 나머지
        public static void Divide(int a, int b, out int quotient, out int remainder) {
            quotient = a / b;
            remainder = a % b;
            // 예전에 튜플 리턴이 없어서 한번에 하나만 값을 리턴할 수 있음
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static float Plus(float a, float b)
        {
            return a + b;
        }

        public static int Sum(params int[] argv)
        {
            int sum = 0;
            foreach(var item in argv)
            {
                sum += item;
            }
            return sum;
        }
        public static void PrintProfile(string name, string phone) {
            Console.WriteLine($"이름 = {name}, 모바일 = {phone}");
        }
        
        
    }
}
