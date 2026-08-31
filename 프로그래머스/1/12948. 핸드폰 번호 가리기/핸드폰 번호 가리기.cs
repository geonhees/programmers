public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        for(int i = 0; i<phone_number.Length; i++)
        {
            answer = phone_number.Length-i>4 ? answer+="*" : answer+=phone_number[i];
        }
        return answer;
    }
}