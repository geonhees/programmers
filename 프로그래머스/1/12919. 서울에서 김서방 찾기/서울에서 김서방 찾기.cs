public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int x=0;
        for(int i=0; i<seoul.Length; i++)
        {
            if(seoul[i] == "Kim")
            {
                x = i;
            }
        }
        answer = "김서방은 "+ x + "에 있다"; 
        return answer;
    }
}