using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bingo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnNumeros_Click(object sender, EventArgs e)
        {
            FrmNumeros snumeros = new FrmNumeros() ;
            snumeros .Show ();
            
        }
     }
}

            
        
    




    
