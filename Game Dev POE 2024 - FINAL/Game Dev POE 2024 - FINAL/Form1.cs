using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Dev_POE_2024___FINAL
{
    public partial class Form1 : Form
    {
        
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
    }
}
