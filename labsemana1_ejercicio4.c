#include<stdio.h>
#include<stdlib.h>

int main()
{
	int i, j;
	char c1='X', c2='O';
	char gato[3][3];	
	printf("GRAN_GATO\n");

	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			gato[i][j] = ' ';
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	gato[0][0]='X';
	
	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	gato[1][2]='O';
	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	gato[2][2]='X';
	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	gato[0][2]='O';
	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	gato[2][0]='X';
	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	gato[1][1]='O';
	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	gato[1][0]='X';
	for(i=0; i<3; i++)
	{
		for(j=0; j<3; j++)
		{
			printf("|%c|",gato[i][j]);
		}
		printf("\n");
	}
	system("pause");
	system("cls");
	
	printf("Ganador jugador X");
		
	return 0;
}