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
    public partial class Nine : Form
    {
        public Nine()
        {
            InitializeComponent();
        }

        //方格位置坐标数组
        int[,] Local = new int[,] { { 58, 157 }, { 192, 157 }, { 327, 157 }, { 58, 292 }, { 192, 292 }, { 327, 292 }, { 58, 427 }, { 192, 427 }, { 327, 427 } };
        //图片索引
        PictureBox[] Pics = null;


        /// <summary>
        /// 加载图片初始位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nine_Load(object sender, EventArgs e)
        {
            Pics = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9 };
        }

        /// <summary>
        /// 开始游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            Pics = Pics.OrderBy(c => Guid.NewGuid()).ToArray<PictureBox>(); //混淆索引
            for (int i = 0; i < 9; i++)
            {
                Pics[i].Left = Local[i, 0];
                Pics[i].Top = Local[i, 1];
            }
            this.timer.Enabled = true;
            if (btn_start.Text == "重新开始")
            {
                time = 0;
            }
            if (btn_start.Text == "开始游戏")
            {
                btn_start.Text = "重新开始";
            }
        }

        /// <summary>
        /// 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int time = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            time += 1;
            this.lbl_time.Text = time.ToString();
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

        /// <summary>
        /// 图片原始位置
        /// </summary>
        private int tempLeft = 0;
        private int tempTop = 0;


        private void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            if (btn_start.Text == "开始游戏")
            {
                MessageBox.Show("请先点击【开始游戏】！","提示：");
                return;
            }
            CurX = e.X;
            CurY = e.Y;
            tempLeft = (sender as Control).Left;
            tempTop = (sender as Control).Top;
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
            //吸附判断
            Control control = sender as Control;
            int left = control.Left+66;
            int top = control.Top + 66;
            if ((left >= 507 && left <= 640) && (top >= 158 && top <= 291))
            {
                control.Left = 507;
                control.Top = 158;
            }
            else if ((left >= 641 && left <= 774) && (top >= 158 && top <= 291))
            {
                control.Left = 641;
                control.Top = 158;
            }
            else if ((left >= 776 && left <= 909) && (top >= 158 && top <= 291))
            {
                control.Left = 776;
                control.Top = 158;
            }
            else if ((left >= 507 && left <= 640) && (top >= 293 && top <= 426))
            {
                control.Left = 507;
                control.Top = 293;
            }
            else if ((left >= 641 && left <= 774) && (top >= 293 && top <= 426))
            {
                control.Left = 641;
                control.Top = 293;
            }
            else if ((left >= 776 && left <= 909) && (top >= 293 && top <= 426))
            {
                control.Left = 776;
                control.Top = 293;
            }
            else if ((left >= 507 && left <= 640) && (top >= 428 && top <= 561))
            {
                control.Left = 507;
                control.Top = 428;
            }
            else if ((left >= 641 && left <= 774) && (top >= 428 && top <= 561))
            {
                control.Left = 641;
                control.Top = 428;
            }
            else if ((left >= 776 && left <= 909) && (top >= 428 && top <= 561))
            {
                control.Left = 776;
                control.Top = 428;
            }
            else
            {
                control.Left = tempLeft;
                control.Top = tempTop;
            }
           
        }

        /// <summary>
        /// 提交答案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "开始游戏")
            {
                MessageBox.Show("请先点击【开始游戏】！", "提示：");
                return;
            }
            if (!(pic1.Left == 507 && pic1.Top == 158))
            {
                ShowError();
                return;
            }
            if (!(pic2.Left == 641 && pic2.Top == 158))
            {
                ShowError();
                return;
            }
            if (!(pic3.Left == 776 && pic3.Top == 158))
            {
                ShowError();
                return;
            }
            if (!(pic4.Left == 507 && pic4.Top == 293))
            {
                ShowError();
                return;
            }
            if (!(pic5.Left == 641 && pic5.Top == 293))
            {
                ShowError();
                return;
            }
            if (!(pic6.Left == 776 && pic6.Top == 293))
            {
                ShowError();
                return;
            }
            if (!(pic7.Left == 507 && pic7.Top == 428))
            {
                ShowError();
                return;
            }
            if (!(pic8.Left == 641 && pic8.Top == 428))
            {
                ShowError();
                return;
            }
            if (!(pic9.Left == 776 && pic9.Top == 428))
            {
                ShowError();
                return;
            }
            this.timer.Enabled = false;
            string msg = "恭喜【" + Login.Login_Name + "】同学完成测试！\n" +
                "您的学号是【" + Login.Login_ID + "】\n" +
                "共花费：" + time + "秒。\n" +
                "点击【确定】关闭提示！";
            MessageBox.Show(msg, "完成测试");
        }


        private void ShowError()
        {
            string msg = "抱歉您提交的答案错误！\n" +
               "当前您共花费：" + time + "秒。\n" +
               "点击【确定】您可以继续本次测试！";
            MessageBox.Show(msg, "答案错误");
        }


    }
}
