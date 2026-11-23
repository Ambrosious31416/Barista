namespace Barista.UI
{
    partial class Frm_Autorizacion
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
            Btn_Autorizar = new Button();
            Txt_Password = new TextBox();
            Lbl_Password = new Label();
            Txt_Usuario = new TextBox();
            Lbl_Usuario = new Label();
            Pnl_Header.SuspendLayout();
            Pnl_Body.SuspendLayout();
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
            Pnl_Header.Size = new Size(420, 75);
            Pnl_Header.TabIndex = 0;
            // 
            // Lbl_Subtitulo
            // 
            Lbl_Subtitulo.AutoSize = true;
            Lbl_Subtitulo.Font = new Font("Segoe UI", 9F);
            Lbl_Subtitulo.ForeColor = Color.FromArgb(215, 200, 185);
            Lbl_Subtitulo.Location = new Point(20, 45);
            Lbl_Subtitulo.Name = "Lbl_Subtitulo";
            Lbl_Subtitulo.Size = new Size(355, 15);
            Lbl_Subtitulo.Text = "Se requieren credenciales con permiso para modificar las recetas.";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Lbl_Titulo.ForeColor = Color.FromArgb(245, 230, 211);
            Lbl_Titulo.Location = new Point(18, 15);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(230, 25);
            Lbl_Titulo.Text = "🔒 Autorización Requerida";
            // 
            // Pnl_Body
            // 
            Pnl_Body.BackColor = Color.FromArgb(248, 246, 244);
            Pnl_Body.Controls.Add(Btn_Cancelar);
            Pnl_Body.Controls.Add(Btn_Autorizar);
            Pnl_Body.Controls.Add(Txt_Password);
            Pnl_Body.Controls.Add(Lbl_Password);
            Pnl_Body.Controls.Add(Txt_Usuario);
            Pnl_Body.Controls.Add(Lbl_Usuario);
            Pnl_Body.Dock = DockStyle.Fill;
            Pnl_Body.Location = new Point(0, 75);
            Pnl_Body.Name = "Pnl_Body";
            Pnl_Body.Padding = new Padding(25);
            Pnl_Body.Size = new Size(420, 205);
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
            Btn_Cancelar.Location = new Point(25, 145);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(170, 36);
            Btn_Cancelar.TabIndex = 5;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = false;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // Btn_Autorizar
            // 
            Btn_Autorizar.BackColor = Color.FromArgb(140, 75, 45);
            Btn_Autorizar.Cursor = Cursors.Hand;
            Btn_Autorizar.FlatAppearance.BorderSize = 0;
            Btn_Autorizar.FlatStyle = FlatStyle.Flat;
            Btn_Autorizar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Btn_Autorizar.ForeColor = Color.White;
            Btn_Autorizar.Location = new Point(215, 145);
            Btn_Autorizar.Name = "Btn_Autorizar";
            Btn_Autorizar.Size = new Size(180, 36);
            Btn_Autorizar.TabIndex = 4;
            Btn_Autorizar.Text = "Verificar y Autorizar";
            Btn_Autorizar.UseVisualStyleBackColor = false;
            Btn_Autorizar.Click += Btn_Autorizar_Click;
            // 
            // Txt_Password
            // 
            Txt_Password.Font = new Font("Segoe UI", 10.5F);
            Txt_Password.Location = new Point(25, 95);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PasswordChar = '●';
            Txt_Password.Size = new Size(370, 26);
            Txt_Password.TabIndex = 3;
            Txt_Password.KeyDown += Txt_Password_KeyDown;
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Password.Location = new Point(25, 75);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(70, 15);
            Lbl_Password.TabIndex = 2;
            Lbl_Password.Text = "Contraseña:";
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.Font = new Font("Segoe UI", 10.5F);
            Txt_Usuario.Location = new Point(25, 40);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(370, 26);
            Txt_Usuario.TabIndex = 1;
            Txt_Usuario.Text = "Administrador";
            // 
            // Lbl_Usuario
            // 
            Lbl_Usuario.AutoSize = true;
            Lbl_Usuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Lbl_Usuario.Location = new Point(25, 20);
            Lbl_Usuario.Name = "Lbl_Usuario";
            Lbl_Usuario.Size = new Size(107, 15);
            Lbl_Usuario.TabIndex = 0;
            Lbl_Usuario.Text = "Usuario Encargado:";
            // 
            // Frm_Autorizacion
            // 
            AcceptButton = Btn_Autorizar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btn_Cancelar;
            ClientSize = new Size(420, 280);
            Controls.Add(Pnl_Body);
            Controls.Add(Pnl_Header);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Autorizacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Autorización de Seguridad";
            Pnl_Header.ResumeLayout(false);
            Pnl_Header.PerformLayout();
            Pnl_Body.ResumeLayout(false);
            Pnl_Body.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Header;
        private Label Lbl_Subtitulo;
        private Label Lbl_Titulo;
        private Panel Pnl_Body;
        private Button Btn_Cancelar;
        private Button Btn_Autorizar;
        private TextBox Txt_Password;
        private Label Lbl_Password;
        private TextBox Txt_Usuario;
        private Label Lbl_Usuario;
    }
}
