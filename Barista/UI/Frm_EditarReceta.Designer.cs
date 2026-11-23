namespace Barista.UI
{
    partial class Frm_EditarReceta
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
            Pnl_Header = new Panel();
            Lbl_Subtitulo = new Label();
            Lbl_Titulo = new Label();

            Pnl_Footer = new Panel();
            Btn_Cancelar = new Button();
            Btn_Guardar = new Button();

            Pnl_Body = new Panel();
            
            // Grupo Bebida y Tamaño
            Grp_InfoBasica = new GroupBox();
            Lbl_Bebida = new Label();
            Txt_Bebida = new TextBox();
            Lbl_Categoria = new Label();
            Cmb_Categoria = new ComboBox();
            Lbl_Tamano = new Label();
            Cmb_Tamano = new ComboBox();

            // Grupo Ingredientes
            Grp_Ingredientes = new GroupBox();
            Lbl_SeleccionarIngrediente = new Label();
            Cmb_Ingredientes = new ComboBox();
            Lbl_Cantidad = new Label();
            Num_Cantidad = new NumericUpDown();
            Lbl_Unidad = new Label();
            Btn_AgregarIngrediente = new Button();
            Dgv_Ingredientes = new DataGridView();
            Col_IdIngrediente = new DataGridViewTextBoxColumn();
            Col_NombreIngrediente = new DataGridViewTextBoxColumn();
            Col_Cant = new DataGridViewTextBoxColumn();
            Col_Uni = new DataGridViewTextBoxColumn();
            Col_EliminarIng = new DataGridViewButtonColumn();

            // Grupo Pasos
            Grp_Pasos = new GroupBox();
            Lbl_NuevaInstruccion = new Label();
            Txt_NuevaInstruccion = new TextBox();
            Btn_AgregarPaso = new Button();
            Lst_Pasos = new ListBox();
            Btn_SubirPaso = new Button();
            Btn_BajarPaso = new Button();
            Btn_EliminarPaso = new Button();

            Pnl_Header.SuspendLayout();
            Pnl_Footer.SuspendLayout();
            Pnl_Body.SuspendLayout();
            Grp_InfoBasica.SuspendLayout();
            Grp_Ingredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Num_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Ingredientes).BeginInit();
            Grp_Pasos.SuspendLayout();
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
            Pnl_Header.Size = new Size(880, 70);
            Pnl_Header.TabIndex = 0;

            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(22, 42);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(460, 15);
            Lbl_Subtitulo.Text = "Configura la bebida, tamaño, cantidades exactas de insumos y pasos secuenciales.";

            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(20, 10);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(235, 28);
            Lbl_Titulo.Text = "📝 Editor de Receta";

            // 
            // Pnl_Footer
            // 
            Pnl_Footer.BackColor = Color.FromArgb(240, 238, 235);
            Pnl_Footer.Controls.Add(Btn_Cancelar);
            Pnl_Footer.Controls.Add(Btn_Guardar);
            Pnl_Footer.Dock = DockStyle.Bottom;
            Pnl_Footer.Location = new Point(0, 640);
            Pnl_Footer.Name = "Pnl_Footer";
            Pnl_Footer.Padding = new Padding(15);
            Pnl_Footer.Size = new Size(880, 60);
            Pnl_Footer.TabIndex = 2;

            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Cancelar.BackColor = Color.FromArgb(200, 195, 190);
            Btn_Cancelar.Cursor = Cursors.Hand;
            Btn_Cancelar.FlatAppearance.BorderSize = 0;
            Btn_Cancelar.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Btn_Cancelar.ForeColor = Color.FromArgb(40, 40, 40);
            Btn_Cancelar.Location = new Point(590, 12);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(130, 36);
            Btn_Cancelar.TabIndex = 1;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = false;
            Btn_Cancelar.Click += Btn_Cancelar_Click;

            // 
            // Btn_Guardar
            // 
            Btn_Guardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Guardar.BackColor = Color.FromArgb(140, 75, 45);
            Btn_Guardar.Cursor = Cursors.Hand;
            Btn_Guardar.FlatAppearance.BorderSize = 0;
            Btn_Guardar.FlatStyle = FlatStyle.Flat;
            Btn_Guardar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Btn_Guardar.ForeColor = Color.White;
            Btn_Guardar.Location = new Point(735, 12);
            Btn_Guardar.Name = "Btn_Guardar";
            Btn_Guardar.Size = new Size(130, 36);
            Btn_Guardar.TabIndex = 0;
            Btn_Guardar.Text = "💾 Guardar Receta";
            Btn_Guardar.UseVisualStyleBackColor = false;
            Btn_Guardar.Click += Btn_Guardar_Click;

            // 
            // Pnl_Body
            // 
            Pnl_Body.BackColor = Color.FromArgb(248, 246, 244);
            Pnl_Body.Controls.Add(Grp_Pasos);
            Pnl_Body.Controls.Add(Grp_Ingredientes);
            Pnl_Body.Controls.Add(Grp_InfoBasica);
            Pnl_Body.Dock = DockStyle.Fill;
            Pnl_Body.Location = new Point(0, 70);
            Pnl_Body.Name = "Pnl_Body";
            Pnl_Body.Padding = new Padding(15);
            Pnl_Body.Size = new Size(880, 570);
            Pnl_Body.TabIndex = 1;

            // 
            // Grp_InfoBasica
            // 
            Grp_InfoBasica.Controls.Add(Cmb_Tamano);
            Grp_InfoBasica.Controls.Add(Lbl_Tamano);
            Grp_InfoBasica.Controls.Add(Cmb_Categoria);
            Grp_InfoBasica.Controls.Add(Lbl_Categoria);
            Grp_InfoBasica.Controls.Add(Txt_Bebida);
            Grp_InfoBasica.Controls.Add(Lbl_Bebida);
            Grp_InfoBasica.Dock = DockStyle.Top;
            Grp_InfoBasica.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Grp_InfoBasica.ForeColor = Color.FromArgb(43, 30, 26);
            Grp_InfoBasica.Location = new Point(15, 15);
            Grp_InfoBasica.Name = "Grp_InfoBasica";
            Grp_InfoBasica.Padding = new Padding(10);
            Grp_InfoBasica.Size = new Size(850, 75);
            Grp_InfoBasica.TabIndex = 0;
            Grp_InfoBasica.TabStop = false;
            Grp_InfoBasica.Text = "1. Información de la Receta";

            // 
            // Lbl_Bebida
            // 
            Lbl_Bebida.AutoSize = true;
            Lbl_Bebida.Font = new Font("Segoe UI", 9F);
            Lbl_Bebida.Location = new Point(15, 23);
            Lbl_Bebida.Name = "Lbl_Bebida";
            Lbl_Bebida.Size = new Size(124, 15);
            Lbl_Bebida.Text = "Nombre de la Bebida:";

            // 
            // Txt_Bebida
            // 
            Txt_Bebida.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_Bebida.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Txt_Bebida.Font = new Font("Segoe UI", 9.5F);
            Txt_Bebida.Location = new Point(15, 41);
            Txt_Bebida.Name = "Txt_Bebida";
            Txt_Bebida.PlaceholderText = "Ej. Cappuccino, Latte, Mocha...";
            Txt_Bebida.Size = new Size(290, 25);
            Txt_Bebida.TabIndex = 0;

            // 
            // Lbl_Categoria
            // 
            Lbl_Categoria.AutoSize = true;
            Lbl_Categoria.Font = new Font("Segoe UI", 9F);
            Lbl_Categoria.Location = new Point(320, 23);
            Lbl_Categoria.Name = "Lbl_Categoria";
            Lbl_Categoria.Size = new Size(64, 15);
            Lbl_Categoria.Text = "Categoría:";

            // 
            // Cmb_Categoria
            // 
            Cmb_Categoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            Cmb_Categoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            Cmb_Categoria.Font = new Font("Segoe UI", 9.5F);
            Cmb_Categoria.FormattingEnabled = true;
            Cmb_Categoria.Location = new Point(320, 41);
            Cmb_Categoria.Name = "Cmb_Categoria";
            Cmb_Categoria.Size = new Size(235, 25);
            Cmb_Categoria.TabIndex = 1;

            // 
            // Lbl_Tamano
            // 
            Lbl_Tamano.AutoSize = true;
            Lbl_Tamano.Font = new Font("Segoe UI", 9F);
            Lbl_Tamano.Location = new Point(570, 23);
            Lbl_Tamano.Name = "Lbl_Tamano";
            Lbl_Tamano.Size = new Size(116, 15);
            Lbl_Tamano.Text = "Tamaño de la Receta:";

            // 
            // Cmb_Tamano
            // 
            Cmb_Tamano.Font = new Font("Segoe UI", 9.5F);
            Cmb_Tamano.FormattingEnabled = true;
            Cmb_Tamano.Items.AddRange(new object[] { "Chico (250 ml)", "Mediano (350 ml)", "Grande (500 ml)", "Extra Grande (600 ml)" });
            Cmb_Tamano.Location = new Point(570, 41);
            Cmb_Tamano.Name = "Cmb_Tamano";
            Cmb_Tamano.Size = new Size(265, 25);
            Cmb_Tamano.TabIndex = 2;

            // 
            // Grp_Ingredientes
            // 
            Grp_Ingredientes.Controls.Add(Dgv_Ingredientes);
            Grp_Ingredientes.Controls.Add(Btn_AgregarIngrediente);
            Grp_Ingredientes.Controls.Add(Lbl_Unidad);
            Grp_Ingredientes.Controls.Add(Num_Cantidad);
            Grp_Ingredientes.Controls.Add(Lbl_Cantidad);
            Grp_Ingredientes.Controls.Add(Cmb_Ingredientes);
            Grp_Ingredientes.Controls.Add(Lbl_SeleccionarIngrediente);
            Grp_Ingredientes.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Grp_Ingredientes.ForeColor = Color.FromArgb(43, 30, 26);
            Grp_Ingredientes.Location = new Point(15, 96);
            Grp_Ingredientes.Name = "Grp_Ingredientes";
            Grp_Ingredientes.Padding = new Padding(10);
            Grp_Ingredientes.Size = new Size(415, 460);
            Grp_Ingredientes.TabIndex = 1;
            Grp_Ingredientes.TabStop = false;
            Grp_Ingredientes.Text = "2. Insumos e Ingredientes";

            // 
            // Lbl_SeleccionarIngrediente
            // 
            Lbl_SeleccionarIngrediente.AutoSize = true;
            Lbl_SeleccionarIngrediente.Font = new Font("Segoe UI", 9F);
            Lbl_SeleccionarIngrediente.Location = new Point(10, 22);
            Lbl_SeleccionarIngrediente.Name = "Lbl_SeleccionarIngrediente";
            Lbl_SeleccionarIngrediente.Size = new Size(108, 15);
            Lbl_SeleccionarIngrediente.Text = "Seleccionar Insumo:";

            // 
            // Cmb_Ingredientes
            // 
            Cmb_Ingredientes.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Ingredientes.Font = new Font("Segoe UI", 9F);
            Cmb_Ingredientes.FormattingEnabled = true;
            Cmb_Ingredientes.Location = new Point(10, 40);
            Cmb_Ingredientes.Name = "Cmb_Ingredientes";
            Cmb_Ingredientes.Size = new Size(220, 23);
            Cmb_Ingredientes.TabIndex = 0;
            Cmb_Ingredientes.SelectedIndexChanged += Cmb_Ingredientes_SelectedIndexChanged;

            // 
            // Lbl_Cantidad
            // 
            Lbl_Cantidad.AutoSize = true;
            Lbl_Cantidad.Font = new Font("Segoe UI", 9F);
            Lbl_Cantidad.Location = new Point(238, 22);
            Lbl_Cantidad.Name = "Lbl_Cantidad";
            Lbl_Cantidad.Size = new Size(38, 15);
            Lbl_Cantidad.Text = "Cant.:";

            // 
            // Num_Cantidad
            // 
            Num_Cantidad.DecimalPlaces = 2;
            Num_Cantidad.Font = new Font("Segoe UI", 9F);
            Num_Cantidad.Location = new Point(238, 40);
            Num_Cantidad.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            Num_Cantidad.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            Num_Cantidad.Name = "Num_Cantidad";
            Num_Cantidad.Size = new Size(70, 23);
            Num_Cantidad.TabIndex = 1;
            Num_Cantidad.Value = new decimal(new int[] { 18, 0, 0, 0 });

            // 
            // Lbl_Unidad
            // 
            Lbl_Unidad.AutoSize = true;
            Lbl_Unidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_Unidad.Location = new Point(312, 43);
            Lbl_Unidad.Name = "Lbl_Unidad";
            Lbl_Unidad.Size = new Size(15, 15);
            Lbl_Unidad.Text = "g";

            // 
            // Btn_AgregarIngrediente
            // 
            Btn_AgregarIngrediente.BackColor = Color.FromArgb(46, 125, 50);
            Btn_AgregarIngrediente.Cursor = Cursors.Hand;
            Btn_AgregarIngrediente.FlatAppearance.BorderSize = 0;
            Btn_AgregarIngrediente.FlatStyle = FlatStyle.Flat;
            Btn_AgregarIngrediente.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Btn_AgregarIngrediente.ForeColor = Color.White;
            Btn_AgregarIngrediente.Location = new Point(335, 38);
            Btn_AgregarIngrediente.Name = "Btn_AgregarIngrediente";
            Btn_AgregarIngrediente.Size = new Size(70, 26);
            Btn_AgregarIngrediente.TabIndex = 2;
            Btn_AgregarIngrediente.Text = "+ Añadir";
            Btn_AgregarIngrediente.UseVisualStyleBackColor = false;
            Btn_AgregarIngrediente.Click += Btn_AgregarIngrediente_Click;

            // 
            // Dgv_Ingredientes
            // 
            Dgv_Ingredientes.AllowUserToAddRows = false;
            Dgv_Ingredientes.AllowUserToDeleteRows = false;
            Dgv_Ingredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Ingredientes.BackgroundColor = Color.White;
            Dgv_Ingredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Ingredientes.Columns.AddRange(new DataGridViewColumn[] { Col_IdIngrediente, Col_NombreIngrediente, Col_Cant, Col_Uni, Col_EliminarIng });
            Dgv_Ingredientes.Dock = DockStyle.Bottom;
            Dgv_Ingredientes.Location = new Point(10, 72);
            Dgv_Ingredientes.MultiSelect = false;
            Dgv_Ingredientes.Name = "Dgv_Ingredientes";
            Dgv_Ingredientes.ReadOnly = true;
            Dgv_Ingredientes.RowHeadersVisible = false;
            Dgv_Ingredientes.RowTemplate.Height = 26;
            Dgv_Ingredientes.Size = new Size(395, 378);
            Dgv_Ingredientes.TabIndex = 3;
            Dgv_Ingredientes.CellContentClick += Dgv_Ingredientes_CellContentClick;

            // 
            // Col_IdIngrediente
            // 
            Col_IdIngrediente.HeaderText = "ID";
            Col_IdIngrediente.Name = "Col_IdIngrediente";
            Col_IdIngrediente.ReadOnly = true;
            Col_IdIngrediente.Visible = false;

            // 
            // Col_NombreIngrediente
            // 
            Col_NombreIngrediente.FillWeight = 130F;
            Col_NombreIngrediente.HeaderText = "Insumo";
            Col_NombreIngrediente.Name = "Col_NombreIngrediente";
            Col_NombreIngrediente.ReadOnly = true;

            // 
            // Col_Cant
            // 
            Col_Cant.FillWeight = 60F;
            Col_Cant.HeaderText = "Cant.";
            Col_Cant.Name = "Col_Cant";
            Col_Cant.ReadOnly = true;

            // 
            // Col_Uni
            // 
            Col_Uni.FillWeight = 45F;
            Col_Uni.HeaderText = "Unid.";
            Col_Uni.Name = "Col_Uni";
            Col_Uni.ReadOnly = true;

            // 
            // Col_EliminarIng
            // 
            Col_EliminarIng.FillWeight = 45F;
            Col_EliminarIng.HeaderText = "Quitar";
            Col_EliminarIng.Name = "Col_EliminarIng";
            Col_EliminarIng.ReadOnly = true;
            Col_EliminarIng.Text = "❌";
            Col_EliminarIng.UseColumnTextForButtonValue = true;

            // 
            // Grp_Pasos
            // 
            Grp_Pasos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Grp_Pasos.Controls.Add(Btn_EliminarPaso);
            Grp_Pasos.Controls.Add(Btn_BajarPaso);
            Grp_Pasos.Controls.Add(Btn_SubirPaso);
            Grp_Pasos.Controls.Add(Lst_Pasos);
            Grp_Pasos.Controls.Add(Btn_AgregarPaso);
            Grp_Pasos.Controls.Add(Txt_NuevaInstruccion);
            Grp_Pasos.Controls.Add(Lbl_NuevaInstruccion);
            Grp_Pasos.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Grp_Pasos.ForeColor = Color.FromArgb(43, 30, 26);
            Grp_Pasos.Location = new Point(440, 96);
            Grp_Pasos.Name = "Grp_Pasos";
            Grp_Pasos.Padding = new Padding(10);
            Grp_Pasos.Size = new Size(425, 460);
            Grp_Pasos.TabIndex = 2;
            Grp_Pasos.TabStop = false;
            Grp_Pasos.Text = "3. Pasos de Preparación Secuenciales";

            // 
            // Lbl_NuevaInstruccion
            // 
            Lbl_NuevaInstruccion.AutoSize = true;
            Lbl_NuevaInstruccion.Font = new Font("Segoe UI", 9F);
            Lbl_NuevaInstruccion.Location = new Point(10, 22);
            Lbl_NuevaInstruccion.Name = "Lbl_NuevaInstruccion";
            Lbl_NuevaInstruccion.Size = new Size(130, 15);
            Lbl_NuevaInstruccion.Text = "Instrucción del paso:";

            // 
            // Txt_NuevaInstruccion
            // 
            Txt_NuevaInstruccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_NuevaInstruccion.Font = new Font("Segoe UI", 9F);
            Txt_NuevaInstruccion.Location = new Point(10, 40);
            Txt_NuevaInstruccion.Multiline = true;
            Txt_NuevaInstruccion.Name = "Txt_NuevaInstruccion";
            Txt_NuevaInstruccion.PlaceholderText = "Escribe la indicación clara para el barista...";
            Txt_NuevaInstruccion.Size = new Size(315, 52);
            Txt_NuevaInstruccion.TabIndex = 0;

            // 
            // Btn_AgregarPaso
            // 
            Btn_AgregarPaso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_AgregarPaso.BackColor = Color.FromArgb(46, 125, 50);
            Btn_AgregarPaso.Cursor = Cursors.Hand;
            Btn_AgregarPaso.FlatAppearance.BorderSize = 0;
            Btn_AgregarPaso.FlatStyle = FlatStyle.Flat;
            Btn_AgregarPaso.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Btn_AgregarPaso.ForeColor = Color.White;
            Btn_AgregarPaso.Location = new Point(332, 40);
            Btn_AgregarPaso.Name = "Btn_AgregarPaso";
            Btn_AgregarPaso.Size = new Size(82, 52);
            Btn_AgregarPaso.TabIndex = 1;
            Btn_AgregarPaso.Text = "+ Añadir\r\nPaso";
            Btn_AgregarPaso.UseVisualStyleBackColor = false;
            Btn_AgregarPaso.Click += Btn_AgregarPaso_Click;

            // 
            // Lst_Pasos
            // 
            Lst_Pasos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lst_Pasos.BackColor = Color.White;
            Lst_Pasos.BorderStyle = BorderStyle.FixedSingle;
            Lst_Pasos.Font = new Font("Segoe UI", 9F);
            Lst_Pasos.FormattingEnabled = true;
            Lst_Pasos.HorizontalScrollbar = true;
            Lst_Pasos.ItemHeight = 15;
            Lst_Pasos.Location = new Point(10, 100);
            Lst_Pasos.Name = "Lst_Pasos";
            Lst_Pasos.Size = new Size(315, 347);
            Lst_Pasos.TabIndex = 2;

            // 
            // Btn_SubirPaso
            // 
            Btn_SubirPaso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_SubirPaso.BackColor = Color.FromArgb(235, 230, 222);
            Btn_SubirPaso.Cursor = Cursors.Hand;
            Btn_SubirPaso.FlatAppearance.BorderColor = Color.FromArgb(200, 190, 180);
            Btn_SubirPaso.FlatStyle = FlatStyle.Flat;
            Btn_SubirPaso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn_SubirPaso.ForeColor = Color.FromArgb(43, 30, 26);
            Btn_SubirPaso.Location = new Point(332, 100);
            Btn_SubirPaso.Name = "Btn_SubirPaso";
            Btn_SubirPaso.Size = new Size(82, 34);
            Btn_SubirPaso.TabIndex = 3;
            Btn_SubirPaso.Text = "▲ Subir";
            Btn_SubirPaso.UseVisualStyleBackColor = false;
            Btn_SubirPaso.Click += Btn_SubirPaso_Click;

            // 
            // Btn_BajarPaso
            // 
            Btn_BajarPaso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_BajarPaso.BackColor = Color.FromArgb(235, 230, 222);
            Btn_BajarPaso.Cursor = Cursors.Hand;
            Btn_BajarPaso.FlatAppearance.BorderColor = Color.FromArgb(200, 190, 180);
            Btn_BajarPaso.FlatStyle = FlatStyle.Flat;
            Btn_BajarPaso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn_BajarPaso.ForeColor = Color.FromArgb(43, 30, 26);
            Btn_BajarPaso.Location = new Point(332, 142);
            Btn_BajarPaso.Name = "Btn_BajarPaso";
            Btn_BajarPaso.Size = new Size(82, 34);
            Btn_BajarPaso.TabIndex = 4;
            Btn_BajarPaso.Text = "▼ Bajar";
            Btn_BajarPaso.UseVisualStyleBackColor = false;
            Btn_BajarPaso.Click += Btn_BajarPaso_Click;

            // 
            // Btn_EliminarPaso
            // 
            Btn_EliminarPaso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_EliminarPaso.BackColor = Color.FromArgb(198, 40, 40);
            Btn_EliminarPaso.Cursor = Cursors.Hand;
            Btn_EliminarPaso.FlatAppearance.BorderSize = 0;
            Btn_EliminarPaso.FlatStyle = FlatStyle.Flat;
            Btn_EliminarPaso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Btn_EliminarPaso.ForeColor = Color.White;
            Btn_EliminarPaso.Location = new Point(332, 184);
            Btn_EliminarPaso.Name = "Btn_EliminarPaso";
            Btn_EliminarPaso.Size = new Size(82, 34);
            Btn_EliminarPaso.TabIndex = 5;
            Btn_EliminarPaso.Text = "🗑 Quitar";
            Btn_EliminarPaso.UseVisualStyleBackColor = false;
            Btn_EliminarPaso.Click += Btn_EliminarPaso_Click;

            // 
            // Frm_EditarReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 700);
            Controls.Add(Pnl_Body);
            Controls.Add(Pnl_Footer);
            Controls.Add(Pnl_Header);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_EditarReceta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Receta";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Footer.ResumeLayout(false);
            Pnl_Body.ResumeLayout(false);
            Grp_InfoBasica.ResumeLayout(false);
            Grp_InfoBasica.PerformLayout();
            Grp_Ingredientes.ResumeLayout(false);
            Grp_Ingredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Num_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Ingredientes).EndInit();
            Grp_Pasos.ResumeLayout(false);
            Grp_Pasos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Header;
        private Label Lbl_Subtitulo;
        private Label Lbl_Titulo;
        private Panel Pnl_Footer;
        private Button Btn_Cancelar;
        private Button Btn_Guardar;
        private Panel Pnl_Body;
        private GroupBox Grp_InfoBasica;
        private Label Lbl_Bebida;
        private TextBox Txt_Bebida;
        private Label Lbl_Categoria;
        private ComboBox Cmb_Categoria;
        private Label Lbl_Tamano;
        private ComboBox Cmb_Tamano;
        private GroupBox Grp_Ingredientes;
        private Label Lbl_SeleccionarIngrediente;
        private ComboBox Cmb_Ingredientes;
        private Label Lbl_Cantidad;
        private NumericUpDown Num_Cantidad;
        private Label Lbl_Unidad;
        private Button Btn_AgregarIngrediente;
        private DataGridView Dgv_Ingredientes;
        private DataGridViewTextBoxColumn Col_IdIngrediente;
        private DataGridViewTextBoxColumn Col_NombreIngrediente;
        private DataGridViewTextBoxColumn Col_Cant;
        private DataGridViewTextBoxColumn Col_Uni;
        private DataGridViewButtonColumn Col_EliminarIng;
        private GroupBox Grp_Pasos;
        private Label Lbl_NuevaInstruccion;
        private TextBox Txt_NuevaInstruccion;
        private Button Btn_AgregarPaso;
        private ListBox Lst_Pasos;
        private Button Btn_SubirPaso;
        private Button Btn_BajarPaso;
        private Button Btn_EliminarPaso;
    }
}
