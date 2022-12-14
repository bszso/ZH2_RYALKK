using ZH2_RYALKK.Models;
namespace ZH2_RYALKK
{
    
    public partial class Form1 : Form
    {
        ReceptContext context = new ReceptContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void NyersanyagListazas()
        {
            var hv = from x in context.Nyersanyagok
                     where x.NyersanyagNev.Contains(textBoxHozzav.Text)
                     select new Nyersanyag
                     {
                         NyersanyagNev = x.NyersanyagNev
                     };
            nyersanyagBindingSource.DataSource = hv.ToList();
        }
        private void EtelListazas()
        {
            var et = from x in context.Fogasok
                     where x.FogasNev.Contains(textBoxEtel.Text)
                     select x;
            listBoxEtel.DataSource = et.ToList();
            listBoxEtel.DisplayMember = "FogasNev";
        }
        private void HozzávalóListázás()
        {
            if (listBoxEtel.SelectedItem == null) return;
            var kivEtel = (Fogasok)listBoxEtel.SelectedItem;
            var hozzávalók = from x in context.Receptek
                             where x.FogasId == kivEtel.FogasId
                             select new Hozzavalo
                             {
                                 ReceptID = x.ReceptId,
                                 FogasID = x.FogasId,
                                 NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                 Mennyiseg_4fo = x.Mennyiseg4fo,
                                 EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 Ár = (double)x.Mennyiseg4fo * (double)x.Nyersanyag.Egysegar
                             };
            hozzavaloBindingSource.DataSource = hozzávalók.ToList();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            EtelListazas();
            NyersanyagListazas();
        }
        private void textBoxHozzav_TextChanged(object sender, EventArgs e)
        {
            NyersanyagListazas();
        }
        private void textBoxEtel_TextChanged(object sender, EventArgs e)
        {
            EtelListazas();
        }
        private void listBoxEtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            HozzávalóListázás();
        }

        private void buttonFelvetel_Click(object sender, EventArgs e)
        {
            FormHA formHA = new FormHA();
            if (formHA.ShowDialog() == DialogResult.OK)
            {
                HozzávalóListázás();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(hozzavaloBindingSource.Current != null)
            {
                FormT formT = new FormT();
                if (formT.ShowDialog() == DialogResult.OK)
                {
                    var receptid = ((Hozzavalo)hozzavaloBindingSource.Current).ReceptID;
                    var torl = (from x in context.Receptek
                                where x.ReceptId == receptid
                                select x).FirstOrDefault();
                    try
                    {
                        context.Receptek.Remove(torl);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    HozzávalóListázás();
                }
            }
            else
            {
                MessageBox.Show("Nincs mit törölni a táblából");
            }
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos be akarod zárni az programot? :( ", "Megerõsítés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            FormUjEtel formUjEtel = new FormUjEtel();
            if (formUjEtel.ShowDialog() == DialogResult.OK) EtelListazas();
        }
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            FormEx formEx = new FormEx();
            formEx.Show();
        }
    }
}