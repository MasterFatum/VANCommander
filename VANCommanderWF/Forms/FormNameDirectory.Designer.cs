
namespace VANCommanderWF.Forms
{
    partial class FormNameDirectory
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
            this.txb_nameDirectory = new System.Windows.Forms.TextBox();
            this.btn_nameDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_nameDirectory
            // 
            this.txb_nameDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_nameDirectory.Location = new System.Drawing.Point(12, 12);
            this.txb_nameDirectory.Name = "txb_nameDirectory";
            this.txb_nameDirectory.Size = new System.Drawing.Size(273, 29);
            this.txb_nameDirectory.TabIndex = 0;
            // 
            // btn_nameDirectory
            // 
            this.btn_nameDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nameDirectory.Location = new System.Drawing.Point(291, 12);
            this.btn_nameDirectory.Name = "btn_nameDirectory";
            this.btn_nameDirectory.Size = new System.Drawing.Size(84, 29);
            this.btn_nameDirectory.TabIndex = 1;
            this.btn_nameDirectory.Text = "Создать";
            this.btn_nameDirectory.UseVisualStyleBackColor = true;
            this.btn_nameDirectory.Click += new System.EventHandler(this.btn_nameDirectory_Click);
            // 
            // FormNameDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 53);
            this.Controls.Add(this.btn_nameDirectory);
            this.Controls.Add(this.txb_nameDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNameDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Имя директории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nameDirectory;
        private System.Windows.Forms.Button btn_nameDirectory;
    }
}