using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookCient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int k = 0;
        public void btn1_Click(object sender, EventArgs e)
        {
            k = 1;
            ActiveForm.Close();
            
        }
        /*public void Vivod()
{
   txtBoxName.Text=;
       t
}
*/
    }
    
}
