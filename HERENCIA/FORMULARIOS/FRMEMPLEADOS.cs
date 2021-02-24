using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class FRMEMPLEADOS : Form
    {
        public FRMEMPLEADOS()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLASES.EMPLEADO EMPLEADO1 = new CLASES.EMPLEADO();
            EMPLEADO1.CEDULA1 = txtCedula.Text;
            EMPLEADO1.GENERARLISTACEDULA();
            txtCedula.Text = EMPLEADO1.CEDULA1;




            EMPLEADO1.APPATERNO1 = txtApPaterno.Text;
            EMPLEADO1.APMATERNO1 = txtApMaterno.Text;
            EMPLEADO1.NOMBRES1 = txtNombres.Text;
            EMPLEADO1.SEXO1 = cboSexo.Text;
            EMPLEADO1.TIPO1 = cmbTipo.Text;
            EMPLEADO1.TIPOCONTRATO1 = cboTipoContrato.Text;
            EMPLEADO1.CALCULARSUELDO(1250);
            DGVEMPLEADOS.Rows.Insert(0, EMPLEADO1.APPATERNO1, EMPLEADO1.APMATERNO1,EMPLEADO1.NOMBRES1, EMPLEADO1.SEXO1,EMPLEADO1.TIPO1, EMPLEADO1.TIPOCONTRATO1, EMPLEADO1.SUELDO1, EMPLEADO1.CEDULA1);
            
        }
    }
}
