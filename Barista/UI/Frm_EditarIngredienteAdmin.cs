using Barista.Data;
using Barista.Modelos;

namespace Barista.UI
{
    public partial class Frm_EditarIngredienteAdmin : Form
    {
        private readonly Contexto _contexto;
        private readonly int _idIngrediente;

        public Frm_EditarIngredienteAdmin(Contexto contexto, int idIngrediente)
        {
            InitializeComponent();
            _contexto = contexto;
            _idIngrediente = idIngrediente;

            Load += Frm_EditarIngredienteAdmin_Load;
        }

        private async void Frm_EditarIngredienteAdmin_Load(object? sender, EventArgs e)
        {
            try
            {
                var ing = await _contexto.Ingredientes.FindAsync(_idIngrediente);
                if (ing == null)
                {
                    MessageBox.Show("El insumo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                Txt_Nombre.Text = ing.Nombre;
                Cmb_Unidad.Text = ing.Unidad;
                Num_StockActual.Value = ing.StockActual;
                Num_StockMinimo.Value = ing.StockMinimo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del insumo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Btn_Guardar_Click(object? sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre del insumo no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ing = await _contexto.Ingredientes.FindAsync(_idIngrediente);
                if (ing == null)
                {
                    MessageBox.Show("El insumo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ing.Nombre = nombre;
                ing.Unidad = Cmb_Unidad.Text.Trim();
                ing.StockActual = Num_StockActual.Value;
                ing.StockMinimo = Num_StockMinimo.Value;

                await _contexto.SaveChangesAsync();

                MessageBox.Show($"Insumo '{ing.Nombre}' modificado exitosamente.", "Ajuste Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
