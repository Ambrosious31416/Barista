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
            // Módulo inicial al abrir el programa
            Navegar(Btn_Catalogo, () => new Frm_Catalogo());
        }

        #region Navegación entre módulos (panel lateral)

        private void Navegar(Button botonActivo, Func<Form> crearFormulario)
        {
            // No se permite cambiar de módulo mientras haya un diálogo abierto
            // (autorización, edición de recetas, ingreso de insumos, etc.)
            if (HayDialogoModalAbierto())
            {
                return;
            }

            ResaltarBoton(botonActivo);

            // Se retira el módulo anterior: al volver a entrar se crea de nuevo
            // para que muestre datos frescos de la base de datos.
            while (Pnl_Contenido.Controls.Count > 0)
            {
                Control control = Pnl_Contenido.Controls[0];
                Pnl_Contenido.Controls.RemoveAt(0);

                if (control is Form form)
                {
                    // Dispara FormClosed y libera el Contexto de Entity Framework
                    try
                    {
                        form.Close();
                    }
                    catch
                    {
                        // Si Close no está disponible para el formulario embebido,
                        // el Dispose de abajo se encarga de liberarlo.
                    }
                }

                control.Dispose();
            }

            Form formulario = crearFormulario();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Pnl_Contenido.Controls.Add(formulario);
            formulario.Show();
        }

        private bool HayDialogoModalAbierto()
        {
            foreach (Form form in Application.OpenForms)
            {
                // Los módulos embebidos no son de nivel superior (TopLevel = false);
                // los diálogos como Frm_Autorizacion o Frm_EditarReceta sí lo son.
                if (form != this && form.TopLevel && form.Visible)
                {
                    return true;
                }
            }

            return false;
        }

        private void ResaltarBoton(Button botonActivo)
        {
            foreach (Control control in Pnl_Sidebar.Controls)
            {
                if (control is Button boton && boton != Btn_Salir)
                {
                    bool activa = boton == botonActivo;

                    boton.BackColor = activa
                        ? Color.FromArgb(140, 75, 45)
                        : Color.FromArgb(43, 30, 26);

                    boton.ForeColor = activa
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

        private void Btn_Salir_Click(object? sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
