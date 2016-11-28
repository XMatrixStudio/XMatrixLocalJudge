#include <math.h>
#include <string.h>
#include <stdio.h>

long int howmuch(char str[]){
  long int sum = 0;
  int longs = strlen(str) - 1;
  for (int index = 0; index < strlen(str); index++){
    sum += (str[longs--] - 48)* pow(10, index);
  }
  return sum;
}

void add(char a[], char b[], char c[]){
    long int temp = howmuch(a) + howmuch(b);
    sprintf(c, "%d", temp);
}
int main() {
  char lhs[8] = {}, rhs[8] = {}, sum[10] = {};
  scanf("%s %s", lhs, rhs);
  add(lhs, rhs, sum);
  printf("%s\n", sum);
  return 0;
}
