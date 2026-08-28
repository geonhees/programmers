public class Solution {
    public long solution(long n) {
        long answer = 0;
        int num = 0;
        while(n >= num * num)
        {
            num++;
            if(n < num * num)
            {
                return -1;
            }
        }
        answer = (num+1)*(num+1);
        return answer;
    }
}