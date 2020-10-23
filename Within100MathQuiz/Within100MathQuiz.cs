using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
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
        
        private List<int> num_left;
        private List<int> num_right;
        private List<Op> op;
        private List<(bool, int)> ans;
        private readonly int total_page_num = 5;
        private int _currentPageNum = 1;

        enum Status
        {
            Idle = 0,
            Quiz = 1,
            QuizFinished = 2
        }

        private Status status;
        //难度
        private int _level = 1;
        //剩余时间
        private int _timeLeft;
        //分数
        private int _score;

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case Status.Idle:
                case Status.QuizFinished:
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
                        int judge = _score / 25 * 25;
                        switch (judge)
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
                        status = Status.QuizFinished;
                        timer1.Stop();
                        for (var i = 0; i < ans.Count; i++)
                        {
                            ans[i] = op[i].check((int)num_left[i], num_right[i], 0);
                        }
                        UpdateAnswer();
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
                MessageBox.Show(@"时间到了还不交卷？0分！", @"Time's up!");
                status = Status.QuizFinished;
                for (var i = 0; i < ans.Count; i++)
                {
                    ans[i] = op[i].check((int)num_left[i], num_right[i], 0);
                }
                UpdateAnswer();
                ButtonStart.Enabled = true;
            }
        }

        private void StartQuiz()
        {
            //填充题目
            num_left = new List<int>();
            num_right = new List<int>();
            ans = new List<(bool, int)>();
            op = new List<Op>();
            for (var i = 0; i < total_page_num * 4; i++)
            {
                ans.Add((true, 0));
            }
            _score = 0;
            LabelPage.Text = $"第{_currentPageNum}页";
            for(var i = 0; i < total_page_num * 4; i++)
                op.Add(Op.create_Op(_random.Next(0, 4)));
            foreach(Op o in op)
            {
                o.generate_Data(out var left, out var right);
                num_left.Add(left);
                num_right.Add(right);
            }
            UpdateQuiz();
            //根据难度适当上调时间
            _timeLeft = 95 + _level * 5;
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
            if (!JudgeFormat())
                return false;
            saveAns();
            checkAns();
            return true;
        }

        private void checkAns()
        {
            for (int i = 0; i < Math.Min(total_page_num * 4, ans.Count); i++)
            {
                Op o = op[i];
                if (o.check(num_left[i], num_right[i], ans[i].Item2).Item1)
                    _score += 5;
            }
        }

        private void ButtonPageUp_Click(object sender, EventArgs e)
        {
            switch(status)
            {
                case Status.Idle:
                    {
                        MessageBox.Show(@"测验未开始！",@"Oops！");
                        break;
                    }
                case Status.Quiz:
                case Status.QuizFinished:
                {
                       if(_currentPageNum == 1)
                            MessageBox.Show(@"是第一页！",@"Oops！");
                       else
                       {
                            if(!JudgeFormat())
                               return;
                            saveAns();
                            _currentPageNum--;
                            LabelPage.Text = $"第{_currentPageNum}页";
                            UpdateQuiz();
                            UpdateAnswer();
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
                        MessageBox.Show(@"测验未开始!",@"Oops!");
                        break;
                    }
                case Status.Quiz:
                case Status.QuizFinished:
                {
                        if (_currentPageNum == total_page_num)
                            MessageBox.Show(@"是最后一页！", @"Oops!");
                        else
                        {
                            if (!JudgeFormat())
                                return;
                            saveAns();
                            _currentPageNum++;
                            LabelPage.Text = $"第{_currentPageNum}页";
                            UpdateQuiz();
                            UpdateAnswer();
                        }
                        break;
                    }
            }       
        }

        private void UpdateQuiz()
        {
            LabelLeftNum1.Text = num_left[(_currentPageNum - 1) * 4].ToString();
            LabelLeftNum2.Text = num_left[(_currentPageNum - 1) * 4 + 1].ToString();
            LabelLeftNum3.Text = num_left[(_currentPageNum - 1) * 4 + 2].ToString();
            LabelLeftNum4.Text = num_left[(_currentPageNum - 1) * 4 + 3].ToString();
            LabelRightNum1.Text = num_right[(_currentPageNum - 1) * 4].ToString();
            LabelRightNum2.Text = num_right[(_currentPageNum - 1) * 4 + 1].ToString();
            LabelRightNum3.Text = num_right[(_currentPageNum - 1) * 4 + 2].ToString();
            LabelRightNum4.Text = num_right[(_currentPageNum - 1) * 4 + 3].ToString();
            LabelOp1.Text = op[(_currentPageNum - 1) * 4].ToString();
            LabelOp2.Text = op[(_currentPageNum - 1) * 4 + 1].ToString();
            LabelOp3.Text = op[(_currentPageNum - 1) * 4 + 2].ToString();
            LabelOp4.Text = op[(_currentPageNum - 1) * 4 + 3].ToString();
        }
        private void UpdateAnswer()
        {

            Ans1.Text = ans[(_currentPageNum - 1) * 4].Item2.ToString();
                Ans2.Text = ans[(_currentPageNum - 1) * 4 + 1].Item2.ToString();
                Ans3.Text = ans[(_currentPageNum - 1) * 4 + 2].Item2.ToString();
                Ans4.Text = ans[(_currentPageNum - 1) * 4 + 3].Item2.ToString();
        }
        private bool JudgeFormat()
        {
            try
            {
                Int32.Parse(Ans1.Text);
                Int32.Parse(Ans2.Text);
                Int32.Parse(Ans3.Text);
                Int32.Parse(Ans4.Text);
                return true;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                MessageBox.Show(@"空着也敢交？", @"格式不对！");
                return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                MessageBox.Show(@"你填的都是什么东西？", @"格式不对！");
                return false;
            }
            
        }
        private void saveAns()
        {
            if (ans.Count >= _currentPageNum * 4)
            {
                ans[(_currentPageNum - 1) * 4] = (true, Int32.Parse(Ans1.Text));
                ans[(_currentPageNum - 1) * 4 + 1] = (true, Int32.Parse(Ans2.Text));
                ans[(_currentPageNum - 1) * 4 + 2] = (true, Int32.Parse(Ans3.Text));
                ans[(_currentPageNum - 1) * 4 + 3] = (true, Int32.Parse(Ans4.Text));
            }
            else
            {
                ans.Add((true, Int32.Parse(Ans1.Text)));
                ans.Add((true, Int32.Parse(Ans2.Text)));
                ans.Add((true, Int32.Parse(Ans3.Text)));
                ans.Add((true, Int32.Parse(Ans4.Text)));
            }
        }
    }
}
