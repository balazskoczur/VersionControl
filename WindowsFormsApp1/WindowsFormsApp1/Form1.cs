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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Flat> lakasok;
        RealEstateEntities context = new RealEstateEntities();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            lakasok = context.Flats.ToList();
        }
    }
}
