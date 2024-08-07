namespace _240806_05_StringOverWrite
{   /// <summary>
    /// 2024-08-06
    /// 프로그래머스 :
    /// 코딩테스트 연습 > 코딩 기초 트레이닝 > Day 2 출력 & 연산 
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181943
    /// </summary>
    internal class Program
    {   /****************************************************************
        * 홀짝 구분하기
        * 문제설명:
        * 문자열 my_string, overwrite_string과 정수 s가 주어집니다. 
        * 문자열 my_string의 인덱스 s부터 overwrite_string의 길이만큼을 
        * 문자열 overwrite_string으로 바꾼 문자열을 return 하는 solution 함수를 작성해 주세요.
        * 입력 #1 He11oWor1d
        * 출력 #1 HelloWorld
        * 입력 #2 Program29b8UYP
        * 출력 #2 ProgrammerS123
        ******************************************************************/
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            Console.WriteLine(solution);
        }
    }
    public class Solution
    {
        public string solution(string my_string, string overwrite_string, int s)
        {
            string subString = my_string.Substring(0, s);
            string overString = my_string.Substring(s + overwrite_string.Length);

            string answer = subString + overwrite_string + overString;
            Console.WriteLine(answer);

            return answer;

            
        }
    }
}
