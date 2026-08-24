using System;

public class Solution {
    public static int solution(int n) {
        int answer = 0;
        while(n != 0)
        {
            answer+=n%10;
            n/=10;
        }
        return answer;
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"정답은 {solution(num)}");
    }
}