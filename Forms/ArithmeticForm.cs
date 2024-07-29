using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using niushuai233.Base;
using Sunny.UI;

namespace StudentPracticeTools.Forms
{
    public partial class ArithmeticForm : BaseForm
    {
        private static readonly ILog Log = LogManager.GetLogger("ArithmeticForm");

        public ArithmeticForm(MainApplication mainApplication)
        {
            InitializeComponent();

            Init(Keyss.Arithmetic_Title, mainApplication);
        }

        public override void AfterInit()
        {
            LoadConfig();

            LoadFont();
        }

        private void LoadFont()
        {
            Log.Info("########################### Load Installed Font ###########################");
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            
            FontFamily[] fontFamilies = installedFontCollection.Families;

            int count = fontFamilies.Length;
            List<string> items = new List<string>();
            for (int j = 0; j < count; ++j)
            {
                string familyName = fontFamilies[j].Name;

                Log.Info("familyName: " + familyName);
                items.Add(familyName);
            }

            ArithmeticConfig.basicConfig.FontName = items;

            int index = FindIndex(ArithmeticConfig.basicConfig.FontName, this.uiTextBox_font_name.Text);
            ArithmeticConfig.basicConfig.FontIndex = index;

        }

        private int FindIndex(List<string> sourceList, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "微软雅黑";
            }

            for (int i = 0; i < sourceList.Count; i++)
            {
                if (sourceList[i].Equals(text))
                {
                    return i;
                }
            }

            return 0;
        }

        /// <summary>
        /// 加载配置项
        /// </summary>
        private void LoadConfig()
        { 
            ArithmeticConfig.BasicConfig basicConfig = new ArithmeticConfig.BasicConfig();
            basicConfig.TotalCount = (int) this.numericUpDown_total_count.Value;
            basicConfig.ColumnCount = (int) this.numericUpDown_column_count.Value;
            basicConfig.FontSize = (int) this.numericUpDown_font_size.Value;
            ArithmeticConfig.basicConfig = basicConfig;



        }

        private void uiTextBox_font_name_Click(object sender, EventArgs e)
        {
            int index = ArithmeticConfig.basicConfig.FontIndex;
            if (this.ShowSelectDialog(ref index, ArithmeticConfig.basicConfig.FontName, 
                "选择字体", "使用该字体生成算术题",
                true))
            {
                ArithmeticConfig.basicConfig.FontIndex = index;
                this.uiTextBox_font_name.Text = ArithmeticConfig.basicConfig.FontName[index];
            }
        }

        private void numericUpDown_no_dot_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 不允许输入dot
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
    }
}
