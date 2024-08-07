namespace _240806_03_RotateString
{
    /// <summary>
    /// 2024-08-06
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 2 출력 & 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181945
    /// </summary>
    internal class Program
    {   /****************************************************************
        * 문자열 돌리기
        * 문제설명:
        * 문자열 str이 주어집니다.
        * 문자열을 시계방향으로 90도 돌려서 아래 입출력 예와 같이 출력하는 코드를 작성해 보세요.
        * 입력 #1 abcde
        * 출력 #1 a
                  b
                  c
                  d
                  e
        ******************************************************************/
        static void Main(string[] args)
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();
            char[] characters = s.ToCharArray();
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }
    }
}
