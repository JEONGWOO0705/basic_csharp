using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex13_linqs
{
    class Profile
    {
        private int age;
        public string Name { get; set; } // 자동 프로퍼티
        public int Height { get; set; } // 키에 -21억부터 +21억까지 들어감. 나중에 제약사항을 넣어야한다!!
        public int Age
        {
            get => age;
            set
            {
                if (value >= 0 && value < 200)
                {
                    age = value;
                }
                else
                {
                    age = 20;
                }
            }
        }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    internal class Program
    {
            static void Main(string[] args)
            {

                Profile[] arrprofiles =
                {
                new Profile { Name = "정우성", Height = 186, Age = 49},
                new Profile { Name = "이정재", Height = 184, Age = 49},
                new Profile { Name = "전지현", Height = 172, Age = 42},
                new Profile { Name = "김태희", Height = 158, Age = 46},
                new Profile { Name = "이문세", Height = 180, Age = 55},
                new Profile { Name = "장원영", Height = 165, Age = 24},
                new Profile { Name = "RM", Height = 175, Age = 29 }
                 };

                Product[] arrProducts =
                {
                    new Product {Title = "비트", Star = "정우성"},
                    new Product {Title = "오징어 게임", Star = "이정재"},
                    new Product {Title = "엽기적인 그녀", Star = "전지현"}
                };
            

            // LINQ 미사용
            // LINQ 사용안할시 너무 15줄 소요
            List<Profile> profiles = new List<Profile>();
            foreach(Profile profile in arrprofiles)
            {
                if (profile.Height < 175)
                    profiles.Add(profile);
            }
            profiles.Sort(
                (profile1, profile2) =>
                {
                    return profile1.Height - profile2.Height;
                }
                );
            foreach(var profile in profiles)
            {
                Console.WriteLine($"{profile.Name} ({profile.Age}세), {profile.Height}cm");
            }

            // LINQ 사용하면 8줄로 끝남
            Console.WriteLine("LINQ 사용");

            var profile2 = from profile in arrprofiles
                           where profile.Height < 175
                           orderby profile.Height
                           select profile;


            foreach (var profile in profile2)
            {
                Console.WriteLine($"{profile.Name} ({profile.Age}세), {profile.Height}cm");
            }

            //LINQ 기본
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from n in numbers
                         where n  % 2 == 0
                         orderby n descending // 내림 차순해서
                         select n;

            foreach (var item in result)
            {
                Console.WriteLine(item); // 10,8,6,4,2
            }

            // group by -> DB의 group by 처럼 집계함수가 필요하진 않음
            var groupProfiles = from p in arrprofiles
                                orderby p.Height descending
                                group p by p.Height < 175 into g
                                select new { GroupKey = g.Key, Profiles = g };

            foreach (var group in groupProfiles)
            {
                Console.WriteLine($"175 미만 ? : {group.GroupKey}");
                foreach (var profile in group.Profiles)
                {
                    Console.WriteLine($">>>{profile.Name}({profile.Age}세) {profile.Height}cm");
                }
            }

            // LINQ JOIN
            var innterJoinResult = from pf in arrprofiles
                                   join pr in arrProducts
                                   on pf.Name equals pr.Star
                                   select new
                                   {
                                       Name = pf.Name,
                                       Work = pr.Title,
                                       Height = pf.Height,
                                       Age = pf.Age
                                   };
            Console.WriteLine("내부조인 결과");
            foreach (var item in innterJoinResult)
            {
                Console.WriteLine($"작품 : {item.Work} / 이름 : {item.Name} / 나이 : {item.Age}");
            }

            var outerJoinResult = from pf in arrprofiles
                                  join pr in arrProducts
                                  on pf.Name equals pr.Star 
                                  // 외부 조인 에서 추가되는 부분
                                  into ps
                                  from pr in ps.DefaultIfEmpty(new Product() { Title = "작품없음" })
                                  select new
                                  {
                                      Name = pf.Name,
                                      Work = pr.Title,
                                      Height = pf.Height,
                                      Age = pf.Age
                                  };

            Console.WriteLine("외부조인 결과");
            foreach (var item in outerJoinResult)
            {
                Console.WriteLine($"작품 : {item.Work} / 이름 : {item.Name} / 나이 : {item.Age}");
            }
        }
    }
}
