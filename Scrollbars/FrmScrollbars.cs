using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrollbars
{
    public partial class FrmScrollbars : Form
    {
        public FrmScrollbars()
        {
            InitializeComponent();
        }

        private void HsbDemo_Scroll(object sender, ScrollEventArgs e)
        {
            LblDemo.Text = HsbDemo.Value.ToString();
        }
    }
}
