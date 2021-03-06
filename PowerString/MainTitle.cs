﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerString
{
    public partial class MainTitle : Form
    {
        public MainTitle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PracticeProblem_Click(object sender, EventArgs e)
        {
            SelectionOfQuiz selectionOfQuiz = new SelectionOfQuiz(this); //버튼을 클릭하면 3번화면이 나오게됨.
            this.Visible = false;
            selectionOfQuiz.Visible = true;
            selectionOfQuiz.Show();

            MainTitle mainTitle = this;
            //mainTitle.Close();
            

            //selectionOfQuiz.Location = new Point(100, 100);
            /*Controls.Add(selectionOfQuiz);//유저컨트롤 추가하는부분
            Controls.Remove(selectionOfQuiz);//유저컨트롤 제거하는 부분.*/

            QuizSelection quizSelection = new QuizSelection(); //버튼을 클릭하면 3번화면이 나오게됨.
            quizSelection.Show();//model
            SelectionOfQuiz selectionOfQuiz = new SelectionOfQuiz(); //버튼을 클릭하면 3번화면이 나오게됨.
            selectionOfQuiz.Show();//model
            this.Hide();
        }

        private void goToUserInfo_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭하면 메인 타이틀 창에서 유저창으로 이동하는 코드.
            // 띄운 유저 창을 닫을 때 까지 부모창에는 접근할 수 없음. 
            UserInfo userInfo = new UserInfo();
            userInfo.Show();
            
            /*var form = new UserInfo();
            var main = this.Location;

            form.Location = new Point((main.X + 600), main.Y);
            form.Show();*/
        }
    }
}
