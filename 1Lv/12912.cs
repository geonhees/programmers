public class Solution {
    public static long solution(int a, int b) {
        long answer = 0;
        if (a < b)
        {
            for(int i=a; i<b+1; i++)
            {
                answer+=i;
            }
        }
        else
        {
            for(int i=b; i<a+1; i++)
            {
                answer+=i;
            }
        }
        return answer;
    }
    static void Main(){
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        Console.WriteLine($"답은 {solution(a,b)}이다.");
    }
}