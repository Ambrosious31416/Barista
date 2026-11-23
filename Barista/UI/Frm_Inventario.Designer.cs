namespace Barista.UI
{
    partial class Frm_Inventario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvCellStyle = new DataGridViewCellStyle();

            Pnl_Header = new Panel();
            Lbl_InsumosBajos = new Label();
            Lbl_InsumosOptimos = new Label();
            Lbl_TotalInsumos = new Label();
            Lbl_Subtitulo = new Label();
            Lbl_Titulo = new Label();

            Pnl_Toolbar = new Panel();
            Btn_NuevoInsumo = new Button();
            Btn_RegistrarEntrada = new Button();
            Btn_ModificarInsumo = new Button();
            Btn_EliminarInsumo = new Button();
            Lbl_Filtro = new Label();
            Cmb_FiltroStock = new ComboBox();
            Txt_Buscar = new TextBox();
            Lbl_Buscar = new Label();

            Pnl_Content = new Panel();
            Dgv_Inventario = new DataGridView();
            Col_IdIngrediente = new DataGridViewTextBoxColumn();
            Col_Nombre = new DataGridViewTextBoxColumn();
            Col_Unidad = new DataGridViewTextBoxColumn();
            Col_StockActual = new DataGridViewTextBoxColumn();
            Col_StockMinimo = new DataGridViewTextBoxColumn();
            Col_Estado = new DataGridViewTextBoxColumn();

            Pnl_Header.SuspendLayout();
            Pnl_Toolbar.SuspendLayout();
            Pnl_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Inventario).BeginInit();
            SuspendLayout();

            // 
            // Pnl_Header
            // 
            Pnl_Header.BackColor = Color.FromArgb(43, 30, 26);
            Pnl_Header.Controls.Add(Lbl_InsumosBajos);
            Pnl_Header.Controls.Add(Lbl_InsumosOptimos);
            Pnl_Header.Controls.Add(Lbl_TotalInsumos);
            Pnl_Header.Controls.Add(Lbl_Subtitulo);
            Pnl_Header.Controls.Add(Lbl_Titulo);
            Pnl_Header.Dock = DockStyle.Top;
            Pnl_Header.Location = new Point(0, 0);
            Pnl_Header.Name = "Pnl_Header";
            Pnl_Header.Size = new Size(1060, 80);
            Pnl_Header.TabIndex = 0;

            // 
            // Lbl_InsumosBajos
            // 
            Lbl_InsumosBajos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_InsumosBajos.BackColor = Color.FromArgb(198, 40, 40);
            Lbl_InsumosBajos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_InsumosBajos.ForeColor = Color.White;
            Lbl_InsumosBajos.Location = new Point(885, 25);
            Lbl_InsumosBajos.Name = "Lbl_InsumosBajos";
            Lbl_InsumosBajos.Size = new Size(150, 32);
            Lbl_InsumosBajos.TabIndex = 4;
            Lbl_InsumosBajos.Text = "⚠️ Stock Bajo: 0";
            Lbl_InsumosBajos.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // Lbl_InsumosOptimos
            // 
            Lbl_InsumosOptimos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_InsumosOptimos.BackColor = Color.FromArgb(46, 125, 50);
            Lbl_InsumosOptimos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_InsumosOptimos.ForeColor = Color.White;
            Lbl_InsumosOptimos.Location = new Point(740, 25);
            Lbl_InsumosOptimos.Name = "Lbl_InsumosOptimos";
            Lbl_InsumosOptimos.Size = new Size(135, 32);
            Lbl_InsumosOptimos.TabIndex = 3;
            Lbl_InsumosOptimos.Text = "✅ Óptimos: 0";
            Lbl_InsumosOptimos.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // Lbl_TotalInsumos
            // 
            Lbl_TotalInsumos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_TotalInsumos.BackColor = Color.FromArgb(70, 55, 50);
            Lbl_TotalInsumos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_TotalInsumos.ForeColor = Color.White;
            Lbl_TotalInsumos.Location = new Point(605, 25);
            Lbl_TotalInsumos.Name = "Lbl_TotalInsumos";
            Lbl_TotalInsumos.Size = new Size(125, 32);
            Lbl_TotalInsumos.TabIndex = 2;
            Lbl_TotalInsumos.Text = "📦 Total: 0";
            Lbl_TotalInsumos.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(22, 45);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(480, 15);
            Lbl_Subtitulo.Text = "Control de existencias en almacén. Registro de entradas de insumos y alertas de reabastecimiento.";

            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(20, 12);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(335, 28);
            Lbl_Titulo.Text = "📦 Control de Inventario y Almacén";

            // 
            // Pnl_Toolbar
            // 
            Pnl_Toolbar.BackColor = Color.FromArgb(240, 238, 235);
            Pnl_Toolbar.Controls.Add(Lbl_Filtro);
            Pnl_Toolbar.Controls.Add(Cmb_FiltroStock);
            Pnl_Toolbar.Controls.Add(Lbl_Buscar);
            Pnl_Toolbar.Controls.Add(Txt_Buscar);
            Pnl_Toolbar.Controls.Add(Btn_EliminarInsumo);
            Pnl_Toolbar.Controls.Add(Btn_ModificarInsumo);
            Pnl_Toolbar.Controls.Add(Btn_RegistrarEntrada);
            Pnl_Toolbar.Controls.Add(Btn_NuevoInsumo);
            Pnl_Toolbar.Dock = DockStyle.Top;
            Pnl_Toolbar.Location = new Point(0, 80);
            Pnl_Toolbar.Name = "Pnl_Toolbar";
            Pnl_Toolbar.Padding = new Padding(12);
            Pnl_Toolbar.Size = new Size(1060, 65);
            Pnl_Toolbar.TabIndex = 1;

            // 
            // Btn_NuevoInsumo
            // 
            Btn_NuevoInsumo.BackColor = Color.FromArgb(46, 125, 50);
            Btn_NuevoInsumo.Cursor = Cursors.Hand;
            Btn_NuevoInsumo.FlatAppearance.BorderSize = 0;
            Btn_NuevoInsumo.FlatStyle = FlatStyle.Flat;
            Btn_NuevoInsumo.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            Btn_NuevoInsumo.ForeColor = Color.White;
            Btn_NuevoInsumo.Location = new Point(12, 14);
            Btn_NuevoInsumo.Name = "Btn_NuevoInsumo";
            Btn_NuevoInsumo.Size = new Size(140, 36);
            Btn_NuevoInsumo.TabIndex = 0;
            Btn_NuevoInsumo.Text = "➕ Nuevo Insumo";
            Btn_NuevoInsumo.UseVisualStyleBackColor = false;
            Btn_NuevoInsumo.Click += Btn_NuevoInsumo_Click;

            // 
            // Btn_RegistrarEntrada
            // 
            Btn_RegistrarEntrada.BackColor = Color.FromArgb(30, 100, 160);
            Btn_RegistrarEntrada.Cursor = Cursors.Hand;
            Btn_RegistrarEntrada.FlatAppearance.BorderSize = 0;
            Btn_RegistrarEntrada.FlatStyle = FlatStyle.Flat;
            Btn_RegistrarEntrada.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            Btn_RegistrarEntrada.ForeColor = Color.White;
            Btn_RegistrarEntrada.Location = new Point(160, 14);
            Btn_RegistrarEntrada.Name = "Btn_RegistrarEntrada";
            Btn_RegistrarEntrada.Size = new Size(150, 36);
            Btn_RegistrarEntrada.TabIndex = 1;
            Btn_RegistrarEntrada.Text = "📥 Registrar Entrada";
            Btn_RegistrarEntrada.UseVisualStyleBackColor = false;
            Btn_RegistrarEntrada.Click += Btn_RegistrarEntrada_Click;

            // 
            // Btn_ModificarInsumo
            // 
            Btn_ModificarInsumo.BackColor = Color.FromArgb(140, 75, 45);
            Btn_ModificarInsumo.Cursor = Cursors.Hand;
            Btn_ModificarInsumo.FlatAppearance.BorderSize = 0;
            Btn_ModificarInsumo.FlatStyle = FlatStyle.Flat;
            Btn_ModificarInsumo.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            Btn_ModificarInsumo.ForeColor = Color.White;
            Btn_ModificarInsumo.Location = new Point(318, 14);
            Btn_ModificarInsumo.Name = "Btn_ModificarInsumo";
            Btn_ModificarInsumo.Size = new Size(150, 36);
            Btn_ModificarInsumo.TabIndex = 2;
            Btn_ModificarInsumo.Text = "✏️ Ajustar Cant. (Admin)";
            Btn_ModificarInsumo.UseVisualStyleBackColor = false;
            Btn_ModificarInsumo.Click += Btn_ModificarInsumo_Click;

            // 
            // Btn_EliminarInsumo
            // 
            Btn_EliminarInsumo.BackColor = Color.FromArgb(198, 40, 40);
            Btn_EliminarInsumo.Cursor = Cursors.Hand;
            Btn_EliminarInsumo.FlatAppearance.BorderSize = 0;
            Btn_EliminarInsumo.FlatStyle = FlatStyle.Flat;
            Btn_EliminarInsumo.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            Btn_EliminarInsumo.ForeColor = Color.White;
            Btn_EliminarInsumo.Location = new Point(476, 14);
            Btn_EliminarInsumo.Name = "Btn_EliminarInsumo";
            Btn_EliminarInsumo.Size = new Size(130, 36);
            Btn_EliminarInsumo.TabIndex = 3;
            Btn_EliminarInsumo.Text = "🗑️ Eliminar (Admin)";
            Btn_EliminarInsumo.UseVisualStyleBackColor = false;
            Btn_EliminarInsumo.Click += Btn_EliminarInsumo_Click;

            // 
            // Lbl_Filtro
            // 
            Lbl_Filtro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Filtro.AutoSize = true;
            Lbl_Filtro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Filtro.Location = new Point(620, 24);
            Lbl_Filtro.Name = "Lbl_Filtro";
            Lbl_Filtro.Size = new Size(47, 15);
            Lbl_Filtro.TabIndex = 4;
            Lbl_Filtro.Text = "Estado:";

            // 
            // Cmb_FiltroStock
            // 
            Cmb_FiltroStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cmb_FiltroStock.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_FiltroStock.Font = new Font("Segoe UI", 9.5F);
            Cmb_FiltroStock.FormattingEnabled = true;
            Cmb_FiltroStock.Items.AddRange(new object[] { "Todos los Insumos", "⚠️ Solo con Stock Bajo", "✅ Solo con Stock Óptimo" });
            Cmb_FiltroStock.Location = new Point(670, 20);
            Cmb_FiltroStock.Name = "Cmb_FiltroStock";
            Cmb_FiltroStock.Size = new Size(175, 24);
            Cmb_FiltroStock.TabIndex = 5;
            Cmb_FiltroStock.SelectedIndexChanged += Cmb_FiltroStock_SelectedIndexChanged;

            // 
            // Lbl_Buscar
            // 
            Lbl_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Buscar.AutoSize = true;
            Lbl_Buscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Buscar.Location = new Point(855, 24);
            Lbl_Buscar.Name = "Lbl_Buscar";
            Lbl_Buscar.Size = new Size(45, 15);
            Lbl_Buscar.TabIndex = 6;
            Lbl_Buscar.Text = "Buscar:";

            // 
            // Txt_Buscar
            // 
            Txt_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Txt_Buscar.Font = new Font("Segoe UI", 9.5F);
            Txt_Buscar.Location = new Point(905, 20);
            Txt_Buscar.Name = "Txt_Buscar";
            Txt_Buscar.PlaceholderText = "Nombre...";
            Txt_Buscar.Size = new Size(140, 24);
            Txt_Buscar.TabIndex = 7;
            Txt_Buscar.TextChanged += Txt_Buscar_TextChanged;

            // 
            // Pnl_Content
            // 
            Pnl_Content.Controls.Add(Dgv_Inventario);
            Pnl_Content.Dock = DockStyle.Fill;
            Pnl_Content.Location = new Point(0, 145);
            Pnl_Content.Name = "Pnl_Content";
            Pnl_Content.Padding = new Padding(15);
            Pnl_Content.Size = new Size(1060, 475);
            Pnl_Content.TabIndex = 2;

            // 
            // Dgv_Inventario
            // 
            Dgv_Inventario.AllowUserToAddRows = false;
            Dgv_Inventario.AllowUserToDeleteRows = false;
            Dgv_Inventario.AllowUserToResizeRows = false;
            Dgv_Inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Inventario.BackgroundColor = Color.White;
            Dgv_Inventario.BorderStyle = BorderStyle.None;
            dgvHeaderStyle.BackColor = Color.FromArgb(240, 235, 230);
            dgvHeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dgvHeaderStyle.ForeColor = Color.FromArgb(43, 30, 26);
            Dgv_Inventario.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            Dgv_Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Inventario.Columns.AddRange(new DataGridViewColumn[] {
                Col_IdIngrediente,
                Col_Nombre,
                Col_Unidad,
                Col_StockActual,
                Col_StockMinimo,
                Col_Estado
            });
            dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = Color.White;
            dgvCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvCellStyle.ForeColor = Color.FromArgb(43, 30, 26);
            dgvCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 245);
            dgvCellStyle.SelectionForeColor = Color.Black;
            Dgv_Inventario.DefaultCellStyle = dgvCellStyle;
            Dgv_Inventario.Dock = DockStyle.Fill;
            Dgv_Inventario.EnableHeadersVisualStyles = false;
            Dgv_Inventario.Location = new Point(15, 15);
            Dgv_Inventario.MultiSelect = false;
            Dgv_Inventario.Name = "Dgv_Inventario";
            Dgv_Inventario.ReadOnly = true;
            Dgv_Inventario.RowHeadersVisible = false;
            Dgv_Inventario.RowTemplate.Height = 32;
            Dgv_Inventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Inventario.Size = new Size(1030, 445);
            Dgv_Inventario.TabIndex = 0;
            Dgv_Inventario.CellFormatting += Dgv_Inventario_CellFormatting;

            // 
            // Col_IdIngrediente
            // 
            Col_IdIngrediente.HeaderText = "ID";
            Col_IdIngrediente.Name = "Col_IdIngrediente";
            Col_IdIngrediente.ReadOnly = true;
            Col_IdIngrediente.FillWeight = 40F;

            // 
            // Col_Nombre
            // 
            Col_Nombre.HeaderText = "Insumo / Ingrediente";
            Col_Nombre.Name = "Col_Nombre";
            Col_Nombre.ReadOnly = true;
            Col_Nombre.FillWeight = 160F;

            // 
            // Col_Unidad
            // 
            Col_Unidad.HeaderText = "Unidad";
            Col_Unidad.Name = "Col_Unidad";
            Col_Unidad.ReadOnly = true;
            Col_Unidad.FillWeight = 50F;

            // 
            // Col_StockActual
            // 
            Col_StockActual.HeaderText = "Stock en Almacén";
            Col_StockActual.Name = "Col_StockActual";
            Col_StockActual.ReadOnly = true;
            Col_StockActual.FillWeight = 90F;

            // 
            // Col_StockMinimo
            // 
            Col_StockMinimo.HeaderText = "Stock Mínimo";
            Col_StockMinimo.Name = "Col_StockMinimo";
            Col_StockMinimo.ReadOnly = true;
            Col_StockMinimo.FillWeight = 80F;

            // 
            // Col_Estado
            // 
            Col_Estado.HeaderText = "Semáforo de Existencia";
            Col_Estado.Name = "Col_Estado";
            Col_Estado.ReadOnly = true;
            Col_Estado.FillWeight = 90F;

            // 
            // Frm_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 244);
            ClientSize = new Size(1060, 620);
            Controls.Add(Pnl_Content);
            Controls.Add(Pnl_Toolbar);
            Controls.Add(Pnl_Header);
            MinimumSize = new Size(950, 500);
            Name = "Frm_Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Inventario - Almacén";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Toolbar.ResumeLayout(false);
            Pnl_Toolbar.PerformLayout();
            Pnl_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Inventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Header;
        private Label Lbl_Subtitulo;
        private Label Lbl_Titulo;
        private Label Lbl_TotalInsumos;
        private Label Lbl_InsumosOptimos;
        private Label Lbl_InsumosBajos;
        private Panel Pnl_Toolbar;
        private Button Btn_NuevoInsumo;
        private Button Btn_RegistrarEntrada;
        private Button Btn_ModificarInsumo;
        private Button Btn_EliminarInsumo;
        private Label Lbl_Filtro;
        private ComboBox Cmb_FiltroStock;
        private Label Lbl_Buscar;
        private TextBox Txt_Buscar;
        private Panel Pnl_Content;
        private DataGridView Dgv_Inventario;
        private DataGridViewTextBoxColumn Col_IdIngrediente;
        private DataGridViewTextBoxColumn Col_Nombre;
        private DataGridViewTextBoxColumn Col_Unidad;
        private DataGridViewTextBoxColumn Col_StockActual;
        private DataGridViewTextBoxColumn Col_StockMinimo;
        private DataGridViewTextBoxColumn Col_Estado;
    }
}
