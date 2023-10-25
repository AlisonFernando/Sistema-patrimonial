namespace UI
{
    partial class CadColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadColaborador));
            Nome = new Label();
            Email = new Label();
            Senha = new Label();
            Agenda = new Label();
            Telefone = new Label();
            InputColabNome = new TextBox();
            inputColabAgenda = new TextBox();
            inputColabEmail = new TextBox();
            inputColabSenha = new TextBox();
            inputColabTel = new TextBox();
            Setor = new Label();
            escolherSetor = new ComboBox();
            HeaderCadColab = new Panel();
            label1 = new Label();
            check_ativo = new CheckBox();
            btn_selectEquips = new Button();
            btnCancelarCad = new Button();
            FotterCadColab = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            HeaderCadColab.SuspendLayout();
            FotterCadColab.SuspendLayout();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(98, 67);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 99;
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(98, 111);
            Email.Name = "Email";
            Email.Size = new Size(41, 15);
            Email.TabIndex = 98;
            Email.Text = "E-mail";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(97, 156);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 97;
            Senha.Text = "Senha";
            // 
            // Agenda
            // 
            Agenda.AutoSize = true;
            Agenda.Location = new Point(18, 303);
            Agenda.Name = "Agenda";
            Agenda.Size = new Size(88, 15);
            Agenda.TabIndex = 94;
            Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(100, 200);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 96;
            Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            InputColabNome.Location = new Point(86, 85);
            InputColabNome.MaxLength = 30;
            InputColabNome.Name = "InputColabNome";
            InputColabNome.Size = new Size(253, 23);
            InputColabNome.TabIndex = 1;
            // 
            // inputColabAgenda
            // 
            inputColabAgenda.Location = new Point(6, 321);
            inputColabAgenda.MaxLength = 90;
            inputColabAgenda.Name = "inputColabAgenda";
            inputColabAgenda.Size = new Size(403, 23);
            inputColabAgenda.TabIndex = 6;
            // 
            // inputColabEmail
            // 
            inputColabEmail.Location = new Point(86, 129);
            inputColabEmail.MaxLength = 100;
            inputColabEmail.Name = "inputColabEmail";
            inputColabEmail.Size = new Size(254, 23);
            inputColabEmail.TabIndex = 2;
            // 
            // inputColabSenha
            // 
            inputColabSenha.Location = new Point(86, 174);
            inputColabSenha.MaxLength = 100;
            inputColabSenha.Name = "inputColabSenha";
            inputColabSenha.Size = new Size(251, 23);
            inputColabSenha.TabIndex = 3;
            inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            inputColabTel.Location = new Point(86, 229);
            inputColabTel.MaxLength = 11;
            inputColabTel.Name = "inputColabTel";
            inputColabTel.Size = new Size(129, 23);
            inputColabTel.TabIndex = 4;
            inputColabTel.TextChanged += inputColabTel_TextChanged;
            // 
            // Setor
            // 
            Setor.AutoSize = true;
            Setor.Location = new Point(100, 255);
            Setor.Name = "Setor";
            Setor.Size = new Size(34, 15);
            Setor.TabIndex = 95;
            Setor.Text = "Setor";
            // 
            // escolherSetor
            // 
            escolherSetor.FormattingEnabled = true;
            escolherSetor.Items.AddRange(new object[] { "Engenharia", "Criação", "Administração", "Marketing", "Ligação", "TI" });
            escolherSetor.Location = new Point(86, 273);
            escolherSetor.MaxDropDownItems = 5;
            escolherSetor.Name = "escolherSetor";
            escolherSetor.Size = new Size(125, 23);
            escolherSetor.TabIndex = 5;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(416, 50);
            HeaderCadColab.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(90, 11);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 91;
            label1.Text = "Cadastrar Colaborador";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(8, 346);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(54, 19);
            check_ativo.TabIndex = 7;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // btn_selectEquips
            // 
            btn_selectEquips.BackColor = Color.DarkGreen;
            btn_selectEquips.Dock = DockStyle.Right;
            btn_selectEquips.ForeColor = Color.White;
            btn_selectEquips.Location = new Point(256, 6);
            btn_selectEquips.Name = "btn_selectEquips";
            btn_selectEquips.Size = new Size(154, 44);
            btn_selectEquips.TabIndex = 7;
            btn_selectEquips.Text = "Selecionar equipamentos";
            btn_selectEquips.UseVisualStyleBackColor = false;
            btn_selectEquips.Click += btn_selectEquips_Click;
            // 
            // btnCancelarCad
            // 
            btnCancelarCad.BackColor = Color.DarkGreen;
            btnCancelarCad.Dock = DockStyle.Left;
            btnCancelarCad.ForeColor = SystemColors.Control;
            btnCancelarCad.Location = new Point(6, 6);
            btnCancelarCad.Name = "btnCancelarCad";
            btnCancelarCad.Size = new Size(150, 44);
            btnCancelarCad.TabIndex = 8;
            btnCancelarCad.Text = "Cancelar";
            btnCancelarCad.UseVisualStyleBackColor = false;
            btnCancelarCad.Click += btnCancelarCad_Click;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btn_selectEquips);
            FotterCadColab.Controls.Add(btnCancelarCad);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 400);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(6, 6, 6, 6);
            FotterCadColab.Size = new Size(416, 56);
            FotterCadColab.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(88, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 17;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(88, 113);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 18;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(90, 256);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 19;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(88, 157);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 20;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(89, 202);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 21;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(6, 303);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 22;
            label7.Text = "*";
            // 
            // CadColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 456);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(check_ativo);
            Controls.Add(HeaderCadColab);
            Controls.Add(FotterCadColab);
            Controls.Add(escolherSetor);
            Controls.Add(Setor);
            Controls.Add(inputColabTel);
            Controls.Add(inputColabSenha);
            Controls.Add(inputColabEmail);
            Controls.Add(inputColabAgenda);
            Controls.Add(InputColabNome);
            Controls.Add(Telefone);
            Controls.Add(Agenda);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(Nome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Colaborador";
            Load += CadColaborador_Load;
            HeaderCadColab.ResumeLayout(false);
            HeaderCadColab.PerformLayout();
            FotterCadColab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label Email;
        private Label Senha;
        private Label Agenda;
        private Label Telefone;
        private TextBox InputColabNome;
        private TextBox inputColabAgenda;
        private TextBox inputColabEmail;
        private TextBox inputColabSenha;
        private TextBox inputColabTel;
        private Label Setor;
        private ComboBox escolherSetor;
        private Panel HeaderCadColab;
        private CheckBox check_ativo;
        private Label label1;
        private Button btn_selectEquips;
        private Button btnCancelarCad;
        private Panel FotterCadColab;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}