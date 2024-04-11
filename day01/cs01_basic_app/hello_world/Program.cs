namespace hello_world // 프로그램 소스의 가장 큰 단위 namespace == project
{
    internal class Program // 접근 제한자 class 파일 명
    {
        static void Main(string[] args) // 정적함수 void Main
        { 
            // System 네임스페이스 > Console 클래스에 있는 정적 메서드 WriteLine()
            //Console.WriteLine("Hello, C#!");\
            if(args.Length == 0)
            {
                Console.WriteLine("사용법 : hello_world.exe <이름>");
                return;

            }else
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
        }
    }
}
