namespace Barista.UI
{
    partial class Frm_GuiaBarista
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            Pnl_Header = new Panel();
            Lbl_HeaderSub = new Label();
            Lbl_HeaderTitle = new Label();
            
            Pnl_Left = new Panel();
            Lst_Bebidas = new ListBox();
            Pnl_Filtros = new Panel();
            Txt_Buscar = new TextBox();
            Lbl_Buscar = new Label();
            Cmb_Categorias = new ComboBox();
            Lbl_FiltroCat = new Label();
            
            Pnl_Content = new Panel();
            Pnl_Detalle = new Panel();
            
            // Header Receta
            Pnl_RecetaInfo = new Panel();
            Lbl_TituloBebida = new Label();
            Lbl_CategoriaBebida = new Label();
            Lbl_DescripcionBebida = new Label();
            Lbl_Tamano = new Label();
            Cmb_Tamanos = new ComboBox();
            Btn_RegistrarPreparacion = new Button();

            // Split de Ingredientes y Pasos
            Pnl_Ingredientes = new GroupBox();
            Dgv_Ingredientes = new DataGridView();
            Col_Ingrediente = new DataGridViewTextBoxColumn();
            Col_Cantidad = new DataGridViewTextBoxColumn();
            Col_Unidad = new DataGridViewTextBoxColumn();

            Pnl_Pasos = new GroupBox();
            Lst_Pasos = new ListBox();

            Pnl_Header.SuspendLayout();
            Pnl_Left.SuspendLayout();
            Pnl_Filtros.SuspendLayout();
            Pnl_Content.SuspendLayout();
            Pnl_Detalle.SuspendLayout();
            Pnl_RecetaInfo.SuspendLayout();
            Pnl_Ingredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Ingredientes).BeginInit();
            Pnl_Pasos.SuspendLayout();
            SuspendLayout();

            // 
            // Pnl_Header
            // 
            Pnl_Header.BackColor = Color.FromArgb(43, 30, 26);
            Pnl_Header.Controls.Add(Lbl_HeaderSub);
            Pnl_Header.Controls.Add(Lbl_HeaderTitle);
            Pnl_Header.Dock = DockStyle.Top;
            Pnl_Header.Location = new Point(0, 0);
            Pnl_Header.Name = "Pnl_Header";
            Pnl_Header.Size = new Size(1100, 70);
            Pnl_Header.TabIndex = 0;

            // 
            // Lbl_HeaderTitle
            // 
            Lbl_HeaderTitle.AutoSize = true;
            Lbl_HeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_HeaderTitle.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_HeaderTitle.Location = new Point(20, 10);
            Lbl_HeaderTitle.Name = "Lbl_HeaderTitle";
            Lbl_HeaderTitle.Size = new Size(430, 30);
            Lbl_HeaderTitle.Text = "☕ Modo Barista - Guía de Preparación";

            // 
            // Lbl_HeaderSub
            // 
            Lbl_HeaderSub.AutoSize = true;
            Lbl_HeaderSub.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_HeaderSub.ForeColor = Color.FromArgb(210, 195, 180);
            Lbl_HeaderSub.Location = new Point(22, 42);
            Lbl_HeaderSub.Name = "Lbl_HeaderSub";
            Lbl_HeaderSub.Size = new Size(520, 17);
            Lbl_HeaderSub.Text = "Aprende el paso a paso, los gramajes exactos y la técnica de cada receta.";

            // 
            // Pnl_Left
            // 
            Pnl_Left.BackColor = Color.FromArgb(248, 246, 244);
            Pnl_Left.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Left.Controls.Add(Lst_Bebidas);
            Pnl_Left.Controls.Add(Pnl_Filtros);
            Pnl_Left.Dock = DockStyle.Left;
            Pnl_Left.Location = new Point(0, 70);
            Pnl_Left.Name = "Pnl_Left";
            Pnl_Left.Padding = new Padding(10);
            Pnl_Left.Size = new Size(320, 630);
            Pnl_Left.TabIndex = 1;

            // 
            // Pnl_Filtros
            // 
            Pnl_Filtros.Controls.Add(Lbl_Buscar);
            Pnl_Filtros.Controls.Add(Txt_Buscar);
            Pnl_Filtros.Controls.Add(Lbl_FiltroCat);
            Pnl_Filtros.Controls.Add(Cmb_Categorias);
            Pnl_Filtros.Dock = DockStyle.Top;
            Pnl_Filtros.Location = new Point(10, 10);
            Pnl_Filtros.Name = "Pnl_Filtros";
            Pnl_Filtros.Size = new Size(298, 125);
            Pnl_Filtros.TabIndex = 0;

            // 
            // Lbl_Buscar
            // 
            Lbl_Buscar.AutoSize = true;
            Lbl_Buscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Buscar.Location = new Point(3, 3);
            Lbl_Buscar.Name = "Lbl_Buscar";
            Lbl_Buscar.Size = new Size(88, 15);
            Lbl_Buscar.Text = "Buscar Bebida:";

            // 
            // Txt_Buscar
            // 
            Txt_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Buscar.Font = new Font("Segoe UI", 10F);
            Txt_Buscar.Location = new Point(3, 22);
            Txt_Buscar.Name = "Txt_Buscar";
            Txt_Buscar.PlaceholderText = "Escribe nombre de bebida...";
            Txt_Buscar.Size = new Size(292, 25);
            Txt_Buscar.TabIndex = 0;
            Txt_Buscar.TextChanged += Txt_Buscar_TextChanged;

            // 
            // Lbl_FiltroCat
            // 
            Lbl_FiltroCat.AutoSize = true;
            Lbl_FiltroCat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_FiltroCat.Location = new Point(3, 58);
            Lbl_FiltroCat.Name = "Lbl_FiltroCat";
            Lbl_FiltroCat.Size = new Size(60, 15);
            Lbl_FiltroCat.Text = "Categoría:";

            // 
            // Cmb_Categorias
            // 
            Cmb_Categorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cmb_Categorias.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Categorias.Font = new Font("Segoe UI", 10F);
            Cmb_Categorias.FormattingEnabled = true;
            Cmb_Categorias.Location = new Point(3, 77);
            Cmb_Categorias.Name = "Cmb_Categorias";
            Cmb_Categorias.Size = new Size(292, 25);
            Cmb_Categorias.TabIndex = 1;
            Cmb_Categorias.SelectedIndexChanged += Cmb_Categorias_SelectedIndexChanged;

            // 
            // Lst_Bebidas
            // 
            Lst_Bebidas.BackColor = Color.White;
            Lst_Bebidas.BorderStyle = BorderStyle.FixedSingle;
            Lst_Bebidas.Dock = DockStyle.Fill;
            Lst_Bebidas.DrawMode = DrawMode.OwnerDrawVariable;
            Lst_Bebidas.Font = new Font("Segoe UI", 10.5F);
            Lst_Bebidas.FormattingEnabled = true;
            Lst_Bebidas.ItemHeight = 44;
            Lst_Bebidas.Location = new Point(10, 135);
            Lst_Bebidas.Name = "Lst_Bebidas";
            Lst_Bebidas.Size = new Size(298, 483);
            Lst_Bebidas.TabIndex = 2;
            Lst_Bebidas.DrawItem += Lst_Bebidas_DrawItem;
            Lst_Bebidas.MeasureItem += Lst_Bebidas_MeasureItem;
            Lst_Bebidas.SelectedIndexChanged += Lst_Bebidas_SelectedIndexChanged;

            // 
            // Pnl_Content
            // 
            Pnl_Content.Controls.Add(Pnl_Detalle);
            Pnl_Content.Dock = DockStyle.Fill;
            Pnl_Content.Location = new Point(320, 70);
            Pnl_Content.Name = "Pnl_Content";
            Pnl_Content.Padding = new Padding(15);
            Pnl_Content.Size = new Size(780, 630);
            Pnl_Content.TabIndex = 2;

            // 
            // Pnl_Detalle
            // 
            Pnl_Detalle.BackColor = Color.White;
            Pnl_Detalle.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Detalle.Controls.Add(Pnl_Pasos);
            Pnl_Detalle.Controls.Add(Pnl_Ingredientes);
            Pnl_Detalle.Controls.Add(Pnl_RecetaInfo);
            Pnl_Detalle.Dock = DockStyle.Fill;
            Pnl_Detalle.Location = new Point(15, 15);
            Pnl_Detalle.Name = "Pnl_Detalle";
            Pnl_Detalle.Padding = new Padding(15);
            Pnl_Detalle.Size = new Size(750, 600);
            Pnl_Detalle.TabIndex = 0;

            // 
            // Pnl_RecetaInfo
            // 
            Pnl_RecetaInfo.Controls.Add(Btn_RegistrarPreparacion);
            Pnl_RecetaInfo.Controls.Add(Cmb_Tamanos);
            Pnl_RecetaInfo.Controls.Add(Lbl_Tamano);
            Pnl_RecetaInfo.Controls.Add(Lbl_DescripcionBebida);
            Pnl_RecetaInfo.Controls.Add(Lbl_CategoriaBebida);
            Pnl_RecetaInfo.Controls.Add(Lbl_TituloBebida);
            Pnl_RecetaInfo.Dock = DockStyle.Top;
            Pnl_RecetaInfo.Location = new Point(15, 15);
            Pnl_RecetaInfo.Name = "Pnl_RecetaInfo";
            Pnl_RecetaInfo.Size = new Size(718, 95);
            Pnl_RecetaInfo.TabIndex = 0;

            // 
            // Lbl_TituloBebida
            // 
            Lbl_TituloBebida.AutoSize = true;
            Lbl_TituloBebida.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Lbl_TituloBebida.ForeColor = Color.FromArgb(43, 30, 26);
            Lbl_TituloBebida.Location = new Point(3, 3);
            Lbl_TituloBebida.Name = "Lbl_TituloBebida";
            Lbl_TituloBebida.Size = new Size(320, 28);
            Lbl_TituloBebida.Text = "Selecciona una bebida de la lista";

            // 
            // Lbl_CategoriaBebida
            // 
            Lbl_CategoriaBebida.AutoSize = true;
            Lbl_CategoriaBebida.BackColor = Color.FromArgb(235, 230, 222);
            Lbl_CategoriaBebida.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            Lbl_CategoriaBebida.ForeColor = Color.FromArgb(90, 70, 60);
            Lbl_CategoriaBebida.Location = new Point(6, 33);
            Lbl_CategoriaBebida.Padding = new Padding(4, 2, 4, 2);
            Lbl_CategoriaBebida.Name = "Lbl_CategoriaBebida";
            Lbl_CategoriaBebida.Size = new Size(65, 19);
            Lbl_CategoriaBebida.Text = "Categoría";

            // 
            // Lbl_DescripcionBebida
            // 
            Lbl_DescripcionBebida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Lbl_DescripcionBebida.Font = new Font("Segoe UI", 9F);
            Lbl_DescripcionBebida.ForeColor = Color.FromArgb(70, 70, 70);
            Lbl_DescripcionBebida.Location = new Point(6, 56);
            Lbl_DescripcionBebida.Name = "Lbl_DescripcionBebida";
            Lbl_DescripcionBebida.Size = new Size(470, 35);
            Lbl_DescripcionBebida.Text = "Aquí verás la descripción sensorial y notas de calibración de la receta.";

            // 
            // Lbl_Tamano
            // 
            Lbl_Tamano.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Tamano.AutoSize = true;
            Lbl_Tamano.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Tamano.Location = new Point(505, 12);
            Lbl_Tamano.Name = "Lbl_Tamano";
            Lbl_Tamano.Size = new Size(116, 15);
            Lbl_Tamano.Text = "Tamaño de la Receta:";

            // 
            // Cmb_Tamanos
            // 
            Cmb_Tamanos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cmb_Tamanos.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Tamanos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Cmb_Tamanos.FormattingEnabled = true;
            Cmb_Tamanos.Location = new Point(505, 33);
            Cmb_Tamanos.Name = "Cmb_Tamanos";
            Cmb_Tamanos.Size = new Size(205, 25);
            Cmb_Tamanos.TabIndex = 0;
            Cmb_Tamanos.SelectedIndexChanged += Cmb_Tamanos_SelectedIndexChanged;

            //
            // Btn_RegistrarPreparacion
            //
            Btn_RegistrarPreparacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_RegistrarPreparacion.BackColor = Color.FromArgb(46, 125, 50);
            Btn_RegistrarPreparacion.Cursor = Cursors.Hand;
            Btn_RegistrarPreparacion.Enabled = false;
            Btn_RegistrarPreparacion.FlatAppearance.BorderSize = 0;
            Btn_RegistrarPreparacion.FlatStyle = FlatStyle.Flat;
            Btn_RegistrarPreparacion.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Btn_RegistrarPreparacion.ForeColor = Color.White;
            Btn_RegistrarPreparacion.Location = new Point(505, 65);
            Btn_RegistrarPreparacion.Name = "Btn_RegistrarPreparacion";
            Btn_RegistrarPreparacion.Size = new Size(205, 26);
            Btn_RegistrarPreparacion.TabIndex = 1;
            Btn_RegistrarPreparacion.Text = "☕ Registrar preparación";
            Btn_RegistrarPreparacion.UseVisualStyleBackColor = false;
            Btn_RegistrarPreparacion.Click += Btn_RegistrarPreparacion_Click;

            //
            // Pnl_Ingredientes
            //
            Pnl_Ingredientes.Controls.Add(Dgv_Ingredientes);
            Pnl_Ingredientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Pnl_Ingredientes.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Pnl_Ingredientes.ForeColor = Color.FromArgb(43, 30, 26);
            Pnl_Ingredientes.Location = new Point(15, 115);
            Pnl_Ingredientes.Name = "Pnl_Ingredientes";
            Pnl_Ingredientes.Padding = new Padding(10);
            Pnl_Ingredientes.Size = new Size(330, 470);
            Pnl_Ingredientes.TabIndex = 1;
            Pnl_Ingredientes.TabStop = false;
            Pnl_Ingredientes.Text = "📋 Ingredientes y Gramajes";

            // 
            // Dgv_Ingredientes
            // 
            Dgv_Ingredientes.AllowUserToAddRows = false;
            Dgv_Ingredientes.AllowUserToDeleteRows = false;
            Dgv_Ingredientes.AllowUserToResizeRows = false;
            Dgv_Ingredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Ingredientes.BackgroundColor = Color.White;
            Dgv_Ingredientes.BorderStyle = BorderStyle.None;
            dgvHeaderStyle.BackColor = Color.FromArgb(240, 235, 230);
            dgvHeaderStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dgvHeaderStyle.ForeColor = Color.FromArgb(43, 30, 26);
            Dgv_Ingredientes.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            Dgv_Ingredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Ingredientes.Columns.AddRange(new DataGridViewColumn[] { Col_Ingrediente, Col_Cantidad, Col_Unidad });
            dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = Color.White;
            dgvCellStyle.Font = new Font("Segoe UI", 9F);
            dgvCellStyle.ForeColor = Color.FromArgb(43, 30, 26);
            dgvCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 245);
            dgvCellStyle.SelectionForeColor = Color.Black;
            Dgv_Ingredientes.DefaultCellStyle = dgvCellStyle;
            Dgv_Ingredientes.Dock = DockStyle.Fill;
            Dgv_Ingredientes.EnableHeadersVisualStyles = false;
            Dgv_Ingredientes.Location = new Point(10, 27);
            Dgv_Ingredientes.MultiSelect = false;
            Dgv_Ingredientes.Name = "Dgv_Ingredientes";
            Dgv_Ingredientes.ReadOnly = true;
            Dgv_Ingredientes.RowHeadersVisible = false;
            Dgv_Ingredientes.RowTemplate.Height = 28;
            Dgv_Ingredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Ingredientes.Size = new Size(310, 308);
            Dgv_Ingredientes.TabIndex = 0;

            // 
            // Col_Ingrediente
            // 
            Col_Ingrediente.FillWeight = 140F;
            Col_Ingrediente.HeaderText = "Insumo";
            Col_Ingrediente.Name = "Col_Ingrediente";
            Col_Ingrediente.ReadOnly = true;

            // 
            // Col_Cantidad
            // 
            Col_Cantidad.FillWeight = 60F;
            Col_Cantidad.HeaderText = "Cant.";
            Col_Cantidad.Name = "Col_Cantidad";
            Col_Cantidad.ReadOnly = true;

            // 
            // Col_Unidad
            // 
            Col_Unidad.FillWeight = 50F;
            Col_Unidad.HeaderText = "Unidad";
            Col_Unidad.Name = "Col_Unidad";
            Col_Unidad.ReadOnly = true;

            // 
            // Pnl_Pasos
            // 
            Pnl_Pasos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pnl_Pasos.Controls.Add(Lst_Pasos);
            Pnl_Pasos.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Pnl_Pasos.ForeColor = Color.FromArgb(43, 30, 26);
            Pnl_Pasos.Location = new Point(355, 115);
            Pnl_Pasos.Name = "Pnl_Pasos";
            Pnl_Pasos.Padding = new Padding(10);
            Pnl_Pasos.Size = new Size(378, 470);
            Pnl_Pasos.TabIndex = 2;
            Pnl_Pasos.TabStop = false;
            Pnl_Pasos.Text = "📝 Pasos de Preparación Secuenciales";

            // 
            // Lst_Pasos
            // 
            Lst_Pasos.BackColor = Color.White;
            Lst_Pasos.BorderStyle = BorderStyle.None;
            Lst_Pasos.Dock = DockStyle.Fill;
            Lst_Pasos.DrawMode = DrawMode.OwnerDrawVariable;
            Lst_Pasos.Font = new Font("Segoe UI", 9.5F);
            Lst_Pasos.FormattingEnabled = true;
            Lst_Pasos.ItemHeight = 52;
            Lst_Pasos.Location = new Point(10, 27);
            Lst_Pasos.Name = "Lst_Pasos";
            Lst_Pasos.Size = new Size(358, 308);
            Lst_Pasos.TabIndex = 0;
            Lst_Pasos.DrawItem += Lst_Pasos_DrawItem;
            Lst_Pasos.MeasureItem += Lst_Pasos_MeasureItem;

            // 
            // Frm_GuiaBarista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 240, 238);
            ClientSize = new Size(1100, 700);
            Controls.Add(Pnl_Content);
            Controls.Add(Pnl_Left);
            Controls.Add(Pnl_Header);
            MinimumSize = new Size(950, 650);
            Name = "Frm_GuiaBarista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guía de Preparación - Modo Barista";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Left.ResumeLayout(false);
            Pnl_Filtros.ResumeLayout(false);
            Pnl_Filtros.PerformLayout();
            Pnl_Content.ResumeLayout(false);
            Pnl_Detalle.ResumeLayout(false);
            Pnl_RecetaInfo.ResumeLayout(false);
            Pnl_RecetaInfo.PerformLayout();
            Pnl_Ingredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Ingredientes).EndInit();
            Pnl_Pasos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Header;
        private Label Lbl_HeaderTitle;
        private Label Lbl_HeaderSub;
        private Panel Pnl_Left;
        private Panel Pnl_Filtros;
        private Label Lbl_Buscar;
        private TextBox Txt_Buscar;
        private Label Lbl_FiltroCat;
        private ComboBox Cmb_Categorias;
        private ListBox Lst_Bebidas;
        private Panel Pnl_Content;
        private Panel Pnl_Detalle;
        private Panel Pnl_RecetaInfo;
        private Label Lbl_TituloBebida;
        private Label Lbl_CategoriaBebida;
        private Label Lbl_DescripcionBebida;
        private Label Lbl_Tamano;
        private ComboBox Cmb_Tamanos;
        private Button Btn_RegistrarPreparacion;
        private GroupBox Pnl_Ingredientes;
        private DataGridView Dgv_Ingredientes;
        private DataGridViewTextBoxColumn Col_Ingrediente;
        private DataGridViewTextBoxColumn Col_Cantidad;
        private DataGridViewTextBoxColumn Col_Unidad;
        private GroupBox Pnl_Pasos;
        private ListBox Lst_Pasos;
    }
}
