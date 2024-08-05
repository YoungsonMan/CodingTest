namespace _240805_03PrintLoopString
{
    internal class Program
    { /****************************************************************
      * 문자열 반복해서 출력하기
      * 문제설명:
      * 문자열 str 과 정수 n 이 주어집니다.
      * str 이 n 번 반복된 문자열을 ㅁ나들어 출력하는 코드를 작성하기
      * 제한사항:
      *         1 <= str 의 길이 <= 10
      *         1 <= n <= 5 
      ***************************************************************/
        static void Main(string[] args)
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            int a = Int32.Parse(input[1]);
            for (int i = 0; i < a; i++)
            {
                Console.Write(s1);
            }

        }
    }
}
