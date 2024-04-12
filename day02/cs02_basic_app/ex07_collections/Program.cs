using System.Collections;

namespace ex07_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5]; // 초기화
            //Console.WriteLine(int.MaxValue); // C#에 각 타입의 최대값, 최소값
            array[0] = 80;
            array[1] = 81;
            array[2] = 100;
            array[3] = 34;
            array[4] = 75;

            //var text = Console.ReadLine(); // 콘솔에서 값입력 ex) 파이썬의 input() 

            //Console.WriteLine(text);

            // 초기화 방법
            int[] score = new int[3] {70,80,90 };
            string[] names = new string[] { "hello", "world", "C#!" }; //알아서 크기 조절해줌
            float[] points = { 3.14f, 5.5f, 10.8f };

            // 타입확인
            Console.WriteLine($"배열의 타입 : {score.GetType()}");
            Console.WriteLine($"배열 기본 타입 : {score.GetType().BaseType}");

            foreach (var item in names)
            {
                Console.WriteLine($"문자열은 : {item}");
            }
            Console.WriteLine(score.Length );
            Array.Sort( score );
            foreach (var item in score)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("");
            Console.WriteLine(Array.BinarySearch(score, 90)); // 2인덱스에 90이 존재한다

            char[] array2 = new char[26]; //'Z' - 'A' + 1
            for (int i = 0; i < array2.Length; i++)
                array2[i] = (char)('A' + i); // ABCDEF... 아스키 코드를 (char)를 통해 문자로 변경한다는말
            foreach (var item in array2)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(array2[..]);
            Console.WriteLine(array2[5..]);
            Console.WriteLine(array2[5..11]);

            /*
             System Collection
             */
            //Array List
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(array2);
            arrayList.Add(true);

            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Count);
            arrayList.RemoveAt(1); // Arraylist에서 인덱스 1번의 값을 지운다.
            arrayList.Insert(2, 24);
            Console.WriteLine(arrayList);


            Stack stack = new Stack();
            stack.Push(1);
            stack.Pop();
            Queue que = new Queue();
            que.Enqueue(1);
            que.Dequeue();
        }
    }

    class CustomEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            // 일반 리턴 문은 return문을 만나면 메서드를 빠져나감
            // yield return 은 return문을 실행한 뒤 멈춰있음. 다음yield return문을 실행하기 전까지
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
        }
    }
}

// 데이터 형식 [] 배열이름 = new 데이터 형식[용량]
//  int[] array = new int[5]
//  프로퍼티는 ()쓰면 안됨
//  메서드, 클래스는 () 써야함