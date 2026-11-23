using Barista.UI;

namespace Barista
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            Load += Frm_Principal_Load;
        }

        private void Frm_Principal_Load(object? sender, EventArgs e)
        {
            Navegar(Btn_Catalogo, () => new Frm_Catalogo());
        }

        #region Navegación entre módulos (panel lateral)

        private void Navegar(Button Boton_Activo, Func<Form> Crear_Formulario)
        {
            
            if (Comprovacion_Ventana_Abierta())
            {
                return;
            }

            Hover_Boton(Boton_Activo);

            
            while (Pnl_Contenido.Controls.Count > 0)
            {
                Control control = Pnl_Contenido.Controls[0];
                Pnl_Contenido.Controls.RemoveAt(0);

                if (control is Form form)
                {
                    try
                    {
                        form.Close();
                    }
                    catch
                    {
                    }
                }

                control.Dispose();
            }

            Form Formulario = Crear_Formulario();
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;

            Pnl_Contenido.Controls.Add(Formulario);
            Formulario.Show();
        }

        private bool Comprovacion_Ventana_Abierta()
        {
            foreach (Form Formulario in Application.OpenForms)
            {

                if (Formulario != this && Formulario.TopLevel && Formulario.Visible)
                {
                    return true;
                }
            }

            return false;
        }

        private void Hover_Boton(Button Boton_Activo)
        {
            foreach (Control Control in Pnl_Sidebar.Controls)
            {
                if (Control is Button Boton && Boton != Btn_Salir)
                {
                    bool Activo = Boton == Boton_Activo;

                    Boton.BackColor = Activo
                        ? Color.FromArgb(140, 75, 45)
                        : Color.FromArgb(43, 30, 26);

                    Boton.ForeColor = Activo
                        ? Color.White
                        : Color.FromArgb(215, 200, 185);
                }
            }
        }

        #endregion

        #region Botones del panel lateral

        private void Btn_GuiaBarista_Click(object? sender, EventArgs e)
        {
            Navegar(Btn_GuiaBarista, () => new Frm_GuiaBarista());
        }

        private void Btn_Catalogo_Click(object? sender, EventArgs e)
        {
            Navegar(Btn_Catalogo, () => new Frm_Catalogo());
        }

        private void Btn_GestionRecetas_Click(object? sender, EventArgs e)
        {
            Navegar(Btn_GestionRecetas, () => new Frm_GestionRecetas());
        }

        private void Btn_Inventario_Click(object? sender, EventArgs e)
        {
            Navegar(Btn_Inventario, () => new Frm_Inventario());
        }

        private void Btn_Reportes_Click(object? sender, EventArgs e)
        {
            Navegar(Btn_Reportes, () => new Frm_Reportes());
        }

        private void Btn_Salir_Click(object? sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
