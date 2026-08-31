#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int num, int n) {
    int a = 0;
    if(num%n==0){
        a=1;
    }
    return a;
}