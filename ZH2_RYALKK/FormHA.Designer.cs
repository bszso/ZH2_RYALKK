namespace ZH2_RYALKK
{
    partial class FormHA
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
            this.labelEtel = new System.Windows.Forms.Label();
            this.labelHozzav = new System.Windows.Forms.Label();
            this.labelMenny = new System.Windows.Forms.Label();
            this.comboBoxEtel = new System.Windows.Forms.ComboBox();
            this.comboBoxHozzav = new System.Windows.Forms.ComboBox();
            this.labelMegys = new System.Windows.Forms.Label();
            this.textBoxMennyi = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelUjHozzav = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEtel
            // 
            this.labelEtel.AutoSize = true;
            this.labelEtel.Location = new System.Drawing.Point(32, 54);
            this.labelEtel.Name = "labelEtel";
            this.labelEtel.Size = new System.Drawing.Size(57, 15);
            this.labelEtel.TabIndex = 0;
            this.labelEtel.Text = "Étel neve:";
            // 
            // labelHozzav
            // 
            this.labelHozzav.AutoSize = true;
            this.labelHozzav.Location = new System.Drawing.Point(32, 81);
            this.labelHozzav.Name = "labelHozzav";
            this.labelHozzav.Size = new System.Drawing.Size(92, 15);
            this.labelHozzav.TabIndex = 1;
            this.labelHozzav.Text = "Hozzávaló neve:";
            // 
            // labelMenny
            // 
            this.labelMenny.AutoSize = true;
            this.labelMenny.Location = new System.Drawing.Point(32, 111);
            this.labelMenny.Name = "labelMenny";
            this.labelMenny.Size = new System.Drawing.Size(68, 15);
            this.labelMenny.TabIndex = 2;
            this.labelMenny.Text = "Mennyiség:";
            // 
            // comboBoxEtel
            // 
            this.comboBoxEtel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEtel.FormattingEnabled = true;
            this.comboBoxEtel.Location = new System.Drawing.Point(131, 48);
            this.comboBoxEtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEtel.Name = "comboBoxEtel";
            this.comboBoxEtel.Size = new System.Drawing.Size(224, 23);
            this.comboBoxEtel.TabIndex = 3;
            // 
            // comboBoxHozzav
            // 
            this.comboBoxHozzav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHozzav.FormattingEnabled = true;
            this.comboBoxHozzav.Location = new System.Drawing.Point(131, 78);
            this.comboBoxHozzav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHozzav.Name = "comboBoxHozzav";
            this.comboBoxHozzav.Size = new System.Drawing.Size(224, 23);
            this.comboBoxHozzav.TabIndex = 4;
            this.comboBoxHozzav.SelectedIndexChanged += new System.EventHandler(this.comboBoxHozzav_SelectedIndexChanged);
            // 
            // labelMegys
            // 
            this.labelMegys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMegys.AutoSize = true;
            this.labelMegys.Location = new System.Drawing.Point(371, 111);
            this.labelMegys.Name = "labelMegys";
            this.labelMegys.Size = new System.Drawing.Size(38, 15);
            this.labelMegys.TabIndex = 6;
            this.labelMegys.Text = "label1";
            // 
            // textBoxMennyi
            // 
            this.textBoxMennyi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMennyi.Location = new System.Drawing.Point(131, 108);
            this.textBoxMennyi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMennyi.Name = "textBoxMennyi";
            this.textBoxMennyi.Size = new System.Drawing.Size(224, 23);
            this.textBoxMennyi.TabIndex = 7;
            this.textBoxMennyi.TextChanged += new System.EventHandler(this.textBoxMennyi_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(301, 150);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(111, 27);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Hozzáad";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(168, 150);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 27);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelUjHozzav
            // 
            this.labelUjHozzav.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUjHozzav.AutoSize = true;
            this.labelUjHozzav.Font = new System.Drawing.Font("Segoe UI", 11.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUjHozzav.Location = new System.Drawing.Point(130, 14);
            this.labelUjHozzav.Name = "labelUjHozzav";
            this.labelUjHozzav.Size = new System.Drawing.Size(168, 20);
            this.labelUjHozzav.TabIndex = 12;
            this.labelUjHozzav.Text = "Hozzávalók hozzáadása";
            // 
            // FormHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(432, 192);
            this.Controls.Add(this.labelUjHozzav);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxMennyi);
            this.Controls.Add(this.labelMegys);
            this.Controls.Add(this.comboBoxHozzav);
            this.Controls.Add(this.comboBoxEtel);
            this.Controls.Add(this.labelMenny);
            this.Controls.Add(this.labelHozzav);
            this.Controls.Add(this.labelEtel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 231);
            this.Name = "FormHA";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hozzávaló hozzáadása";
            this.Load += new System.EventHandler(this.FormHA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Label labelEtel;
        private Label labelHozzav;
        private Label labelMenny;
        private ComboBox comboBoxEtel;
        private ComboBox comboBoxHozzav;
        private Label labelMegys;
        private TextBox textBoxMennyi;
        private Button buttonOk;
        private Button buttonCancel;
        private ErrorProvider errorProvider1;
        private Label labelUjHozzav;
    }
}