#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <fcntl.h>
#include <sys/shm.h>
#include <sys/stat.h>
#include <sys/mman.h>
#include <unistd.h>
#include <errno.h>
#include <semaphore.h>
#include <sys/types.h>
#include <sys/wait.h>

#define SIZE 1024
#define NAME "my_shr_mem"
#define SEM_NAME "my_sem1"

sem_t *sem;

void merge(int arr[], int l, int m, int r)
{
    printf("in merge left:%d ,midle:%d ,right:%d\n", l, m, r);
    sleep(1);
    int i, j, k;
    int n1 = m - l + 1;
    int n2 = r - m;

    int L[n1], R[n2];

    for (i = 0; i < n1; i++)
        L[i] = arr[l + i];
    for (j = 0; j < n2; j++)
        R[j] = arr[m + 1 + j];

    i = 0;
    j = 0;
    k = l;
    sem_wait(sem);
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    while (i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
    sem_post(sem);
}

void mergeSort(int arr[], int l, int r)
{
    printf("in sort left:%d ,right:%d\n", l, r);
    sleep(1);
    int pid = -10;
    int pid2 = -10;
    if (l < r)
    {
        int m = l + (r - l) / 2;

        pid = fork();
        if (pid == 0)
        {
            mergeSort(arr, l, m);
            exit(0);
        }
        else
        {
            mergeSort(arr, m + 1, r);
        }
        wait(NULL);
        if (pid > 0)
            merge(arr, l, m, r);
    }
}

void printArray(int A[], int size)
{
    int i;
    for (i = 0; i < size; i++)
        printf("%d ", A[i]);
    printf("\n");
}

int main()
{
    int shm_fd;
    int *ptr;

    sem = sem_open(SEM_NAME, O_CREAT, 0666, 1);
    shm_fd = shm_open(NAME, O_CREAT | O_RDWR, 0666);
    if (shm_fd < 0)
    {
        perror("Failed to open shared mem");
        return EXIT_FAILURE;
    }
    ftruncate(shm_fd, SIZE);
    ptr = (int *)mmap(0, SIZE, PROT_WRITE, MAP_SHARED, shm_fd, 0);

    int arr[] = {12, 11, 13, 5, 6, 7, 32, 32, 32, 3, 2, 3};
    int arr_size = rand();
    arr_size %= 15;
    if (arr_size < 5)
        arr_size = 10;
    for (int i = 0; i < arr_size; i++)
        ptr[i] = rand() % 100;
    printf("array length : %d \n", arr_size);
    printf("unsorted array : ");
    printArray(ptr, arr_size);
    printf("\n-------------------\n");

    mergeSort(ptr, 0, arr_size - 1);

    wait(NULL);
    printf("-------------\nsorted array : \n");
    printArray(ptr, arr_size);

    return 0;
}
