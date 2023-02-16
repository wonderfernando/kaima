namespace INTERFACE.GestaoAcademica
{
    partial class FrmCursoCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursoCadastrar));
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFormaca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtMensalidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome Curso";
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.Color.White;
            this.txtCurso.BorderRadius = 5;
            this.txtCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurso.DefaultText = "";
            this.txtCurso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurso.DisabledState.Parent = this.txtCurso;
            this.txtCurso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtCurso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurso.FocusedState.Parent = this.txtCurso;
            this.txtCurso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurso.HoverState.Parent = this.txtCurso;
            this.txtCurso.Location = new System.Drawing.Point(37, 109);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.PasswordChar = '\0';
            this.txtCurso.PlaceholderText = "";
            this.txtCurso.SelectedText = "";
            this.txtCurso.ShadowDecoration.Parent = this.txtCurso;
            this.txtCurso.Size = new System.Drawing.Size(313, 36);
            this.txtCurso.TabIndex = 14;
            this.txtCurso.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(412, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Area Formação";
            // 
            // comboFormaca
            // 
            this.comboFormaca.BackColor = System.Drawing.Color.Transparent;
            this.comboFormaca.BorderRadius = 5;
            this.comboFormaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFormaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormaca.FocusedColor = System.Drawing.Color.Empty;
            this.comboFormaca.FocusedState.Parent = this.comboFormaca;
            this.comboFormaca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFormaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFormaca.FormattingEnabled = true;
            this.comboFormaca.HoverState.Parent = this.comboFormaca;
            this.comboFormaca.ItemHeight = 30;
            this.comboFormaca.Items.AddRange(new object[] {
            "Informatica",
            "Quimica",
            "Mecanica"});
            this.comboFormaca.ItemsAppearance.Parent = this.comboFormaca;
            this.comboFormaca.Location = new System.Drawing.Point(415, 109);
            this.comboFormaca.Name = "comboFormaca";
            this.comboFormaca.ShadowDecoration.Parent = this.comboFormaca;
            this.comboFormaca.Size = new System.Drawing.Size(310, 36);
            this.comboFormaca.TabIndex = 21;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlTop.Controls.Add(this.lblText);
            this.pnlTop.Controls.Add(this.btnFechar);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(749, 50);
            this.pnlTop.TabIndex = 24;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblText.ForeColor = System.Drawing.Color.LightGray;
            this.lblText.Location = new System.Drawing.Point(55, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(145, 17);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "CADASTRAR CURSO";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(133)))), ((int)(((byte)(9)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(620, 309);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(105, 40);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Salvar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnlTop;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(35, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mensalidade";
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.BackColor = System.Drawing.Color.White;
            this.txtMensalidade.BorderRadius = 5;
            this.txtMensalidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensalidade.DefaultText = "";
            this.txtMensalidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMensalidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMensalidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMensalidade.DisabledState.Parent = this.txtMensalidade;
            this.txtMensalidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMensalidade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtMensalidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMensalidade.FocusedState.Parent = this.txtMensalidade;
            this.txtMensalidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMensalidade.HoverState.Parent = this.txtMensalidade;
            this.txtMensalidade.Location = new System.Drawing.Point(39, 200);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.PasswordChar = '\0';
            this.txtMensalidade.PlaceholderText = "";
            this.txtMensalidade.SelectedText = "";
            this.txtMensalidade.ShadowDecoration.Parent = this.txtMensalidade;
            this.txtMensalidade.Size = new System.Drawing.Size(311, 36);
            this.txtMensalidade.TabIndex = 29;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.CheckedState.Parent = this.btnFechar;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.CustomImages.Parent = this.btnFechar;
            this.btnFechar.FillColor = System.Drawing.Color.Transparent;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            this.btnFechar.HoverState.Parent = this.btnFechar;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(717, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.ShadowDecoration.Parent = this.btnFechar;
            this.btnFechar.Size = new System.Drawing.Size(29, 47);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::INTERFACE.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-54, -64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCursoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.comboFormaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCursoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "p";
            this.Load += new System.EventHandler(this.FrmCursoCadastrar_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCurso;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboFormaca;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMensalidade;
    }
}