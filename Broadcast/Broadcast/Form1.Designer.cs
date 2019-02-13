namespace Broadcast
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCookie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lkCleanLog = new System.Windows.Forms.LinkLabel();
            this.lkCleanList = new System.Windows.Forms.LinkLabel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCookie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.tbUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本配置";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(77, 185);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(835, 21);
            this.tbKey.TabIndex = 6;
            this.tbKey.Text = "协yi|抖音|小红书|功能定制|辅Zhu|彩票|分析|游戏|娱乐|插件|hook|so|逆向|加密|加固|混淆\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "关键词过滤:";
            // 
            // tbCookie
            // 
            this.tbCookie.Location = new System.Drawing.Point(78, 71);
            this.tbCookie.Multiline = true;
            this.tbCookie.Name = "tbCookie";
            this.tbCookie.Size = new System.Drawing.Size(834, 95);
            this.tbCookie.TabIndex = 4;
            this.tbCookie.Text = resources.GetString("tbCookie.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cookie:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(929, 30);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(77, 32);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(835, 21);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "http://bbs.125.la/plugin.php?id=e3600%3Atask&mod=show&subject=APP&startprice=1000" +
    "0&endprice=50000&source=0&sort=0&s=1&t=1550047068572";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(42, 278);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(1010, 316);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // lkCleanLog
            // 
            this.lkCleanLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lkCleanLog.AutoSize = true;
            this.lkCleanLog.Location = new System.Drawing.Point(1064, 606);
            this.lkCleanLog.Name = "lkCleanLog";
            this.lkCleanLog.Size = new System.Drawing.Size(29, 12);
            this.lkCleanLog.TabIndex = 6;
            this.lkCleanLog.TabStop = true;
            this.lkCleanLog.Text = "清空";
            this.lkCleanLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkCleanLog_LinkClicked);
            // 
            // lkCleanList
            // 
            this.lkCleanList.AutoSize = true;
            this.lkCleanList.Location = new System.Drawing.Point(1023, 263);
            this.lkCleanList.Name = "lkCleanList";
            this.lkCleanList.Size = new System.Drawing.Size(29, 12);
            this.lkCleanList.TabIndex = 7;
            this.lkCleanList.TabStop = true;
            this.lkCleanList.Text = "清空";
            this.lkCleanList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkCleanList_LinkClicked);
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 621);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(1093, 155);
            this.tbLog.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 776);
            this.Controls.Add(this.lkCleanList);
            this.Controls.Add(this.lkCleanLog);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "播报";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCookie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel lkCleanLog;
        private System.Windows.Forms.LinkLabel lkCleanList;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Timer timer1;
    }
}

