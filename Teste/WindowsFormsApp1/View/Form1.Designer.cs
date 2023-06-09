namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Txt_Categoria = new System.Windows.Forms.TextBox();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Exibir = new System.Windows.Forms.Button();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Lbn_Codigo = new System.Windows.Forms.Label();
            this.Lbn_Nome = new System.Windows.Forms.Label();
            this.Lbn_Categoria = new System.Windows.Forms.Label();
            this.Lbn_Valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(59, 72);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(311, 20);
            this.Txt_Nome.TabIndex = 2;
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(59, 124);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(84, 20);
            this.Txt_Valor.TabIndex = 4;
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.Location = new System.Drawing.Point(59, 98);
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.Size = new System.Drawing.Size(311, 20);
            this.Txt_Categoria.TabIndex = 3;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Location = new System.Drawing.Point(45, 211);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastrar.TabIndex = 5;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Location = new System.Drawing.Point(140, 211);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Atualizar.TabIndex = 6;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.Location = new System.Drawing.Point(140, 260);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Deletar.TabIndex = 8;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = true;
            this.Btn_Deletar.Click += new System.EventHandler(this.Btn_Deletar_Click);
            // 
            // Btn_Exibir
            // 
            this.Btn_Exibir.Location = new System.Drawing.Point(45, 260);
            this.Btn_Exibir.Name = "Btn_Exibir";
            this.Btn_Exibir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exibir.TabIndex = 7;
            this.Btn_Exibir.Text = "Exibir";
            this.Btn_Exibir.UseVisualStyleBackColor = true;
            this.Btn_Exibir.Click += new System.EventHandler(this.Btn_Exibir_Click);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(59, 46);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(51, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Lbn_Codigo
            // 
            this.Lbn_Codigo.AutoSize = true;
            this.Lbn_Codigo.Location = new System.Drawing.Point(1, 46);
            this.Lbn_Codigo.Name = "Lbn_Codigo";
            this.Lbn_Codigo.Size = new System.Drawing.Size(40, 13);
            this.Lbn_Codigo.TabIndex = 8;
            this.Lbn_Codigo.Text = "Código";
            // 
            // Lbn_Nome
            // 
            this.Lbn_Nome.AutoSize = true;
            this.Lbn_Nome.Location = new System.Drawing.Point(1, 75);
            this.Lbn_Nome.Name = "Lbn_Nome";
            this.Lbn_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lbn_Nome.TabIndex = 9;
            this.Lbn_Nome.Text = "Nome";
            // 
            // Lbn_Categoria
            // 
            this.Lbn_Categoria.AutoSize = true;
            this.Lbn_Categoria.Location = new System.Drawing.Point(1, 98);
            this.Lbn_Categoria.Name = "Lbn_Categoria";
            this.Lbn_Categoria.Size = new System.Drawing.Size(52, 13);
            this.Lbn_Categoria.TabIndex = 10;
            this.Lbn_Categoria.Text = "Categoria";
            // 
            // Lbn_Valor
            // 
            this.Lbn_Valor.AutoSize = true;
            this.Lbn_Valor.Location = new System.Drawing.Point(1, 124);
            this.Lbn_Valor.Name = "Lbn_Valor";
            this.Lbn_Valor.Size = new System.Drawing.Size(31, 13);
            this.Lbn_Valor.TabIndex = 11;
            this.Lbn_Valor.Text = "Valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 323);
            this.Controls.Add(this.Lbn_Valor);
            this.Controls.Add(this.Lbn_Categoria);
            this.Controls.Add(this.Lbn_Nome);
            this.Controls.Add(this.Lbn_Codigo);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Btn_Exibir);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Txt_Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.TextBox Txt_Categoria;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Exibir;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label Lbn_Codigo;
        private System.Windows.Forms.Label Lbn_Nome;
        private System.Windows.Forms.Label Lbn_Categoria;
        private System.Windows.Forms.Label Lbn_Valor;
    }
}

