namespace _240806_01_Addition
{/// <summary>
 /// 2024-08-06
 /// 프로그래머스 :
 /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 2 출력 & 연산 
 /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181947
 /// </summary>
    internal class Program
    {/****************************************************************
      * 덧셈식 출력하기
      * 문제설명:
      * 두 정수 a, b가 주어질 때 다음과 같은 형태의 계산식을 출력하는 코드를 작성해 보세요.
      * 입력 #1 4 5
      * 출력 #1 4 + 5 = 9
      ***************************************************************/
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            int answer = a + b;

            Console.WriteLine($"{a} + {b} = " + answer);
        }
    }
}
