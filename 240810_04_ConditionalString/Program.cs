namespace _240810_04_ConditionalString
{   /// <summary>
    /// 2024-08-10
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 4 연산, 조건문 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181934
    /// </summary>


    public class Program
    {
        /****************************************************************
        * 공배수
        * 문자열에 따라 다음과 같이 두 수의 크기를 비교하려고 합니다.
        * 두 수가 n과 m이라면 
            ">", "=" : n >= m
            "<", "=" : n <= m
            ">", "!" : n > m
            "<", "!" : n < m
        * 두 문자열 ineq와 eq가 주어집니다. 
        * ineq는 "<"와 ">"중 하나고, eq는 "="와 "!"중 하나입니다. 
        * 그리고 두 정수 n과 m이 주어질 때, n과 m이 ineq와 eq의 조건에 맞으면 1을 
        * 아니면 0을 return하도록 solution 함수를 완성해주세요.
        * 
        * 제한사항:
        *        1 ≤ n, m ≤ 100
        *       
        * 입출력 예)
        *    ineq    |     eq     | 	 n    |	     m     |     result
        *    "<"     |     "="    |  	20    |	    50     |	    1
        *    ">"     |     "!"	  |     41    |	    78     |	    0
        *****************************************************************/
        static void Main(string[] args)
        {
            string ineq, eq;
            int n, m;
            ineq = ">";
            eq = "=";
            n = 20;
            m = 50;
            Solution result = new Solution();
            result.solution(ineq,eq,n,m);
            Console.WriteLine(result.solution(ineq, eq, n, m));
        }

        public class Solution
        {
            public int solution(string ineq, string eq, int n, int m)
            {
                // ineq 랜덤 ">" or "<"
                //  eq  랜덤 "=" or "!"
                // 어차피 무조건 m 이더 크다.
                // 논리적으로 n이나 m은 뭐 필요 없다.
                // eq( = , ! )도 뭐 딱히 상관 없고 그냥 
                
                // 음.. 테스트에서 다른 변수들도 나오는구나
                // n & m 둘다 고려해야한다.

                // int n,m을 그냥 string으로 바꿔서 비교해서 같으면 1 아니면 0되게??
                int answer = 0;

                string string1, string2, comb1, comb2;

                string1 = $"{n}{ineq}{eq}{m}";

                Console.WriteLine(string1);
                //string1 = n.ToString();
                //string2 = m.ToString();
                //
                //comb1 = string1+ineq+string2;
                //Console.WriteLine(comb1);


                if (n < m)
                {
                    answer = 1;
                }
                else if (n > m)
                {

                }

                if (ineq == "<")
                {

                }
                else if (ineq == ">")
                {
                    answer = 0;
                }
                
                return answer;
            }
        }
    }
}
