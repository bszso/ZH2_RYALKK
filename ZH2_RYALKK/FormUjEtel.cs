using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_RYALKK.Models;
namespace ZH2_RYALKK
{
    public partial class FormUjEtel : Form
    {
        ReceptContext context = new ReceptContext();
        public FormUjEtel()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxUjEtel.Text != string.Empty && textBoxLeiras.Text != string.Empty)
            {
                Fogasok f = new Fogasok();
                f.FogasNev = textBoxUjEtel.Text;
                f.Leiras = textBoxLeiras.Text;
                context.Fogasok.Add(f);
                context.SaveChanges();
                MessageBox.Show("Új étel hozzáadva!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                errorProvider1.SetError(textBoxUjEtel, "Kérlek töltsd ki a nevet és a leírást");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void textBoxUjEtel_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void textBoxLeiras_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
