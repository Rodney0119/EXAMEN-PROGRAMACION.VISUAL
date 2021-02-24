using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES
{
    public class EMPLEADO : PERSONA
    {
        //ATRIBUTOS
        private string TIPO;
        private string TIPOCONTRATO;
        private Double SUELDO;
        private string CEDULA;
        //PROPIEDADES

        public string TIPOCONTRATO1
        {
            get => TIPOCONTRATO;
            set => TIPOCONTRATO = value;
        }
        public double SUELDO1
        {
            get => SUELDO;
            set => SUELDO = value;
        }
        public string CEDULA1
        { get => CEDULA;
            set => CEDULA = value;
        }
        public string TIPO1
        {
            get => TIPO;
            set => TIPO = value;
        }




        //PROCEDIMIENTOS, OPERACIONES O MÉTODOS

        public void CALCULARSUELDO(double SUELDOBASE)
        
        {
            if (this.TIPO1 == "GERENTE")
            {
                if(this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 1500;

                }

            }
            else if(this.TIPO1 == "VENDEDOR")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASE + 500;

                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = SUELDOBASE + 1500;

                }

            }
            if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 =  SUELDOBASE + 1500;
                }
            
            else
            {
                this.SUELDO1 = 0;
            }
        }
        public void GENERARLISTACEDULA()
        {
            this.CEDULA1 = "" + this.CEDULA1.Substring(0, 10);
        }


    }
}
