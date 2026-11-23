namespace Barista.UI
{
    partial class Frm_EntradaInventario
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
            Grp_Resultado = new GroupBox();
            Lbl_NuevoStockResultante = new Label();
            Lbl_FormulaExplicada = new Label();
            Grp_Empaque = new GroupBox();
            Cmb_UnidadPresentacion = new ComboBox();
            Lbl_UnidadPresentacion = new Label();
            Num_TamanoPorPaquete = new NumericUpDown();
            Lbl_TamanoPorPaquete = new Label();
            Num_CantidadPaquetes = new NumericUpDown();
            Lbl_CantidadPaquetes = new Label();
            Grp_Insumo = new GroupBox();
            Lbl_StockActualInfo = new Label();
            Lbl_UnidadBaseInfo = new Label();
            Lbl_InsumoNombre = new Label();
            Pnl_Header.SuspendLayout();
            Pnl_Footer.SuspendLayout();
            Pnl_Body.SuspendLayout();
            Grp_Resultado.SuspendLayout();
            Grp_Empaque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Num_TamanoPorPaquete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_CantidadPaquetes).BeginInit();
            Grp_Insumo.SuspendLayout();
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
            Pnl_Header.Size = new Size(530, 75);
            Pnl_Header.TabIndex = 0;
            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(20, 45);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(460, 15);
            Lbl_Subtitulo.Text = "Calculadora inteligente de empaques con conversión automática a la unidad del almacén.";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(18, 15);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(330, 25);
            Lbl_Titulo.Text = "📥 Entrada y Reabastecimiento";
            // 
            // Pnl_Footer
            // 
            Pnl_Footer.BackColor = Color.FromArgb(240, 238, 235);
            Pnl_Footer.Controls.Add(Btn_Cancelar);
            Pnl_Footer.Controls.Add(Btn_Guardar);
            Pnl_Footer.Dock = DockStyle.Bottom;
            Pnl_Footer.Location = new Point(0, 460);
            Pnl_Footer.Name = "Pnl_Footer";
            Pnl_Footer.Padding = new Padding(15);
            Pnl_Footer.Size = new Size(530, 60);
            Pnl_Footer.TabIndex = 2;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Cancelar.BackColor = Color.FromArgb(210, 205, 200);
            Btn_Cancelar.Cursor = Cursors.Hand;
            Btn_Cancelar.FlatAppearance.BorderSize = 0;
            Btn_Cancelar.FlatStyle = FlatStyle.Flat;
            Btn_Cancelar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Btn_Cancelar.ForeColor = Color.FromArgb(50, 50, 50);
            Btn_Cancelar.Location = new Point(220, 12);
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
            Btn_Guardar.BackColor = Color.FromArgb(46, 125, 50);
            Btn_Guardar.Cursor = Cursors.Hand;
            Btn_Guardar.FlatAppearance.BorderSize = 0;
            Btn_Guardar.FlatStyle = FlatStyle.Flat;
            Btn_Guardar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Btn_Guardar.ForeColor = Color.White;
            Btn_Guardar.Location = new Point(360, 12);
            Btn_Guardar.Name = "Btn_Guardar";
            Btn_Guardar.Size = new Size(155, 36);
            Btn_Guardar.TabIndex = 0;
            Btn_Guardar.Text = "📥 Sumar al Stock";
            Btn_Guardar.UseVisualStyleBackColor = false;
            Btn_Guardar.Click += Btn_Guardar_Click;
            // 
            // Pnl_Body
            // 
            Pnl_Body.BackColor = Color.FromArgb(248, 246, 244);
            Pnl_Body.Controls.Add(Grp_Resultado);
            Pnl_Body.Controls.Add(Grp_Empaque);
            Pnl_Body.Controls.Add(Grp_Insumo);
            Pnl_Body.Dock = DockStyle.Fill;
            Pnl_Body.Location = new Point(0, 75);
            Pnl_Body.Name = "Pnl_Body";
            Pnl_Body.Padding = new Padding(15);
            Pnl_Body.Size = new Size(530, 385);
            Pnl_Body.TabIndex = 1;
            // 
            // Grp_Resultado
            // 
            Grp_Resultado.BackColor = Color.FromArgb(240, 246, 240);
            Grp_Resultado.Controls.Add(Lbl_NuevoStockResultante);
            Grp_Resultado.Controls.Add(Lbl_FormulaExplicada);
            Grp_Resultado.Dock = DockStyle.Fill;
            Grp_Resultado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Grp_Resultado.ForeColor = Color.FromArgb(43, 30, 26);
            Grp_Resultado.Location = new Point(15, 265);
            Grp_Resultado.Name = "Grp_Resultado";
            Grp_Resultado.Padding = new Padding(10);
            Grp_Resultado.Size = new Size(500, 105);
            Grp_Resultado.TabIndex = 2;
            Grp_Resultado.TabStop = false;
            Grp_Resultado.Text = "3. Conversión Automática y Vista Previa";
            // 
            // Lbl_NuevoStockResultante
            // 
            Lbl_NuevoStockResultante.AutoSize = true;
            Lbl_NuevoStockResultante.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            Lbl_NuevoStockResultante.ForeColor = Color.FromArgb(46, 125, 50);
            Lbl_NuevoStockResultante.Location = new Point(15, 60);
            Lbl_NuevoStockResultante.Name = "Lbl_NuevoStockResultante";
            Lbl_NuevoStockResultante.Size = new Size(290, 19);
            Lbl_NuevoStockResultante.Text = "Stock Actual: 0.00 ➔ Nuevo Total: 0.00 unid.";
            // 
            // Lbl_FormulaExplicada
            // 
            Lbl_FormulaExplicada.AutoSize = true;
            Lbl_FormulaExplicada.Font = new Font("Segoe UI", 9.5F);
            Lbl_FormulaExplicada.ForeColor = Color.FromArgb(40, 40, 40);
            Lbl_FormulaExplicada.Location = new Point(15, 28);
            Lbl_FormulaExplicada.Name = "Lbl_FormulaExplicada";
            Lbl_FormulaExplicada.Size = new Size(320, 17);
            Lbl_FormulaExplicada.Text = "📦 Entrada calculada: 5 botella(s) × 1 L = 5,000.00 ml";
            // 
            // Grp_Empaque
            // 
            Grp_Empaque.Controls.Add(Cmb_UnidadPresentacion);
            Grp_Empaque.Controls.Add(Lbl_UnidadPresentacion);
            Grp_Empaque.Controls.Add(Num_TamanoPorPaquete);
            Grp_Empaque.Controls.Add(Lbl_TamanoPorPaquete);
            Grp_Empaque.Controls.Add(Num_CantidadPaquetes);
            Grp_Empaque.Controls.Add(Lbl_CantidadPaquetes);
            Grp_Empaque.Dock = DockStyle.Top;
            Grp_Empaque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Grp_Empaque.ForeColor = Color.FromArgb(43, 30, 26);
            Grp_Empaque.Location = new Point(15, 105);
            Grp_Empaque.Name = "Grp_Empaque";
            Grp_Empaque.Padding = new Padding(10);
            Grp_Empaque.Size = new Size(500, 160);
            Grp_Empaque.TabIndex = 1;
            Grp_Empaque.TabStop = false;
            Grp_Empaque.Text = "2. Detalle de la Mercancía que Llegó";
            // 
            // Cmb_UnidadPresentacion
            // 
            Cmb_UnidadPresentacion.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_UnidadPresentacion.Font = new Font("Segoe UI", 9.5F);
            Cmb_UnidadPresentacion.FormattingEnabled = true;
            Cmb_UnidadPresentacion.Location = new Point(270, 105);
            Cmb_UnidadPresentacion.Name = "Cmb_UnidadPresentacion";
            Cmb_UnidadPresentacion.Size = new Size(215, 25);
            Cmb_UnidadPresentacion.TabIndex = 5;
            Cmb_UnidadPresentacion.SelectedIndexChanged += ValoresEntrada_Changed;
            // 
            // Lbl_UnidadPresentacion
            // 
            Lbl_UnidadPresentacion.AutoSize = true;
            Lbl_UnidadPresentacion.Font = new Font("Segoe UI", 8.5F);
            Lbl_UnidadPresentacion.Location = new Point(270, 87);
            Lbl_UnidadPresentacion.Name = "Lbl_UnidadPresentacion";
            Lbl_UnidadPresentacion.Size = new Size(136, 15);
            Lbl_UnidadPresentacion.TabIndex = 4;
            Lbl_UnidadPresentacion.Text = "¿En qué medida viene?";
            // 
            // Num_TamanoPorPaquete
            // 
            Num_TamanoPorPaquete.DecimalPlaces = 2;
            Num_TamanoPorPaquete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Num_TamanoPorPaquete.Location = new Point(15, 105);
            Num_TamanoPorPaquete.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Num_TamanoPorPaquete.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            Num_TamanoPorPaquete.Name = "Num_TamanoPorPaquete";
            Num_TamanoPorPaquete.Size = new Size(230, 25);
            Num_TamanoPorPaquete.TabIndex = 3;
            Num_TamanoPorPaquete.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Num_TamanoPorPaquete.ValueChanged += ValoresEntrada_Changed;
            // 
            // Lbl_TamanoPorPaquete
            // 
            Lbl_TamanoPorPaquete.AutoSize = true;
            Lbl_TamanoPorPaquete.Font = new Font("Segoe UI", 8.5F);
            Lbl_TamanoPorPaquete.Location = new Point(15, 87);
            Lbl_TamanoPorPaquete.Name = "Lbl_TamanoPorPaquete";
            Lbl_TamanoPorPaquete.Size = new Size(225, 15);
            Lbl_TamanoPorPaquete.TabIndex = 2;
            Lbl_TamanoPorPaquete.Text = "¿De cuánto es cada producto/presentación?";
            // 
            // Num_CantidadPaquetes
            // 
            Num_CantidadPaquetes.DecimalPlaces = 2;
            Num_CantidadPaquetes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Num_CantidadPaquetes.Location = new Point(15, 48);
            Num_CantidadPaquetes.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Num_CantidadPaquetes.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            Num_CantidadPaquetes.Name = "Num_CantidadPaquetes";
            Num_CantidadPaquetes.Size = new Size(470, 25);
            Num_CantidadPaquetes.TabIndex = 1;
            Num_CantidadPaquetes.Value = new decimal(new int[] { 5, 0, 0, 0 });
            Num_CantidadPaquetes.ValueChanged += ValoresEntrada_Changed;
            // 
            // Lbl_CantidadPaquetes
            // 
            Lbl_CantidadPaquetes.AutoSize = true;
            Lbl_CantidadPaquetes.Font = new Font("Segoe UI", 8.5F);
            Lbl_CantidadPaquetes.Location = new Point(15, 28);
            Lbl_CantidadPaquetes.Name = "Lbl_CantidadPaquetes";
            Lbl_CantidadPaquetes.Size = new Size(275, 15);
            Lbl_CantidadPaquetes.TabIndex = 0;
            Lbl_CantidadPaquetes.Text = "¿Cuántos productos/botellas/cajas/bolsas llegaron?";
            // 
            // Grp_Insumo
            // 
            Grp_Insumo.Controls.Add(Lbl_StockActualInfo);
            Grp_Insumo.Controls.Add(Lbl_UnidadBaseInfo);
            Grp_Insumo.Controls.Add(Lbl_InsumoNombre);
            Grp_Insumo.Dock = DockStyle.Top;
            Grp_Insumo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Grp_Insumo.ForeColor = Color.FromArgb(43, 30, 26);
            Grp_Insumo.Location = new Point(15, 15);
            Grp_Insumo.Name = "Grp_Insumo";
            Grp_Insumo.Padding = new Padding(10);
            Grp_Insumo.Size = new Size(500, 90);
            Grp_Insumo.TabIndex = 0;
            Grp_Insumo.TabStop = false;
            Grp_Insumo.Text = "1. Insumo Seleccionado";
            // 
            // Lbl_StockActualInfo
            // 
            Lbl_StockActualInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_StockActualInfo.AutoSize = true;
            Lbl_StockActualInfo.Font = new Font("Segoe UI", 9.5F);
            Lbl_StockActualInfo.ForeColor = Color.FromArgb(70, 70, 70);
            Lbl_StockActualInfo.Location = new Point(300, 52);
            Lbl_StockActualInfo.Name = "Lbl_StockActualInfo";
            Lbl_StockActualInfo.Size = new Size(130, 17);
            Lbl_StockActualInfo.TabIndex = 2;
            Lbl_StockActualInfo.Text = "Stock Actual: 0.00 ml";
            // 
            // Lbl_UnidadBaseInfo
            // 
            Lbl_UnidadBaseInfo.AutoSize = true;
            Lbl_UnidadBaseInfo.Font = new Font("Segoe UI", 9F);
            Lbl_UnidadBaseInfo.ForeColor = Color.FromArgb(120, 100, 90);
            Lbl_UnidadBaseInfo.Location = new Point(15, 52);
            Lbl_UnidadBaseInfo.Name = "Lbl_UnidadBaseInfo";
            Lbl_UnidadBaseInfo.Size = new Size(140, 15);
            Lbl_UnidadBaseInfo.TabIndex = 1;
            Lbl_UnidadBaseInfo.Text = "Unidad base en receta: ml";
            // 
            // Lbl_InsumoNombre
            // 
            Lbl_InsumoNombre.AutoSize = true;
            Lbl_InsumoNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Lbl_InsumoNombre.ForeColor = Color.FromArgb(43, 30, 26);
            Lbl_InsumoNombre.Location = new Point(15, 23);
            Lbl_InsumoNombre.Name = "Lbl_InsumoNombre";
            Lbl_InsumoNombre.Size = new Size(150, 21);
            Lbl_InsumoNombre.Text = "Agua Purificada...";
            // 
            // Frm_EntradaInventario
            // 
            AcceptButton = Btn_Guardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btn_Cancelar;
            ClientSize = new Size(530, 520);
            Controls.Add(Pnl_Body);
            Controls.Add(Pnl_Footer);
            Controls.Add(Pnl_Header);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_EntradaInventario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Entrada de Mercancía";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Footer.ResumeLayout(false);
            Pnl_Body.ResumeLayout(false);
            Grp_Resultado.ResumeLayout(false);
            Grp_Resultado.PerformLayout();
            Grp_Empaque.ResumeLayout(false);
            Grp_Empaque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Num_TamanoPorPaquete).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_CantidadPaquetes).EndInit();
            Grp_Insumo.ResumeLayout(false);
            Grp_Insumo.PerformLayout();
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
        private GroupBox Grp_Insumo;
        private Label Lbl_StockActualInfo;
        private Label Lbl_UnidadBaseInfo;
        private Label Lbl_InsumoNombre;
        private GroupBox Grp_Empaque;
        private ComboBox Cmb_UnidadPresentacion;
        private Label Lbl_UnidadPresentacion;
        private NumericUpDown Num_TamanoPorPaquete;
        private Label Lbl_TamanoPorPaquete;
        private NumericUpDown Num_CantidadPaquetes;
        private Label Lbl_CantidadPaquetes;
        private GroupBox Grp_Resultado;
        private Label Lbl_NuevoStockResultante;
        private Label Lbl_FormulaExplicada;
    }
}
