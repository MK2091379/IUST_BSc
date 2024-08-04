#include<stdio.h>
#include<stdlib.h>
void hanoi (int DiskNumber,char ColumnA,char ColumnB,char ColumnC)

{
    if (DiskNumber == 1)
    {
        printf("%c -> %c",ColumnA,ColumnB);
        printf("\n");
        printf("%c -> %c",ColumnB,ColumnC);
        printf("\n");
    }
    else
    {
        hanoi(DiskNumber - 1, ColumnA, ColumnB, ColumnC);
        printf("%c -> %c",ColumnA,ColumnB);
        printf("\n");
        hanoi(DiskNumber - 1, ColumnC, ColumnB, ColumnA);
        printf("%c -> %c",ColumnB,ColumnC);
        printf("\n");
        hanoi(DiskNumber - 1, ColumnA, ColumnB, ColumnC);
    }
    
}
int main(int argc, char const *argv[])
{
    int input1;
    scanf("%d",&input1);
    hanoi(input1,'A','B','C');
}

