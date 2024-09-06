using System.Runtime;

namespace _240826_P01_IcedAmericano
{   /// <summary>
    /// 2024-08-26
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > 아이스 아메리카노 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120819
    /// </summary>
    internal class Program
    {
        /****************************************************************
        * 머쓱이는 추운 날에도 아이스 아메리카노만 마십니다.
        * 아이스 아메리카노는 한잔에 5,500원입니다.
        * 머쓱이가 가지고 있는 돈 "money"가 매개 변수로 주어질 때,
        * 머쓱이가 최대로 마실 수 있는 아메리카노의 잔 수와 남는 돈을 순서대로 담은
        * 배열을 return 하도록 solution 함수를 완성 해보세요.
        *제한사항:
        *        0 < money ≤ 1,000,000
        *       
        *       
        * 입출력 예)
        *    money  |    result   |
        *    5,500  |    [1, 0]   |   
        *    15,000 |  [2, 4000]  | 
        *   
        *****************************************************************/
        static void Main(string[] args)
        {
            Solution test = new Solution();
            int input = 5500;
            int[] answer = new int[2];
            answer = test.solution(input);
            Console.WriteLine($"{input}원은 아이스 아메리카노 {answer[0]}잔을 살 수 있고," +
                $"잔돈은 {answer[1]}원 입니다.");
        }
    }
    public class Solution
    {
        public int[] solution(int money)
        {
            int[] answer = new int [2];
            int IA = 5500;
            int remainder;

            answer[0] = money / IA;
            remainder = money % IA;

            answer[1] = remainder;

            return answer;
        }
    }
    public class JiEunSolution
    {
        public int[] JiSolution (int n)
        {// 지은님 %안쓰고 풀이
            int[] result = new int[2];
            result[0] = n / 5500;
            result[1] = n - (5500 * result[0]);  // 여기서 수호님인가 어떤분이 괄호쓰면 더 이쁠거같다하셔서 괄호추가 

            return result;

        }

    }
}
