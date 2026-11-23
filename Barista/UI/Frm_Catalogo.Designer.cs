namespace Barista.UI
{
    partial class Frm_Catalogo
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Pnl_Header = new Panel();
            Lbl_TotalBebidas = new Label();
            Lbl_Subtitulo = new Label();
            Lbl_Titulo = new Label();
            Pnl_Toolbar = new Panel();
            Lbl_Buscar = new Label();
            Txt_Buscar = new TextBox();
            Btn_Actualizar = new Button();
            Pnl_Content = new Panel();
            Dgv_Bebidas = new DataGridView();
            Col_IdBebida = new DataGridViewTextBoxColumn();
            Col_Nombre = new DataGridViewTextBoxColumn();
            Col_Descripcion = new DataGridViewTextBoxColumn();
            Col_Categoria = new DataGridViewTextBoxColumn();
            Col_Estado = new DataGridViewTextBoxColumn();
            Pnl_Header.SuspendLayout();
            Pnl_Toolbar.SuspendLayout();
            Pnl_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Bebidas).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Header
            // 
            Pnl_Header.BackColor = Color.FromArgb(43, 30, 26);
            Pnl_Header.Controls.Add(Lbl_TotalBebidas);
            Pnl_Header.Controls.Add(Lbl_Subtitulo);
            Pnl_Header.Controls.Add(Lbl_Titulo);
            Pnl_Header.Dock = DockStyle.Top;
            Pnl_Header.Location = new Point(0, 0);
            Pnl_Header.Name = "Pnl_Header";
            Pnl_Header.Size = new Size(1000, 75);
            Pnl_Header.TabIndex = 0;
            // 
            // Lbl_TotalBebidas
            // 
            Lbl_TotalBebidas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_TotalBebidas.BackColor = Color.FromArgb(70, 55, 50);
            Lbl_TotalBebidas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_TotalBebidas.ForeColor = Color.White;
            Lbl_TotalBebidas.Location = new Point(860, 21);
            Lbl_TotalBebidas.Name = "Lbl_TotalBebidas";
            Lbl_TotalBebidas.Size = new Size(120, 32);
            Lbl_TotalBebidas.TabIndex = 2;
            Lbl_TotalBebidas.Text = "📦 Total: 0";
            Lbl_TotalBebidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(22, 45);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(352, 15);
            Lbl_Subtitulo.TabIndex = 3;
            Lbl_Subtitulo.Text = "Consulta visual de las bebidas del bar. Libre para todo el personal.";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(20, 12);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(239, 28);
            Lbl_Titulo.TabIndex = 4;
            Lbl_Titulo.Text = "☕ Catálogo de Bebidas";
            // 
            // Pnl_Toolbar
            // 
            Pnl_Toolbar.BackColor = Color.FromArgb(240, 238, 235);
            Pnl_Toolbar.Controls.Add(Lbl_Buscar);
            Pnl_Toolbar.Controls.Add(Txt_Buscar);
            Pnl_Toolbar.Controls.Add(Btn_Actualizar);
            Pnl_Toolbar.Dock = DockStyle.Top;
            Pnl_Toolbar.Location = new Point(0, 75);
            Pnl_Toolbar.Name = "Pnl_Toolbar";
            Pnl_Toolbar.Padding = new Padding(15);
            Pnl_Toolbar.Size = new Size(1000, 60);
            Pnl_Toolbar.TabIndex = 1;
            // 
            // Lbl_Buscar
            // 
            Lbl_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Buscar.AutoSize = true;
            Lbl_Buscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Buscar.Location = new Point(653, 23);
            Lbl_Buscar.Name = "Lbl_Buscar";
            Lbl_Buscar.Size = new Size(61, 15);
            Lbl_Buscar.TabIndex = 1;
            Lbl_Buscar.Text = "🔍 Buscar:";
            // 
            // Txt_Buscar
            // 
            Txt_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Txt_Buscar.Font = new Font("Segoe UI", 10F);
            Txt_Buscar.Location = new Point(720, 18);
            Txt_Buscar.Name = "Txt_Buscar";
            Txt_Buscar.PlaceholderText = "Filtrar por bebida o categoría...";
            Txt_Buscar.Size = new Size(265, 25);
            Txt_Buscar.TabIndex = 2;
            Txt_Buscar.TextChanged += Txt_Buscar_TextChanged;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.BackColor = Color.FromArgb(30, 100, 160);
            Btn_Actualizar.Cursor = Cursors.Hand;
            Btn_Actualizar.FlatAppearance.BorderSize = 0;
            Btn_Actualizar.FlatStyle = FlatStyle.Flat;
            Btn_Actualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Btn_Actualizar.ForeColor = Color.White;
            Btn_Actualizar.Location = new Point(15, 12);
            Btn_Actualizar.Name = "Btn_Actualizar";
            Btn_Actualizar.Size = new Size(150, 36);
            Btn_Actualizar.TabIndex = 0;
            Btn_Actualizar.Text = "🔄 Actualizar";
            Btn_Actualizar.UseVisualStyleBackColor = false;
            Btn_Actualizar.Click += Btn_Actualizar_Click;
            // 
            // Pnl_Content
            // 
            Pnl_Content.Controls.Add(Dgv_Bebidas);
            Pnl_Content.Dock = DockStyle.Fill;
            Pnl_Content.Location = new Point(0, 135);
            Pnl_Content.Name = "Pnl_Content";
            Pnl_Content.Padding = new Padding(15);
            Pnl_Content.Size = new Size(1000, 485);
            Pnl_Content.TabIndex = 2;
            // 
            // Dgv_Bebidas
            // 
            Dgv_Bebidas.AllowUserToAddRows = false;
            Dgv_Bebidas.AllowUserToDeleteRows = false;
            Dgv_Bebidas.AllowUserToResizeRows = false;
            Dgv_Bebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Bebidas.BackgroundColor = Color.White;
            Dgv_Bebidas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(240, 235, 230);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(43, 30, 26);
            Dgv_Bebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            Dgv_Bebidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Bebidas.Columns.AddRange(new DataGridViewColumn[] { Col_IdBebida, Col_Nombre, Col_Descripcion, Col_Categoria, Col_Estado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(43, 30, 26);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(220, 235, 245);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Dgv_Bebidas.DefaultCellStyle = dataGridViewCellStyle6;
            Dgv_Bebidas.Dock = DockStyle.Fill;
            Dgv_Bebidas.EnableHeadersVisualStyles = false;
            Dgv_Bebidas.Location = new Point(15, 15);
            Dgv_Bebidas.MultiSelect = false;
            Dgv_Bebidas.Name = "Dgv_Bebidas";
            Dgv_Bebidas.ReadOnly = true;
            Dgv_Bebidas.RowHeadersVisible = false;
            Dgv_Bebidas.RowTemplate.Height = 32;
            Dgv_Bebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Bebidas.Size = new Size(970, 455);
            Dgv_Bebidas.TabIndex = 0;
            Dgv_Bebidas.CellFormatting += Dgv_Bebidas_CellFormatting;
            // 
            // Col_IdBebida
            // 
            Col_IdBebida.FillWeight = 40F;
            Col_IdBebida.HeaderText = "ID";
            Col_IdBebida.Name = "Col_IdBebida";
            Col_IdBebida.ReadOnly = true;
            // 
            // Col_Nombre
            // 
            Col_Nombre.FillWeight = 140F;
            Col_Nombre.HeaderText = "Bebida";
            Col_Nombre.Name = "Col_Nombre";
            Col_Nombre.ReadOnly = true;
            // 
            // Col_Descripcion
            // 
            Col_Descripcion.FillWeight = 240F;
            Col_Descripcion.HeaderText = "Descripción";
            Col_Descripcion.Name = "Col_Descripcion";
            Col_Descripcion.ReadOnly = true;
            // 
            // Col_Categoria
            // 
            Col_Categoria.FillWeight = 90F;
            Col_Categoria.HeaderText = "Categoría";
            Col_Categoria.Name = "Col_Categoria";
            Col_Categoria.ReadOnly = true;
            // 
            // Col_Estado
            // 
            Col_Estado.FillWeight = 70F;
            Col_Estado.HeaderText = "Estado";
            Col_Estado.Name = "Col_Estado";
            Col_Estado.ReadOnly = true;
            // 
            // Frm_Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 244);
            ClientSize = new Size(1000, 620);
            Controls.Add(Pnl_Content);
            Controls.Add(Pnl_Toolbar);
            Controls.Add(Pnl_Header);
            MinimumSize = new Size(850, 500);
            Name = "Frm_Catalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catálogo de Bebidas";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Toolbar.ResumeLayout(false);
            Pnl_Toolbar.PerformLayout();
            Pnl_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Bebidas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Header;
        private Label Lbl_Titulo;
        private Label Lbl_Subtitulo;
        private Label Lbl_TotalBebidas;
        private Panel Pnl_Toolbar;
        private Button Btn_Actualizar;
        private Label Lbl_Buscar;
        private TextBox Txt_Buscar;
        private Panel Pnl_Content;
        private DataGridView Dgv_Bebidas;
        private DataGridViewTextBoxColumn Col_IdBebida;
        private DataGridViewTextBoxColumn Col_Nombre;
        private DataGridViewTextBoxColumn Col_Descripcion;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn Col_Estado;
    }
}
