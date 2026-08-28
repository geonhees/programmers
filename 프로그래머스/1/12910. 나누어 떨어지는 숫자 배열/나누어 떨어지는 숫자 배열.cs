public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[]{-1};
        int count = 0;
        int index = 0;
        int temp = 0;
        for(int i=0; i<arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                count++;
            }
            
        }

        if(count > 0)
        {
            answer = new int[count];
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] % divisor == 0)
                {
                    answer[index++] = arr[i];
                }
            }
        }   
        
        for(int i=0; i<count; i++)
        {
            for(int j=0; j<count-1; j++)
            {
                if (answer[i] < answer[j])
                {
                    temp = answer[j];
                    answer[j] = answer[i];
                    answer[i] = temp;
                }
            }
        }
        return answer;
    }
}