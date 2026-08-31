#include <stdio.h>

int solution(int num1, int num2) {
    float n1=num1, n2=num2;
    float answer = n1/n2;
    int n=answer*1000;
    return n;
}