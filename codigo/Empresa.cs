using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado.codigo
{
    class Empresa
    {
        private String nombreEmpresa;
        private String direccion;
        private Trabajador trabajadorUno;
        private Trabajador trabajadorDos;

        //CONSTRUCTOR
        public Empresa(String pNombreEmpresa, String pDireccion, Trabajador pTrabajadorUno, Trabajador pTrabajadorDos)
        {
            nombreEmpresa = pNombreEmpresa;
            direccion = pDireccion;
            trabajadorUno = pTrabajadorUno;
            trabajadorDos = pTrabajadorDos;
        }

        //getters
        public String getNombreEmpresa()
        {
            return nombreEmpresa;
        }
        public String getDireccion()
        {
            return direccion;
        }

        public Trabajador getTrabajadorUno()
        {
            return trabajadorUno;
        }

        public Trabajador getTrabajadorDos()
        {
            return trabajadorDos;
        }

        //metodos
        //public String infoEmpresa()
        //{
        //    return ;
        //}

        //public double mayorSueldo()
        //{

        //}

        public String darMasViejo()
        {
            //variable temporal
            String viejo = "";

            if (trabajadorUno.getEdad() > trabajadorDos.getEdad())
            {
                viejo = trabajadorUno.darInfoUsuario();
            }
            else if (trabajadorUno.getEdad() < trabajadorDos.getEdad())
            {
                viejo = trabajadorDos.darInfoUsuario();
            }
            else
            {
                viejo = "Tienen la misma edad!";
            }

            return viejo;
        }
    }
}
