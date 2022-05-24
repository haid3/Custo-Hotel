namespace Avaliacaocsharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_dias = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_consumo = new System.Windows.Forms.TextBox();
            this.lbl_consumo = new System.Windows.Forms.Label();
            this.lbl_quarto = new System.Windows.Forms.Label();
            this.lbl_valorquarto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome";
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(58, 76);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nome.TabIndex = 1;
            this.txtbox_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(370, 156);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(328, 50);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(112, 52);
            this.btn_enviar.TabIndex = 3;
            this.btn_enviar.Text = "Ok";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione seu quarto:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quarto pobre",
            "Quarto mediano",
            "Quarto de rico",
            "Quarto o$tentação"});
            this.comboBox1.Location = new System.Drawing.Point(58, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade de dias";
            // 
            // box_dias
            // 
            this.box_dias.Location = new System.Drawing.Point(59, 232);
            this.box_dias.Name = "box_dias";
            this.box_dias.Size = new System.Drawing.Size(100, 20);
            this.box_dias.TabIndex = 7;
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(191, 233);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(26, 13);
            this.lbl_dias.TabIndex = 8;
            this.lbl_dias.Text = "dias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Consumação em R$:";
            // 
            // txtbox_consumo
            // 
            this.txtbox_consumo.Location = new System.Drawing.Point(59, 324);
            this.txtbox_consumo.Name = "txtbox_consumo";
            this.txtbox_consumo.Size = new System.Drawing.Size(100, 20);
            this.txtbox_consumo.TabIndex = 10;
            // 
            // lbl_consumo
            // 
            this.lbl_consumo.AutoSize = true;
            this.lbl_consumo.Location = new System.Drawing.Point(187, 330);
            this.lbl_consumo.Name = "lbl_consumo";
            this.lbl_consumo.Size = new System.Drawing.Size(75, 13);
            this.lbl_consumo.TabIndex = 11;
            this.lbl_consumo.Text = "label consumo";
            // 
            // lbl_quarto
            // 
            this.lbl_quarto.AutoSize = true;
            this.lbl_quarto.Location = new System.Drawing.Point(218, 161);
            this.lbl_quarto.Name = "lbl_quarto";
            this.lbl_quarto.Size = new System.Drawing.Size(88, 13);
            this.lbl_quarto.TabIndex = 12;
            this.lbl_quarto.Text = "label valor quarto";
            // 
            // lbl_valorquarto
            // 
            this.lbl_valorquarto.AutoSize = true;
            this.lbl_valorquarto.Location = new System.Drawing.Point(346, 174);
            this.lbl_valorquarto.Name = "lbl_valorquarto";
            this.lbl_valorquarto.Size = new System.Drawing.Size(64, 13);
            this.lbl_valorquarto.TabIndex = 13;
            this.lbl_valorquarto.Text = "Valor quarto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 440);
            this.Controls.Add(this.lbl_valorquarto);
            this.Controls.Add(this.lbl_quarto);
            this.Controls.Add(this.lbl_consumo);
            this.Controls.Add(this.txtbox_consumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_dias);
            this.Controls.Add(this.box_dias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txtbox_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_dias;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_consumo;
        private System.Windows.Forms.Label lbl_consumo;
        private System.Windows.Forms.Label lbl_quarto;
        private System.Windows.Forms.Label lbl_valorquarto;
    }
}

