using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoControls
{
    public delegate void TestSwitchPointHandler(object sender, TestEventArgs e);

    [DefaultEvent("TestSwitch")]
    public class TestColorPoint : Control
    {
        #region 构造
        public TestColorPoint()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            CreateControl();
        }
        #endregion

        #region 属性
        private Color openColor = Color.FromArgb(128, 255, 128);
        [Category("DemoUI"), Description("开启时的颜色")]
        public Color OpenColor
        {
            get { return openColor; }
            set
            {
                openColor = value;
                Invalidate();
            }
        }

        private Color closeColor = Color.FromArgb(255, 128, 128);
        [Category("DemoUI"), Description("关闭时的颜色")]
        public Color CloseColor
        {
            get { return closeColor; }
            set
            {
                closeColor = value;
                Invalidate();
            }
        }

        private int diameter = 20;
        [Category("DemoUI"), Description("圆直径")]
        public int Diameter
        {
            get { return diameter; }
            set
            {
                diameter = value;
                Size = new Size(diameter, diameter);
                Invalidate();
            }
        }

        private bool isOpen = false;
        [Category("DemoUI"), Description("开关状态")]
        public bool IsOpen
        {
            get { return isOpen; }
            set
            {
                isOpen = value;
                Invalidate();
                TestSwitch?.Invoke(this, new TestEventArgs(isOpen));
            }
        }

        #endregion

        public event TestSwitchPointHandler TestSwitch;

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, Diameter, Diameter, specified);
        }


        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (Region.IsVisible(e.Location))
            {
                if (IsOpen)
                {
                    IsOpen = false;
                }
                else
                {
                    IsOpen = true;
                }
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


            if(isOpen == true)
            {
                e.Graphics.FillEllipse(new SolidBrush(OpenColor),0, 0, Diameter, Diameter);
            }
            else
            {
                e.Graphics.FillEllipse(new SolidBrush(CloseColor), 0, 0, Diameter, Diameter);
            }
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, Diameter, Diameter);
            Region = new Region(path);
        }
    }
}
