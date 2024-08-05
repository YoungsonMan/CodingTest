using System.ComponentModel.Design;

namespace _240805_04_ExchangeUpperAndLowerCase
{/****************************************************************
 * 대소문자 바꿔서 출력하기
 * 문제설명:
 * 영어 알파벳으로 이루어진 문자열 str 이 주어집니다.
 * 각 알파벳을 대문자는 소문자로, 소문자는 대문자로 변환해서
 * 출력하는 코드를 작성해보세요
 * 제한사항:
 *         1 <= str 의 길이 <= 20
 *         str 은 알파벳으로 이루어진 문자열입니다.
 * 입력 #1:
 *          aBcDeFg
 * 출력 #1:
 *          AbCdEfG
 *****************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            String input, exchange;
            exchange = "";
            Console.Clear();
            input = Console.ReadLine();

            char[] caseCheck = input.ToCharArray();
            for (int i = 0; i < caseCheck.Length; i++)
            {
                if (caseCheck[i] >= 'a' && caseCheck[i] <= 'z')
                {
                    exchange += char.ToUpper(caseCheck[i]);
                }
                else if (caseCheck[i] >= 'A' && caseCheck[i] <= 'Z')
                {
                    exchange += char.ToLower(caseCheck[i]);
                }
                else
                {
                    exchange += caseCheck[i];
                }
            }
            Console.WriteLine(exchange);




            /*
             String s;

             Console.Clear();
             s = Console.ReadLine();

             foreach ( char c in s)
             {
                 if(char.IsUpper(c))
                 {
                     Console.Write(char.ToLower(c));
                 }
                 else
                 {
                     Console.Write(char.ToUpper(c));
                 }
             }
            다른사람 한거 확인하는데 위에코드 깔끔하고 좋다.
            이런식으로 되는줄 알았으면 이렇게 했지

             */



        }
    }
}
