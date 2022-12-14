namespace ZH2_RYALKK
{
    partial class FormEx
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
            this.buttonEtelEx = new System.Windows.Forms.Button();
            this.labelEx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEtelEx
            // 
            this.buttonEtelEx.Location = new System.Drawing.Point(80, 70);
            this.buttonEtelEx.Name = "buttonEtelEx";
            this.buttonEtelEx.Size = new System.Drawing.Size(203, 50);
            this.buttonEtelEx.TabIndex = 0;
            this.buttonEtelEx.Text = "\"Fogások\" tábla exportálása";
            this.buttonEtelEx.UseVisualStyleBackColor = true;
            this.buttonEtelEx.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEx
            // 
            this.labelEx.AutoSize = true;
            this.labelEx.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEx.Location = new System.Drawing.Point(80, 28);
            this.labelEx.Name = "labelEx";
            this.labelEx.Size = new System.Drawing.Size(203, 20);
            this.labelEx.TabIndex = 2;
            this.labelEx.Text = "Excel munkafüzet generálása:";
            // 
            // FormEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 158);
            this.Controls.Add(this.labelEx);
            this.Controls.Add(this.buttonEtelEx);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 202);
            this.Name = "FormEx";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel megjelenítés";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private Button buttonEtelEx;
        private Label labelEx;
    }
}