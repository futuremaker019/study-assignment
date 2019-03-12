using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum Operators { Add, Sub, Multi, Div }          // 열거형으로 연산자 상수 선언

    public partial class SimpleCalculator : Form
    {
        public double Result = 0;                           // Result 변수 초기화
        public bool isNewNum = true;                         
        public Operators Opt = Operators.Add;

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        // 숫자 이벤트 핸들러
        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;              // sender의 형변환으로 숫자입력을 핸들러 하나로 묶음
            SetNum(numButton.Text);
        }

        // 핵심코드 생성 : 숫자입력
        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        // 연산 버튼 이벤트 핸들러
        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)                           // 연산버튼이 연속으로 두번 클릭시 자가연산되는 것을 방지
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result = Result + num;
                else if (Opt == Operators.Sub)
                    Result = Result - num;
                else if (Opt == Operators.Multi)
                    Result = Result * num;
                else
                    Result = Result / num;

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;               // 연산을 저장함
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else
                Opt = Operators.Div;
        }

        // Clear 버튼 이벤트 핸들러
        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
    }
}
