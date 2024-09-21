namespace _240909_P03_DiceGame2
{/// <summary>
 /// 2024-09-09
 /// 프로그래머스 :
 /// 코딩테스트 연습 > 코딩 기초 트레이닝 > 주사위 게임2
 /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181930
 /// </summary>
    internal class Program
    {   /****************************************************************
        * 1부터 6까지 숫자가 적힌 주사위가 세개 있습니다. 
        * 세 주사위를 굴렸을 때 나온 숫자를 각각 a, b, c 라고 했을 때 얻는 점수는 다음과 같습니다.
        * 세 숫자가 모두 다르다면 a + b + c 점을 얻습니다.
        * 세 숫자 중 어느 두 숫자는 같고 나머지 다른 숫자는 다르다면 (a + b + c) × (a2 + b2 + c2 )점을 얻습니다.
        * 세 숫자가 모두 같다면 (a + b + c) × (a2 + b2 + c2 ) × (a3 + b3 + c3 )점을 얻습니다.
        * 세 정수 a, b, c가 매개변수로 주어질 때, 얻는 점수를 return 하는 solution 함수를 작성해 주세요.
        * 
                a	b	c	result
                2	6	1	9
                5	3	3	473
                4	4	4	110592
        *   
        *   입출력 예 #1
        *   예제 1번에서 세 주사위 숫자가 모두 다르므로 2 + 6 + 1 = 9점을 얻습니다. 따라서 9를 return 합니다.
        *   
        *   입출력 예 #2
        *   예제 2번에서 두 주사위 숫자만 같으므로 (5 + 3 + 3) × (52 + 32 + 32 ) = 11 × 43 = 473점을 얻습니다. 
        *   따라서 473을 return 합니다.
        *   
        *   입출력 예 #3
        *   예제 3번에서 세 주사위 숫자가 모두 같으므로 (4 + 4 + 4) × (42 + 42 + 42 ) × (43 + 43 + 43 ) 
        *   = 12 × 48 × 192 = 110,592점을 얻습니다. 
        *   따라서 110592를 return 합니다.
        *****************************************************************/
        static void Main(string[] args)
        {
            Solution test = new Solution();
            int answer1 = test.solution(2, 6, 1);
            int answer2 = test.solution(5, 3, 3);
            int answer3 = test.solution(4, 4, 4);

            Console.WriteLine($"{answer1}");
            Console.WriteLine($"{answer2}");
            Console.WriteLine($"{answer3}");

        }
    }
    public class Solution
    {
        public int solution(int a, int b, int c)
        {
            int answer = 0;
            // 숫자가 다 다르면
            // a + b + c
            int combination1;

            // 숫자 두숫자 같고 나머지 하나
            // (a+b+c) * (a^2 + b^2 + c^2)
            int combination2;

            // 세숫자 같으면
            // (a+b+c) * (a^2 + b^2 + c^2) * (a^3 + b^3 + c^3)
            int combination3;

            combination1 = a + b + c;
            combination2 = combination1 * (a * a + b * b + c * c);
            combination3 = (((int)Math.Pow(a,3)) * 3) * combination2;


            var allEqual = new[] { a, b, c }.Distinct().Count() == 1;
            // using System.Linq; 이거 임포트해야한다...
            // Enumerable 함수인데 Enum이 뭔가 유용한 기능이 많은것같다.
            // 찾아보다가 이런것도 있어서 써보긴했는데 느낌은 알겠는데 Enum을 뭔가 더 알야봐야될거같다.
            // distinct()메서드는
            // { } 안에있는 것들 같은가 비교하고 중복값을 제거하고 .Count해서 같은 수 없고 카운트가 1이

            if (a != b && a!=c && b!=c)
            {
                answer = combination1;
            }
            else if ((a==b && a!=c && b!=c) || (a != b && a == c && b != c) || (a != b && a != c && b == c))
            //아 이거를 수식을 다 안쓰고 하나만 같아도니까 그냥
            //(a == b || a == c || b == c) 이게 되네... 아 ㅏㅏㅏ
            {
                answer = combination2;
            }
            else if (allEqual) // true면...
            {
                answer = combination3;
            }


                return answer;
        }
    }
}
