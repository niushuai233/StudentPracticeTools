using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using niushuai233.Base;
using StudentPracticeTools.Forms;

namespace StudentPracticeTools
{
    public partial class MainApplication : BaseForm
    {
        private static readonly ILog Log = LogManager.GetLogger("MainApplication");

        public MainApplication()
        {
            InitializeComponent();

            Init(Keyss.App_Name);
        }

        /// <summary>
        /// 跳转到口算界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_kou_suan_Click(object sender, EventArgs e)
        {
            ArithmeticForm arithmeticForm = new ArithmeticForm(this);
        }

        public override void AfterInit()
        {
            Log.Info(Keyss.App_Package_Name + " started");
        }
    }
}
