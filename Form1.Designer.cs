namespace Ev__Final__4toBi
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
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(339, 196);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TextUsuario
            // 
            this.TextUsuario.Location = new System.Drawing.Point(69, 34);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(100, 22);
            this.TextUsuario.TabIndex = 1;
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(544, 34);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(100, 22);
            this.TextContraseña.TabIndex = 2;
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Location = new System.Drawing.Point(339, 300);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(88, 16);
            this.LBL.TabIndex = 3;
            this.LBL.Text = "Examen Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.Label LBL;
    }
}

