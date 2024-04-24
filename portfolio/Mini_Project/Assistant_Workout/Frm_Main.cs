namespace Assistant_Workout
{
    public partial class Frm_Main : Form
    {
        string[] Chest = {"바벨 플랫 벤치 프레스", "플레이트 인클라인 체스트 프레스", "덤벨 인클라인 벤치 프레스", "머신 플라이",
                             "머신 체스트 프레스","덤벨 플랫 벤치 프레스", "케이블 체스트 프레스","케이블 크로스 오버 로우 플라이","플레이트 체스트 프레스",
                             "덤벨 플라이","딥스","덤벨 디클라인 벤치 프레스"};
        int second;
        private bool Toggle = false;
        public Frm_Main()
        {
            InitializeComponent();
        }



        // 콤보박스 클리어
        private void CboClear()
        {
            CboFirst.Items.Clear();
            CboSecond.Items.Clear();
            CboThird.Items.Clear();
            CboFourth.Items.Clear();
            CboFifth.Items.Clear();
        }
        private void ResetTime()
        {
            TxtRestTime.Text = TxtSetRestTime.Text;
            second = Convert.ToInt32(TxtRestTime.Text);
        }

        // 가슴 운동 선택 버튼 클릭시 이벤트 핸들러
        private void BtnChest_Click(object sender, EventArgs e)
        {

            CboClear();
            LstDoit.Items.Clear();



            // 콤보박스에 운동 종류 넣기
            for (int i = 0; i < Chest.GetLength(0); i++)
            {
                int num = i;
                CboFirst.Items.Add(Chest[num].ToString());
                CboSecond.Items.Add(Chest[num].ToString());
                CboThird.Items.Add(Chest[num].ToString());
                CboFourth.Items.Add(Chest[num].ToString());
                CboFifth.Items.Add(Chest[num].ToString());
            }


            // 랜덤 가슴 운동 리스트 및 콤보박스에 넣기
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int doit = random.Next(0, Chest.GetLength(0));
                LstDoit.Items.Add(Chest[doit]);

                int switch_on = i;
                switch (switch_on)
                {
                    case 0:
                        CboFirst.SelectedIndex = doit; break;
                    case 1:
                        CboSecond.SelectedIndex = doit; break;
                    case 2:
                        CboThird.SelectedIndex = doit; break;
                    case 3:
                        CboFourth.SelectedIndex = doit; break;
                    case 4:
                        CboFifth.SelectedIndex = doit; break;
                    default: break;
                }
            }
        }

        #region '콤보박스 운동 원하는 것으로 바꿔주는 이벤트 핸들러'

        // 랜덤 운동 종목 체인지 이벤트 핸들러( ex.. 벤치 프레스 -> 딥스)
        private void CboFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstDoit.Items[0] = CboFirst.Text;
        }

        private void CboSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstDoit.Items[1] = CboSecond.Text;
        }

        private void CboThird_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstDoit.Items[2] = CboThird.Text;
        }

        private void CboFourth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstDoit.Items[3] = CboFourth.Text;
        }

        private void CboFifth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstDoit.Items[4] = CboFifth.Text;
        }
        #endregion



        // 총 운동시간
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (TxtSec.Text == "59")
            {
                if (TxtMin.Text == "59")
                {
                    TxtSec.Text = "0";
                    TxtMin.Text = "0";
                    TxtHour.Text = (Convert.ToInt32(TxtHour.Text) + 1).ToString();

                }
                else
                {
                    TxtSec.Text = "0";
                    TxtMin.Text = (Convert.ToInt32(TxtMin.Text) + 1).ToString();
                }
            }
            else
            {
                TxtSec.Text = (Convert.ToInt32(TxtSec.Text) + 1).ToString();
            }

        }


        // 운동 시작 이벤트 핸들러
        private void BtnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("운동을 시작하겠습니다!!!");
            timer1.Start();
        }

        // 운동 일시 정지 이벤트 핸들러
        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (Toggle == false)
            {
                timer1.Start();
                //// 여기서 부터 다시하기!!!!!!!!!!!!!!!
                if(second <= 0)
                {
                    timer2.Start();
                }
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                Toggle = false;
            }
        }



        private void BtnSet_Click(object sender, EventArgs e)
        {
            ResetTime();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TxtRestTime.Text = second--.ToString();
            if (second == -1)
            {
                timer2.Stop();
                MessageBox.Show("쉬는 시간 종료!!!");
                ResetTime();
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("운동을 끝내시겠습니까?", "종료 여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                timer1.Stop();
                timer2.Stop();
                TxtHour.Text = "0";
                TxtMin.Text = "0";
                TxtSec.Text = "0";
                TxtSetRestTime.Text = "0";
                TxtRestTime.Text = "0";
            }

        }

        #region 'Click and Rest'
        private void Chkone_Click(object sender, EventArgs e)
        {
            ResetTime();
            Txtone.Text = (Convert.ToInt32(Txtone.Text) + 1).ToString();
            Chkone.Checked = false; // 체크박스를 다시 선택 해제
            timer2.Start();
        }

        private void Chktwo_Click(object sender, EventArgs e)
        {
            ResetTime();
            Txttwo.Text=(Convert.ToInt32(Txttwo.Text) + 1).ToString();
            Chktwo.Checked = false;
            timer2.Start();
        }

        private void Chkthree_Click(object sender, EventArgs e)
        {
            ResetTime();
            Txtthree.Text = (Convert.ToInt32(Txtthree.Text) + 1).ToString();    
            Chkthree.Checked = false;
            timer2.Start();
        }

        private void Chkfour_Click(object sender, EventArgs e)
        {
            ResetTime();
            Txtfour.Text = (Convert.ToInt32(Txtfour.Text)+1).ToString();
            Chkfour.Checked = false;
            timer2.Start();
        }

        private void Chkfive_Click(object sender, EventArgs e)
        {
            ResetTime();
            Txtfive.Text = (Convert.ToInt32(Txtfive.Text) + 1).ToString();
            Chkfour.Checked = false;
            timer2.Start();
        }
        #endregion
    }
}

