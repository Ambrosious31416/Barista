using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.UI
{
    public partial class Frm_Autorizacion : Form
    {
        private readonly Contexto _contexto;
        public Usuario? UsuarioAutorizado { get; private set; }

        public Frm_Autorizacion(Contexto contexto)
        {
            InitializeComponent();
            _contexto = contexto;
        }

        private async void Btn_Autorizar_Click(object? sender, EventArgs e)
        {
            string nombre = Txt_Usuario.Text.Trim();
            string password = Txt_Password.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = await _contexto.Usuarios
                    .FirstOrDefaultAsync(u => u.Nombre.ToLower() == nombre.ToLower());

                if (usuario == null || usuario.PasswordHash != password)
                {
                    MessageBox.Show("Credenciales incorrectas. Verifique usuario y contraseña.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Password.Clear();
                    Txt_Password.Focus();
                    return;
                }

                if (!usuario.PuedeEditarRecetas)
                {
                    MessageBox.Show($"El usuario '{usuario.Nombre}' (Rol: {usuario.Rol}) no tiene permisos para dar de alta, modificar o eliminar recetas.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioAutorizado = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar credenciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Txt_Password_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Autorizar_Click(sender, e);
            }
        }
    }
}
