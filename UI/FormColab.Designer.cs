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
            Nome.Location = new Point(26, 124);
            Nome.Margin = new Padding(4, 0, 4, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(61, 25);
            Nome.TabIndex = 0;
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(26, 198);
            Email.Margin = new Padding(4, 0, 4, 0);
            Email.Name = "Email";
            Email.Size = new Size(61, 25);
            Email.TabIndex = 1;
            Email.Text = "E-mail";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(209, 272);
            Senha.Margin = new Padding(4, 0, 4, 0);
            Senha.Name = "Senha";
            Senha.Size = new Size(60, 25);
            Senha.TabIndex = 2;
            Senha.Text = "Senha";
            // 
            // Agenda
            // 
            Agenda.AutoSize = true;
            Agenda.Location = new Point(26, 345);
            Agenda.Margin = new Padding(4, 0, 4, 0);
            Agenda.Name = "Agenda";
            Agenda.Size = new Size(136, 25);
            Agenda.TabIndex = 3;
            Agenda.Text = "Agenda google";
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(396, 124);
            Telefone.Margin = new Padding(4, 0, 4, 0);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(77, 25);
            Telefone.TabIndex = 4;
            Telefone.Text = "Telefone";
            // 
            // InputColabNome
            // 
            InputColabNome.Location = new Point(9, 155);
            InputColabNome.Margin = new Padding(4, 5, 4, 5);
            InputColabNome.MaxLength = 30;
            InputColabNome.Name = "InputColabNome";
            InputColabNome.Size = new Size(360, 31);
            InputColabNome.TabIndex = 1;
            // 
            // inputColabAgenda
            // 
            inputColabAgenda.Location = new Point(9, 375);
            inputColabAgenda.Margin = new Padding(4, 5, 4, 5);
            inputColabAgenda.MaxLength = 90;
            inputColabAgenda.Name = "inputColabAgenda";
            inputColabAgenda.Size = new Size(574, 31);
            inputColabAgenda.TabIndex = 7;
            // 
            // inputColabEmail
            // 
            inputColabEmail.Location = new Point(9, 228);
            inputColabEmail.Margin = new Padding(4, 5, 4, 5);
            inputColabEmail.MaxLength = 40;
            inputColabEmail.Name = "inputColabEmail";
            inputColabEmail.Size = new Size(361, 31);
            inputColabEmail.TabIndex = 2;
            // 
            // inputColabSenha
            // 
            inputColabSenha.Location = new Point(196, 302);
            inputColabSenha.Margin = new Padding(4, 5, 4, 5);
            inputColabSenha.MaxLength = 10;
            inputColabSenha.Name = "inputColabSenha";
            inputColabSenha.Size = new Size(173, 31);
            inputColabSenha.TabIndex = 5;
            inputColabSenha.UseSystemPasswordChar = true;
            // 
            // inputColabTel
            // 
            inputColabTel.Location = new Point(380, 155);
            inputColabTel.Margin = new Padding(4, 5, 4, 5);
            inputColabTel.MaxLength = 11;
            inputColabTel.Name = "inputColabTel";
            inputColabTel.Size = new Size(183, 31);
            inputColabTel.TabIndex = 4;
            // 
            // Setor
            // 
            Setor.AutoSize = true;
            Setor.Location = new Point(26, 272);
            Setor.Margin = new Padding(4, 0, 4, 0);
            Setor.Name = "Setor";
            Setor.Size = new Size(54, 25);
            Setor.TabIndex = 11;
            Setor.Text = "Setor";
            // 
            // escolherSetor
            // 
            escolherSetor.FormattingEnabled = true;
            escolherSetor.Items.AddRange(new object[] { "Engenharia", "Criação", "Administração", "Marketing", "Ligação", "TI" });
            escolherSetor.Location = new Point(9, 302);
            escolherSetor.Margin = new Padding(4, 5, 4, 5);
            escolherSetor.Name = "escolherSetor";
            escolherSetor.Size = new Size(177, 33);
            escolherSetor.TabIndex = 3;
            // 
            // HeaderCadColab
            // 
            HeaderCadColab.BackColor = Color.DarkGreen;
            HeaderCadColab.Controls.Add(label1);
            HeaderCadColab.Dock = DockStyle.Top;
            HeaderCadColab.Location = new Point(0, 0);
            HeaderCadColab.Margin = new Padding(4, 5, 4, 5);
            HeaderCadColab.Name = "HeaderCadColab";
            HeaderCadColab.Size = new Size(594, 83);
            HeaderCadColab.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(154, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Colaborador";
            // 
            // check_ativo
            // 
            check_ativo.AutoSize = true;
            check_ativo.Location = new Point(380, 228);
            check_ativo.Margin = new Padding(4, 5, 4, 5);
            check_ativo.Name = "check_ativo";
            check_ativo.Size = new Size(80, 29);
            check_ativo.TabIndex = 6;
            check_ativo.Text = "Ativo";
            check_ativo.UseVisualStyleBackColor = true;
            // 
            // btn_selectEquips
            // 
            btn_selectEquips.BackColor = Color.DarkGreen;
            btn_selectEquips.Dock = DockStyle.Right;
            btn_selectEquips.ForeColor = Color.White;
            btn_selectEquips.Location = new Point(365, 10);
            btn_selectEquips.Margin = new Padding(4, 5, 4, 5);
            btn_selectEquips.Name = "btn_selectEquips";
            btn_selectEquips.Size = new Size(220, 73);
            btn_selectEquips.TabIndex = 17;
            btn_selectEquips.Text = "Selecionar equipamentos";
            btn_selectEquips.UseVisualStyleBackColor = false;
            btn_selectEquips.Click += btn_selectEquips_Click;
            // 
            // btnCancelarCad
            // 
            btnCancelarCad.BackColor = Color.DarkGreen;
            btnCancelarCad.Dock = DockStyle.Left;
            btnCancelarCad.ForeColor = SystemColors.Control;
            btnCancelarCad.Location = new Point(9, 10);
            btnCancelarCad.Margin = new Padding(4, 5, 4, 5);
            btnCancelarCad.Name = "btnCancelarCad";
            btnCancelarCad.Size = new Size(214, 73);
            btnCancelarCad.TabIndex = 15;
            btnCancelarCad.Text = "Cancelar";
            btnCancelarCad.UseVisualStyleBackColor = false;
            btnCancelarCad.Click += btnCancelarCad_Click;
            // 
            // FotterCadColab
            // 
            FotterCadColab.Controls.Add(btn_selectEquips);
            FotterCadColab.Controls.Add(btnCancelarCad);
            FotterCadColab.Dock = DockStyle.Bottom;
            FotterCadColab.Location = new Point(0, 434);
            FotterCadColab.Margin = new Padding(4, 5, 4, 5);
            FotterCadColab.Name = "FotterCadColab";
            FotterCadColab.Padding = new Padding(9, 10, 9, 10);
            FotterCadColab.Size = new Size(594, 93);
            FotterCadColab.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 17;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 201);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 18;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 19;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(196, 274);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 20;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(380, 126);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 21;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(9, 347);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 22;
            label7.Text = "*";
            // 
            // CadColaborador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 527);
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
            Margin = new Padding(4, 5, 4, 5);
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