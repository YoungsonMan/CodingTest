namespace _240806_02_PrintingStringsTogether
{/// <summary>
 /// 2024-08-06
 /// 프로그래머스 :
 /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 2 출력 & 연산 
 /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181946
 /// </summary>
    internal class Program
    {
        /****************************************************************
        * 문자열 붙여서 출력하기
        * 문제설명:
        * 두 개의 문자열 str1, str2가 공백으로 구분되어 입력으로 주어집니다.
        * 입출력 예와 같이 str1과 str2을 이어서 출력하는 코드를 작성해 보세요.
        * 입력 #1 apple pen
        * 출력 #1 applepen
        * 입력 #2 Hello World!
        * 출력 #2 HelloWorld!
        ******************************************************************/
        static void Main(string[] args)
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');


            String s1 = input[0];
            String s2 = input[1];

            Console.WriteLine(s1 + s2);
        }
    }
}
