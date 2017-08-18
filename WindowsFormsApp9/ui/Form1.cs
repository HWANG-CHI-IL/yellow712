using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 바로 dispose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClone1_Click(object sender, EventArgs e)
        {
            using (Clone clone1 = new Clone(1))
            {
                // 아무것도 안함
            }
        }

        private void btnClone2_Click(object sender, EventArgs e)
        {
            Clone clone2 = new Clone(2);

            clone2 = null;
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
