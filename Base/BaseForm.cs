using System;
using System.Drawing;
using System.Windows.Forms;
using log4net;
using Sunny.UI;

namespace niushuai233.Base
{

#if DEBUG
    public class BaseForm
#else
    public abstract class BaseForm 
#endif
        : UIForm2
    {
        private static readonly ILog Log = LogManager.GetLogger("BaseForm");

        protected float X;
        protected float Y;

        protected UIForm2 superForm;

        public BaseForm()
        {
            this.Load += new EventHandler(this.BaseForm_Load);
            this.Resize += new EventHandler(this.BaseForm_Resize);

            this.FormClosed += new FormClosedEventHandler(this.BaseForm_FormClosed);

            AfterInit();
        }

        public BaseForm(UIForm2 form)
        {
            superForm = form;
        }
#if DEBUG
        public virtual void AfterInit() { }
#else
    public abstract void AfterInit();
#endif
        protected void Init(string title)
        {
            SetTitle(title);
        }
        

        protected void Init(UIForm2 form)
        {
            superForm = form;
            // 显示子窗体
            this.Show();
            // 隐藏父窗体
            superForm.Hide();

        }


        protected void Init(string title, UIForm2 form)
        {
            Init(title);
            Init(form);
        }

        /// <summary>
        /// 重写标题
        /// </summary>
        /// <param name="title">标题名</param>
        private void SetTitle(string title)
        {
            this.Text = title;
        }

        protected void BaseForm_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            SetTag(this);
            Initialize();
        }

        protected void BaseForm_Resize(object sender, EventArgs e)
        {
            if (X == 0 || Y == 0)
            {
                return;
            }
            float newX = this.Width / X;
            float newY = this.Height / Y;
            SetControls(newX, newY, this);
        }

        protected void BaseForm_FormClosed(object sender, EventArgs e)
        {
            if (superForm == null)
            {
                return;
            }

            superForm.Show();
        }

        public virtual void Initialize()
        {
            Console.WriteLine(@"BaseForm Initialize...");
        }

        /// <summary>
        /// 将控件的宽，高，左边距，顶边距和字体大小暂存到tag属性中
        /// </summary>
        /// <param name="itemControl">窗体中的控件</param>
        protected void SetTag(Control itemControl)
        {
            foreach (Control con in itemControl.Controls)//循环窗体中的控件
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    SetTag(con);
            }
        }

        /// <summary>
        /// 根据窗体大小调整控件大小
        /// </summary>
        /// <param name="newX">窗体宽度缩放比例</param>
        /// <param name="newY">窗体高度缩放比例</param>
        /// <param name="controls">随窗体改变控件大小</param>
        private void SetControls(float newX, float newY, Control controls)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control item in controls.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                string[] customTag = item.Tag.ToString().Split(new char[] {':'});
                //根据窗体缩放比例确定控件的值，宽度
                float a = System.Convert.ToSingle(customTag[0]) * newX; 
                //宽度
                item.Width = (int) a; 
                //高度
                a = System.Convert.ToSingle(customTag[1]) * newY; 
                item.Height = (int) (a);
                //左边距离
                a = System.Convert.ToSingle(customTag[2]) * newX; 
                item.Left = (int) (a);
                //上边缘距离
                a = System.Convert.ToSingle(customTag[3]) * newY; 
                item.Top = (int) (a);
                //字体大小
                Single currentSize = System.Convert.ToSingle(customTag[4]) * newY;
                item.Font = new Font(item.Font.Name, currentSize, item.Font.Style, item.Font.Unit);
                if (item.Controls.Count > 0)
                {
                    SetControls(newX, newY, item);
                }
            }
        }

    }
}
