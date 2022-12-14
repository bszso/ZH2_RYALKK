namespace ZH2_RYALKK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxEtel = new System.Windows.Forms.TextBox();
            this.textBoxHozzav = new System.Windows.Forms.TextBox();
            this.listBoxEtel = new System.Windows.Forms.ListBox();
            this.listBoxHozzav = new System.Windows.Forms.ListBox();
            this.nyersanyagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTabla = new System.Windows.Forms.DataGridView();
            this.receptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyersanyagokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mennyisegiEgysegekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFelvetel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fogasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelEtelKeres = new System.Windows.Forms.Label();
            this.labelhozzavKeres = new System.Windows.Forms.Label();
            this.labelFo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelUjEtel = new System.Windows.Forms.Label();
            this.buttonExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegiEgysegekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEtel
            // 
            this.textBoxEtel.Location = new System.Drawing.Point(33, 36);
            this.textBoxEtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEtel.Name = "textBoxEtel";
            this.textBoxEtel.Size = new System.Drawing.Size(182, 23);
            this.textBoxEtel.TabIndex = 0;
            this.textBoxEtel.TextChanged += new System.EventHandler(this.textBoxEtel_TextChanged);
            // 
            // textBoxHozzav
            // 
            this.textBoxHozzav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHozzav.Location = new System.Drawing.Point(788, 36);
            this.textBoxHozzav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHozzav.Name = "textBoxHozzav";
            this.textBoxHozzav.Size = new System.Drawing.Size(190, 23);
            this.textBoxHozzav.TabIndex = 1;
            this.textBoxHozzav.TextChanged += new System.EventHandler(this.textBoxHozzav_TextChanged);
            // 
            // listBoxEtel
            // 
            this.listBoxEtel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEtel.FormattingEnabled = true;
            this.listBoxEtel.ItemHeight = 15;
            this.listBoxEtel.Location = new System.Drawing.Point(33, 68);
            this.listBoxEtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEtel.Name = "listBoxEtel";
            this.listBoxEtel.Size = new System.Drawing.Size(182, 394);
            this.listBoxEtel.TabIndex = 2;
            this.listBoxEtel.SelectedIndexChanged += new System.EventHandler(this.listBoxEtel_SelectedIndexChanged);
            // 
            // listBoxHozzav
            // 
            this.listBoxHozzav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxHozzav.DataSource = this.nyersanyagBindingSource;
            this.listBoxHozzav.DisplayMember = "NyersanyagNev";
            this.listBoxHozzav.FormattingEnabled = true;
            this.listBoxHozzav.ItemHeight = 15;
            this.listBoxHozzav.Location = new System.Drawing.Point(788, 68);
            this.listBoxHozzav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxHozzav.Name = "listBoxHozzav";
            this.listBoxHozzav.Size = new System.Drawing.Size(190, 394);
            this.listBoxHozzav.TabIndex = 3;
            // 
            // nyersanyagBindingSource
            // 
            this.nyersanyagBindingSource.DataSource = typeof(ZH2_RYALKK.Nyersanyag);
            // 
            // dataGridViewTabla
            // 
            this.dataGridViewTabla.AllowUserToAddRows = false;
            this.dataGridViewTabla.AllowUserToDeleteRows = false;
            this.dataGridViewTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabla.AutoGenerateColumns = false;
            this.dataGridViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIDDataGridViewTextBoxColumn,
            this.fogasIDDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridViewTabla.DataSource = this.hozzavaloBindingSource;
            this.dataGridViewTabla.Location = new System.Drawing.Point(220, 68);
            this.dataGridViewTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTabla.Name = "dataGridViewTabla";
            this.dataGridViewTabla.ReadOnly = true;
            this.dataGridViewTabla.RowHeadersWidth = 47;
            this.dataGridViewTabla.RowTemplate.Height = 28;
            this.dataGridViewTabla.Size = new System.Drawing.Size(563, 394);
            this.dataGridViewTabla.TabIndex = 4;
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            this.receptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.HeaderText = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            this.receptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receptIDDataGridViewTextBoxColumn.Visible = false;
            this.receptIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            this.fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            this.fogasIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fogasIDDataGridViewTextBoxColumn.Visible = false;
            this.fogasIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "Hozzávaló";
            this.nyersanyagNevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            this.nyersanyagNevDataGridViewTextBoxColumn.ReadOnly = true;
            this.nyersanyagNevDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nyersanyagNevDataGridViewTextBoxColumn.Width = 115;
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg";
            this.mennyiseg4foDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            this.mennyiseg4foDataGridViewTextBoxColumn.ReadOnly = true;
            this.mennyiseg4foDataGridViewTextBoxColumn.Width = 115;
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "Mértékegység";
            this.egysegNevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            this.egysegNevDataGridViewTextBoxColumn.ReadOnly = true;
            this.egysegNevDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.egysegNevDataGridViewTextBoxColumn.Width = 115;
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár (Ft)";
            this.árDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            this.árDataGridViewTextBoxColumn.ReadOnly = true;
            this.árDataGridViewTextBoxColumn.Width = 115;
            // 
            // hozzavaloBindingSource
            // 
            this.hozzavaloBindingSource.DataSource = typeof(ZH2_RYALKK.Hozzavalo);
            // 
            // nyersanyagokBindingSource
            // 
            this.nyersanyagokBindingSource.DataSource = typeof(ZH2_RYALKK.Models.Nyersanyagok);
            // 
            // mennyisegiEgysegekBindingSource
            // 
            this.mennyisegiEgysegekBindingSource.DataSource = typeof(ZH2_RYALKK.Models.MennyisegiEgysegek);
            // 
            // buttonFelvetel
            // 
            this.buttonFelvetel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFelvetel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFelvetel.Font = new System.Drawing.Font("Segoe UI", 10.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFelvetel.Location = new System.Drawing.Point(311, 467);
            this.buttonFelvetel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFelvetel.Name = "buttonFelvetel";
            this.buttonFelvetel.Size = new System.Drawing.Size(189, 46);
            this.buttonFelvetel.TabIndex = 5;
            this.buttonFelvetel.Text = "Hozzávaló hozzáadása a recepthez...";
            this.buttonFelvetel.UseVisualStyleBackColor = false;
            this.buttonFelvetel.Click += new System.EventHandler(this.buttonFelvetel_Click);
            // 
            // fogasokBindingSource
            // 
            this.fogasokBindingSource.DataSource = typeof(ZH2_RYALKK.Models.Fogasok);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 10.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.Location = new System.Drawing.Point(515, 467);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(189, 46);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Kijelölt hozzávaló törlése a receptből";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelEtelKeres
            // 
            this.labelEtelKeres.AutoSize = true;
            this.labelEtelKeres.Font = new System.Drawing.Font("Segoe UI", 11.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEtelKeres.Location = new System.Drawing.Point(33, 13);
            this.labelEtelKeres.Name = "labelEtelKeres";
            this.labelEtelKeres.Size = new System.Drawing.Size(97, 20);
            this.labelEtelKeres.TabIndex = 7;
            this.labelEtelKeres.Text = "Étel keresése:";
            // 
            // labelhozzavKeres
            // 
            this.labelhozzavKeres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelhozzavKeres.AutoSize = true;
            this.labelhozzavKeres.Font = new System.Drawing.Font("Segoe UI", 11.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelhozzavKeres.Location = new System.Drawing.Point(788, 13);
            this.labelhozzavKeres.Name = "labelhozzavKeres";
            this.labelhozzavKeres.Size = new System.Drawing.Size(142, 20);
            this.labelhozzavKeres.TabIndex = 8;
            this.labelhozzavKeres.Text = "Hozzávaló keresése:";
            // 
            // labelFo
            // 
            this.labelFo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFo.AutoSize = true;
            this.labelFo.Font = new System.Drawing.Font("Segoe UI", 13.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFo.Location = new System.Drawing.Point(372, 32);
            this.labelFo.Name = "labelFo";
            this.labelFo.Size = new System.Drawing.Size(227, 25);
            this.labelFo.TabIndex = 9;
            this.labelFo.Text = "Kiválasztott étel összetevői:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(33, 523);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // labelUjEtel
            // 
            this.labelUjEtel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUjEtel.AutoSize = true;
            this.labelUjEtel.Font = new System.Drawing.Font("Segoe UI", 11.16364F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUjEtel.Location = new System.Drawing.Point(33, 501);
            this.labelUjEtel.Name = "labelUjEtel";
            this.labelUjEtel.Size = new System.Drawing.Size(143, 20);
            this.labelUjEtel.TabIndex = 11;
            this.labelUjEtel.Text = "Új étel hozzáadása...";
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcel.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExcel.Location = new System.Drawing.Point(788, 523);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(189, 32);
            this.buttonExcel.TabIndex = 12;
            this.buttonExcel.Text = "Adatok exportálása (Excel)";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1002, 561);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.labelUjEtel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFo);
            this.Controls.Add(this.labelhozzavKeres);
            this.Controls.Add(this.labelEtelKeres);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonFelvetel);
            this.Controls.Add(this.dataGridViewTabla);
            this.Controls.Add(this.listBoxHozzav);
            this.Controls.Add(this.listBoxEtel);
            this.Controls.Add(this.textBoxHozzav);
            this.Controls.Add(this.textBoxEtel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(912, 486);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Étel adatbázis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegiEgysegekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private TextBox textBoxEtel;
        private TextBox textBoxHozzav;
        private ListBox listBoxEtel;
        private ListBox listBoxHozzav;
        private DataGridView dataGridViewTabla;
        private Button buttonFelvetel;
        private BindingSource bindingSource1;
        private BindingSource nyersanyagokBindingSource;
        private BindingSource fogasokBindingSource;
        private BindingSource hozzavaloBindingSource;
        private Button buttonRemove;
        private Label labelEtelKeres;
        private Label labelhozzavKeres;
        private Label labelFo;
        private BindingSource nyersanyagBindingSource;
        private TextBox textBox1;
        private Label labelUjEtel;
        private Button buttonExcel;
        private BindingSource mennyisegiEgysegekBindingSource;
        private DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
    }
}