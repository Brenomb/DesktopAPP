namespace BancoEndereco
{
    partial class frmUser
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
            components = new System.ComponentModel.Container();
            bsUser = new BindingSource(components);
            btnSalvar = new Button();
            btnCanc = new Button();
            label1 = new Label();
            Nome = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)bsUser).BeginInit();
            SuspendLayout();
            // 
            // bsUser
            // 
            bsUser.DataSource = typeof(BLL.Agenda);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(24, 275);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCanc
            // 
            btnCanc.Location = new Point(124, 275);
            btnCanc.Name = "btnCanc";
            btnCanc.Size = new Size(94, 29);
            btnCanc.TabIndex = 1;
            btnCanc.Text = "Cancelar";
            btnCanc.UseVisualStyleBackColor = true;
            btnCanc.Click += btnCanc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Cadastro";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(24, 57);
            Nome.Name = "Nome";
            Nome.Size = new Size(50, 20);
            Nome.TabIndex = 3;
            Nome.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 132);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "CEP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 207);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(24, 231);
            maskedTextBox1.Mask = "(00) 00000 - 0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(194, 27);
            maskedTextBox1.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(24, 155);
            maskedTextBox2.Mask = "00000 - 000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(194, 27);
            maskedTextBox2.TabIndex = 10;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 338);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(label1);
            Controls.Add(btnCanc);
            Controls.Add(btnSalvar);
            Name = "frmUser";
            Text = "Cadastro";
            Load += frmUser_Load;
            ((System.ComponentModel.ISupportInitialize)bsUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsUser;
        private Button btnSalvar;
        private Button btnCanc;
        private Label label1;
        private Label Nome;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
    }
}