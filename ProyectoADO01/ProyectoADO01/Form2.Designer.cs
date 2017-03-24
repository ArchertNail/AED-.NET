namespace ProyectoADO01
{
    partial class Form2
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
            this.practica1 = new System.Windows.Forms.Button();
            this.comboAutores = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mostrarEjemplaresBtn = new System.Windows.Forms.Button();
            this.volverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // practica1
            // 
            this.practica1.Location = new System.Drawing.Point(12, 12);
            this.practica1.Name = "practica1";
            this.practica1.Size = new System.Drawing.Size(75, 23);
            this.practica1.TabIndex = 0;
            this.practica1.Text = "Practica1";
            this.practica1.UseVisualStyleBackColor = true;
            this.practica1.Click += new System.EventHandler(this.practica1_Click);
            // 
            // comboAutores
            // 
            this.comboAutores.FormattingEnabled = true;
            this.comboAutores.Location = new System.Drawing.Point(203, 14);
            this.comboAutores.Name = "comboAutores";
            this.comboAutores.Size = new System.Drawing.Size(151, 21);
            this.comboAutores.TabIndex = 1;
            this.comboAutores.SelectedIndexChanged += new System.EventHandler(this.comboAutores_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 181);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mostrarEjemplaresBtn
            // 
            this.mostrarEjemplaresBtn.Location = new System.Drawing.Point(397, 239);
            this.mostrarEjemplaresBtn.Name = "mostrarEjemplaresBtn";
            this.mostrarEjemplaresBtn.Size = new System.Drawing.Size(119, 23);
            this.mostrarEjemplaresBtn.TabIndex = 3;
            this.mostrarEjemplaresBtn.Text = "Mostrar Ejemplares";
            this.mostrarEjemplaresBtn.UseVisualStyleBackColor = true;
            this.mostrarEjemplaresBtn.Click += new System.EventHandler(this.mostrarEjemplaresBtn_Click);
            // 
            // volverMenu
            // 
            this.volverMenu.Location = new System.Drawing.Point(12, 235);
            this.volverMenu.Name = "volverMenu";
            this.volverMenu.Size = new System.Drawing.Size(87, 30);
            this.volverMenu.TabIndex = 4;
            this.volverMenu.Text = "Volver";
            this.volverMenu.UseVisualStyleBackColor = true;
            this.volverMenu.Click += new System.EventHandler(this.volverMenu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 274);
            this.Controls.Add(this.volverMenu);
            this.Controls.Add(this.mostrarEjemplaresBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboAutores);
            this.Controls.Add(this.practica1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button practica1;
        private System.Windows.Forms.ComboBox comboAutores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button mostrarEjemplaresBtn;
        private System.Windows.Forms.Button volverMenu;
    }
}