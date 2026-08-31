public class Solution {
    public int solution(long num) {
        int answer = 0;
        while(answer < 500 && num != 1){
            if(num % 2 == 0)
            {
                num /= 2;
            }
            else if(num % 2 != 0)
            {
                num *= 3;
                num++;
            }
            answer++;
        }
        if(answer >= 500)
        {
            return -1;
        }
        return answer;
    }
}