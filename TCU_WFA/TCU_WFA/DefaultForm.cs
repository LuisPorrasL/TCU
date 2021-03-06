﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class DefaultForm : Form
    {

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public DefaultForm()
        {
            InitializeComponent();
        }

        protected void botonVolver_Click(object sender, EventArgs e)
        {
            Form form = (Form)Tag;
            form.Show();
            Close();
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
