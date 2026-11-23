namespace Barista.UI
{
    partial class Frm_EditarIngredienteAdmin
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
            Pnl_Body = new Panel();
            Btn_Cancelar = new Button();
            Btn_Guardar = new Button();
            Num_StockMinimo = new NumericUpDown();
            Lbl_StockMinimo = new Label();
            Num_StockActual = new NumericUpDown();
            Lbl_StockActual = new Label();
            Cmb_Unidad = new ComboBox();
            Lbl_Unidad = new Label();
            Txt_Nombre = new TextBox();
            Lbl_Nombre = new Label();
            Pnl_Header.SuspendLayout();
            Pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Num_StockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_StockActual).BeginInit();
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
            Pnl_Header.Size = new Size(460, 75);
            Pnl_Header.TabIndex = 0;
            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(20, 45);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(390, 15);
            Lbl_Subtitulo.Text = "Modificación directa de cantidades de almacén y parámetros del insumo.";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(18, 15);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(375, 25);
            Lbl_Titulo.Text = "✏️ Modificar / Ajustar Insumo (Admin)";
            // 
            // Pnl_Body
            // 
            Pnl_Body.BackColor = Color.FromArgb(248, 246, 244);
            Pnl_Body.Controls.Add(Btn_Cancelar);
            Pnl_Body.Controls.Add(Btn_Guardar);
            Pnl_Body.Controls.Add(Num_StockMinimo);
            Pnl_Body.Controls.Add(Lbl_StockMinimo);
            Pnl_Body.Controls.Add(Num_StockActual);
            Pnl_Body.Controls.Add(Lbl_StockActual);
            Pnl_Body.Controls.Add(Cmb_Unidad);
            Pnl_Body.Controls.Add(Lbl_Unidad);
            Pnl_Body.Controls.Add(Txt_Nombre);
            Pnl_Body.Controls.Add(Lbl_Nombre);
            Pnl_Body.Dock = DockStyle.Fill;
            Pnl_Body.Location = new Point(0, 75);
            Pnl_Body.Name = "Pnl_Body";
            Pnl_Body.Padding = new Padding(25);
            Pnl_Body.Size = new Size(460, 285);
            Pnl_Body.TabIndex = 1;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.BackColor = Color.FromArgb(210, 205, 200);
            Btn_Cancelar.Cursor = Cursors.Hand;
            Btn_Cancelar.FlatAppearance.BorderSize = 0;
            Btn_Cancelar.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Btn_Cancelar.ForeColor = Color.FromArgb(50, 50, 50);
            Btn_Cancelar.Location = new Point(25, 225);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(185, 36);
            Btn_Cancelar.TabIndex = 9;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = false;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // Btn_Guardar
            // 
            Btn_Guardar.BackColor = Color.FromArgb(140, 75, 45);
            Btn_Guardar.Cursor = Cursors.Hand;
            Btn_Guardar.FlatAppearance.BorderSize = 0;
            Btn_Guardar.FlatStyle = FlatStyle.Flat;
            Btn_Guardar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Btn_Guardar.ForeColor = Color.White;
            Btn_Guardar.Location = new Point(230, 225);
            Btn_Guardar.Name = "Btn_Guardar";
            Btn_Guardar.Size = new Size(205, 36);
            Btn_Guardar.TabIndex = 8;
            Btn_Guardar.Text = "💾 Guardar Ajustes";
            Btn_Guardar.UseVisualStyleBackColor = false;
            Btn_Guardar.Click += Btn_Guardar_Click;
            // 
            // Num_StockMinimo
            // 
            Num_StockMinimo.DecimalPlaces = 2;
            Num_StockMinimo.Font = new Font("Segoe UI", 10F);
            Num_StockMinimo.Location = new Point(230, 160);
            Num_StockMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Num_StockMinimo.Name = "Num_StockMinimo";
            Num_StockMinimo.Size = new Size(205, 25);
            Num_StockMinimo.TabIndex = 7;
            // 
            // Lbl_StockMinimo
            // 
            Lbl_StockMinimo.AutoSize = true;
            Lbl_StockMinimo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_StockMinimo.Location = new Point(230, 140);
            Lbl_StockMinimo.Name = "Lbl_StockMinimo";
            Lbl_StockMinimo.Size = new Size(130, 15);
            Lbl_StockMinimo.TabIndex = 6;
            Lbl_StockMinimo.Text = "Stock Mínimo (Alerta):";
            // 
            // Num_StockActual
            // 
            Num_StockActual.DecimalPlaces = 2;
            Num_StockActual.Font = new Font("Segoe UI", 10F);
            Num_StockActual.Location = new Point(25, 160);
            Num_StockActual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Num_StockActual.Name = "Num_StockActual";
            Num_StockActual.Size = new Size(185, 25);
            Num_StockActual.TabIndex = 5;
            // 
            // Lbl_StockActual
            // 
            Lbl_StockActual.AutoSize = true;
            Lbl_StockActual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_StockActual.Location = new Point(25, 140);
            Lbl_StockActual.Name = "Lbl_StockActual";
            Lbl_StockActual.Size = new Size(122, 15);
            Lbl_StockActual.TabIndex = 4;
            Lbl_StockActual.Text = "Stock Físico / Actual:";
            // 
            // Cmb_Unidad
            // 
            Cmb_Unidad.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Unidad.Font = new Font("Segoe UI", 10F);
            Cmb_Unidad.FormattingEnabled = true;
            Cmb_Unidad.Items.AddRange(new object[] { "g", "ml", "pza", "oz", "kg", "L" });
            Cmb_Unidad.Location = new Point(25, 95);
            Cmb_Unidad.Name = "Cmb_Unidad";
            Cmb_Unidad.Size = new Size(410, 25);
            Cmb_Unidad.TabIndex = 3;
            // 
            // Lbl_Unidad
            // 
            Lbl_Unidad.AutoSize = true;
            Lbl_Unidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Unidad.Location = new Point(25, 75);
            Lbl_Unidad.Name = "Lbl_Unidad";
            Lbl_Unidad.Size = new Size(111, 15);
            Lbl_Unidad.TabIndex = 2;
            Lbl_Unidad.Text = "Unidad de Medida:";
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.Font = new Font("Segoe UI", 10.5F);
            Txt_Nombre.Location = new Point(25, 38);
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.Size = new Size(410, 26);
            Txt_Nombre.TabIndex = 1;
            // 
            // Lbl_Nombre
            // 
            Lbl_Nombre.AutoSize = true;
            Lbl_Nombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Nombre.Location = new Point(25, 18);
            Lbl_Nombre.Name = "Lbl_Nombre";
            Lbl_Nombre.Size = new Size(117, 15);
            Lbl_Nombre.TabIndex = 0;
            Lbl_Nombre.Text = "Nombre del Insumo:";
            // 
            // Frm_EditarIngredienteAdmin
            // 
            AcceptButton = Btn_Guardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btn_Cancelar;
            ClientSize = new Size(460, 360);
            Controls.Add(Pnl_Body);
            Controls.Add(Pnl_Header);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_EditarIngredienteAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar Insumo (Administrador)";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Body.ResumeLayout(false);
            Pnl_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Num_StockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_StockActual).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Header;
        private Label Lbl_Subtitulo;
        private Label Lbl_Titulo;
        private Panel Pnl_Body;
        private Button Btn_Cancelar;
        private Button Btn_Guardar;
        private NumericUpDown Num_StockMinimo;
        private Label Lbl_StockMinimo;
        private NumericUpDown Num_StockActual;
        private Label Lbl_StockActual;
        private ComboBox Cmb_Unidad;
        private Label Lbl_Unidad;
        private TextBox Txt_Nombre;
        private Label Lbl_Nombre;
    }
}
