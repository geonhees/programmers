public class Solution {
    public long solution(long n) {
        long answer = 0;
        char temp = '0';

        char[] arr = n.ToString().ToCharArray();

        for(int i=0; i<arr.Length; i++)
        {
            for(int j=0; j<arr.Length-1; j++)
            {
                if(arr[j] < arr[j+1])
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        answer = long.Parse(new string(arr));
        return answer;
    }
}