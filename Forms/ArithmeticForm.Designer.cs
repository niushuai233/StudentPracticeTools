
namespace StudentPracticeTools.Forms
{
    partial class ArithmeticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.numericUpDown_font_size = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_total_count = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_column_count = new System.Windows.Forms.NumericUpDown();
            this.uiTextBox_font_name = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_font_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_total_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_column_count)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(3, 38);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(105, 35);
            this.uiSymbolLabel1.Symbol = 560103;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "生成数量";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(179, 38);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(105, 35);
            this.uiSymbolLabel2.Symbol = 560103;
            this.uiSymbolLabel2.TabIndex = 1;
            this.uiSymbolLabel2.Text = "生成列数";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(341, 38);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Size = new System.Drawing.Size(64, 35);
            this.uiSymbolLabel3.Symbol = 560103;
            this.uiSymbolLabel3.TabIndex = 2;
            this.uiSymbolLabel3.Text = "字体";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(606, 38);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Size = new System.Drawing.Size(105, 35);
            this.uiSymbolLabel4.Symbol = 560103;
            this.uiSymbolLabel4.TabIndex = 3;
            this.uiSymbolLabel4.Text = "字体大小";
            // 
            // numericUpDown_font_size
            // 
            this.numericUpDown_font_size.Location = new System.Drawing.Point(715, 42);
            this.numericUpDown_font_size.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_font_size.Name = "numericUpDown_font_size";
            this.numericUpDown_font_size.Size = new System.Drawing.Size(73, 26);
            this.numericUpDown_font_size.TabIndex = 8;
            this.numericUpDown_font_size.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_font_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_no_dot_KeyPress);
            // 
            // numericUpDown_total_count
            // 
            this.numericUpDown_total_count.Location = new System.Drawing.Point(112, 42);
            this.numericUpDown_total_count.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_total_count.Name = "numericUpDown_total_count";
            this.numericUpDown_total_count.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown_total_count.TabIndex = 9;
            this.numericUpDown_total_count.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_total_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_no_dot_KeyPress);
            // 
            // numericUpDown_column_count
            // 
            this.numericUpDown_column_count.Location = new System.Drawing.Point(288, 42);
            this.numericUpDown_column_count.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_column_count.Name = "numericUpDown_column_count";
            this.numericUpDown_column_count.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown_column_count.TabIndex = 10;
            this.numericUpDown_column_count.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_column_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_no_dot_KeyPress);
            // 
            // uiTextBox_font_name
            // 
            this.uiTextBox_font_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_font_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_font_name.Location = new System.Drawing.Point(409, 41);
            this.uiTextBox_font_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_font_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_font_name.Name = "uiTextBox_font_name";
            this.uiTextBox_font_name.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_font_name.ReadOnly = true;
            this.uiTextBox_font_name.ShowText = false;
            this.uiTextBox_font_name.Size = new System.Drawing.Size(193, 29);
            this.uiTextBox_font_name.TabIndex = 11;
            this.uiTextBox_font_name.Text = "微软雅黑";
            this.uiTextBox_font_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_font_name.Watermark = "";
            this.uiTextBox_font_name.Click += new System.EventHandler(this.uiTextBox_font_name_Click);
            // 
            // ArithmeticForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTextBox_font_name);
            this.Controls.Add(this.numericUpDown_column_count);
            this.Controls.Add(this.numericUpDown_total_count);
            this.Controls.Add(this.numericUpDown_font_size);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "ArithmeticForm";
            this.Text = "Arithmetic";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_font_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_total_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_column_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private System.Windows.Forms.NumericUpDown numericUpDown_font_size;
        private System.Windows.Forms.NumericUpDown numericUpDown_total_count;
        private System.Windows.Forms.NumericUpDown numericUpDown_column_count;
        private Sunny.UI.UITextBox uiTextBox_font_name;
    }
}