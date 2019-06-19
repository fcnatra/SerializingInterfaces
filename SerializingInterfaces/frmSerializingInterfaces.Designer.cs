namespace SerializingInterfaces
{
    partial class frmSerializingInterfaces
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDeserialization1 = new System.Windows.Forms.TextBox();
            this.txtDeserialization3 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSerialized = new System.Windows.Forms.TextBox();
            this.txtDeserialization2 = new System.Windows.Forms.TextBox();
            this.txtDeserialization4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(13, 13);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(306, 425);
            this.txtSource.TabIndex = 0;
            // 
            // txtDeserialization1
            // 
            this.txtDeserialization1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeserialization1.Location = new System.Drawing.Point(639, 12);
            this.txtDeserialization1.Multiline = true;
            this.txtDeserialization1.Name = "txtDeserialization1";
            this.txtDeserialization1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDeserialization1.Size = new System.Drawing.Size(255, 212);
            this.txtDeserialization1.TabIndex = 0;
            // 
            // txtDeserialization3
            // 
            this.txtDeserialization3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeserialization3.Location = new System.Drawing.Point(639, 225);
            this.txtDeserialization3.Multiline = true;
            this.txtDeserialization3.Name = "txtDeserialization3";
            this.txtDeserialization3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDeserialization3.Size = new System.Drawing.Size(255, 212);
            this.txtDeserialization3.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1080, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSerialized
            // 
            this.txtSerialized.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialized.Location = new System.Drawing.Point(327, 12);
            this.txtSerialized.Multiline = true;
            this.txtSerialized.Name = "txtSerialized";
            this.txtSerialized.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSerialized.Size = new System.Drawing.Size(306, 425);
            this.txtSerialized.TabIndex = 0;
            // 
            // txtDeserialization2
            // 
            this.txtDeserialization2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeserialization2.Location = new System.Drawing.Point(900, 12);
            this.txtDeserialization2.Multiline = true;
            this.txtDeserialization2.Name = "txtDeserialization2";
            this.txtDeserialization2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDeserialization2.Size = new System.Drawing.Size(255, 212);
            this.txtDeserialization2.TabIndex = 0;
            // 
            // txtDeserialization4
            // 
            this.txtDeserialization4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeserialization4.Location = new System.Drawing.Point(900, 225);
            this.txtDeserialization4.Multiline = true;
            this.txtDeserialization4.Name = "txtDeserialization4";
            this.txtDeserialization4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDeserialization4.Size = new System.Drawing.Size(255, 212);
            this.txtDeserialization4.TabIndex = 0;
            // 
            // frmSerializingInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1167, 481);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDeserialization4);
            this.Controls.Add(this.txtDeserialization2);
            this.Controls.Add(this.txtDeserialization3);
            this.Controls.Add(this.txtDeserialization1);
            this.Controls.Add(this.txtSerialized);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSerializingInterfaces";
            this.Text = "SERIALIZING THROUGH INTERFACES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDeserialization1;
        private System.Windows.Forms.TextBox txtDeserialization3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSerialized;
        private System.Windows.Forms.TextBox txtDeserialization2;
        private System.Windows.Forms.TextBox txtDeserialization4;
    }
}

