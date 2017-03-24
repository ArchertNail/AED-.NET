namespace ProyectoADO01
{
    partial class Practica04
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
            this.IrMenu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codAutorField = new System.Windows.Forms.TextBox();
            this.isbnField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listarbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreAutorText = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.autoresCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numLibrosBtn = new System.Windows.Forms.Button();
            this.isbnCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IrMenu
            // 
            this.IrMenu.Location = new System.Drawing.Point(16, 340);
            this.IrMenu.Name = "IrMenu";
            this.IrMenu.Size = new System.Drawing.Size(95, 34);
            this.IrMenu.TabIndex = 0;
            this.IrMenu.Text = "Menu";
            this.IrMenu.UseVisualStyleBackColor = true;
            this.IrMenu.Click += new System.EventHandler(this.IrMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 322);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.isbnField);
            this.tabPage1.Controls.Add(this.codAutorField);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proceso01";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nombreAutorText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.listarbtn);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proceso02";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // codAutorField
            // 
            this.codAutorField.Location = new System.Drawing.Point(31, 72);
            this.codAutorField.Name = "codAutorField";
            this.codAutorField.Size = new System.Drawing.Size(95, 20);
            this.codAutorField.TabIndex = 1;
            // 
            // isbnField
            // 
            this.isbnField.Location = new System.Drawing.Point(31, 152);
            this.isbnField.Name = "isbnField";
            this.isbnField.Size = new System.Drawing.Size(140, 20);
            this.isbnField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "cod. Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(242, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(428, 200);
            this.dataGridView2.TabIndex = 0;
            // 
            // listarbtn
            // 
            this.listarbtn.Location = new System.Drawing.Point(72, 119);
            this.listarbtn.Name = "listarbtn";
            this.listarbtn.Size = new System.Drawing.Size(82, 37);
            this.listarbtn.TabIndex = 1;
            this.listarbtn.Text = "Listar ";
            this.listarbtn.UseVisualStyleBackColor = true;
            this.listarbtn.Click += new System.EventHandler(this.listarbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom Autor";
            // 
            // nombreAutorText
            // 
            this.nombreAutorText.Location = new System.Drawing.Point(72, 63);
            this.nombreAutorText.Name = "nombreAutorText";
            this.nombreAutorText.Size = new System.Drawing.Size(100, 20);
            this.nombreAutorText.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.numLibrosBtn);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.autoresCombo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(700, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "proceso03";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.isbnCombo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(700, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "proceso04";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // autoresCombo
            // 
            this.autoresCombo.FormattingEnabled = true;
            this.autoresCombo.Location = new System.Drawing.Point(101, 30);
            this.autoresCombo.Name = "autoresCombo";
            this.autoresCombo.Size = new System.Drawing.Size(121, 21);
            this.autoresCombo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Autores";
            // 
            // numLibrosBtn
            // 
            this.numLibrosBtn.Location = new System.Drawing.Point(116, 72);
            this.numLibrosBtn.Name = "numLibrosBtn";
            this.numLibrosBtn.Size = new System.Drawing.Size(80, 30);
            this.numLibrosBtn.TabIndex = 2;
            this.numLibrosBtn.Text = "Num Libros";
            this.numLibrosBtn.UseVisualStyleBackColor = true;
            this.numLibrosBtn.Click += new System.EventHandler(this.numLibrosBtn_Click);
            // 
            // isbnCombo
            // 
            this.isbnCombo.FormattingEnabled = true;
            this.isbnCombo.Location = new System.Drawing.Point(64, 39);
            this.isbnCombo.Name = "isbnCombo";
            this.isbnCombo.Size = new System.Drawing.Size(121, 21);
            this.isbnCombo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Isbn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mostrar datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Practica04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 386);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.IrMenu);
            this.Name = "Practica04";
            this.Text = "Practica04";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IrMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isbnField;
        private System.Windows.Forms.TextBox codAutorField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button listarbtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreAutorText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox autoresCombo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button numLibrosBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox isbnCombo;
        private System.Windows.Forms.Button button2;
    }
}