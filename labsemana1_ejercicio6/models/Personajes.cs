using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.CodeDom;

namespace labsemana1_ejercicio6.models
{
    public class Personajes
    {
        public string Tipo = string.Empty;
        public string Nombre = string.Empty;
        public int Vida { get; set;}
        public string Poder = string.Empty;
        public int Velocidad { get; set; }
       /* public static BindingList<Personajes> jugadores = new BindingList<Personajes>();
        public void add(string tipo, string nombre,int vida, string poder, int velocidad )
        {
            jugadores.Add(new personajes(){Tipo = tipo, Nombre = nombre, Vida = vida, Poder = poder, Velocidad = velocidad});
        }*/
        public void Vidas()
        {
            int aux=0;
            do
            {
                System.Console.WriteLine("¿Desea descansar?");
                System.Console.WriteLine("Si: Y");
                System.Console.WriteLine("No: N");
                string resp = System.Console.ReadLine() ?? "y";
                if(resp=="y"||resp=="Y")
                {
                Vida++;
                aux=1;
                }
                else if (resp=="n"||resp=="N")
                {
                    aux=1;
                }
            } while (aux==0);
        }

        public void ataque()
        {
            Random r = new Random();
            int aux = r.Next(0,4);
            if(aux==0)
            {
                System.Console.WriteLine("El ataque "+this.Poder+" ha fallado");
            }
            else
            {
                System.Console.WriteLine("El ataque "+this.Poder+" ha acertado");
            }
        }

        public override string ToString()
        {
            return "Tipo: "+this.Tipo+ "\nNombre: "+ this.Nombre + "\nVida: "+this.Vida+ "\nPoder: "+ this.Poder + "\nVelocidad: "+ this.Velocidad;
        }
    }
}