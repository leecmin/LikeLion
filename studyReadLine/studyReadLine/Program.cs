using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요: ");
            //string username = Console.ReadLine();

            //Console.WriteLine($"안녕하세요, {username}님!");

            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!");
            //Console.WriteLine("내년에는 " + age + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age);

            float skill = 0.0f;
            
            Console.Write("루인 스킬 피해를 입력하세요: ");
            string luin = Console.ReadLine();
            float a = float.Parse(luin);

            Console.Write("카드 게이지 획득량을 입력하세요: ");
            string kard = Console.ReadLine();
            float b = float.Parse(kard);

            Console.Write("각성기 피해를 입력하세요: ");
            string kdamage = Console.ReadLine();
            float c = float.Parse(kdamage);

            Console.Write("최대 마나를 입력하세요: ");
            string mana = Console.ReadLine();
            float d = float.Parse(mana);

            Console.Write("전투 중 마나 회복량을 입력하세요: ");
            string kare = Console.ReadLine();
            float e = float.Parse(kare);

            Console.Write("비전투 중 마나 회복량을 입력하세요: ");
            string bkare = Console.ReadLine();
            float f = float.Parse(bkare);

            Console.Write("이동속도를 입력하세요: ");
            string speed = Console.ReadLine();
            float g = float.Parse(speed);

            Console.Write("탈 것 속도를 입력하세요: ");
            string ride = Console.ReadLine();
            float h = float.Parse(ride);

            Console.Write("운반 속도를 입력하세요: ");
            string rideb = Console.ReadLine();
            float i = float.Parse(rideb);
            
            Console.Write("스킬 재사용 대기시간 감소를 입력하세요: ");
            skill = float.Parse(Console.ReadLine());
            


            Console.WriteLine($"루인 스킬 피해          : {a}%");
            Console.WriteLine($"카드 게이지 획득량 피해 : {b}%");
            Console.WriteLine($"각성기 피해             : {c}%");
            Console.WriteLine($"최대 마나               : {d}%");
            Console.WriteLine($"전투 중 마나 회복량     : {e}%");
            Console.WriteLine($"비전투 중 마나 회복량   : {f}%");
            Console.WriteLine($"이동 속도               : {g}%");
            Console.WriteLine($"탈 것 속도              : {h}%");
            Console.WriteLine($"운반 속도               : {i}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {skill}%");






        }
    }
}
