﻿namespace _240810_02_MultipleOfN
{   /// <summary>
    /// 2024-08-10
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 4 연산, 조건문 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181937
    /// </summary>
    public class Program
    {
        /****************************************************************
        * n의 배수
        * 문제설명:
        * 정수 num과 n이 매개 변수로 주어질 때, 
        * num이 n의 배수이면 1을 return n의 배수가 아니라면 
        * 0을 return하도록 solution 함수를 완성해주세요.
        * 제한사항:
        *        2 ≤ num ≤ 100
        *        2 ≤ n ≤ 9
        * 입출력 예)
        *         num     | 	n    |	    result
        *          98     |	    2    |	     1
        *          34	  |     3    |	     0
        *****************************************************************/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Solution
        {
            public int solution(int num, int n)
            {
                int answer = 0;
                if (num % n == 0)
                    answer++;
                return answer;
            }
        }
    }
}
