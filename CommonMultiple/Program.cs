using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _240810_02_CommonMultiple
{   /// <summary>
    /// 2024-08-10
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 4 연산, 조건문 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181936
    /// </summary>
    public class Program
    {   /****************************************************************
        * 공배수
        * 문제설명:
        * 정수 number와 n, m이 주어집니다. 
        * number가 n의 배수이면서 m의 배수이면 1을 아니라면 0을 return하도록 
        * solution 함수를 완성해주세요.
        * 제한사항:
        *        2 ≤ num ≤ 100
        *        2 ≤ n, m ≤ 9
        * 입출력 예)
        *    num     |      n     | 	 m    |	    result
        *     60     |      2     |  	 3    |	     1
        *     55     |     10	  |      5    |	     0
        *****************************************************************/
        static void Main(string[] args)
        {
            int number, n, m;
            number = 55;
            n = 10;
            m = 5;

            Solution result = new Solution();
            result.solution(number, n, m);
            Console.WriteLine(result.solution(number, n, m));

        }
        // 맨처음에는 number % n == number % m 해가지고 하다가 반정도 안되서 
        // n * m 합result로 나눠서 구해보려고햇는데 테스트2번에서 계속 실패떠서 찾아보니  number % result == 0 
        // number = 8, n = 8, m = 4 이런 경우도 있고 이런 경우는 성립이 안되서.. 고민끝에 double로 소수까지 나오게해서 더해서 0이아니면 아닌걸로..
        public class Solution
        {
            public int solution(int number, int n, int m)
            {
                int answer = 0;
                int result = n * m;
                if ( (((double)(number % n)) + ((double)(number % m)) == 0))
                    answer++;
                return answer;
            }
        }
    }
}
/*
 * 문제의 허점을 잘 파고든거 같다 대단하구만... 
 public class Solution {
    public int solution(int number, int n, int m) {
        if(number % n != 0) return 0;
        if(number % m != 0) return 0;
        return 1;
    }
 * 
 * 
 * 
 */
