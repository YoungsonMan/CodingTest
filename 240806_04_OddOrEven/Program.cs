namespace _240806_04_OddOrEven
{
    /// <summary>
    /// 2024-08-06
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 2 출력 & 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181944
    /// </summary>
    internal class Program
    {   /****************************************************************
        * 홀짝 구분하기
        * 문제설명:
        * 자연수 n이 입력으로 주어졌을 때 만약 n이 짝수이면 "n is even"을, 
        * 홀수이면 "n is odd"를 출력하는 코드를 작성해 보세요.
        * 입력 #1 100
        * 출력 #1 100 is even
        * 입력 #2 1
        * 출력 #2 1 is odd
        ******************************************************************/
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }
        }
    }
}
