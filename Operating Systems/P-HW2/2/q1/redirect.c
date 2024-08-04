#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <unistd.h>
#include <sys/wait.h>
#include <sys/stat.h>

int main(int argc, char **argv)
{
    //stage 2 and 3 : check to see if file is excutable 
    struct stat sb;
    FILE *fPtr;
    char *argv2[argc-1];
    int i;
    if (stat(argv[1], &sb) != 0 || !(sb.st_mode & S_IXUSR)) 
    {
        printf("Given file is not executable.\n");
        return 0;
    }

    // stage 4 :create file and id
    fPtr = fopen(argv[2], "w+");
    freopen(argv[2],"a",stdout);
    freopen(argv[2],"a",stderr);

    if(fPtr == NULL)
    {
        printf("Unable to create file.\n");
        exit(EXIT_FAILURE);
    }
    //stage 6 : run program with args
    if(fork() == 0){ 
        argv2[0] = argv[1];
        for(i=3;i<argc;i++)
            argv2[i-2] = argv[i];
        argv2[argc-2] = NULL;
        execvp(argv2[0], argv2);
    }
    wait(NULL);
    freopen("/dev/tty", "w", stdout);
    freopen("/dev/tty", "w", stderr);
    printf("child rc: 0\n");
    fclose(fPtr);
    
    return 0; 
}