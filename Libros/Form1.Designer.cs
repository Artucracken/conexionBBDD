
namespace Libros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_consulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_muestra = new System.Windows.Forms.DataGridView();
            this.seleccionaConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_conectar.Location = new System.Drawing.Point(12, 54);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(174, 56);
            this.btn_conectar.TabIndex = 0;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_desconectar.Location = new System.Drawing.Point(12, 116);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(174, 56);
            this.btn_desconectar.TabIndex = 1;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = false;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_consulta.Location = new System.Drawing.Point(12, 229);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(174, 51);
            this.btn_consulta.TabIndex = 2;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // txt_consulta
            // 
            this.txt_consulta.Location = new System.Drawing.Point(12, 368);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(196, 27);
            this.txt_consulta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar por:";
            // 
            // dgv_muestra
            // 
            this.dgv_muestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestra.Location = new System.Drawing.Point(214, 55);
            this.dgv_muestra.Name = "dgv_muestra";
            this.dgv_muestra.RowHeadersWidth = 51;
            this.dgv_muestra.RowTemplate.Height = 29;
            this.dgv_muestra.Size = new System.Drawing.Size(614, 340);
            this.dgv_muestra.TabIndex = 5;
            // 
            // seleccionaConsulta
            // 
            this.seleccionaConsulta.FormattingEnabled = true;
            this.seleccionaConsulta.Items.AddRange(new object[] {
            "Todo",
            "Autor",
            "Nombre Libro",
            "cantidad"});
            this.seleccionaConsulta.Location = new System.Drawing.Point(12, 315);
            this.seleccionaConsulta.Name = "seleccionaConsulta";
            this.seleccionaConsulta.Size = new System.Drawing.Size(151, 28);
            this.seleccionaConsulta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escribir busqueda:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seleccionaConsulta);
            this.Controls.Add(this.dgv_muestra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_consulta);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_conectar);
            this.Name = "Form1";
            this.Text = "Libreria Larpi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_muestra;
        private System.Windows.Forms.ComboBox seleccionaConsulta;
        private System.Windows.Forms.Label label2;
    }
}

