using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using niushuai233.Base;

namespace StudentPracticeTools.Forms
{
    public partial class ArithmeticForm : BaseForm
    {
        public ArithmeticForm(MainApplication mainApplication)
        {
            InitializeComponent();

            Init(Keyss.Arithmetic_Title, mainApplication);
        }

        public override void AfterInit()
        {
            
        }
    }
}
