namespace Barista.UI
{
    partial class Frm_GestionRecetas
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
            Lbl_Subtitulo = new Label();
            Lbl_Titulo = new Label();

            Pnl_Toolbar = new Panel();
            Btn_NuevaReceta = new Button();
            Btn_EditarReceta = new Button();
            Btn_EliminarReceta = new Button();
            Txt_Buscar = new TextBox();
            Lbl_Buscar = new Label();

            Pnl_Content = new Panel();
            Dgv_Recetas = new DataGridView();
            Col_IdReceta = new DataGridViewTextBoxColumn();
            Col_Bebida = new DataGridViewTextBoxColumn();
            Col_Categoria = new DataGridViewTextBoxColumn();
            Col_Tamano = new DataGridViewTextBoxColumn();
            Col_CantIngredientes = new DataGridViewTextBoxColumn();
            Col_CantPasos = new DataGridViewTextBoxColumn();

            Pnl_Header.SuspendLayout();
            Pnl_Toolbar.SuspendLayout();
            Pnl_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Recetas).BeginInit();
            SuspendLayout();

            // 
            // Pnl_Header
            // 
            Pnl_Header.BackColor = Color.FromArgb(43, 30, 26);
            Pnl_Header.Controls.Add(Lbl_Subtitulo);
            Pnl_Header.Controls.Add(Lbl_Titulo);
            Pnl_Header.Dock = DockStyle.Top;
            Pnl_Header.Location = new Point(0, 0);
            Pnl_Header.Name = "Pnl_Header";
            Pnl_Header.Size = new Size(1000, 75);
            Pnl_Header.TabIndex = 0;

            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(22, 45);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(540, 15);
            Lbl_Subtitulo.Text = "Consulta el recetario general. Se requieren permisos de encargado/administrador para agregar o eliminar.";

            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(20, 12);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(325, 28);
            Lbl_Titulo.Text = "🛠️ Gestión de Recetas de Barista";

            // 
            // Pnl_Toolbar
            // 
            Pnl_Toolbar.BackColor = Color.FromArgb(240, 238, 235);
            Pnl_Toolbar.Controls.Add(Lbl_Buscar);
            Pnl_Toolbar.Controls.Add(Txt_Buscar);
            Pnl_Toolbar.Controls.Add(Btn_EliminarReceta);
            Pnl_Toolbar.Controls.Add(Btn_EditarReceta);
            Pnl_Toolbar.Controls.Add(Btn_NuevaReceta);
            Pnl_Toolbar.Dock = DockStyle.Top;
            Pnl_Toolbar.Location = new Point(0, 75);
            Pnl_Toolbar.Name = "Pnl_Toolbar";
            Pnl_Toolbar.Padding = new Padding(15);
            Pnl_Toolbar.Size = new Size(1000, 60);
            Pnl_Toolbar.TabIndex = 1;

            // 
            // Btn_NuevaReceta
            // 
            Btn_NuevaReceta.BackColor = Color.FromArgb(46, 125, 50);
            Btn_NuevaReceta.Cursor = Cursors.Hand;
            Btn_NuevaReceta.FlatAppearance.BorderSize = 0;
            Btn_NuevaReceta.FlatStyle = FlatStyle.Flat;
            Btn_NuevaReceta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Btn_NuevaReceta.ForeColor = Color.White;
            Btn_NuevaReceta.Location = new Point(15, 12);
            Btn_NuevaReceta.Name = "Btn_NuevaReceta";
            Btn_NuevaReceta.Size = new Size(150, 36);
            Btn_NuevaReceta.TabIndex = 0;
            Btn_NuevaReceta.Text = "➕ Nueva Receta";
            Btn_NuevaReceta.UseVisualStyleBackColor = false;
            Btn_NuevaReceta.Click += Btn_NuevaReceta_Click;

            // 
            // Btn_EditarReceta
            // 
            Btn_EditarReceta.BackColor = Color.FromArgb(140, 75, 45);
            Btn_EditarReceta.Cursor = Cursors.Hand;
            Btn_EditarReceta.FlatAppearance.BorderSize = 0;
            Btn_EditarReceta.FlatStyle = FlatStyle.Flat;
            Btn_EditarReceta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Btn_EditarReceta.ForeColor = Color.White;
            Btn_EditarReceta.Location = new Point(175, 12);
            Btn_EditarReceta.Name = "Btn_EditarReceta";
            Btn_EditarReceta.Size = new Size(150, 36);
            Btn_EditarReceta.TabIndex = 1;
            Btn_EditarReceta.Text = "✏️ Modificar Receta";
            Btn_EditarReceta.UseVisualStyleBackColor = false;
            Btn_EditarReceta.Click += Btn_EditarReceta_Click;

            // 
            // Btn_EliminarReceta
            // 
            Btn_EliminarReceta.BackColor = Color.FromArgb(198, 40, 40);
            Btn_EliminarReceta.Cursor = Cursors.Hand;
            Btn_EliminarReceta.FlatAppearance.BorderSize = 0;
            Btn_EliminarReceta.FlatStyle = FlatStyle.Flat;
            Btn_EliminarReceta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Btn_EliminarReceta.ForeColor = Color.White;
            Btn_EliminarReceta.Location = new Point(335, 12);
            Btn_EliminarReceta.Name = "Btn_EliminarReceta";
            Btn_EliminarReceta.Size = new Size(150, 36);
            Btn_EliminarReceta.TabIndex = 2;
            Btn_EliminarReceta.Text = "🗑️ Eliminar Receta";
            Btn_EliminarReceta.UseVisualStyleBackColor = false;
            Btn_EliminarReceta.Click += Btn_EliminarReceta_Click;

            // 
            // Txt_Buscar
            // 
            Txt_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Txt_Buscar.Font = new Font("Segoe UI", 10F);
            Txt_Buscar.Location = new Point(720, 18);
            Txt_Buscar.Name = "Txt_Buscar";
            Txt_Buscar.PlaceholderText = "Filtrar por bebida o categoría...";
            Txt_Buscar.Size = new Size(265, 25);
            Txt_Buscar.TabIndex = 4;
            Txt_Buscar.TextChanged += Txt_Buscar_TextChanged;

            // 
            // Lbl_Buscar
            // 
            Lbl_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Buscar.AutoSize = true;
            Lbl_Buscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Buscar.Location = new Point(660, 23);
            Lbl_Buscar.Name = "Lbl_Buscar";
            Lbl_Buscar.Size = new Size(54, 15);
            Lbl_Buscar.TabIndex = 3;
            Lbl_Buscar.Text = "🔍 Buscar:";

            // 
            // Pnl_Content
            // 
            Pnl_Content.Controls.Add(Dgv_Recetas);
            Pnl_Content.Dock = DockStyle.Fill;
            Pnl_Content.Location = new Point(0, 135);
            Pnl_Content.Name = "Pnl_Content";
            Pnl_Content.Padding = new Padding(15);
            Pnl_Content.Size = new Size(1000, 485);
            Pnl_Content.TabIndex = 2;

            // 
            // Dgv_Recetas
            // 
            Dgv_Recetas.AllowUserToAddRows = false;
            Dgv_Recetas.AllowUserToDeleteRows = false;
            Dgv_Recetas.AllowUserToResizeRows = false;
            Dgv_Recetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Recetas.BackgroundColor = Color.White;
            Dgv_Recetas.BorderStyle = BorderStyle.None;
            dgvHeaderStyle.BackColor = Color.FromArgb(240, 235, 230);
            dgvHeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dgvHeaderStyle.ForeColor = Color.FromArgb(43, 30, 26);
            Dgv_Recetas.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            Dgv_Recetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Recetas.Columns.AddRange(new DataGridViewColumn[] {
                Col_IdReceta,
                Col_Bebida,
                Col_Categoria,
                Col_Tamano,
                Col_CantIngredientes,
                Col_CantPasos
            });
            dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = Color.White;
            dgvCellStyle.Font = new Font("Segoe UI", 9F);
            dgvCellStyle.ForeColor = Color.FromArgb(43, 30, 26);
            dgvCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 245);
            dgvCellStyle.SelectionForeColor = Color.Black;
            Dgv_Recetas.DefaultCellStyle = dgvCellStyle;
            Dgv_Recetas.Dock = DockStyle.Fill;
            Dgv_Recetas.EnableHeadersVisualStyles = false;
            Dgv_Recetas.Location = new Point(15, 15);
            Dgv_Recetas.MultiSelect = false;
            Dgv_Recetas.Name = "Dgv_Recetas";
            Dgv_Recetas.ReadOnly = true;
            Dgv_Recetas.RowHeadersVisible = false;
            Dgv_Recetas.RowTemplate.Height = 32;
            Dgv_Recetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Recetas.Size = new Size(970, 455);
            Dgv_Recetas.TabIndex = 0;

            // 
            // Col_IdReceta
            // 
            Col_IdReceta.HeaderText = "ID Receta";
            Col_IdReceta.Name = "Col_IdReceta";
            Col_IdReceta.ReadOnly = true;
            Col_IdReceta.FillWeight = 40F;

            // 
            // Col_Bebida
            // 
            Col_Bebida.HeaderText = "Bebida";
            Col_Bebida.Name = "Col_Bebida";
            Col_Bebida.ReadOnly = true;
            Col_Bebida.FillWeight = 140F;

            // 
            // Col_Categoria
            // 
            Col_Categoria.HeaderText = "Categoría";
            Col_Categoria.Name = "Col_Categoria";
            Col_Categoria.ReadOnly = true;
            Col_Categoria.FillWeight = 90F;

            // 
            // Col_Tamano
            // 
            Col_Tamano.HeaderText = "Tamaño";
            Col_Tamano.Name = "Col_Tamano";
            Col_Tamano.ReadOnly = true;
            Col_Tamano.FillWeight = 80F;

            // 
            // Col_CantIngredientes
            // 
            Col_CantIngredientes.HeaderText = "Insumos Asignados";
            Col_CantIngredientes.Name = "Col_CantIngredientes";
            Col_CantIngredientes.ReadOnly = true;
            Col_CantIngredientes.FillWeight = 70F;

            // 
            // Col_CantPasos
            // 
            Col_CantPasos.HeaderText = "Pasos Registrados";
            Col_CantPasos.Name = "Col_CantPasos";
            Col_CantPasos.ReadOnly = true;
            Col_CantPasos.FillWeight = 70F;

            // 
            // Frm_GestionRecetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 244);
            ClientSize = new Size(1000, 620);
            Controls.Add(Pnl_Content);
            Controls.Add(Pnl_Toolbar);
            Controls.Add(Pnl_Header);
            MinimumSize = new Size(850, 500);
            Name = "Frm_GestionRecetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Recetas y Permisos";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Toolbar.ResumeLayout(false);
            Pnl_Toolbar.PerformLayout();
            Pnl_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Recetas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Header;
        private Label Lbl_Subtitulo;
        private Label Lbl_Titulo;
        private Panel Pnl_Toolbar;
        private Button Btn_NuevaReceta;
        private Button Btn_EditarReceta;
        private Button Btn_EliminarReceta;
        private Label Lbl_Buscar;
        private TextBox Txt_Buscar;
        private Panel Pnl_Content;
        private DataGridView Dgv_Recetas;
        private DataGridViewTextBoxColumn Col_IdReceta;
        private DataGridViewTextBoxColumn Col_Bebida;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn Col_Tamano;
        private DataGridViewTextBoxColumn Col_CantIngredientes;
        private DataGridViewTextBoxColumn Col_CantPasos;
    }
}
