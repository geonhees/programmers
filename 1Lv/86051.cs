// 차라리 그냥 
// 0부터 9까지 먼저 다 answer에 더하고
// 배열에 있는 수를 빼면 되지 않나?

using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;
        for(int i=0; i<numbers.Length; i++)
        {
            answer-=numbers[i];
        }
        return answer;
    }
}