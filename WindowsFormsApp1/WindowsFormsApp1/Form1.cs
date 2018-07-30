using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        long noA;
        long noB;
        long noC;
        long queCnt;
        long queMax;
        long corCnt;
        long type;
        string typeStr;

        public Form1()
        {
            InitializeComponent();
        }

        #region ロード時処理
        private void Form1_Load(object sender, EventArgs e)
        {
            //開始ボタンを押下するまで回答欄には記入不可
            TxtAnswer.Enabled = false;
        }
        #endregion

        #region 開始ボタン
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //ラジオボタンで問題数の変更を行う。
            //問題数が10問
            if (Rdb10.Checked)
            {
                queMax = 10;
            }
            //問題数が20問
            if (Rdb20.Checked)
            {
                queMax = 20;
            }
            //問題数が30問
            if (Rdb30.Checked)
            {
                queMax = 30;
            }
            //問題数が40問
            if (Rdb40.Checked)
            {
                queMax = 40;
            }

            //ラジオボタンで計算の種類を変更する。
            //足し算が選択状態
            if (RdbNum.Checked)
            {
                type = 1;
                typeStr = "+";
            }
            //引き算が選択状態
            if (RdbSub.Checked)
            {
                type = 2;
                typeStr = "-";
            }
            //割り算が選択状態
            if (RdbMul.Checked)
            {
                type = 3;
                typeStr = "*";
            }

            queCnt = 0;
            corCnt = 0;
            MondaiSakusei();
            //解答欄を入力可にする
            TxtAnswer.Enabled = true;
            //解答欄にフォーカスを移す
            TxtAnswer.Focus();
        }
        #endregion

        #region 解答記入時
        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数字以外を回答欄に記入させない
            if(e.KeyChar < '0' || e.KeyChar > '9' && e.KeyChar != '\b')
            {
                //-は解答欄に1つしか記入できない
                if(e.KeyChar != '-'  && TxtAnswer.TextLength == 0)
                {
                    e.Handled = true;
                }
                
            }
            //解答欄が空白の場合は答え合わせをしない
            if(e.KeyChar == (char)Keys.Enter && TxtAnswer.Text != "" && TxtAnswer.Text != "-")
            {
                Console.WriteLine(TxtAnswer.Text);
                AnswerCheck();
                TxtAnswer.Text = "";
                if(queCnt < queMax)
                {
                    MondaiSakusei();
                }
                else
                {
                    Seiseki();
                }
               
            }
        }
        #endregion

        #region 問題作成用メソッド
        private void MondaiSakusei()
        {
            noA = rand.Next(1,9);
            noB = rand.Next(1,9);
            LblMondai.Text = noA + typeStr + noB + "=";
            //足し算が選ばれたとき
            if(type == 1)
            {
                noC = noA + noB;
            }
            //引き算が選ばれたとき
            else if (type == 2)
            {
                noC = noA - noB;
            }
            //掛け算が選ばれたとき
            else if (type == 3)
            {
                noC = noA * noB;
            }

            queCnt++;
        }
        #endregion

        #region 回答確認メソッド
        private void AnswerCheck()
        {
            //解答が合っているとき
            if(noC == Int64.Parse(TxtAnswer.Text))
            {
                TxtQue.AppendText("〇");
                corCnt++;
            }
            //解答が間違っているとき
            else
            {
                TxtQue.AppendText("×");
            }
            //解答の表示
            TxtQue.AppendText(LblMondai.Text + TxtAnswer.Text + "\r\n");
        }
        #endregion

        #region 成績表示メソッド
        private void Seiseki()
        {
            double validity = (corCnt/queMax)* 100;
            TxtAnswer.Enabled = true;
            LblMondai.Text = "";
            TxtQue.AppendText("お疲れ様です。" + "\r\n");
            TxtQue.AppendText("正解数は" + corCnt + "です。" + "\r\n");
            TxtQue.AppendText("正答率は" + validity + "です。" + "\r\n");
        }
        #endregion

        #region 終了ボタン
        private void BtnClose_Click(object sender, EventArgs e)
        {
            //確認メッセージの表示
            DialogResult result = MessageBox.Show(this,
                "終了しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            //Yesが押下されたとき
            if(result.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
        #endregion
    }
}
