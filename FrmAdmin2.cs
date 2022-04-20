using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCEATCC
{
    public partial class FrmAdmin2 : Form
    {
        Clsfacultad facultad = new Clsfacultad();
        Clsreservacion reservar = new Clsreservacion();

        public string es;

        public string m;


        public FrmAdmin2()
        {
            InitializeComponent();
        }

        private void butncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cmbestado.SelectedValue.ToString() == "1")
            {
                    string liberada;

                    reservar._estadou = "LIBERADA POR ADMINISTRADOR";
                    liberada = reservar.traerestado();
                    reservar._cvestado = liberada;
                    reservar._horas = DateTime.Now.ToShortTimeString();
                    reservar._nmaquina = m;
                    string usuario = reservar.traerusuariomaquina();
                    reservar._idusuarios = usuario;
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    string HORAE = reservar.traerhorae();
                    reservar._horae = HORAE;

                if (usuario == "")
                {
                    facultad._cvestado = liberada;
                    facultad._horas= DateTime.Now.ToShortTimeString();
                    facultad._nmaquina = m;
                    facultad._fechareg= DateTime.Now.ToString("yyyy-MM-dd");
                    string HORAEN = facultad.traerhorae();
                    facultad._horae = HORAEN;
                    facultad.actualizarreservaciohoras();
                }
                if (usuario != null)
                {
                    reservar.actualizarreservaciohoras();
                }

               
                

                facultad._idusuario = "";
                facultad._cveestado = cmbestado.SelectedValue.ToString();
                facultad._nmaquina = m;
                facultad.actualizarmaquinaID();
            }

            if (cmbestado.SelectedValue.ToString() == "4")
            {
                facultad._idusuario = "";
                facultad._cveestado = cmbestado.SelectedValue.ToString();
                facultad._nmaquina = m;
                facultad.actualizarmaquinaID();
            }
            if (cmbestado.SelectedValue.ToString() == "2")
            {


                //reservar._idusuarios = y;
                facultad._nmaquina = m;
                facultad._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                facultad._horae = DateTime.Now.ToShortTimeString();
                facultad.grabarresusuario();


                facultad._idusuario = "";
                facultad._cveestado = cmbestado.SelectedValue.ToString();
                facultad._nmaquina = m;
                facultad.actualizarmaquinaID();
            }

           

            

            this.Hide();

        }

        private void FrmAdmin2_Load(object sender, EventArgs e)
        {
            facultad.cargarestmaquina(cmbestado);

            cmbestado.SelectedValue = es;

        }


    }
}
