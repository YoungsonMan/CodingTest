using System.Security.Cryptography.X509Certificates;

namespace _24080922_P02_CutToArray
{
    internal class Program
    {   /****************************************************************
        * 문자열 my_str과 n이 매개변수로 주어질 때, 
        * my_str을 길이 n씩 잘라서 저장한 배열을 return하도록 함수를 완성하기.
        * 
        *제한사항:
        *        0 < my_str ≤ 100
        *       1 ≤ n ≤ my_str의 길이
        *       my_str은 알파벳 소문자, 대문자, 숫자로 이루어져 있습니다.
        *       
        * 입출력 예)
        *         money          |   n   |               result                 |
        *    "abc1Addfggg4556b"  |   6   |     ["abc1Ad", "dfggg4", "556b"]     |   
        *    "abcdef123"         |   3   |         ["abc", "def", "123"]        | 
        *   
        *   
        *   입출력 예 #1
        *   "abc1Addfggg4556b" 를 길이 6씩 잘라 배열에 저장한 ["abc1Ad", "dfggg4", "556b"]를 return해야 합니다.
        *   
        *   입출력 예 #2
        *   "abcdef123" 를 길이 3씩 잘라 배열에 저장한 ["abc", "def", "123"]를 return해야 합니다.
        *   
        *****************************************************************/
        static void Main(string[] args)
        {
            string str1;
            int n;

            str1 = "abc1Addfggg4556b";
            n = 6;
            Solution testing = new Solution();
            
            var answer = testing.solution(str1, n);

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Solution
    {
        public string[] solution(string my_str, int n)
        {
            string[] answer = new string[] { };
            List<string> list = new List<string>();
            int j = my_str.Length;
            for (int i = 0; i < my_str.Length; i += n)
            {
                // 이게 그냥 하면 i가 마지막 3번째에서 556b가 4개라 n(6)보다 낮아서 계속 터져서
                // int j만들어서 그걸로 Length 줄때마다 j로 n 비교해서 string 자르기
                // j 를 첨에는 그냥 forLoop안에 넣어는데 돌때마다 그냥 마이너스 안된 풀str.Length로 갱신되서 밖에 뺴버리기
                if (j > n)
                {
                    list.Add(my_str.Substring(i, n));
                    j -= n;
                }
                else if (j <= n)
                {   // for 루프 돌다가 이제 string Length가 n보다 짧으면 그냥 J(남은)만큼만.
                    // 처음에 j < n 해서 한번 안됐다. 망충이
                    list.Add(my_str.Substring(i, j));
                    break;
                }
     
            }
            answer = list.ToArray();
            return answer;
        }
    }
}
