public class Solution {
    public bool solution(int x) {
        int n = 0;
        int n2 = x;
        while(n2 > 0){
            n += n2%10;
            n2/=10;
        }
        return x%n==0 ? true : false;
    }
}