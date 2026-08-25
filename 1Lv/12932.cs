using System;

public class Solution {
    public int[] solution(long n) {
        int length = n.ToString().Length;
        int[] answer = new int[length];
        for(int i=0; i<length; i++){
            answer[i] = (int)(n % 10);
            n /= 10;
        }
        return answer;
    }

    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine($"정답은 {solution(num)}");
    }
}