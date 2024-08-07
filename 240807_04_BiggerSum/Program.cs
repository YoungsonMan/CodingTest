namespace _240807_04_BiggerSum
{   /// <summary>
    /// 2024-08-07
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 3 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181939
    /// </summary>
    public class Program
    {   /****************************************************************
        * 문자열 곱하기
        * 문제설명:
        * 연산 ⊕는 두 정수에 대한 연산으로 두 정수를 붙여서 쓴 값을 반환합니다. 
        * 예를 들면 다음과 같습니다.
        * 12 ⊕ 3 = 123
        * 3 ⊕ 12 = 312
        * 양의 정수 a와 b가 주어졌을 때,
        * a ⊕ b와 b ⊕ a 중 더 큰 값을 return 하는 solution 함수를 완성해 주세요.
        * 단, a ⊕ b와 b ⊕ a가 같다면 a ⊕ b를 return 합니다.
        * 제한사항:
        *        1 ≤ a, b < 10,000
        * 입출력 예)
        *           a     | 	b    |	    result
        *           9     |	   91    |	     991
        *           89	  |     8    |	     898
        *****************************************************************/
        static void Main(string[] args)
        {
            Solution result = new Solution();
            int a = 9;
            int b = 91;
            result.solution(a, b);
            Console.WriteLine(result.solution(a, b));
        }
    }


    public class Solution
    {
        public int solution(int a, int b)
        {
            int answer = 0;
            string str1 = a.ToString();
            string str2 = b.ToString();
            string temp = str1 + str2;
            answer = int.Parse(temp);
            return answer;
            // 위에 방식이 작동은 하는데 
            // 제출 채점에서 테스트 반정도 실패하면서 빠꾸먹음.
        }
    }
}
