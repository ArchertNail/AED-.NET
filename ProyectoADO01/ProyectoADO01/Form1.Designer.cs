namespace ProyectoADO01
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.onActualizar = new System.Windows.Forms.Button();
            this.labelAutores = new System.Windows.Forms.Label();
            this.labelEjemplares = new System.Windows.Forms.Label();
            this.onPractica2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(384, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // onActualizar
            // 
            this.onActualizar.Location = new System.Drawing.Point(209, 242);
            this.onActualizar.Name = "onActualizar";
            this.onActualizar.Size = new System.Drawing.Size(75, 23);
            this.onActualizar.TabIndex = 2;
            this.onActualizar.Text = "Guardar";
            this.onActualizar.UseVisualStyleBackColor = true;
            this.onActualizar.Click += new System.EventHandler(this.onActualizar_Click);
            // 
            // labelAutores
            // 
            this.labelAutores.AutoSize = true;
            this.labelAutores.Location = new System.Drawing.Point(80, 193);
            this.labelAutores.Name = "labelAutores";
            this.labelAutores.Size = new System.Drawing.Size(35, 13);
            this.labelAutores.TabIndex = 3;
            this.labelAutores.Text = "label1";
            // 
            // labelEjemplares
            // 
            this.labelEjemplares.AutoSize = true;
            this.labelEjemplares.Location = new System.Drawing.Point(475, 193);
            this.labelEjemplares.Name = "labelEjemplares";
            this.labelEjemplares.Size = new System.Drawing.Size(35, 13);
            this.labelEjemplares.TabIndex = 4;
            this.labelEjemplares.Text = "label2";
            // 
            // onPractica2
            // 
            this.onPractica2.Location = new System.Drawing.Point(708, 222);
            this.onPractica2.Name = "onPractica2";
            this.onPractica2.Size = new System.Drawing.Size(75, 63);
            this.onPractica2.TabIndex = 5;
            this.onPractica2.Text = "Menu";
            this.onPractica2.UseVisualStyleBackColor = true;
            this.onPractica2.Click += new System.EventHandler(this.onPractica2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 292);
            this.Controls.Add(this.onPractica2);
            this.Controls.Add(this.labelEjemplares);
            this.Controls.Add(this.labelAutores);
            this.Controls.Add(this.onActualizar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button onActualizar;
        private System.Windows.Forms.Label labelAutores;
        private System.Windows.Forms.Label labelEjemplares;
        private System.Windows.Forms.Button onPractica2;
    }
}

