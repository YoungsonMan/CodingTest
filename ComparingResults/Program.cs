namespace _240810_05_ComparingResults
{   /// <summary>
    /// 2024-08-10
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 3 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181938
    /// </summary>
    public class Program
    {   /****************************************************************
        * 두 수의 연산값 비교하기
        * 문제설명:
        * 연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다. 
        * 예를 들면 다음과 같습니다.
        * 12 ⊕ 3 = 123
        * 3 ⊕ 12 = 312
        * 양의 정수 a와 b가 주어졌을 때, 
        * a ⊕ b와 2 * a * b 중 더 큰 값을 return하는 solution 함수를 완성해 주세요.
        * 단, a ⊕ b와 2 * a * b가 같으면 a ⊕ b를 return 합니다.


        * 제한사항:
        *        1 ≤ a, b < 10,000
        * 입출력 예)
        *           a     | 	b    |	    result
        *           2     |	   91    |	     364
        *           91	  |     2    |	     912
        *****************************************************************/
        static void Main(string[] args)
        {
            int a = 2;
            int b = 91;
            Solution result = new Solution();
            result.solution(a, b);
            Console.WriteLine(result.solution(a, b));
        }
    }
    public class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;
            int product;
            product = 2 * a * b;

            int strProduct;
            string str1 = a.ToString();
            string str2 = b.ToString();
            strProduct = int.Parse(str1 + str2);
            if (product > strProduct)
            {
                answer = product;
            }
            else
            {
                answer = strProduct;

            }

            return answer;
        }
    }
}
