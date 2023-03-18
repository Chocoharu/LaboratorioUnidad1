using System;
using labsemana1_ejercicio6.models;

Personajes p1 = new Personajes();
p1.Tipo = "Caballero";
p1.Nombre = "Lancelot";
p1.Vida = 3;
p1.Poder = "Estocada";
p1.Velocidad = 5;

Personajes p2 = new Personajes();
p2.Tipo = "Mago";
p2.Nombre = "Gandalf";
p2.Vida = 3;
p2.Poder = "Gravity";
p2.Velocidad = 3;

Personajes p3 = new Personajes();
p3.Tipo = "Bardo";
p3.Nombre = "Jaskier";
p3.Vida = 2;
p3.Poder = "Encanto";
p3.Velocidad = 4;

System.Console.WriteLine(p1.ToString());
p1.Vidas();
System.Console.WriteLine(p1.ToString());
p1.ataque();

System.Console.WriteLine("-----------------");
System.Console.WriteLine("Player 2");

System.Console.WriteLine(p2.ToString());
p2.Vidas();
System.Console.WriteLine(p2.ToString());
p2.ataque();