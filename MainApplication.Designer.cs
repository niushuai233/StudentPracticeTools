
namespace StudentPracticeTools
{
    partial class MainApplication
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiButton_arithmetic = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiButton_arithmetic
            // 
            this.uiButton_arithmetic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_arithmetic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_arithmetic.Location = new System.Drawing.Point(49, 77);
            this.uiButton_arithmetic.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_arithmetic.Name = "uiButton_arithmetic";
            this.uiButton_arithmetic.Size = new System.Drawing.Size(150, 89);
            this.uiButton_arithmetic.TabIndex = 0;
            this.uiButton_arithmetic.Text = "算术题";
            this.uiButton_arithmetic.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_arithmetic.Click += new System.EventHandler(this.uiButton_arithmetic_Click);
            // 
            // MainApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiButton_arithmetic);
            this.Name = "MainApplication";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton_arithmetic;
    }
}

