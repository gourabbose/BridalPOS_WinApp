using BridalPOS.Bootstrapper;
using BridalPOS.Business.Interfaces.Base;
using BridalPOS.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridalPOS.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bridalPOS2DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.bridalPOS2DataSet.Employees);


        }
    }
}
