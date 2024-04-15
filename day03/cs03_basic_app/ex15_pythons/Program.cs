using IronPython.Hosting;   //  파이썬용 라이브러리 사용 등록
namespace ex15_pythons
{
    /*
     [

     
    'C:\\Users\\user\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32', 
    'C:\\Users\\user\\AppData\\Roaming\\Python\\Python311\\site-packages\\win32\\lib', 
    'C:\\Users\\user\\AppData\\Roaming\\Python\\Python311\\site-packages\\Pythonwin', 
    ]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("파이썬 실행 예제");

            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var paths = engine.GetSearchPaths();

            // python 경로 설정 '@' 리소스 키워드
            paths.Add(@"C:\DEV\Langs\Python311"); // 기본 파이썬 경로
            paths.Add(@"C:\DEV\Langs\Python311\DLLs");
            paths.Add(@"C:\DEV\Langs\Python311\Lib");
            paths.Add(@"C:\DEV\Langs\Python311\Lib\site-packages");
            paths.Add(@"C:\Users\user\AppData\Roaming\Python\Python311\site-packages");
            paths.Add(@"C:\Users\user\AppData\Roaming\Python\Python311\site-packages\win32");
            paths.Add(@"C:\Users\user\AppData\Roaming\Python\Python311\site-packages\win32\lib'");

            // 실행시킬 python 파일 경로 설정
            var filePath = @"C:\Sources\basic_csharp\day03\cs03_basic_app\ex15_pythons\Test.py";
            var source = engine.CreateScriptSourceFromFile(filePath);

            //python 실행
            source.Execute(scope);

            var PythonFunc = scope.GetVariable<Func<int, int, int>>("sum");
            var result = PythonFunc(10, 7);
            Console.WriteLine($"파이썬 함수 실행 {result}");

            var PythonGreeting = scope.GetVariable<Func<string>>("sayGreeting");
            var greeting = PythonGreeting();
            Console.WriteLine($"결과 : {greeting}");

        }
    }
}
