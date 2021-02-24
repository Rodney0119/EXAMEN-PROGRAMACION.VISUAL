using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES
{
    public class CLIENTE : PERSONA 
    {
        //ATRIBUTOS
        private string CATEGORIA;
        private string CODIGODEPEDIDO;
        private string CEDULAS;
        
        //PROPIEDADES
        public string CATEGORIA1 
        { 
            get => CATEGORIA; 
            set => CATEGORIA = value; 
        }
        public string CODIGODEPEDIDO1 
        { 
            get => CODIGODEPEDIDO; 
            set => CODIGODEPEDIDO = value; 
        }
        public string CEDULAS1 
        { get => CEDULAS; 
            set => CEDULAS = value; 
        }



        //PROCEDIMIENTOS, OPERACIONES O MÉTODOS
        public void GENERARCODIGODEPEDIDO()
        {
            this.CODIGODEPEDIDO1 = "" + this.APPATERNO1.Substring(0, 3);
        }
        public void GENERARLISTACEDULAS()
        {
            this.CEDULAS1 = "" + this.CEDULAS1.Substring(0, 10);
        }


    }
}
