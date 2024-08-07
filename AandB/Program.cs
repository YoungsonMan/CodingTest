namespace _240805_02_AandB
{
    public class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************
             * a와 b 출력하기
             * 문제설명:
             * 정수 a와 b가 주어집니다. 
             * 각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.
             * 입력 #1 4 5
             * 출력 #1 a = 4
             *         b = 5
             ***************************************************************/

            
            Console.Clear();
            string input = Console.ReadLine();
            String[] s = input.Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine($"a = {a}\nb = {b}");
            

            /*
             
            그냥 이렇게 했어도 됐음 왜 처음에 VS로 복붙할떄 에러떴는지 모르겠지만...

            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine($"a = {a}\nb = {b}");
            */




        }
    }
}
