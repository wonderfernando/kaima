namespace INTERFACE
{
    partial class FrmMatriculaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatriculaCadastro));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cmbTurma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnoLetovo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNmatricula = new Guna.UI2.WinForms.Guna2TextBox();
            this.Turma = new System.Windows.Forms.Label();
            this.cmbAluno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCurso = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClasse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTurno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFim = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.load = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            this.SuspendLayout();
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlTop.Controls.Add(this.lblText);
            this.pnlTop.Controls.Add(this.btnFechar);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 50);
            this.pnlTop.TabIndex = 36;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblText.ForeColor = System.Drawing.Color.LightGray;
            this.lblText.Location = new System.Drawing.Point(55, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(154, 17);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "EFETUAR MATRICULA";
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
            this.btnFechar.Location = new System.Drawing.Point(768, 2);
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
            // cmbTurma
            // 
            this.cmbTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbTurma.BorderRadius = 5;
            this.cmbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cmbTurma.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTurma.FocusedState.Parent = this.cmbTurma;
            this.cmbTurma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.HoverState.Parent = this.cmbTurma;
            this.cmbTurma.ItemHeight = 30;
            this.cmbTurma.ItemsAppearance.Parent = this.cmbTurma;
            this.cmbTurma.Location = new System.Drawing.Point(553, 181);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.ShadowDecoration.Parent = this.cmbTurma;
            this.cmbTurma.Size = new System.Drawing.Size(235, 36);
            this.cmbTurma.TabIndex = 40;
            this.cmbTurma.SelectedIndexChanged += new System.EventHandler(this.cmbTurma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ano Lectivo";
            // 
            // txtAnoLetovo
            // 
            this.txtAnoLetovo.BackColor = System.Drawing.Color.White;
            this.txtAnoLetovo.BorderRadius = 5;
            this.txtAnoLetovo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnoLetovo.DefaultText = "";
            this.txtAnoLetovo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnoLetovo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnoLetovo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnoLetovo.DisabledState.Parent = this.txtAnoLetovo;
            this.txtAnoLetovo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnoLetovo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtAnoLetovo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnoLetovo.FocusedState.Parent = this.txtAnoLetovo;
            this.txtAnoLetovo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnoLetovo.HoverState.Parent = this.txtAnoLetovo;
            this.txtAnoLetovo.Location = new System.Drawing.Point(16, 104);
            this.txtAnoLetovo.Name = "txtAnoLetovo";
            this.txtAnoLetovo.PasswordChar = '\0';
            this.txtAnoLetovo.PlaceholderText = "";
            this.txtAnoLetovo.ReadOnly = true;
            this.txtAnoLetovo.SelectedText = "";
            this.txtAnoLetovo.ShadowDecoration.Parent = this.txtAnoLetovo;
            this.txtAnoLetovo.Size = new System.Drawing.Size(177, 36);
            this.txtAnoLetovo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Numero de Matricula";
            // 
            // txtNmatricula
            // 
            this.txtNmatricula.BackColor = System.Drawing.Color.White;
            this.txtNmatricula.BorderRadius = 5;
            this.txtNmatricula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNmatricula.DefaultText = "";
            this.txtNmatricula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNmatricula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNmatricula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNmatricula.DisabledState.Parent = this.txtNmatricula;
            this.txtNmatricula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNmatricula.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtNmatricula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNmatricula.FocusedState.Parent = this.txtNmatricula;
            this.txtNmatricula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNmatricula.HoverState.Parent = this.txtNmatricula;
            this.txtNmatricula.Location = new System.Drawing.Point(16, 181);
            this.txtNmatricula.Name = "txtNmatricula";
            this.txtNmatricula.PasswordChar = '\0';
            this.txtNmatricula.PlaceholderText = "";
            this.txtNmatricula.SelectedText = "";
            this.txtNmatricula.ShadowDecoration.Parent = this.txtNmatricula;
            this.txtNmatricula.Size = new System.Drawing.Size(177, 36);
            this.txtNmatricula.TabIndex = 43;
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Turma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Turma.Location = new System.Drawing.Point(549, 158);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(54, 20);
            this.Turma.TabIndex = 45;
            this.Turma.Text = "Turma";
            // 
            // cmbAluno
            // 
            this.cmbAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbAluno.BorderRadius = 5;
            this.cmbAluno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAluno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cmbAluno.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAluno.FocusedState.Parent = this.cmbAluno;
            this.cmbAluno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.HoverState.Parent = this.cmbAluno;
            this.cmbAluno.ItemHeight = 30;
            this.cmbAluno.ItemsAppearance.Parent = this.cmbAluno;
            this.cmbAluno.Location = new System.Drawing.Point(199, 181);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.ShadowDecoration.Parent = this.cmbAluno;
            this.cmbAluno.Size = new System.Drawing.Size(295, 36);
            this.cmbAluno.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(195, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Curso";
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbCurso.BorderRadius = 5;
            this.cmbCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cmbCurso.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCurso.FocusedState.Parent = this.cmbCurso;
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.HoverState.Parent = this.cmbCurso;
            this.cmbCurso.ItemHeight = 30;
            this.cmbCurso.ItemsAppearance.Parent = this.cmbCurso;
            this.cmbCurso.Location = new System.Drawing.Point(199, 104);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.ShadowDecoration.Parent = this.cmbCurso;
            this.cmbCurso.Size = new System.Drawing.Size(337, 36);
            this.cmbCurso.TabIndex = 47;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(549, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbClasse.BorderRadius = 5;
            this.cmbClasse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cmbClasse.FocusedColor = System.Drawing.Color.Empty;
            this.cmbClasse.FocusedState.Parent = this.cmbClasse;
            this.cmbClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.HoverState.Parent = this.cmbClasse;
            this.cmbClasse.ItemHeight = 30;
            this.cmbClasse.ItemsAppearance.Parent = this.cmbClasse;
            this.cmbClasse.Location = new System.Drawing.Point(553, 104);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.ShadowDecoration.Parent = this.cmbClasse;
            this.cmbClasse.Size = new System.Drawing.Size(235, 36);
            this.cmbClasse.TabIndex = 49;
            this.cmbClasse.SelectedIndexChanged += new System.EventHandler(this.cmbClasse_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(206, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Aluno";
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
            this.guna2Button1.Location = new System.Drawing.Point(668, 376);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(105, 40);
            this.guna2Button1.TabIndex = 41;
            this.guna2Button1.Text = "Salvar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbTurno.BorderRadius = 5;
            this.cmbTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Enabled = false;
            this.cmbTurno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cmbTurno.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTurno.FocusedState.Parent = this.cmbTurno;
            this.cmbTurno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.HoverState.Parent = this.cmbTurno;
            this.cmbTurno.ItemHeight = 30;
            this.cmbTurno.ItemsAppearance.Parent = this.cmbTurno;
            this.cmbTurno.Location = new System.Drawing.Point(16, 254);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.ShadowDecoration.Parent = this.cmbTurno;
            this.cmbTurno.Size = new System.Drawing.Size(177, 36);
            this.cmbTurno.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(364, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Data da Matricula";
            // 
            // txtFim
            // 
            this.txtFim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtFim.BorderRadius = 5;
            this.txtFim.BorderThickness = 1;
            this.txtFim.CheckedState.Parent = this.txtFim;
            this.txtFim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFim.HoverState.Parent = this.txtFim;
            this.txtFim.Location = new System.Drawing.Point(368, 254);
            this.txtFim.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFim.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFim.Name = "txtFim";
            this.txtFim.ShadowDecoration.Parent = this.txtFim;
            this.txtFim.Size = new System.Drawing.Size(168, 36);
            this.txtFim.TabIndex = 56;
            this.txtFim.Value = new System.DateTime(2023, 1, 23, 2, 2, 45, 26);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(199, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Tipo de Matricula";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbTipo.BorderRadius = 5;
            this.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cmbTipo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipo.FocusedState.Parent = this.cmbTipo;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.HoverState.Parent = this.cmbTipo;
            this.cmbTipo.ItemHeight = 30;
            this.cmbTipo.Items.AddRange(new object[] {
            "Nova",
            "Confirmação",
            "Transferencia"});
            this.cmbTipo.ItemsAppearance.Parent = this.cmbTipo;
            this.cmbTipo.Location = new System.Drawing.Point(203, 254);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.ShadowDecoration.Parent = this.cmbTipo;
            this.cmbTipo.Size = new System.Drawing.Size(159, 36);
            this.cmbTipo.TabIndex = 57;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Transparent;
            this.load.Image = ((System.Drawing.Image)(resources.GetObject("load.Image")));
            this.load.Location = new System.Drawing.Point(210, 119);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(340, 242);
            this.load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.load.TabIndex = 59;
            this.load.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(12, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Total A pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderRadius = 5;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(16, 338);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(177, 36);
            this.txtTotal.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(206, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Forma de Pagamento";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "A vista",
            "TPA"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(210, 338);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(235, 36);
            this.guna2ComboBox1.TabIndex = 64;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::INTERFACE.Properties.Resources.Search_64px;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Location = new System.Drawing.Point(500, 177);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(34, 40);
            this.guna2Button2.TabIndex = 52;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FrmMatriculaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.Turma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNmatricula);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnoLetovo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatriculaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMatriculaCadastro";
            this.Load += new System.EventHandler(this.FrmMatriculaCadastro_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTurma;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAluno;
        private System.Windows.Forms.Label Turma;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNmatricula;
        private Guna.UI2.WinForms.Guna2TextBox txtAnoLetovo;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTurno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClasse;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCurso;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipo;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFim;
        private System.Windows.Forms.PictureBox load;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}