
namespace RecuperatorioJesusSivira
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNodoNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listPila = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listCola = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el valor deseado a cargar:";
            // 
            // txtNodoNombre
            // 
            this.txtNodoNombre.Location = new System.Drawing.Point(311, 41);
            this.txtNodoNombre.Name = "txtNodoNombre";
            this.txtNodoNombre.Size = new System.Drawing.Size(246, 22);
            this.txtNodoNombre.TabIndex = 1;
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Location = new System.Drawing.Point(340, 198);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(102, 34);
            this.btnAgregarNodo.TabIndex = 2;
            this.btnAgregarNodo.Text = "Cargar";
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(115, 331);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(105, 34);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(340, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listPila
            // 
            this.listPila.FormattingEnabled = true;
            this.listPila.ItemHeight = 16;
            this.listPila.Location = new System.Drawing.Point(41, 112);
            this.listPila.Name = "listPila";
            this.listPila.Size = new System.Drawing.Size(245, 196);
            this.listPila.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pila";
            // 
            // listCola
            // 
            this.listCola.FormattingEnabled = true;
            this.listCola.ItemHeight = 16;
            this.listCola.Location = new System.Drawing.Point(483, 112);
            this.listCola.Name = "listCola";
            this.listCola.Size = new System.Drawing.Size(262, 196);
            this.listCola.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cola";
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(576, 331);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(103, 34);
            this.btnDequeue.TabIndex = 11;
            this.btnDequeue.Text = "Quitar";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listCola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPila);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.txtNodoNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNodoNombre;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listPila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDequeue;
    }
}

