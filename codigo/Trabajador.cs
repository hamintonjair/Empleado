using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado.codigo
{
    class Trabajador
    {

        //Variables
        private String nombre; 
        private double sueldo; 
        private int edad; 

        //Constructor
        //p = parametro

        public Trabajador(String nombre, double pSueldo, int pEdad)
        {
            this.nombre = nombre;
            sueldo = pSueldo;
            edad = pEdad;
        }

        //Si no me pasa el sueldo, el sueldo por defecto sera de 900000
        public Trabajador(String pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
            sueldo = 1900000;
        }

        //Metodos Getters 

        public String getNombre()
        {
            return nombre;
        }

        public double getSueldo()
        {
            return sueldo;
        }

        public int getEdad()
        {
            return edad;
        }

        //Metodos Setters 

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        public void setEdad(int pEdad)
        {
            edad = pEdad;
        }
        
        public void setSueldo(double pSueldo)
        {
            sueldo = pSueldo;
        }

        //Metodos
        public String darInfoUsuario()
        {
            return "El nombre es " + getNombre() + " Sueldo: " + sueldo + " Edad: " + edad;
        }

    }
}
