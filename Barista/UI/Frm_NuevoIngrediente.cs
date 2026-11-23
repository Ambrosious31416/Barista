using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.UI
{
    public partial class Frm_NuevoIngrediente : Form
    {
        private readonly Contexto _contexto;

        public Frm_NuevoIngrediente(Contexto contexto)
        {
            InitializeComponent();
            _contexto = contexto;
            Cmb_Unidad.SelectedIndex = 0;
        }

        private async void Btn_Guardar_Click(object? sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor ingresa el nombre del insumo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Nombre.Focus();
                return;
            }

            string unidadSeleccionada = Cmb_Unidad.Text.Split(' ')[0]; // ej. "g", "ml"

            try
            {
                bool existe = await _contexto.Ingredientes.AnyAsync(i => i.Nombre.ToLower() == nombre.ToLower());
                if (existe)
                {
                    MessageBox.Show($"Ya existe un insumo registrado con el nombre '{nombre}'.", "Insumo Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Nombre.Focus();
                    return;
                }

                // Inicia con stock en 0 tal como se solicitó
                var nuevo = new Ingrediente
                {
                    Nombre = nombre,
                    Unidad = unidadSeleccionada,
                    StockActual = 0m,
                    StockMinimo = Num_StockMinimo.Value
                };

                _contexto.Ingredientes.Add(nuevo);
                await _contexto.SaveChangesAsync();

                MessageBox.Show($"Insumo '{nombre}' registrado exitosamente con stock inicial en 0 {unidadSeleccionada}.\n\nYa puedes registrar entradas de este producto cuando llegue la mercancía.", "Insumo Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el insumo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
