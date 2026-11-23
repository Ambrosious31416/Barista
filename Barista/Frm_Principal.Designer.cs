namespace Barista
{
    partial class Frm_Principal
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
            Pnl_Sidebar = new Panel();
            Btn_Salir = new Button();
            Btn_Inventario = new Button();
            Btn_GestionRecetas = new Button();
            Btn_Catalogo = new Button();
            Btn_GuiaBarista = new Button();
            Lbl_Subtitulo = new Label();
            Lbl_Titulo = new Label();
            Pnl_Contenido = new Panel();
            Pnl_Sidebar.SuspendLayout();
            SuspendLayout();

            //
            // Pnl_Sidebar
            //
            Pnl_Sidebar.BackColor = Color.FromArgb(43, 30, 26);
            Pnl_Sidebar.Controls.Add(Btn_Salir);
            Pnl_Sidebar.Controls.Add(Btn_Inventario);
            Pnl_Sidebar.Controls.Add(Btn_GestionRecetas);
            Pnl_Sidebar.Controls.Add(Btn_Catalogo);
            Pnl_Sidebar.Controls.Add(Btn_GuiaBarista);
            Pnl_Sidebar.Controls.Add(Lbl_Subtitulo);
            Pnl_Sidebar.Controls.Add(Lbl_Titulo);
            Pnl_Sidebar.Dock = DockStyle.Left;
            Pnl_Sidebar.Location = new Point(0, 0);
            Pnl_Sidebar.Name = "Pnl_Sidebar";
            Pnl_Sidebar.Size = new Size(240, 720);
            Pnl_Sidebar.TabIndex = 0;

            //
            // Lbl_Titulo
            //
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(20, 22);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(181, 31);
            Lbl_Titulo.TabIndex = 0;
            Lbl_Titulo.Text = "☕ BARISTA";

            //
            // Lbl_Subtitulo
            //
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(22, 58);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(138, 15);
            Lbl_Subtitulo.TabIndex = 1;
            Lbl_Subtitulo.Text = "Sistema de Cafetería";

            //
            // Btn_GuiaBarista
            //
            Btn_GuiaBarista.BackColor = Color.FromArgb(43, 30, 26);
            Btn_GuiaBarista.Cursor = Cursors.Hand;
            Btn_GuiaBarista.FlatAppearance.BorderSize = 0;
            Btn_GuiaBarista.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 55, 50);
            Btn_GuiaBarista.FlatStyle = FlatStyle.Flat;
            Btn_GuiaBarista.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            Btn_GuiaBarista.ForeColor = Color.FromArgb(215, 200, 185);
            Btn_GuiaBarista.Location = new Point(10, 105);
            Btn_GuiaBarista.Name = "Btn_GuiaBarista";
            Btn_GuiaBarista.Padding = new Padding(12, 0, 0, 0);
            Btn_GuiaBarista.Size = new Size(220, 46);
            Btn_GuiaBarista.TabIndex = 2;
            Btn_GuiaBarista.Text = "📖 Guía Barista";
            Btn_GuiaBarista.TextAlign = ContentAlignment.MiddleLeft;
            Btn_GuiaBarista.UseVisualStyleBackColor = false;
            Btn_GuiaBarista.Click += Btn_GuiaBarista_Click;

            //
            // Btn_Catalogo
            //
            Btn_Catalogo.BackColor = Color.FromArgb(140, 75, 45);
            Btn_Catalogo.Cursor = Cursors.Hand;
            Btn_Catalogo.FlatAppearance.BorderSize = 0;
            Btn_Catalogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 55, 50);
            Btn_Catalogo.FlatStyle = FlatStyle.Flat;
            Btn_Catalogo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            Btn_Catalogo.ForeColor = Color.White;
            Btn_Catalogo.Location = new Point(10, 158);
            Btn_Catalogo.Name = "Btn_Catalogo";
            Btn_Catalogo.Padding = new Padding(12, 0, 0, 0);
            Btn_Catalogo.Size = new Size(220, 46);
            Btn_Catalogo.TabIndex = 3;
            Btn_Catalogo.Text = "☕ Catálogo";
            Btn_Catalogo.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Catalogo.UseVisualStyleBackColor = false;
            Btn_Catalogo.Click += Btn_Catalogo_Click;

            //
            // Btn_GestionRecetas
            //
            Btn_GestionRecetas.BackColor = Color.FromArgb(43, 30, 26);
            Btn_GestionRecetas.Cursor = Cursors.Hand;
            Btn_GestionRecetas.FlatAppearance.BorderSize = 0;
            Btn_GestionRecetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 55, 50);
            Btn_GestionRecetas.FlatStyle = FlatStyle.Flat;
            Btn_GestionRecetas.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            Btn_GestionRecetas.ForeColor = Color.FromArgb(215, 200, 185);
            Btn_GestionRecetas.Location = new Point(10, 211);
            Btn_GestionRecetas.Name = "Btn_GestionRecetas";
            Btn_GestionRecetas.Padding = new Padding(12, 0, 0, 0);
            Btn_GestionRecetas.Size = new Size(220, 46);
            Btn_GestionRecetas.TabIndex = 4;
            Btn_GestionRecetas.Text = "🛠️ Gestión de Recetas";
            Btn_GestionRecetas.TextAlign = ContentAlignment.MiddleLeft;
            Btn_GestionRecetas.UseVisualStyleBackColor = false;
            Btn_GestionRecetas.Click += Btn_GestionRecetas_Click;

            //
            // Btn_Inventario
            //
            Btn_Inventario.BackColor = Color.FromArgb(43, 30, 26);
            Btn_Inventario.Cursor = Cursors.Hand;
            Btn_Inventario.FlatAppearance.BorderSize = 0;
            Btn_Inventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 55, 50);
            Btn_Inventario.FlatStyle = FlatStyle.Flat;
            Btn_Inventario.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            Btn_Inventario.ForeColor = Color.FromArgb(215, 200, 185);
            Btn_Inventario.Location = new Point(10, 264);
            Btn_Inventario.Name = "Btn_Inventario";
            Btn_Inventario.Padding = new Padding(12, 0, 0, 0);
            Btn_Inventario.Size = new Size(220, 46);
            Btn_Inventario.TabIndex = 5;
            Btn_Inventario.Text = "📦 Inventario";
            Btn_Inventario.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Inventario.UseVisualStyleBackColor = false;
            Btn_Inventario.Click += Btn_Inventario_Click;

            //
            // Btn_Salir
            //
            Btn_Salir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Salir.BackColor = Color.FromArgb(198, 40, 40);
            Btn_Salir.Cursor = Cursors.Hand;
            Btn_Salir.FlatAppearance.BorderSize = 0;
            Btn_Salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(218, 75, 75);
            Btn_Salir.FlatStyle = FlatStyle.Flat;
            Btn_Salir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Salir.ForeColor = Color.White;
            Btn_Salir.Location = new Point(10, 662);
            Btn_Salir.Name = "Btn_Salir";
            Btn_Salir.Size = new Size(220, 42);
            Btn_Salir.TabIndex = 6;
            Btn_Salir.Text = "⏻  Salir";
            Btn_Salir.UseVisualStyleBackColor = false;
            Btn_Salir.Click += Btn_Salir_Click;

            //
            // Pnl_Contenido
            //
            Pnl_Contenido.BackColor = Color.FromArgb(248, 246, 244);
            Pnl_Contenido.Dock = DockStyle.Fill;
            Pnl_Contenido.Location = new Point(240, 0);
            Pnl_Contenido.Name = "Pnl_Contenido";
            Pnl_Contenido.Size = new Size(1040, 720);
            Pnl_Contenido.TabIndex = 1;

            //
            // Frm_Principal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 244);
            ClientSize = new Size(1280, 720);
            Controls.Add(Pnl_Contenido);
            Controls.Add(Pnl_Sidebar);
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barista Workspace - Sistema de Cafetería";
            WindowState = FormWindowState.Maximized;
            Pnl_Sidebar.ResumeLayout(false);
            Pnl_Sidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Sidebar;
        private Panel Pnl_Contenido;
        private Label Lbl_Titulo;
        private Label Lbl_Subtitulo;
        private Button Btn_GuiaBarista;
        private Button Btn_Catalogo;
        private Button Btn_GestionRecetas;
        private Button Btn_Inventario;
        private Button Btn_Salir;
    }
}
