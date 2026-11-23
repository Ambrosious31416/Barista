namespace Barista.UI
{
    partial class Frm_Reportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Pnl_Header = new Panel();
            Lbl_Reabastecer = new Label();
            Lbl_Consumo = new Label();
            Lbl_Movimientos = new Label();
            Lbl_Subtitulo = new Label();
            Lbl_Titulo = new Label();
            Pnl_Toolbar = new Panel();
            Btn_Actualizar = new Button();
            Lbl_Periodo = new Label();
            Cmb_Periodo = new ComboBox();
            Btn_Exportar = new Button();
            Tab_Reportes = new TabControl();
            Pag_Movimientos = new TabPage();
            Dgv_Movimientos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Pag_Consumo = new TabPage();
            Dgv_Consumos = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            Pag_Reabastecimiento = new TabPage();
            Dgv_Reabastecer = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            Pnl_Header.SuspendLayout();
            Pnl_Toolbar.SuspendLayout();
            Tab_Reportes.SuspendLayout();
            Pag_Movimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Movimientos).BeginInit();
            Pag_Consumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Consumos).BeginInit();
            Pag_Reabastecimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Reabastecer).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Header
            // 
            Pnl_Header.BackColor = Color.FromArgb(43, 30, 26);
            Pnl_Header.Controls.Add(Lbl_Reabastecer);
            Pnl_Header.Controls.Add(Lbl_Consumo);
            Pnl_Header.Controls.Add(Lbl_Movimientos);
            Pnl_Header.Controls.Add(Lbl_Subtitulo);
            Pnl_Header.Controls.Add(Lbl_Titulo);
            Pnl_Header.Dock = DockStyle.Top;
            Pnl_Header.Location = new Point(0, 0);
            Pnl_Header.Name = "Pnl_Header";
            Pnl_Header.Size = new Size(984, 80);
            Pnl_Header.TabIndex = 2;
            // 
            // Lbl_Reabastecer
            // 
            Lbl_Reabastecer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Reabastecer.BackColor = Color.FromArgb(198, 40, 40);
            Lbl_Reabastecer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_Reabastecer.ForeColor = Color.White;
            Lbl_Reabastecer.Location = new Point(831, 25);
            Lbl_Reabastecer.Name = "Lbl_Reabastecer";
            Lbl_Reabastecer.Size = new Size(145, 32);
            Lbl_Reabastecer.TabIndex = 0;
            Lbl_Reabastecer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Consumo
            // 
            Lbl_Consumo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Consumo.BackColor = Color.FromArgb(30, 100, 160);
            Lbl_Consumo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_Consumo.ForeColor = Color.White;
            Lbl_Consumo.Location = new Point(676, 25);
            Lbl_Consumo.Name = "Lbl_Consumo";
            Lbl_Consumo.Size = new Size(145, 32);
            Lbl_Consumo.TabIndex = 1;
            Lbl_Consumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Movimientos
            // 
            Lbl_Movimientos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Movimientos.BackColor = Color.FromArgb(70, 55, 50);
            Lbl_Movimientos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lbl_Movimientos.ForeColor = Color.White;
            Lbl_Movimientos.Location = new Point(521, 25);
            Lbl_Movimientos.Name = "Lbl_Movimientos";
            Lbl_Movimientos.Size = new Size(145, 32);
            Lbl_Movimientos.TabIndex = 2;
            Lbl_Movimientos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(22, 45);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(500, 20);
            Lbl_Subtitulo.TabIndex = 3;
            Lbl_Subtitulo.Text = "Consumo de insumos, movimientos de inventario y reabastecimiento.";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(20, 12);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(130, 28);
            Lbl_Titulo.TabIndex = 4;
            Lbl_Titulo.Text = "📊 Reportes";
            // 
            // Pnl_Toolbar
            // 
            Pnl_Toolbar.BackColor = Color.FromArgb(240, 238, 235);
            Pnl_Toolbar.Controls.Add(Btn_Actualizar);
            Pnl_Toolbar.Controls.Add(Lbl_Periodo);
            Pnl_Toolbar.Controls.Add(Cmb_Periodo);
            Pnl_Toolbar.Controls.Add(Btn_Exportar);
            Pnl_Toolbar.Dock = DockStyle.Top;
            Pnl_Toolbar.Location = new Point(0, 80);
            Pnl_Toolbar.Name = "Pnl_Toolbar";
            Pnl_Toolbar.Size = new Size(984, 60);
            Pnl_Toolbar.TabIndex = 1;
            // 
            // Btn_Actualizar
            // 
            Btn_Actualizar.BackColor = Color.FromArgb(30, 100, 160);
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
            // Lbl_Periodo
            // 
            Lbl_Periodo.AutoSize = true;
            Lbl_Periodo.Location = new Point(185, 21);
            Lbl_Periodo.Name = "Lbl_Periodo";
            Lbl_Periodo.Size = new Size(51, 15);
            Lbl_Periodo.TabIndex = 1;
            Lbl_Periodo.Text = "Período:";
            // 
            // Cmb_Periodo
            // 
            Cmb_Periodo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Periodo.Items.AddRange(new object[] { "Todos", "Hoy", "Últimos 7 días", "Últimos 30 días" });
            Cmb_Periodo.Location = new Point(245, 17);
            Cmb_Periodo.Name = "Cmb_Periodo";
            Cmb_Periodo.Size = new Size(180, 23);
            Cmb_Periodo.TabIndex = 2;
            Cmb_Periodo.SelectedIndexChanged += Cmb_Periodo_SelectedIndexChanged;
            // 
            // Btn_Exportar
            // 
            Btn_Exportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Exportar.BackColor = Color.FromArgb(46, 125, 50);
            Btn_Exportar.FlatAppearance.BorderSize = 0;
            Btn_Exportar.FlatStyle = FlatStyle.Flat;
            Btn_Exportar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Btn_Exportar.ForeColor = Color.White;
            Btn_Exportar.Location = new Point(819, 12);
            Btn_Exportar.Name = "Btn_Exportar";
            Btn_Exportar.Size = new Size(150, 36);
            Btn_Exportar.TabIndex = 3;
            Btn_Exportar.Text = "⬇ Exportar CSV";
            Btn_Exportar.UseVisualStyleBackColor = false;
            Btn_Exportar.Click += Btn_Exportar_Click;
            // 
            // Tab_Reportes
            // 
            Tab_Reportes.Controls.Add(Pag_Movimientos);
            Tab_Reportes.Controls.Add(Pag_Consumo);
            Tab_Reportes.Controls.Add(Pag_Reabastecimiento);
            Tab_Reportes.Dock = DockStyle.Fill;
            Tab_Reportes.Location = new Point(0, 140);
            Tab_Reportes.Name = "Tab_Reportes";
            Tab_Reportes.SelectedIndex = 0;
            Tab_Reportes.Size = new Size(984, 541);
            Tab_Reportes.TabIndex = 0;
            // 
            // Pag_Movimientos
            // 
            Pag_Movimientos.Controls.Add(Dgv_Movimientos);
            Pag_Movimientos.Location = new Point(4, 24);
            Pag_Movimientos.Name = "Pag_Movimientos";
            Pag_Movimientos.Size = new Size(976, 513);
            Pag_Movimientos.TabIndex = 0;
            Pag_Movimientos.Text = "Movimientos";
            // 
            // Dgv_Movimientos
            // 
            Dgv_Movimientos.AllowUserToAddRows = false;
            Dgv_Movimientos.AllowUserToDeleteRows = false;
            Dgv_Movimientos.BackgroundColor = Color.White;
            Dgv_Movimientos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 30, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgv_Movimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv_Movimientos.ColumnHeadersHeight = 38;
            Dgv_Movimientos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(215, 200, 185);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(43, 30, 26);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Dgv_Movimientos.DefaultCellStyle = dataGridViewCellStyle2;
            Dgv_Movimientos.Dock = DockStyle.Fill;
            Dgv_Movimientos.EnableHeadersVisualStyles = false;
            Dgv_Movimientos.Location = new Point(0, 0);
            Dgv_Movimientos.MultiSelect = false;
            Dgv_Movimientos.Name = "Dgv_Movimientos";
            Dgv_Movimientos.ReadOnly = true;
            Dgv_Movimientos.RowHeadersVisible = false;
            Dgv_Movimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Movimientos.Size = new Size(976, 513);
            Dgv_Movimientos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Pag_Consumo
            // 
            Pag_Consumo.Controls.Add(Dgv_Consumos);
            Pag_Consumo.Location = new Point(4, 24);
            Pag_Consumo.Name = "Pag_Consumo";
            Pag_Consumo.Size = new Size(192, 72);
            Pag_Consumo.TabIndex = 1;
            Pag_Consumo.Text = "Consumo";
            // 
            // Dgv_Consumos
            // 
            Dgv_Consumos.AllowUserToAddRows = false;
            Dgv_Consumos.AllowUserToDeleteRows = false;
            Dgv_Consumos.BackgroundColor = Color.White;
            Dgv_Consumos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(43, 30, 26);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Dgv_Consumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Dgv_Consumos.ColumnHeadersHeight = 38;
            Dgv_Consumos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(215, 200, 185);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(43, 30, 26);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            Dgv_Consumos.DefaultCellStyle = dataGridViewCellStyle4;
            Dgv_Consumos.Dock = DockStyle.Fill;
            Dgv_Consumos.EnableHeadersVisualStyles = false;
            Dgv_Consumos.Location = new Point(0, 0);
            Dgv_Consumos.MultiSelect = false;
            Dgv_Consumos.Name = "Dgv_Consumos";
            Dgv_Consumos.ReadOnly = true;
            Dgv_Consumos.RowHeadersVisible = false;
            Dgv_Consumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Consumos.Size = new Size(192, 72);
            Dgv_Consumos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Pag_Reabastecimiento
            // 
            Pag_Reabastecimiento.Controls.Add(Dgv_Reabastecer);
            Pag_Reabastecimiento.Location = new Point(4, 24);
            Pag_Reabastecimiento.Name = "Pag_Reabastecimiento";
            Pag_Reabastecimiento.Size = new Size(192, 72);
            Pag_Reabastecimiento.TabIndex = 2;
            Pag_Reabastecimiento.Text = "Necesitan reabastecimiento";
            // 
            // Dgv_Reabastecer
            // 
            Dgv_Reabastecer.AllowUserToAddRows = false;
            Dgv_Reabastecer.AllowUserToDeleteRows = false;
            Dgv_Reabastecer.BackgroundColor = Color.White;
            Dgv_Reabastecer.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(43, 30, 26);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Dgv_Reabastecer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            Dgv_Reabastecer.ColumnHeadersHeight = 38;
            Dgv_Reabastecer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(215, 200, 185);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(43, 30, 26);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Dgv_Reabastecer.DefaultCellStyle = dataGridViewCellStyle6;
            Dgv_Reabastecer.Dock = DockStyle.Fill;
            Dgv_Reabastecer.EnableHeadersVisualStyles = false;
            Dgv_Reabastecer.Location = new Point(0, 0);
            Dgv_Reabastecer.MultiSelect = false;
            Dgv_Reabastecer.Name = "Dgv_Reabastecer";
            Dgv_Reabastecer.ReadOnly = true;
            Dgv_Reabastecer.RowHeadersVisible = false;
            Dgv_Reabastecer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Reabastecer.Size = new Size(192, 72);
            Dgv_Reabastecer.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // Frm_Reportes
            // 
            ClientSize = new Size(984, 681);
            Controls.Add(Tab_Reportes);
            Controls.Add(Pnl_Toolbar);
            Controls.Add(Pnl_Header);
            Name = "Frm_Reportes";
            Text = "Reportes";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Toolbar.ResumeLayout(false);
            Pnl_Toolbar.PerformLayout();
            Tab_Reportes.ResumeLayout(false);
            Pag_Movimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Movimientos).EndInit();
            Pag_Consumo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Consumos).EndInit();
            Pag_Reabastecimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Reabastecer).EndInit();
            ResumeLayout(false);
        }

        private Panel Pnl_Header;
        private Panel Pnl_Toolbar;
        private Label Lbl_Titulo;
        private Label Lbl_Subtitulo;
        private Label Lbl_Movimientos;
        private Label Lbl_Consumo;
        private Label Lbl_Reabastecer;
        private Label Lbl_Periodo;
        private ComboBox Cmb_Periodo;
        private Button Btn_Actualizar;
        private Button Btn_Exportar;
        private TabControl Tab_Reportes;
        private TabPage Pag_Movimientos;
        private TabPage Pag_Consumo;
        private TabPage Pag_Reabastecimiento;
        private DataGridView Dgv_Movimientos;
        private DataGridView Dgv_Consumos;
        private DataGridView Dgv_Reabastecer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}
