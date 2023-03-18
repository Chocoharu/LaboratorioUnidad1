#include<stdio.h>
#include<stdlib.h>

int main()
{
	int i, j;

	printf ("Cargando\n");
	system("pause");
	system("cls");
	
	for(i=0; i<10; i++)
	{
		printf("#########\n");
		for(j=0; j<i; j++)
		{
			printf("X");
		}
		printf("\n#########\n");
	}

	
	printf("Carga completa");
	
	
	return 0;
}
