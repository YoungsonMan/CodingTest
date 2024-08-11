namespace _240811_05_ConditionalFlag
{   /// <summary>
    /// 2024-08-11
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 4 연산, 조건문 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181933
    /// </summary>
    public class Program
    {/****************************************************************
     * 공배수
     * 두 정수 a, b와 boolean 변수 flag가 매개변수로 주어질 때, 
     * flag가 true면 a + b를 false면 a - b를 return 하는 solution 함수를 작성해 주세요.
     * 
     * 제한사항:
     *        -1,000 ≤ a, b ≤ 1,000
     *       
     * 입출력 예)
     *     a     |     b     |	  flag    |   result
     *    -4     |     7     |	  true    |	    3
     *    -4     |     7     |	 false    |	   -11
     *****************************************************************/
        static void Main(string[] args)
        {
            Solution[] result = new Solution[4];
            result[0] = new Solution();
            result[1] = new Solution();
            result[2] = new Solution();
            result[3] = new Solution();

            //result[0].solution(-4, 7, true);
            //result[1].solution(-4, 7, false);
            //result[2].solution(-12, -12, true);
            //result[3].solution(-12, -12, false);
            Console.WriteLine(result[0].solution(-4, 7, true));
            Console.WriteLine(result[1].solution(-4, 7, false));
            Console.WriteLine(result[2].solution(-12, -12, true));
            Console.WriteLine(result[3].solution(-12, -12, false));
        }
        public class Solution
        {
            public int solution(int a, int b, bool flag)
            {
                int answer = 0;
                if (flag.Equals(true))
                {
                    answer = a + b;
                }
                else if (flag.Equals(false))
                {
                    answer = a - b;
                }

                return answer;
            }
        }
        /// 이전 문제에서 .Equals를 검색해본게 여기서 도움이 됐다.
        /// 아 근데 맨날 이거 테스트 돌리는데 위에 프로그램 안바꿔가지고  <summary>
        /// 이전 문제에서 .Equals를 검색해본게 여기서 도움이 됐다.
        /// 다른 프로그램 돌아가서 이상하게 돌아가서 햇깔렸다. 
    }
}
