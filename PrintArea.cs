using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PrintArea : Form
    {
        public PrintArea()
        {
            InitializeComponent();
        }

        private void PrintArea_Load(object sender, EventArgs e)
        {
            txtCInfo.AppendText("INVOICE\t");
            txtCInfo.AppendText("\t");
            txtCInfo.AppendText("GREATE COMPUTERS\t");
            txtCInfo.AppendText("P. O. BOX 70, TAKORADI\t");
            txtCInfo.AppendText("0241842651 / 0557857895");
            txtDate.Text = DateTime.Today.ToString("dd - MM - yyyy") + "        " + DateTime.Now.ToString("HH : mm : ss");
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Height = this.Height - 30;
   
            this.Height = this.Height + 30;

            System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();

            PrintDialog myPrinDialog1 = new PrintDialog();

            //myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);

            myPrinDialog1.Document = myPrintDocument1;



            if (myPrinDialog1.ShowDialog() == DialogResult.OK)

            {

                myPrintDocument1.Print();

            }
        }
    }
}
