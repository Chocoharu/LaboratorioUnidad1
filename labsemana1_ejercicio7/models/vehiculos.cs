using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.CodeDom;

namespace labsemana1_ejercicio7.models
{
    public class Vehiculos
    {
        public string Fabricante = string.Empty;
        public string Modelo = string.Empty;
        public string Año = string.Empty;
        public double Velocidad;
        public double Maniobrabilidad;

        public override string ToString()
        {
            return "Fabricante: "+this.Fabricante+ "\nModelo: "+ this.Modelo + "\nAño: "+this.Año+ "\nVelocidad: "+ this.Velocidad + " %" + "\nManiobrabilidad: "+ this.Maniobrabilidad + " %";
        }
        public double Distancia()
        {
            double Meta = 500;
            double Tiempo = Meta/this.Velocidad;
            System.Console.WriteLine("La distancia de la pista es de 5km, el vehiculo "+ this.Modelo+ " tardaria:");
            return Math.Round(Tiempo,2);
        }
        public void Curva()
        {
            System.Console.WriteLine("En las curvas el vehiculo " + this.Modelo+ " debera de:");

            if(this.Maniobrabilidad>=60&&this.Maniobrabilidad<70)
            {
                System.Console.WriteLine("Frenar");
            }
            else if(this.Maniobrabilidad>=70&&this.Maniobrabilidad<80)
            {
                System.Console.WriteLine("Reducir la velocidad");
            }
            else if(this.Maniobrabilidad>=80)
            {
                System.Console.WriteLine("Puede mantener la velocidad");
            }
        }
        public void Nitro()
        {
            double NewSpeed = this.Velocidad*1.5;
            double NewManio = this.Maniobrabilidad-15;

            System.Console.WriteLine("Al usar nitro el vehiculo "+this.Modelo+" aumentara su velocidad a: ");
            System.Console.WriteLine(Math.Round(NewSpeed,2)+ " %");
            System.Console.WriteLine("Pero su maniobrabilida se reducira a: ");
            System.Console.WriteLine(Math.Round(NewManio,2)+ " %");
        }
    }
}