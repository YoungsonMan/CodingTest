namespace _240807_03_ArrayProduct
{   /// <summary>
    /// 2024-08-07
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 3 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181940
    /// </summary>
    public class Program
    {   /****************************************************************
        * 문자열 곱하기
        * 문제설명:
        * 문자열 my_string과 정수 k가 주어질 때, 
        * my_string을 k번 반복한 문자열을 return 하는 solution 함수를 작성해 주세요.
        * 제한사항:
        *         1 ≤ my_string의 길이 ≤ 100
        *         my_string은 영소문자로만 이루어져 있습니다.
        *         1 ≤ k ≤ 100
        * 입출력 예)
        *           my_string | 	k  |	result
        *           "string"  |	    3  |	"stringstringstring"
        *           "love"	  |    10  |	"lovelovelovelovelovelovelovelovelovelove"
        *****************************************************************/
        static void Main(string[] args)
        {
            string my_string = "string";
            int k = 3;

            string my_string2 = "string";

            Solution solution = new Solution();
            solution.solution(my_string, k);
            Console.WriteLine(solution.solution(my_string, k));


         }
    }

    public class Solution
    {
        public string solution(string my_string, int k)
        {
            string answer = "";
            for (int i = 0; i < k; i++)
            {
                answer += my_string;
            }

            return answer;
        }
    }

}
