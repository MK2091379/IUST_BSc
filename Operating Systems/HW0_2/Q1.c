#include <stdio.h>
void swap(int* a, int* b) {
  int c = 0;
  c = *b;
  *b = *a;
  *a = c;
}
int main() {
    int a = 11;
    int b = 1;
    printf("a before swap:%d b before swap:%d\n", a, b);
    swap(&a, &b);
    printf("a after swap:%d b after swap:%d\n", a, b);
}