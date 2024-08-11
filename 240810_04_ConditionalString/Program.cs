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
            result.solution(ineq, eq, n, m);
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
                // .Equals
                int answer = 0;

                if (ineq == "<" && eq == "=")
                {
                    if (n <= m) { answer++; }
                }
                else if (ineq == ">" && eq == "=")
                {
                    if (n >= m) { answer++; }
                }
                else if (ineq == "<" && eq == "!")
                {
                    if (n < m) { answer++; }
                }
                else if (ineq == ">" && eq == "!")
                {
                    if (n > m) { answer++; }
                }

                return answer;


                /// 몇시간동안 박으면서 
                /// 이게 ! , = 에서 !이 참이 아닐때 쓰는데 왜 이게 있으면 반대로 받아야하는거 아닌가
                /// 이러한 생각 때문에 더 했갈렸다
                /// ex) >! 이러면 오른쪽이 더 커야하는거 아닌가 라던가
                /// 잘 안되다보니 이게 별의별 이상한걸 다 시도해보려했던거같다
                /// 로직은 이해는 했었는데 구현을 어떻게 해야하는가 쪽에서 막혔었다.
                /// 통채로 string1 = $"{n}{ineq}{eq}{m}"; 이런식으로 문자열로 만들어서
                /// 이 문자열이 참이면 1, 아니면 0 이런식으로 하려고했는데
                /// 이게 또 막상하려다보니까 뭔가 생각했던 것보다 더 복잡했다.
                /// 이게 뭔가 logical 하고 simple하게 사고하는 방식이 더 필요한거 같다.
                
                /// 다른사람들보면 ? 물음표를 많이 쓰는데 찾아봐도 뭔가가 뭔가 햇갈린다.
                /// 그래서 안쓰고 그냥 ==로 했는데 뭔가 봐도봐도 이해가 안되는? 햇갈리는 것들이 있다.


                //int answer = 0;
                //
                //bool isTrue = true;
                //
                //string string1, string2, comb1, comb2;
                //string compare1, compare2, compare3, compare4;
                //compare1 = 
                //string1 = $"{n}{ineq}{eq}{m}";
                //
                //switch (string1)
                //{
                //    case string s:
                //        answer ++;
                //        break;
                //}
                //

                //string1 = n.ToString();
                //string2 = m.ToString();
                //
                //comb1 = string1+ineq+string2;
                //Console.WriteLine(comb1);

                /// 밑에 여기서 if를 한번 더 써서 구축을 해봐야 한단거를
                /// 생각을 못했었다.


                //if (n < m)
                //{
                //    answer = 1;
                //}
                //else if (n > m)
                //{
                //
                //}
                //
                //if (ineq == "<")
                //{
                //
                //}
                //else if (ineq == ">")
                //{
                //    answer = 0;
                //}


            }
        }
    }
}
