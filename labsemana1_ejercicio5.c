#include<stdio.h>
#include<stdlib.h>
#include<time.h>

int main ()
{
	srand(time(NULL));
	
	int i=0, aux;

	printf("VRVTetrix\n");
	
	do 
	{
		int a=rand()%7+1;
		
		do
		{
			a=rand()%7+1;
		}while(a==aux);
		
		printf("Pieza de juego: %d\n",a);
		
		aux = a;
		i++;
		
	}while(i<7);
	
	
	return 0;
}
