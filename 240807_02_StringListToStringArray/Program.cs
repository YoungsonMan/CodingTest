namespace _240807_02_StringListToStringArray
{   /// <summary>
    /// 2024-08-07
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 3 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181941
    /// </summary>
    public class Program
    {
        /****************************************************************
        * 대소문자 바꿔서 출력하기
        * 문제설명:
        * 문자들이 담겨있는 배열 arr가 주어집니다. 
        * arr의 원소들을 순서대로 이어 붙인 문자열을 return 하는 solution함수를 작성해 주세요.
        * 제한사항:
        *         1 <= arr 의 길이 <= 200
        *         arr의 원소는 전부 알파벳 소문자로 이루어진 길이가 1인 문자열입니다.
        * 입력 #1:
        *          arr:  ["a","b","c"]
        * 출력 #1:
        *          "abc"
        *****************************************************************/
        static void Main(string[] args)
        {
            string answer = "";
            string[] strings = { "a", "b", "c" };
            for (int i = 0; i < strings.Length; i++)
            {
                answer += strings[i];
            }
            Console.Write(answer);
            
            Console.WriteLine();
            foreach (string s in strings)
            {
                Console.Write(s);
            }
            Console.WriteLine();
            Console.WriteLine();



            // 클래서 불러와서 쓸때 이런식으로 사용
            Solution solution = new Solution();
            solution.solution(strings);
            Console.WriteLine(solution.solution(strings));

            

        }

        public class Solution
        {
            public string solution(string[] arr)
            {
                string answer = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    answer += arr[i];
                }

                return answer;
            }
        }

    }
}
