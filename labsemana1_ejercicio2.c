#include<stdio.h>

int main()
{
	int num, suma, resta, multiplicacion;
	float division;
	
	printf ("Ingrese un numero entero:");
	scanf ("%d", &num);
	
	suma = 5+num;
	printf ("\nEl resultado de la suma es: %d", suma);
	
	resta = 4-num;
	printf ("\nEl resultado de la resta es: %d", resta);
	
	multiplicacion = 3*num;
	printf ("\nEl resultado de la multiplicacion es: %d", multiplicacion);
	
	division = (float)num/2;
	printf ("\nEl resultado de la division es: %f", division);
	
	return 0;
}
