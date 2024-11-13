namespace BancoProduto
{
    partial class FormCadastro
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
            btnSalvar = new Button();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(150, 149);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(53, 62);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(222, 62);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 2;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 255);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNome;
        private TextBox txtPreco;
    }
}