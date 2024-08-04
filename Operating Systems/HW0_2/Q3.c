#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include <stdbool.h>
#include <assert.h>
struct virus{
    char* name;
    int infection;
    int mortality;
    int resistance_to_vaccines;
    int avr;
};
///////////////////////////////////////////////////////////////////////////
void swap(struct virus *xp, struct virus *yp)
{
    struct virus temp = *xp;
    *xp = *yp;
    *yp = temp;
}
int func1(struct virus v1,struct virus v2){
    if(v1.infection>v2.infection){
        return 1;
    }
    else{
        return 0;
    }
}
int func2(struct virus v1,struct virus v2){
    if(v1.avr>v2.avr){
        return 1;
    }
    else{
        return 0;
    }
}
int func3(struct virus v1,struct virus v2){
    if((v1.infection+v1.mortality)>(v2.infection+v2.mortality)){
        return 1;
    }
    else{
        return 0;
    }
}
int func4(struct virus v1,struct virus v2){
    if(3*(v1.mortality)+v1.resistance_to_vaccines>3*(v2.mortality)+v2.resistance_to_vaccines){
        return 1;
    }
    else{
        return 0;
    }
}
/////////////////////////////////////////////////////////////////////////////////////////////////////
void function(int(*method)(struct virus,struct virus),struct virus VIRUSES[],int n){
    bool swapped;
    for(int i = 0;i<n-1;i++){
        swapped = false;
        for(int j = 0;j<n-i-1;j++){
            if((*method)(VIRUSES[j],VIRUSES[j+1])==false){
                swap(&VIRUSES[j], &VIRUSES[j+1]);
                swapped = true;
            }
        }
        if(swapped==false)
            break;
    }
    for (int i=0; i < n; i++)
    {
        printf("%-11s",VIRUSES[i].name);
        if(VIRUSES[i].infection>=10 && VIRUSES[i].infection<=99)
            printf(" %d",VIRUSES[i].infection);
        if(VIRUSES[i].infection<10)
            printf("  %d",VIRUSES[i].infection);
        if(VIRUSES[i].infection>=100)
            printf("%d",VIRUSES[i].infection);
        

        if(VIRUSES[i].mortality>=10 && VIRUSES[i].mortality<=99)
            printf("  %d",VIRUSES[i].mortality);
        if(VIRUSES[i].mortality<10)
            printf("   %d",VIRUSES[i].mortality);
        if(VIRUSES[i].mortality>=100)
            printf(" %d",VIRUSES[i].mortality);
        



        if(VIRUSES[i].resistance_to_vaccines>=10 && VIRUSES[i].resistance_to_vaccines<=99)
            printf("  %d",VIRUSES[i].resistance_to_vaccines);
        if(VIRUSES[i].resistance_to_vaccines<10)
            printf("   %d",VIRUSES[i].resistance_to_vaccines);
        if(VIRUSES[i].resistance_to_vaccines>=100)
            printf(" %d",VIRUSES[i].resistance_to_vaccines);
        



        if(VIRUSES[i].avr>=10 && VIRUSES[i].avr<=99)
            printf("  %d",VIRUSES[i].avr);
        if(VIRUSES[i].avr<10)
            printf("   %d",VIRUSES[i].avr);
        if(VIRUSES[i].avr>=100)
            printf(" %d",VIRUSES[i].avr);
        printf("\n");
    }


}

int main(int argc, char const *argv[])
{
    int n;
    scanf("%d",&n);
    char info_arr[100][100];
    int i = 0;
    while(true)
    {
        char info[50];
        fgets(info, 100, stdin);
        //info_arr[i] = info;
        strcpy(info_arr[i], info);
        if(i==n){
            break;
        }
        i++;
    }
    int method_number;
    scanf("%d",&method_number);
////////////////////////////////////////////////////////////////////////////
struct virus VIRUSES[n];
////////////////////////////////////////////////////////////////////////////
    printf("           INF MOR RES AVG\n");
    for(int i = 1;i<n+1;i++)
    {
        int j = 0;
        //char line[4][100];
	    char * token = strtok(info_arr[i], " ");
        while( token != NULL ) {
           //printf( " %s\n", token );
            if(j == 0){
               VIRUSES[i-1].name = token;
               //printf("%s\n",VIRUSES[i-1].name);
            }
            if(j == 1){
               VIRUSES[i-1].infection = atoi(token);
               //printf("%d\n",VIRUSES[i-1].infection);
            }
            if(j == 2){
               VIRUSES[i-1].mortality = atoi(token);
               //printf("%d\n",VIRUSES[i-1].mortality);
            }
            if(j == 3){
               VIRUSES[i-1].resistance_to_vaccines = atoi(token);
               //printf("%d\n",VIRUSES[i-1].resistance_to_vaccines);
            }
           //strcpy(line[j], token);
           token = strtok(NULL, " ");
           j++;
        }
        VIRUSES[i-1].avr = (VIRUSES[i-1].mortality + VIRUSES[i-1].infection + VIRUSES[i-1].resistance_to_vaccines)/3;
        //printf("%d\n",VIRUSES[i-1].avr);
        //printf("___________________________________________\n");
    }
    int(*method[])(struct virus,struct virus) = {func1,func2,func3,func4};
    function((*method[method_number]),VIRUSES,n);
    return 0;
}
