using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPracticeTools.Forms
{
    public class ArithmeticConfig
    {
        public static ArithmeticConfig.BasicConfig basicConfig;

        /// <summary>
        /// 基础配置项
        /// </summary>
        public class BasicConfig
        {
            /// <summary>
            /// 总生成数
            /// </summary>
            public int TotalCount { get; set; }

            /// <summary>
            /// 列数
            /// </summary>
            public int ColumnCount { get; set; }

            /// <summary>
            /// 使用的字体下标
            /// </summary>
            public int FontIndex { get; set; }
            /// <summary>
            /// 字体名
            /// </summary>
            public List<string> FontName { get; set; }

            /// <summary>
            /// 字体大小
            /// </summary>
            public int FontSize { get; set; }
        }
    }
}
