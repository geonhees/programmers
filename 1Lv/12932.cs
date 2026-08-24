public class Solution {
    public static int[] solution(long n) {
        int length = n.ToString().Length;
        int[] answer = new int[length] {};
        int index = 0;
        while(n != 0)
        {
            answer[index] = Convert.ToInt32(n % 10);
            n /= 10;
            index++;
        }
        return answer.ToArray();
    }

    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine($"정답은 {solution(num)}");
    }
}