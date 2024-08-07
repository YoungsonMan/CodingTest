using Microsoft.VisualBasic;

namespace _240807_01_MixStrings
{   /// <summary>
    /// 2024-08-07
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 3 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181942
    /// </summary>
    internal class Program
    {
        /****************************************************************
        * 문자열 섞기
        * 문제설명:
        * 길이가 같은 두 문자열 str1과 str2가 주어집니다.
        * 두 문자열의 각 문자가 앞에서부터 서로 번갈아가면서 한 번씩 등장하는 문자열을 만들어 
        * return 하는 solution 함수를 완성해 주세요.
        * 제한사항:
        *         1 <= str 의 길이 <= 10
        *         str 은 알파벳으로 소문자로 이루어진 문자열입니다.
        * 입력 #1:
        *          str1: "aaaaa"
        *          str2: "bbbbb"
        * 출력 #1:
        *          	ababababab
        *****************************************************************/

        static void Main(string[] args)
        {
            string str1 = "aaaaa";
            string str2 = "bbbbb";

            string answer = ""; // 아무것도 없어도 지정을 해줘야되는구나.

            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            for (int i = 0; i < charArray1.Length; i++)
            {
                answer += charArray1[i];
                Console.Write($"{charArray1[i]}");
                for (int j = 1; j < charArray2.Length+1; j++)
                {
                    answer += charArray2[j];
                    Console.Write(charArray2[j]);
                    break ;
                }
            }
            Console.WriteLine();
            Console.WriteLine(answer);


            // 위에처럼 했었는데 작동은하고 정답은 뽑았지만 효율성에서 실패를 먹었다.
            // 그래서 찾아보니 string에서 array[]순서로 어떻게 하면서 뽑느게 있었다.
            for (int i = 0; i < str1.Length; i++)
            {
                answer += str1[i].ToString() + str2[i].ToString();

            }

            Console.WriteLine();
            Console.WriteLine();


            // 클래서 불러와서 쓸때 이런식으로 사용
            Solution solution = new Solution();
            solution.solution(str1, str2);
            Console.WriteLine(solution.solution(str1, str2));
        }

        public class Solution
        {
            public string solution(string str1, string str2)
            {
                string answer = "";
                for (int i = 0; i < str1.Length; i++)
                {
                    answer += str1[i].ToString() + str2[i].ToString();
                }
                return answer;
            }
        }
    }
}

