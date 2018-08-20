using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StuTraining
{
    public partial class Liver : Form
    {
        public Liver()
        {
            InitializeComponent();
            Random();
            timer.Enabled = true;
        }

        /// <summary>
        /// 鼠标按下为true
        /// </summary>
        private bool Mousedown;

        /// <summary>
        /// 鼠标在事件源的位置
        /// </summary>
        private int CurX = 0;
        private int CurY = 0;

        private void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            CurX = e.X;
            CurY = e.Y;
            Mousedown = true;
        }

        private void Controls_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mousedown)
            {
                // 获取当前屏幕的光标坐标
                Point pTemp = new Point(Cursor.Position.X, Cursor.Position.Y);
                // 转换成工作区坐标
                pTemp = this.PointToClient(pTemp);
                // 定位事件源的 Location
                Control control = sender as Control;
                control.Location = new Point(pTemp.X - CurX, pTemp.Y - CurY);
            }
        }

        private void Controls_MouseUp(object sender, MouseEventArgs e)
        {
            Mousedown = false; 
        }

        /// <summary>
        /// 验证答案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_check_Click(object sender, EventArgs e)
        {
            //肝固有动脉   pic1
            //左：0 - 170
            //上：250 - 540
            if (!(btn_ggydm.Left >= 0 && btn_ggydm.Left <= 170))
            {
                ShowError();
                return;
            }
            if (!(btn_ggydm.Top >= 250 && btn_ggydm.Top <= 540))
            {
                ShowError();
                return;
            }
            if (!(pic1.Left >= 0 && pic1.Left <= 170))
            {
                ShowError();
                return;
            }
            if (!(pic1.Top >= 250 && pic1.Top <= 540))
            {
                ShowError();
                return;
            }

            //肝门静脉 pic3
            //左：0 - 170
            //上：500 - 712
            if (!(btn_gmjm.Left >= 0 && btn_gmjm.Left <= 170))
            {
                ShowError();
                return;
            }
            if (!(btn_gmjm.Top >= 500 && btn_gmjm.Top <= 712))
            {
                ShowError();
                return;
            }
            if (!(pic3.Left >= 0 && pic3.Left <= 170))
            {
                ShowError();
                return;
            }
            if (!(pic3.Top >= 500 && pic3.Top <= 712))
            {
                ShowError();
                return;
            }

            //小叶间动脉 pic4
            //左：170 - 340 
            //上：250 - 540
            if (!(btn_xyjdm.Left >= 170 && btn_xyjdm.Left <= 340))
            {
                ShowError();
                return;
            }
            if (!(btn_xyjdm.Top >= 250 && btn_xyjdm.Top <= 540))
            {
                ShowError();
                return;
            }
            if (!(pic4.Left >= 170 && pic4.Left <= 340))
            {
                ShowError();
                return;
            }
            if (!(pic4.Top >= 250 && pic4.Top <= 540))
            {
                ShowError();
                return;
            }

            //小叶间静脉 pic5
            //左：170 - 340
            //上：500 - 712
            if (!(btn_xyjjm.Left >= 170 && btn_xyjjm.Left <= 340))
            {
                ShowError();
                return;
            }
            if (!(btn_xyjjm.Top >= 500 && btn_xyjjm.Top <= 712))
            {
                ShowError();
                return;
            }
            if (!(pic5.Left >= 170 && pic5.Left <= 340))
            {
                ShowError();
                return;
            }
            if (!(pic5.Top >= 500 && pic5.Top <= 712))
            {
                ShowError();
                return;
            }

            //肝血窦 pic8
            //左：335 - 500
            //上：285 - 712
            if (!(btn_gxd.Left >= 335 && btn_gxd.Left <= 500))
            {
                ShowError();
                return;
            }
            if (!(btn_gxd.Top >= 285 && btn_gxd.Top <= 712))
            {
                ShowError();
                return;
            }
            if (!(pic8.Left >= 335 && pic8.Left <= 500))
            {
                ShowError();
                return;
            }
            if (!(pic8.Top >= 285 && pic8.Top <= 712))
            {
                ShowError();
                return;
            }

            //中央静脉 pic6
            //左：498-670
            //上：285 - 712
            if (!(btn_zyjm.Left >= 498 && btn_zyjm.Left <= 670))
            {
                ShowError();
                return;
            }
            if (!(btn_zyjm.Top >= 285 && btn_zyjm.Top <= 712))
            {
                ShowError();
                return;
            }
            if (!(pic6.Left >= 498 && pic6.Left <= 670))
            {
                ShowError();
                return;
            }
            if (!(pic6.Top >= 285 && pic6.Top <= 712))
            {
                ShowError();
                return;
            }

            //肝静脉 pic7
            //左：660 - 840 
            //上：285 - 712
            if (!(btn_gjm.Left >= 660 && btn_gjm.Left <= 840))
            {
                ShowError();
                return;
            }
            if (!(btn_gjm.Top >= 285 && btn_gjm.Top <= 712))
            {
                ShowError();
                return;
            }
            if (!(pic7.Left >= 660 && pic7.Left <= 840))
            {
                ShowError();
                return;
            }
            if (!(pic7.Top >= 285 && pic7.Top <= 712))
            {
                ShowError();
                return;
            }

            //下腔静脉 pic2
            //左：830 - 962
            //上:285 - 712
            if (!(btn_xqjm.Left >= 830 && btn_xqjm.Left <= 962))
            {
                ShowError();
                return;
            }
            if (!(btn_xqjm.Top >= 285 && btn_xqjm.Top <= 712))
            {
                ShowError();
                return;
            }
            if (!(pic2.Left >= 830 && pic2.Left <= 962))
            {
                ShowError();
                return;
            }
            if (!(pic2.Top >= 285 && pic2.Top <= 712))
            {
                ShowError();
                return;
            }

            this.timer.Enabled = false;
            string msg = "恭喜【" + Login.Login_Name + "】同学完成测试！\n" +
                "您的学号是【" + Login.Login_ID + "】\n" +
                "共花费：" + useTime + "秒。\n" +
                "点击【确定】关闭提示！";
            MessageBox.Show(msg, "完成测试");
        }

        private void ShowError()
        {
            string msg = "抱歉您提交的答案错误！\n" +
                "当前您共花费：" + useTime + "秒。\n" +
                "点击【确定】您可以继续本次测试！";
            MessageBox.Show(msg, "答案错误");

        }


        private int useTime = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            useTime += 1;
            this.lbl_useTime.Text = useTime.ToString();
        }

        private void Random()
        {
            Button[] btns = new Button[] { btn_ggydm, btn_gmjm, btn_xyjdm, btn_xyjjm, btn_gxd, btn_zyjm, btn_gjm, btn_xqjm };
            PictureBox[] pics = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8 };
            int[] lefts = new int[] { 15, 133, 252, 372, 491, 610, 728, 848 }; //45  132
            lefts = lefts.OrderBy(c => Guid.NewGuid()).ToArray<int>(); //混淆数组
            int[] leftPic = lefts.OrderBy(c => Guid.NewGuid()).ToArray<int>();
            for (int i = 0; i < 8; i++)
            {
                btns[i].Left = lefts[i];
                pics[i].Left = leftPic[i];
            }
        }



    }
}
