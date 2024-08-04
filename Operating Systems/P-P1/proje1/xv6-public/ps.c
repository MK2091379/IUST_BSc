#include "types.h"
#include "stat.h"
#include "user.h"
#include "fs.h"

#include "my_struct.h"

void swap(struct proc_info *xp, struct proc_info *yp)
{
	struct proc_info temp = *xp;
	*xp = *yp;
	*yp = temp;
}

void selectionSort(struct proc_info *arr, int n)
{
	int min_idx;
	for (int i = 0; i < n - 1; i++)
	{
		min_idx = i;
		for (int j = i + 1; j < n; j++)
			if (arr[j].memsize < arr[min_idx].memsize)
				min_idx = j;
		swap(&arr[min_idx], &arr[i]);
	}
}

int main(void)
{
	int size = 5;
	struct proc_info *processes_infos = malloc(sizeof(struct proc_info) * size);

	int c_pi1 = fork();
	int c_pi2 = fork();

	//Xv6 applications ask the kernel for heap memory using the sbrk() system call.
	if (c_pi1 == 0)
	{
		sbrk(16000);
	}

	if (c_pi2 == 0)
	{
		sbrk(4096);
	}

	if (c_pi1 > 0 && c_pi2 > 0)
	{
		int a = proc_dump(size, processes_infos);
		if (a < 0)
		{
			printf(1, "ERROR : input variables are not valid! \n");
			exit();
		}
		sleep(30);
		selectionSort(a, size);
		for (int i = 0; i < size; i++)
		{
			printf(1, "%d -> pid : %d ,memsize : %d \n", i, processes_infos[i].pid, processes_infos[i].memsize);
		}
	}
	exit();
}
