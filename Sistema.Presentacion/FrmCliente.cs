using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidades;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FrmCliente : Form
    {
        List<Cliente> RegistrosSeleccionados { get; set; }
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NCliente.Listar();
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            if(TxtBuscar.Text != "")
            {
                DgvListado.DataSource = ((List<Cliente>)DgvListado.DataSource).ToList().Where(s => s.Nombre.Contains(TxtBuscar.Text));
            }
            else
            {
                this.Listar();
            }
            
            //try
            //{
            //    DgvListado.DataSource = NCliente.Buscar(TxtBuscar.Text);
            //    LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }
        private void Formato()
        {
            DgvListado.Columns[0].Visible = ChkSeleccionar.Checked;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;            
            DgvListado.Columns[4].Width = 100;            
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].Width = 100;            
            DgvListado.Columns[7].Width = 60;
            DgvListado.Columns[8].Width = 200;            
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;

        }
        private void InicializarMantenimiento()
        {            
            
            TxtIdCte.Clear();
            TxtMedio.Clear();
            TxtCto.Clear();
            TxtNombre.Clear();
            TxtApPaterno.Clear();
            TxtApMaterno.Clear();
            TxtSexo.Clear();
            TxtEstadoCivil.Clear();
            TxtResidencia.Clear();
            TxtRetISR.Clear();
            TxtRFC.Clear();
            DateFechaNac.Value = DateTime.Now;
            TxtCURP.Clear();
            TxtTelCasa.Clear();
            TxtCelular.Clear();
            TxtTelOficina.Clear();
            TxtOtro.Clear();
            TxtNextel.Clear();
            TxtFax1.Clear();
            TxtEmail1.Clear();
            TxtEmail2.Clear();
            TxtEmail3.Clear();
            TxtWeb.Clear();
            TxtTipo.Clear();
            DateFechaAn.Value = DateTime.Now;
            TxtIdZoho.Clear();
            TxtEntidadNa.Clear();
            TxtCiudadNa.Clear();
            TxtPaisNa.Clear();
            DateFechaCreacion.Value = DateTime.Now;
            TxtCreadoPor.Clear();
            TxtNacionalidad.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();
        }
        private void InicializarListado()
        {
            TxtBuscar.Clear();
            RegistrosSeleccionados = new List<Cliente>();            
            BtnEliminar.Enabled = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.InicializarListado();
            this.Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            this.InicializarListado();
            bool Visible = ChkSeleccionar.Checked;
            DgvListado.Columns[0].Visible = Visible;            
            BtnEliminar.Visible = Visible;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnActualizar.Visible = true;
            BtnInsertar.Visible = false;
            TxtIdCte.Text = DgvListado.CurrentRow.Cells["idCte"].Value.ToString();
            TxtMedio.Text = DgvListado.CurrentRow.Cells["idMedio"].Value.ToString();
            TxtCto.Text = DgvListado.CurrentRow.Cells["idCto"].Value.ToString();
            TxtNombre.Text = DgvListado.CurrentRow.Cells["nombre"].Value.ToString();
            TxtApPaterno.Text = DgvListado.CurrentRow.Cells["apellido_paterno"].Value.ToString();
            TxtApMaterno.Text = DgvListado.CurrentRow.Cells["apellido_materno"].Value.ToString();
            TxtSexo.Text = DgvListado.CurrentRow.Cells["sexo"].Value.ToString();
            TxtEstadoCivil.Text = DgvListado.CurrentRow.Cells["edo_civil"].Value.ToString();
            TxtResidencia.Text = DgvListado.CurrentRow.Cells["residencia"].Value.ToString();
            TxtRetISR.Text = DgvListado.CurrentRow.Cells["retIsr"].Value.ToString();
            TxtRFC.Text = DgvListado.CurrentRow.Cells["rfc"].Value.ToString();
            DateFechaNac.Text = DgvListado.CurrentRow.Cells["fechaNa"].Value.ToString();
            TxtCURP.Text = DgvListado.CurrentRow.Cells["curp"].Value.ToString();
            TxtTelCasa.Text = DgvListado.CurrentRow.Cells["telCasa"].Value.ToString();
            TxtCelular.Text = DgvListado.CurrentRow.Cells["celular"].Value.ToString();
            TxtTelOficina.Text = DgvListado.CurrentRow.Cells["telOficina"].Value.ToString();
            TxtOtro.Text = DgvListado.CurrentRow.Cells["telOtro"].Value.ToString();
            TxtNextel.Text = DgvListado.CurrentRow.Cells["nextel"].Value.ToString();
            TxtFax1.Text = DgvListado.CurrentRow.Cells["fax1"].Value.ToString();
            TxtEmail1.Text = DgvListado.CurrentRow.Cells["email1"].Value.ToString();
            TxtEmail2.Text = DgvListado.CurrentRow.Cells["email2"].Value.ToString();
            TxtEmail3.Text = DgvListado.CurrentRow.Cells["email3"].Value.ToString();
            TxtWeb.Text = DgvListado.CurrentRow.Cells["web"].Value.ToString();
            TxtTipo.Text = DgvListado.CurrentRow.Cells["tipo"].Value.ToString();
            DateFechaAn.Text = DgvListado.CurrentRow.Cells["fechaAn"].Value.ToString();
            TxtIdZoho.Text = DgvListado.CurrentRow.Cells["idZoho"].Value.ToString();
            TxtEntidadNa.Text = DgvListado.CurrentRow.Cells["entidadNacimiento"].Value.ToString();
            TxtCiudadNa.Text = DgvListado.CurrentRow.Cells["ciudadNacimiento"].Value.ToString();
            TxtPaisNa.Text = DgvListado.CurrentRow.Cells["paisNacimiento"].Value.ToString();
            DateFechaCreacion.Text = DgvListado.CurrentRow.Cells["fecha_creacion"].Value.ToString();
            TxtCreadoPor.Text = DgvListado.CurrentRow.Cells["creado_por"].Value.ToString();
            TxtNacionalidad.Text = DgvListado.CurrentRow.Cells["nacionalidad"].Value.ToString();
            TabGeneral.SelectedIndex = 1;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = string.Empty;
                if (TxtMedio.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtMedio, "Ingrese IdMedio.");
                }
                if (TxtCto.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCto, "Ingrese IdCto.");
                }
                if (TxtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un Nombre.");
                }
                if (TxtEstadoCivil.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtEstadoCivil, "Ingrese estado civil.");
                }
                if (TxtRetISR.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtRetISR, "Ingrese Ret ISR.");
                }
                if (TxtRFC.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtRFC, "Ingrese RFC.");
                }                
                if (TxtCURP.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCURP, "Ingrese un CURP");
                }
                if (TxtTelCasa.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtTelCasa, "Ingrese tel de casa.");
                }
                if (TxtCelular.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCelular, "Ingrese tel celular.");
                }
                if (TxtTelOficina.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtTelOficina, "Ingrese tel de oficina.");
                }
                if (TxtFax1.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtFax1, "Ingrese un nùmero de fax.");
                }
                if (TxtEmail1.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtEmail1, "Ingrese correo electronico.");
                }
                if (TxtWeb.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtWeb, "Ingrese Web.");
                }
                if (TxtTipo.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtTipo, "Ingrese un tipo.");
                }                
                if (TxtCreadoPor.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCreadoPor, "Ingrese creado por.");
                }
                else
                {
                    Respuesta = NCliente.Insertar(Convert.ToInt32(TxtMedio.Text.Trim()),Convert.ToInt32(TxtCto.Text.Trim()),TxtNombre.Text.Trim(),TxtApPaterno.Text.Trim(),
            TxtApMaterno.Text.Trim(),TxtSexo.Text.Trim(),TxtEstadoCivil.Text.Trim(), Convert.ToChar(TxtResidencia.Text.Trim()), Convert.ToChar(TxtRetISR.Text.Trim()),TxtRFC.Text.Trim(),DateFechaNac.Value.ToString(),
            TxtCURP.Text.Trim(), TxtNacionalidad.Text.Trim(),TxtTelCasa.Text.Trim(),TxtCelular.Text.Trim(),TxtTelOficina.Text.Trim(),TxtOtro.Text.Trim(), TxtNextel.Text.Trim(), TxtFax1.Text.Trim(),
            TxtEmail1.Text.Trim(),TxtEmail2.Text.Trim(),TxtEmail3.Text.Trim(),TxtWeb.Text.Trim(),TxtTipo.Text.Trim(), DateFechaCreacion.Value, Convert.ToInt32(TxtCreadoPor.Text.Trim()),DateFechaAn.Value.ToString(),TxtIdZoho.Text.Trim(),
            TxtEntidadNa.Text.Trim(),TxtCiudadNa.Text.Trim(),TxtPaisNa.Text.Trim());
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeOK("Se ingresò de forma correcta el registro");
                        this.InicializarMantenimiento();
                        this.Listar();
                    }
                    else
                        this.MensajeError(Respuesta);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = string.Empty;
                if (TxtMedio.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtMedio, "Ingrese IdMedio.");
                }
                if (TxtCto.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCto, "Ingrese IdCto.");
                }
                if (TxtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un Nombre.");
                }
                if (TxtEstadoCivil.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtEstadoCivil, "Ingrese estado civil.");
                }
                if (TxtRetISR.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtRetISR, "Ingrese Ret ISR.");
                }
                if (TxtRFC.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtRFC, "Ingrese RFC.");
                }                
                if (TxtCURP.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCURP, "Ingrese un CURP");
                }
                if (TxtTelCasa.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtTelCasa, "Ingrese tel de casa.");
                }
                if (TxtCelular.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCelular, "Ingrese tel celular.");
                }
                if (TxtTelOficina.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtTelOficina, "Ingrese tel de oficina.");
                }
                if (TxtFax1.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtFax1, "Ingrese un nùmero de fax.");
                }
                if (TxtEmail1.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtEmail1, "Ingrese correo electronico.");
                }
                if (TxtWeb.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtWeb, "Ingrese Web.");
                }
                if (TxtTipo.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtTipo, "Ingrese un tipo.");
                }                
                if (TxtCreadoPor.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seràn requeridos");
                    ErrorIcono.SetError(TxtCreadoPor, "Ingrese creado por.");
                }
                else
                {
                    Respuesta = NCliente.Actualizar(Convert.ToInt32(TxtIdCte.Text.Trim()),Convert.ToInt32(TxtMedio.Text.Trim()), Convert.ToInt32(TxtCto.Text.Trim()), TxtNombre.Text.Trim(), TxtApPaterno.Text.Trim(),
            TxtApMaterno.Text.Trim(), TxtSexo.Text.Trim(), TxtEstadoCivil.Text.Trim(), Convert.ToChar(TxtResidencia.Text.Trim()), Convert.ToChar(TxtRetISR.Text.Trim()), TxtRFC.Text.Trim(), DateFechaNac.Value.ToString(),
            TxtCURP.Text.Trim(), TxtNacionalidad.Text.Trim(), TxtTelCasa.Text.Trim(), TxtCelular.Text.Trim(), TxtTelOficina.Text.Trim(), TxtOtro.Text.Trim(), TxtNextel.Text.Trim(), TxtFax1.Text.Trim(),
            TxtEmail1.Text.Trim(), TxtEmail2.Text.Trim(), TxtEmail3.Text.Trim(), TxtWeb.Text.Trim(), TxtTipo.Text.Trim(), DateFechaCreacion.Value, Convert.ToInt32(TxtCreadoPor.Text.Trim()), DateFechaAn.Value.ToString(), TxtIdZoho.Text.Trim(),
            TxtEntidadNa.Text.Trim(), TxtCiudadNa.Text.Trim(), TxtPaisNa.Text.Trim());
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeOK("Se actualizo de forma correcta el registro");
                        this.InicializarMantenimiento();
                        this.Listar();
                    }
                    else
                        this.MensajeError(Respuesta);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
