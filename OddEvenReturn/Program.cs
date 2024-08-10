namespace _240810_03_OddEvenReturn
{   /// <summary>
    /// 2024-08-10
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 4 연산, 조건문 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181935
    /// </summary>
    internal class Program
    {   /****************************************************************
        * 홀짝에 따라 다른 값 반환하기
        * 문제설명:
        * 양의 정수 n이 매개변수로 주어질 때, 
        * n이 홀수라면 n 이하의 홀수인 모든 양의 정수의 합을 return 하고 
        * n이 짝수라면 n 이하의 짝수인 모든 양의 정수의 제곱의 합을 return 하는 solution 함수를 작성해 주세요.
        * 제한사항:
        *        1 ≤ n ≤ 100
        *       
        * 입출력 예)
        *    	 n    |	   result
        *        7    |	     16
        *       10    |	    220
        *****************************************************************/
        static void Main(string[] args)
        {
            Solution result = new Solution();
            result.solution(7);
            Console.WriteLine(result.solution(7));
        }
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                int odd = 0; 
                int even = 0;
                
                for (int i = n; i > 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        odd += i;
                    }
                    else if (i % 2 == 0)
                    {
                        even += i * i;
                    }
                }

                if (n % 2 != 0)
                {
                    answer = odd;
                }
                else if (n % 2 == 0)
                {
                    answer = even;
                }
                return answer;
            }
        }
    }
}
// 내 코드는 뭔가 이쁘지 않다...

/*
 * 와... 이게 보기도 좋고 나름 깔끔한거 같다.
public class Solution {
    public int solution(int n) {
        int answer = 0;
        if( n%2==0)
        {
            for(int i=2; i <= n; i+=2)
                answer += (i*i);
        }
        else
        {
            for(int i=1; i <= n; i+=2)
                answer +=i;
        }
        return answer;
    }
} 

 */