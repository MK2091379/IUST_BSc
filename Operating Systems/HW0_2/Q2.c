#include <stdio.h>

int main() {
    int a[] = {12, 20, 4, -8, 32, 2, 2, 2, 2, 2, 2, 6, 22, 2, 5, 13, 2, 0, 0, 1, 2, 2, 2};
    int len = sizeof(a)/sizeof(a[0]);
    printf("%d\n", len);
}