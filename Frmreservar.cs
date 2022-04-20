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
    public partial class Frmreservarm : Form
    {
        Clsfacultad facultad = new Clsfacultad();

        public Frmreservarm()
        {
            InitializeComponent();
        }

        private void Frmreservarm_Load(object sender, EventArgs e)
        {
            
            txtidmaestro.Text = "";
            cmbcarrera.Visible = true;
            lblcarrera.Visible = true;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            txtidmaestro.Enabled = false;
            cmbcarrera.Enabled = false;
            cmbgrupo.Enabled = false;
            cmbhora.Enabled = false;

            facultad.cargarcarrera(cmbcarrera);
            cmbcarrera.Text = "";

            facultad.cargarbloque(cmbhora);
            cmbhora.Text = "";

            //facultad._cc = "1";
            facultad.llenargridreservarm(dgvreservar);

            dgvreservar.Columns[0].HeaderText = "Maestro";
            dgvreservar.Columns[1].HeaderText = "Fecha";
            dgvreservar.Columns[2].HeaderText = "Grupo";
            dgvreservar.Columns[3].HeaderText = "Reservacion";
            dgvreservar.Columns[6].HeaderText = "Registro";
            dgvreservar.Columns[4].Visible = false;
            dgvreservar.Columns[5].Visible = false;
            dgvreservar.Columns[6].Visible = false;
            dgvreservar.Columns[3].Visible = false;


            txtidmaestro.Focus();
            //txtidmaestro.Text = dtmfecha.Value.ToString("yyyy-MM-dd");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Clsreservacion reservar = new Clsreservacion();
            Cursor.Current = Cursors.WaitCursor;
            reservar._estadou = "RESERVADA";
            string reservada = reservar.traerestado();
            reservar._reser = reservada;
            int contar = Convert.ToInt32(reservar.contarmaquina2());
            if (contar != 0)
            {
                string valor;
                string es;
                int c = 0;
                string valor2;
                string liberada;
                

                DataTable inf = new DataTable();
                inf = reservar.traerestmaquina2();

                for (int z = 1; z <= contar; z++)
                {
                    DataRow row = inf.Rows[c];
                    valor = Convert.ToString(row["nmaquina"]);
                    valor2 = Convert.ToString(row["idusuario"]);
                    reservar._estadou = "LIBERADA POR SISTEMA";
                    liberada = reservar.traerestado();
                    reservar._cvestado = liberada;


                    reservar._horas = DateTime.Now.ToShortTimeString();
                    reservar._nmaquina = valor;
                    reservar._idusuarios = valor2;
                    reservar._fechareg = DateTime.Now.ToString("yyyy-MM-dd");
                    string HORAE = reservar.traerhorae();
                    reservar._horae = HORAE;
                    string fechareg = reservar.traerfechareg();
                    reservar._fechareg = fechareg;
                    reservar.actualizarreservaciohoras();

                    facultad._idusuario = "";
                    reservar._estadou = "DISPONIBLE";
                    es = reservar.traerestado();
                    facultad._cveestado = es;
                    facultad._nmaquina = valor;
                    facultad.actualizarmaquinaID();

                    c = c + 1;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtidmaestro.Text = "";
            cmbcarrera.Text = "";
            cmbgrupo.Text = "";
            cmbhora.Text = "";
            dtmfecha.Text= DateTime.Now.ToShortDateString();
            cmbgrupo.Visible = false;
            lblgrupo.Visible = false;


            txtidmaestro.Enabled = true;
            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
            txtidmaestro.Enabled = true;     
            cmbhora.Enabled = true;
            cmbgrupo.Enabled = true;
            cmbcarrera.Enabled = true;
            txtidmaestro.Text = "";
            cmbgrupo.Visible = false;
            lblgrupo.Visible = false;
            cmbcarrera.Visible = true;
            lblcarrera.Visible = true;


            facultad.cargarcarrera(cmbcarrera);
            cmbcarrera.Text = "";

            facultad.cargarbloque(cmbhora);
            cmbhora.Text = "";

            toolStripButton2.Text = "Grabar";
            txtidmaestro.Focus();
        }

        private void dgvreservar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            toolStripButton2.Text = "Modificar";

            txtidmaestro.Text = dgvreservar.CurrentRow.Cells[0].Value.ToString();
            dtmfecha.Text= dgvreservar.CurrentRow.Cells[1].Value.ToString();

            cmbgrupo.Visible = true;
            lblgrupo.Visible = true;

            string grupo = dgvreservar.CurrentRow.Cells[2].Value.ToString();
            facultad._grupo = dgvreservar.CurrentRow.Cells[2].Value.ToString();
            facultad.cargargruporgrid(cmbgrupo);
            cmbgrupo.SelectedValue = grupo;

            cmbcarrera.Visible = false;
            lblcarrera.Visible = false;

            string hora = dgvreservar.CurrentRow.Cells[3].Value.ToString();
            facultad.cargarbloque(cmbhora);
            cmbhora.SelectedValue = hora;

            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            txtidmaestro.Enabled = false;
            dtmfecha.Enabled = true;
            cmbgrupo.Enabled = false;
            cmbhora.Enabled = true;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult buttton = MessageBox.Show("Esta seguro que desea elimnar la reservación: " + txtidmaestro.Text, "Eliminar Reservación", MessageBoxButtons.OKCancel);
            if (buttton == DialogResult.OK)
            {
                facultad._idmaestro = txtidmaestro.Text;
                facultad._fechares = dtmfecha.Value.ToString("yyyy-MM-dd");
                facultad._nbloque = cmbhora.SelectedValue.ToString();
                //facultad._cc = "1";


                facultad.eliminaresmaestro();
            }

            facultad.llenargridreservarm(dgvreservar);

           

            txtidmaestro.Text = "";
            cmbcarrera.Visible = true;
            lblcarrera.Visible = true;
            cmbcarrera.Text = "";
            cmbgrupo.Text = "";
            cmbhora.Text = "";
            

            toolStripButton2.Text = "Grabar";
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;

            txtidmaestro.Enabled = false;
            cmbcarrera.Enabled = false;
            cmbgrupo.Enabled = false;
            cmbhora.Enabled = false;

            cmbgrupo.Visible = false;
            lblgrupo.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            if (txtidmaestro.Text.Length != 0 && cmbhora.Text.Length != 0 && cmbgrupo.Visible==true)
            {
                try
                {
                    facultad._idmaestro = txtidmaestro.Text;
                    facultad._fechares = dtmfecha.Value.ToString("yyyy-MM-dd");
                    facultad._grupo = cmbgrupo.SelectedValue.ToString();
                    facultad._nbloque = cmbhora.SelectedValue.ToString();
                    //facultad._cc = "1";

                    facultad._estado = "RESERVADA";
                    string estado = facultad.buscarcvestadoconombre();

                    facultad._cveestado = estado;
                    //facultad._idusuariosis = "10111533";

                }
                catch (Exception)
                {
                    MessageBox.Show("LOS CAMPOS DEL FORMULARIO NO SON VALIDOS");
                }

                try
                {
                    string dup = facultad.buscaduplicadosr();

                    if (toolStripButton2.Text == "Grabar")
                    {


                        if (dup != "")
                        {
                            MessageBox.Show("La fecha y hora ya ha sido reservada.");
                            
                        }
                        else
                        {
                            facultad.grabarreservacionmaestro();
                        }
                        
                    }
                    else
                    {
                        if (dup != "")
                        {
                            MessageBox.Show("La fecha y hora ya ha sido reservada.");
                            
                        }
                        else
                        {
                            facultad.actualizarreservacionmaestro();

                            toolStripButton2.Text = "Grabar";
                            toolStripButton2.Enabled = false;
                            toolStripButton3.Enabled = false;
                            toolStripButton4.Enabled = false;

                            txtidmaestro.Enabled = false;
                            cmbcarrera.Enabled = false;
                            cmbgrupo.Enabled = false;
                            cmbhora.Enabled = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("LA RESERVACIÓN YA SE ENCUENTRA O NO ES VALIDA");
                }

                facultad.llenargridreservarm(dgvreservar);
                txtidmaestro.Text = "";
                cmbhora.Text = "";
                cmbgrupo.Text = "";
                cmbcarrera.Text = "";
                lblgrupo.Visible = false;
                cmbgrupo.Visible = false;

                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                txtidmaestro.Enabled = false;
                cmbcarrera.Enabled = false;
                cmbgrupo.Enabled = false;
                cmbhora.Enabled = false;
            }
            else
            {
                MessageBox.Show("ESCRIBA DATOS EN LOS CAMPOS");
            }
        }

        private void cmbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*lblgrupo.Visible = true;
            cmbgrupo.Visible = true;

            facultad._cvecarrera= cmbcarrera.SelectedValue.ToString();
            facultad.cargargrupo(cmbgrupo);
            cmbgrupo.Text = "";*/

        }

        private void cmbcarrera_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbcarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblgrupo.Visible = true;
            cmbgrupo.Visible = true;

            facultad._cvecarrera = cmbcarrera.SelectedValue.ToString();
            facultad.cargargrupo(cmbgrupo);
            cmbgrupo.Text = "";
        }
    }
}
