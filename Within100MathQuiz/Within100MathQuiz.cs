using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Media;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using Within100MathQuiz.Properties;

namespace Within100MathQuiz
{
    public partial class Quiz : Form
    {
        private readonly Random _random = new Random();
        /*private int _addNumLeft, _addNumRight;
        private int _minusNumLeft, _minusNumRight;
        private int _multiplyNumLeft, _multiplyNumRight;
        private int _divideNumLeft, _divideNumRight;*/

        private ArrayList num_left;
        private ArrayList num_right;
        private ArrayList op;
        private ArrayList ans;
        private int total_page_num = 5;
        private int current_page_num = 1;

        enum Status
        {
            Idle = 0,
            Quiz = 1
        }

        private Status status;
        //难度
        private int _level = 1;
        //剩余时间
        private int _timeLeft = 10000000;
        //分数
        private int _score;

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case Status.Idle:
                {
                    StartQuiz();
                    //初始化文本
                    Ans1.Text = "0";
                    Ans2.Text = "0";
                    Ans3.Text = "0";
                    Ans4.Text = "0";
                    ButtonStart.Text = @"要交卷了？";
                    status = Status.Quiz;
                    break;
                }
                case Status.Quiz:
                {
                    if(CheckCorrectness())
                    {
                        var str = new StringBuilder();
                        switch (_score)
                        {
                            case 0:
                                str.Append("呵呵，");
                                break;
                            case 25:
                                str.Append("你只有");
                                break;
                            case 50:
                                str.Append("勉强有个");
                                break;
                            case 75:
                                str.Append("竟然有");
                                break;
                            case 100:
                                str.Append("真不错");
                                break;
                        }
                        str.Append(_score);
                        str.Append(@"分！");
                        status = Status.Idle;
                        timer1.Stop();
                        _timeLeft = 25;
                        MessageBox.Show(str.ToString(), @"你的成绩是：");
                        ButtonStart.Text = @"开始测验？";
                    }
                    break;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= 1;
                LabelTimer.Text = _timeLeft.ToString() + @"秒";
            }
            else
            {
                timer1.Stop();
                LabelTimer.Text = @"Time's up!";
                //播放音乐羞辱小朋友
                //SoundPlayer player = new SoundPlayer(@"E:\VS2019projects\calculator\Within100MathQuiz\Within100MathQuiz\assets\哈哈哈多捞啊.wav");
                //player.Play();
                MessageBox.Show(@"时间到了还不交卷？0分！", @"Time's up!");
                status = Status.Idle;
                /*Ans1.Text = (_addNumLeft + _addNumRight).ToString();
                Ans2.Text = (_minusNumLeft - _minusNumRight).ToString();
                Ans3.Text = (_multiplyNumLeft * _multiplyNumRight).ToString();
                Ans4.Text = (_divideNumLeft / _divideNumRight).ToString();*/
                ButtonStart.Enabled = true;
            }
        }

        private void StartQuiz()
        {
            //填充题目
            int left, right;
            num_left = new ArrayList();
            num_right = new ArrayList();
            ans = new ArrayList();
            op = new ArrayList();
            _score = 0;
            for(int i = 0; i < total_page_num * 4; i++)
                op.Add(Op.create_Op(_random.Next(0, 2)));
            foreach(Op o in op)
            {
                o.generate_Data(out left, out right);
                num_left.Add(left);
                num_right.Add(right);
            }
            LabelLeftNum1.Text = num_left[0].ToString();
            LabelLeftNum2.Text = num_left[1].ToString();
            LabelLeftNum3.Text = num_left[2].ToString();
            LabelLeftNum4.Text = num_left[3].ToString();
            LabelRightNum1.Text = num_right[0].ToString();
            LabelRightNum2.Text = num_right[1].ToString();
            LabelRightNum3.Text = num_right[2].ToString();
            LabelRightNum4.Text = num_right[3].ToString();
            LabelOp1.Text = op[0].ToString();
            LabelOp2.Text = op[1].ToString();
            LabelOp3.Text = op[2].ToString();
            LabelOp4.Text = op[3].ToString();
            //根据难度适当上调时间
            _timeLeft += _level * 5;
            //初始化计时器
            LabelTimer.Text = _timeLeft.ToString()+@"秒";
            timer1.Enabled = true;

        }

        private void SetLevel(int level)
        {
            this._level = level;
        }
        public Quiz()
        {
            InitializeComponent();
        }
        //返回真只是表示可以结束了，并不是说全部正确
        //只有格式错误才会返回false，允许重填
        private bool CheckCorrectness()
        {
            try
            {
                saveAns();

                checkAns();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                //播放音乐羞辱小朋友
                SoundPlayer player = new SoundPlayer(Within100MathQuiz.Properties.Resources.哈哈哈多捞啊);
                player.Play();
                MessageBox.Show(@"空着也敢交？", @"格式不对！");
                return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                //播放音乐羞辱小朋友
                SoundPlayer player = new SoundPlayer(Within100MathQuiz.Properties.Resources.哈哈哈多捞啊);
                player.Play();
                MessageBox.Show(@"你填的都是什么东西？", @"格式不对！");
                return false;
            }
            return true;
        }

        private void checkAns()
        {
            for (int i = 0; i < Math.Min(total_page_num * 4, ans.Count); i++)
            {
                Op o = (Op)op[i];
                if (o.check((int)num_left[i], (int)num_right[i], (int)ans[i]))
                    _score += 5;
            }
        }

        private void ButtonPageUp_Click(object sender, EventArgs e)
        {
            switch(status)
            {
                case Status.Idle:
                    {
                        MessageBox.Show("测验未开始");
                        break;
                    }
                case Status.Quiz:
                    {
                       if(current_page_num == 1)
                            MessageBox.Show("是第一页！");
                       else
                        {
                            saveAns();
                            current_page_num--;
                            LabelLeftNum1.Text = num_left[(current_page_num - 1) * 4].ToString();
                            LabelLeftNum2.Text = num_left[(current_page_num - 1) * 4 + 1].ToString();
                            LabelLeftNum3.Text = num_left[(current_page_num - 1) * 4 + 2].ToString();
                            LabelLeftNum4.Text = num_left[(current_page_num - 1) * 4 + 3].ToString();
                            LabelRightNum1.Text = num_right[(current_page_num - 1) * 4].ToString();
                            LabelRightNum2.Text = num_right[(current_page_num - 1) * 4 + 1].ToString();
                            LabelRightNum3.Text = num_right[(current_page_num - 1) * 4 + 2].ToString();
                            LabelRightNum4.Text = num_right[(current_page_num - 1) * 4 + 3].ToString();
                            LabelOp1.Text = op[(current_page_num - 1) * 4].ToString();
                            LabelOp2.Text = op[(current_page_num - 1) * 4 + 1].ToString();
                            LabelOp3.Text = op[(current_page_num - 1) * 4 + 2].ToString();
                            LabelOp4.Text = op[(current_page_num - 1) * 4 + 3].ToString();
                            if(ans.Count >= current_page_num * 4)
                            {
                                Ans1.Text = ans[(current_page_num - 1) * 4].ToString();
                                Ans2.Text = ans[(current_page_num - 1) * 4 + 1].ToString();
                                Ans3.Text = ans[(current_page_num - 1) * 4 + 2].ToString();
                                Ans4.Text = ans[(current_page_num - 1) * 4 + 3].ToString();
                            }
                            else
                            {
                                Ans1.Text = "0";
                                Ans2.Text = "0";
                                Ans3.Text = "0";
                                Ans4.Text = "0";
                                ans.Add(0);
                                ans.Add(0);
                                ans.Add(0);
                                ans.Add(0);
                            }
                        }
                       break;
                    }
            }
        }

        private void ButtonPageDown_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case Status.Idle:
                    {
                        MessageBox.Show("测验未开始");
                        break;
                    }
                case Status.Quiz:
                    {
                        if (current_page_num == total_page_num)
                            MessageBox.Show("是最后一页！");
                        else
                        {
                            saveAns();
                            current_page_num++;
                            LabelLeftNum1.Text = num_left[(current_page_num - 1) * 4].ToString();
                            LabelLeftNum2.Text = num_left[(current_page_num - 1) * 4 + 1].ToString();
                            LabelLeftNum3.Text = num_left[(current_page_num - 1) * 4 + 2].ToString();
                            LabelLeftNum4.Text = num_left[(current_page_num - 1) * 4 + 3].ToString();
                            LabelRightNum1.Text = num_right[(current_page_num - 1) * 4].ToString();
                            LabelRightNum2.Text = num_right[(current_page_num - 1) * 4 + 1].ToString();
                            LabelRightNum3.Text = num_right[(current_page_num - 1) * 4 + 2].ToString();
                            LabelRightNum4.Text = num_right[(current_page_num - 1) * 4 + 3].ToString();
                            LabelOp1.Text = op[(current_page_num - 1) * 4].ToString();
                            LabelOp2.Text = op[(current_page_num - 1) * 4 + 1].ToString();
                            LabelOp3.Text = op[(current_page_num - 1) * 4 + 2].ToString();
                            LabelOp4.Text = op[(current_page_num - 1) * 4 + 3].ToString();
                            if (ans.Count >= current_page_num * 4)
                            {
                                Ans1.Text = ans[(current_page_num - 1) * 4].ToString();
                                Ans2.Text = ans[(current_page_num - 1) * 4 + 1].ToString();
                                Ans3.Text = ans[(current_page_num - 1) * 4 + 2].ToString();
                                Ans4.Text = ans[(current_page_num - 1) * 4 + 3].ToString();
                            }
                            else
                            {
                                Ans1.Text = "0";
                                Ans2.Text = "0";
                                Ans3.Text = "0";
                                Ans4.Text = "0";
                                ans.Add(0);
                                ans.Add(0);
                                ans.Add(0);
                                ans.Add(0);
                            }
                        }
                        break;
                    }
            }
        }


        private void saveAns()
        {
            if (ans.Count >= current_page_num * 4)
            {
                ans[(current_page_num - 1) * 4] = Int32.Parse(Ans1.Text);
                ans[(current_page_num - 1) * 4 + 1] = Int32.Parse(Ans2.Text);
                ans[(current_page_num - 1) * 4 + 2] = Int32.Parse(Ans3.Text);
                ans[(current_page_num - 1) * 4 + 3] = Int32.Parse(Ans4.Text);
            }
            else
            {
                ans.Add(Int32.Parse(Ans1.Text));
                ans.Add(Int32.Parse(Ans2.Text));
                ans.Add(Int32.Parse(Ans3.Text));
                ans.Add(Int32.Parse(Ans4.Text));
            }
        }
    }
}
