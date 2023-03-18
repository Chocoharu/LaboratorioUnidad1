using System;
using labsemana1_ejercicio7.models;

Vehiculos v1 = new Vehiculos();
v1.Fabricante = "Chevrolet";
v1.Modelo = "Camaro";
v1.Año = "2020";
v1.Velocidad = 75.7;
v1.Maniobrabilidad = 64.35;

Vehiculos v2 = new Vehiculos();
v2.Fabricante = "Ford";
v2.Modelo = "Mustang";
v2.Año = "2019";
v2.Velocidad = 69.8;
v2.Maniobrabilidad = 72.64;

Vehiculos v3 = new Vehiculos();
v3.Fabricante = "Dodge";
v3.Modelo = "Challenger";
v3.Año = "2020";
v3.Velocidad = 72.3;
v3.Maniobrabilidad = 66.48;

System.Console.WriteLine(v1.ToString());
System.Console.WriteLine("----------------");
System.Console.WriteLine(v2.ToString());
System.Console.WriteLine("----------------");
System.Console.WriteLine(v3.ToString());

System.Console.WriteLine();
System.Console.WriteLine(v1.Distancia() + " minutos en llegar");
System.Console.WriteLine("----------------");
System.Console.WriteLine(v2.Distancia() + " minutos en llegar");
System.Console.WriteLine("----------------");
System.Console.WriteLine(v3.Distancia() + " minutos en llegar");

System.Console.WriteLine();
v1.Curva();
System.Console.WriteLine("----------------");
v2.Curva();
System.Console.WriteLine("----------------");
v3.Curva();

System.Console.WriteLine();
v1.Nitro();
System.Console.WriteLine("----------------");
v2.Nitro();
System.Console.WriteLine("----------------");
v3.Nitro();
