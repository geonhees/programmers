public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] arr;
        char temp;
        arr = s.ToCharArray();
        for(int i = 0; i<s.Length; i++)
        {
            for(int j = 0; j<s.Length-1; j++)
            {
                if(arr[j] < arr[j+1])
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        answer = new string(arr);
        return answer;
    }
}