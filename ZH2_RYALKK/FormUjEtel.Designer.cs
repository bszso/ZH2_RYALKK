namespace ZH2_RYALKK
{
    partial class FormUjEtel
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
            this.components = new System.ComponentModel.Container();
            this.labelUjEtel = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxUjEtel = new System.Windows.Forms.TextBox();
            this.labelLeiras = new System.Windows.Forms.Label();
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUjEtel
            // 
            this.labelUjEtel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUjEtel.AutoSize = true;
            this.labelUjEtel.Font = new System.Drawing.Font("Segoe UI", 11.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUjEtel.Location = new System.Drawing.Point(10, 7);
            this.labelUjEtel.Name = "labelUjEtel";
            this.labelUjEtel.Size = new System.Drawing.Size(90, 20);
            this.labelUjEtel.TabIndex = 12;
            this.labelUjEtel.Text = "Új étel neve:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(182, 101);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(102, 101);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxUjEtel
            // 
            this.textBoxUjEtel.Location = new System.Drawing.Point(109, 9);
            this.textBoxUjEtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUjEtel.Name = "textBoxUjEtel";
            this.textBoxUjEtel.Size = new System.Drawing.Size(148, 23);
            this.textBoxUjEtel.TabIndex = 16;
            this.textBoxUjEtel.TextChanged += new System.EventHandler(this.textBoxUjEtel_TextChanged);
            // 
            // labelLeiras
            // 
            this.labelLeiras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLeiras.AutoSize = true;
            this.labelLeiras.Font = new System.Drawing.Font("Segoe UI", 11.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLeiras.Location = new System.Drawing.Point(10, 32);
            this.labelLeiras.Name = "labelLeiras";
            this.labelLeiras.Size = new System.Drawing.Size(97, 20);
            this.labelLeiras.TabIndex = 17;
            this.labelLeiras.Text = "Rövid leírása:";
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Location = new System.Drawing.Point(10, 54);
            this.textBoxLeiras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLeiras.Multiline = true;
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(247, 43);
            this.textBoxLeiras.TabIndex = 18;
            this.textBoxLeiras.TextChanged += new System.EventHandler(this.textBoxLeiras_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUjEtel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(283, 135);
            this.Controls.Add(this.textBoxLeiras);
            this.Controls.Add(this.labelLeiras);
            this.Controls.Add(this.textBoxUjEtel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelUjEtel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 174);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 174);
            this.Name = "FormUjEtel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új étel";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Label labelUjEtel;
        private Button buttonOK;
        private Button buttonCancel;
        private TextBox textBoxUjEtel;
        private Label labelLeiras;
        private TextBox textBoxLeiras;
        private ErrorProvider errorProvider1;
    }
}