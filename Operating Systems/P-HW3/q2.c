
#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <math.h>
#include <sys/wait.h>

#define PIPE_NO 1
#define NO 5

void rand_str(char *dest, size_t length)
{
    char charset[] = "0123456789"
                     "abcdefghijklmnopqrstuvwxyz"
                     "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int i = 0;
    while (length-- > 0)
    {
        size_t index = (double)rand() / RAND_MAX * (sizeof charset - 1);
        dest[i] = charset[index];
        i++;
    }
    dest[i] = '\0';
}

int LogProducer(int id, int write_pipe)
{
    char str[100];
    char str2[80];
    sleep(1);
    printf("start : LogProducer %d\n", id);
    for (size_t i = 0; i < NO; i++)
    {
        rand_str(str2, 10 + i + id % 10);
        sprintf(str, "%d : %s", id, str2);
        write(write_pipe, &str, sizeof(char) * 80);
        sleep(1);
    }
    return 1;
}

int Logger(int read_pipe)
{
    FILE *fp;
    char str2[80];
    int count = 0;
    fp = fopen("./q2.txt", "w");
    printf("start : Logger 0\n");
    for (size_t i = 0; i < NO * 3; i++)
    {
        read(read_pipe, &str2, sizeof(char) * 80);
        count++;
        printf("%d => %s\n", count, str2);
        fprintf(fp, "%s\n", str2);
    }
    fclose(fp);
}
int main(int argc, char const *argv[])
{
    int pipes[PIPE_NO][2];
    for (size_t i = 0; i < PIPE_NO; i++)
    {
        pipe(pipes[i]);
    }

    int pid1;
    pid1 = fork();
    if (pid1 == 0)
    {
        pid1 = fork();
        if (pid1 != 0)
        {
            LogProducer(pid1, pipes[0][1]);
        }
        else
        {
            pid1 = fork();
            if (pid1 != 0)
            {
                LogProducer(pid1, pipes[0][1]);
            }
            else
            {
                pid1 = fork();
                if (pid1 != 0)
                {
                    LogProducer(pid1, pipes[0][1]);
                }
            }
        }
        exit(0);
    }
    else
    {
        Logger(pipes[0][0]);
    }
    return EXIT_SUCCESS;
}
