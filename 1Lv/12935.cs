public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length-1];
        int min=2100000000;
        int index = 0;
        int answerIndex = 0;
        
        if(arr.Length-1 == 0){
            answer = new int[]{-1};
            return answer;
        }
        
        for(int i = 0; i<arr.Length; i++){
            if(min > arr[i]){
                min = arr[i];
                index = i;
            }
        }
        
        for(int i=0; i<arr.Length; i++){
            if(index == i){
                continue;
            }
            answer[answerIndex++] = arr[i];
        }
        
        return answer;
    }
}