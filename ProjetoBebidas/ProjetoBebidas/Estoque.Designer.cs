
namespace ProjetoBebidas
{
    partial class Estoque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btdAddEstoque = new System.Windows.Forms.Button();
            this.btdRmvEstoque = new System.Windows.Forms.Button();
            this.txtAddEstoque = new System.Windows.Forms.TextBox();
            this.txtRmvEstoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBebida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btdAddEstoque
            // 
            this.btdAddEstoque.Location = new System.Drawing.Point(477, 304);
            this.btdAddEstoque.Name = "btdAddEstoque";
            this.btdAddEstoque.Size = new System.Drawing.Size(104, 38);
            this.btdAddEstoque.TabIndex = 1;
            this.btdAddEstoque.Text = "Adcionar estoque";
            this.btdAddEstoque.UseVisualStyleBackColor = true;
            this.btdAddEstoque.Click += new System.EventHandler(this.btdAddEstoque_Click);
            // 
            // btdRmvEstoque
            // 
            this.btdRmvEstoque.Location = new System.Drawing.Point(477, 400);
            this.btdRmvEstoque.Name = "btdRmvEstoque";
            this.btdRmvEstoque.Size = new System.Drawing.Size(104, 38);
            this.btdRmvEstoque.TabIndex = 2;
            this.btdRmvEstoque.Text = "Remover estoque";
            this.btdRmvEstoque.UseVisualStyleBackColor = true;
            this.btdRmvEstoque.Click += new System.EventHandler(this.btdRmvEstoque_Click);
            // 
            // txtAddEstoque
            // 
            this.txtAddEstoque.Location = new System.Drawing.Point(587, 322);
            this.txtAddEstoque.Name = "txtAddEstoque";
            this.txtAddEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtAddEstoque.TabIndex = 3;
            // 
            // txtRmvEstoque
            // 
            this.txtRmvEstoque.Location = new System.Drawing.Point(587, 418);
            this.txtRmvEstoque.Name = "txtRmvEstoque";
            this.txtRmvEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtRmvEstoque.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite a quantidade: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite a quantidade: ";
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida.Location = new System.Drawing.Point(473, 242);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(176, 24);
            this.lblBebida.TabIndex = 7;
            this.lblBebida.Text = "Bebida selecionada";
            this.lblBebida.Click += new System.EventHandler(this.lblBebida_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRmvEstoque);
            this.Controls.Add(this.txtAddEstoque);
            this.Controls.Add(this.btdRmvEstoque);
            this.Controls.Add(this.btdAddEstoque);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btdAddEstoque;
        private System.Windows.Forms.Button btdRmvEstoque;
        private System.Windows.Forms.TextBox txtAddEstoque;
        private System.Windows.Forms.TextBox txtRmvEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBebida;
    }
}