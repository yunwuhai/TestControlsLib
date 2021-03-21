
namespace TestMyControls
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
            this.testColorPoint1 = new DemoControls.TestColorPoint();
            this.testColorPoint2 = new DemoControls.TestColorPoint();
            this.SuspendLayout();
            // 
            // testColorPoint1
            // 
            this.testColorPoint1.CloseColor = System.Drawing.Color.Blue;
            this.testColorPoint1.Diameter = 200;
            this.testColorPoint1.IsOpen = false;
            this.testColorPoint1.Location = new System.Drawing.Point(100, 86);
            this.testColorPoint1.Name = "testColorPoint1";
            this.testColorPoint1.OpenColor = System.Drawing.Color.Red;
            this.testColorPoint1.Size = new System.Drawing.Size(200, 200);
            this.testColorPoint1.TabIndex = 0;
            this.testColorPoint1.Text = "testColorPoint1";
            this.testColorPoint1.TestSwitch += new DemoControls.TestSwitchPointHandler(this.testColorPoint1_TestSwitch);
            // 
            // testColorPoint2
            // 
            this.testColorPoint2.CloseColor = System.Drawing.Color.Blue;
            this.testColorPoint2.Diameter = 150;
            this.testColorPoint2.IsOpen = false;
            this.testColorPoint2.Location = new System.Drawing.Point(517, 116);
            this.testColorPoint2.Name = "testColorPoint2";
            this.testColorPoint2.OpenColor = System.Drawing.Color.Red;
            this.testColorPoint2.Size = new System.Drawing.Size(150, 150);
            this.testColorPoint2.TabIndex = 1;
            this.testColorPoint2.Text = "testColorPoint2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testColorPoint2);
            this.Controls.Add(this.testColorPoint1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DemoControls.TestColorPoint testColorPoint1;
        private DemoControls.TestColorPoint testColorPoint2;
    }
}

