public class Solution {
    public static int solution(string s) {
        int answer = 0;
        answer = int.Parse(s);
        return answer;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine($"출력 : {solution(s)}");
    }
}