using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_RYALKK.Models;
namespace ZH2_RYALKK
{
    public partial class FormHA : Form
    {
        ReceptContext context = new ReceptContext();
        public FormHA()
        {
            InitializeComponent();
        }
        private void FormHA_Load(object sender, EventArgs e)
        {
            ComboForras();
        }
        private void ComboForras()
        {
            var a = from x in context.Fogasok
                    select x;
            var b = from y in context.Nyersanyagok
                    select y;
            comboBoxEtel.DataSource = a.ToList();
            comboBoxEtel.DisplayMember = "FogasNev";
            comboBoxHozzav.DataSource = b.ToList();
            comboBoxHozzav.DisplayMember = "Nyersanyagnev";

        }
        private void comboBoxHozzav_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiv = (Nyersanyagok)comboBoxHozzav.SelectedItem;
            var megys = (from z in context.MennyisegiEgysegek
                         where z.MennyisegiEgysegId == kiv.MennyisegiEgysegId
                         select z).FirstOrDefault();
            labelMegys.Text = megys.EgysegNev;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxHozzav.SelectedIndex == -1 || comboBoxEtel.SelectedIndex == -1)
            {
                MessageBox.Show("Válassz ételt és hozzávalót a listából");
                return;
            }
            Regex reg = new Regex("^[1-9]|[1-9][0-9]|[1-9][0-9][0-9]$");
            if (!reg.IsMatch(textBoxMennyi.Text))
            {
                errorProvider1.SetError(textBoxMennyi, "0-nál nagyobb mennyiség");
                return;
            }
            Receptek r = new Receptek();
            r.NyersanyagId = ((Nyersanyagok)comboBoxHozzav.SelectedItem).NyersanyagId;
            r.FogasId = ((Fogasok)comboBoxEtel.SelectedItem).FogasId;
            double m;
            if (double.TryParse(textBoxMennyi.Text, out m) && m > 0)
            {
                r.Mennyiseg4fo = m;
                try
                {
                    context.Receptek.Add(r);
                    context.SaveChanges();
                    MessageBox.Show("Sikeresen felvetted a hozzávalót!");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxMennyi_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}