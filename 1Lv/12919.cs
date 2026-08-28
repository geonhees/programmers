// 그냥 for문 돌려서 seoul안에 Kim 있으면
// 그거 x 안에 저장하고 
// 문자열 연결해서 완성

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