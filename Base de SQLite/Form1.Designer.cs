namespace Base_de_SQLite
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.insertarbutton = new System.Windows.Forms.Button();
            this.actualizarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Red;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.dataGridView1.Location = new System.Drawing.Point(423, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(254, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base de Datos de SQLite";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Nombrelabel.Location = new System.Drawing.Point(31, 110);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(93, 25);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.IDlabel.Location = new System.Drawing.Point(31, 189);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(38, 25);
            this.IDlabel.TabIndex = 3;
            this.IDlabel.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox1.Location = new System.Drawing.Point(182, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 31);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox2.Location = new System.Drawing.Point(182, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 31);
            this.textBox2.TabIndex = 5;
            // 
            // insertarbutton
            // 
            this.insertarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.insertarbutton.Location = new System.Drawing.Point(65, 273);
            this.insertarbutton.Name = "insertarbutton";
            this.insertarbutton.Size = new System.Drawing.Size(271, 35);
            this.insertarbutton.TabIndex = 6;
            this.insertarbutton.Text = "Insertar";
            this.insertarbutton.UseVisualStyleBackColor = true;
            this.insertarbutton.Click += new System.EventHandler(this.insertarbutton_Click);
            // 
            // actualizarbutton
            // 
            this.actualizarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.actualizarbutton.Location = new System.Drawing.Point(65, 327);
            this.actualizarbutton.Name = "actualizarbutton";
            this.actualizarbutton.Size = new System.Drawing.Size(271, 35);
            this.actualizarbutton.TabIndex = 7;
            this.actualizarbutton.Text = "Actualizar";
            this.actualizarbutton.UseVisualStyleBackColor = true;
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.eliminarbutton.Location = new System.Drawing.Point(65, 384);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(271, 35);
            this.eliminarbutton.TabIndex = 8;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.actualizarbutton);
            this.Controls.Add(this.insertarbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button insertarbutton;
        private System.Windows.Forms.Button actualizarbutton;
        private System.Windows.Forms.Button eliminarbutton;
    }
}

