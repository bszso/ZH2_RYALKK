using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using ZH2_RYALKK.Models;
namespace ZH2_RYALKK
{
    public partial class FormEx : Form
    {

        public FormEx()
        {
            InitializeComponent();
        }
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public void CreateExcel()
        {
            try
            {

                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTableEtel();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        void CreateTableEtel()
        {
            string[] fejlécek = new string[] {
        "Étel Azon.",
        "Étel neve",
        "Leírás"};
            xlSheet.Cells[1, 1] = fejlécek[0];
            xlSheet.Cells[1, 2] = fejlécek[1];
            xlSheet.Cells[1, 3] = fejlécek[2];
            ReceptContext context = new ReceptContext();
            var mind = context.Fogasok.ToList();
            object[,] adatTömb = new object[mind.Count(), fejlécek.Count()];
            for (int i = 0; i < mind.Count(); i++)
            {
                adatTömb[i, 0] = mind[i].FogasId;
                adatTömb[i, 1] = mind[i].FogasNev;
                adatTömb[i, 2] = mind[i].Leiras;
            }
            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);
            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;
            adatRange.Columns.AutoFit();
            Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
            fejllécRange.Font.Bold = true;
            fejllécRange.EntireColumn.AutoFit();
            fejllécRange.Interior.Color = Color.White;
            fejllécRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
            MessageBox.Show("Tevékenysége új ablakban nyílt meg.");
        }
    }
}
