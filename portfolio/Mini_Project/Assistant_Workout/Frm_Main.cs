namespace Assistant_Workout
{
    public partial class Frm_Main : Form
    {
        #region '전역변수'
        string[] Chest = {"바벨 플랫 벤치 프레스", "플레이트 인클라인 체스트 프레스", "덤벨 인클라인 벤치 프레스", "머신 플라이",
                             "머신 체스트 프레스","덤벨 플랫 벤치 프레스", "케이블 체스트 프레스","케이블 크로스 오버 로우 플라이","플레이트 체스트 프레스",
                             "덤벨 플라이","딥스","덤벨 디클라인 벤치 프레스"};

        string[] Back = {"랫풀다운","케이블 스트레이트 암풀 다운","머신 와이드 풀다운","데드 리프트","루마니안 데드 리프트", "풀업", "프론트 로우",
                            "원암 벤트로우","케이블 시티드 로우","원암 케이블 시티드 로우","클로즈 그립 랫풀 다운","바벨 로우","덤벨로우"
                        ,"플레이드 로우","티바 로우"," 머신 레터럴 로우" };
        string[] Leg = {"플레이트 힙 쓰러스트","바벨 힙 쓰러스트","바벨 루마니안 데드 리프트","라잉 레그 컬","힙 어브덕션","스모 데드리프트"
                            , "바벨 스쿼트","레그 익스텐션","싱글 레그 익스텐션","레그 프레스","머신 레그프레스","스미스 머신 스쿼트",
                            "덤벨 스쿼트", "덤벨 루마니안 스쿼트","런지","바벨 런지","덤벨 런지"};

        int second;
        private bool Toggle = false;
        #endregion
        public Frm_Main()
        {
            InitializeComponent();
        }


        #region '메서드'
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
        #endregion

        #region'이벤트 핸들러'
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

        // 가슴,등,하체 운동 선택 버튼 클릭시 이벤트 핸들러
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
        private void BtnBack_Click(object sender, EventArgs e)
        {

            CboClear();
            LstDoit.Items.Clear();



            // 콤보박스에 운동 종류 넣기
            for (int i = 0; i < Back.GetLength(0); i++)
            {
                int num = i;
                CboFirst.Items.Add(Back[num].ToString());
                CboSecond.Items.Add(Back[num].ToString());
                CboThird.Items.Add(Back[num].ToString());
                CboFourth.Items.Add(Back[num].ToString());
                CboFifth.Items.Add(Back[num].ToString());
            }


            // 랜덤 등 운동 리스트 및 콤보박스에 넣기
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int doit = random.Next(0, Back.GetLength(0));
                LstDoit.Items.Add(Back[doit]);

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
        private void BtnLeg_Click(object sender, EventArgs e)
        {

            CboClear();
            LstDoit.Items.Clear();



            // 콤보박스에 운동 종류 넣기
            for (int i = 0; i < Leg.GetLength(0); i++)
            {
                int num = i;
                CboFirst.Items.Add(Leg[num].ToString());
                CboSecond.Items.Add(Leg[num].ToString());
                CboThird.Items.Add(Leg[num].ToString());
                CboFourth.Items.Add(Leg[num].ToString());
                CboFifth.Items.Add(Leg[num].ToString());
            }


            // 랜덤 등 운동 리스트 및 콤보박스에 넣기
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int doit = random.Next(0, Leg.GetLength(0));
                LstDoit.Items.Add(Leg[doit]);

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

        //--------------------------------------------------------------------------------


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
                
                if (second > 0)
                {
                    timer2.Start();
                }
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Toggle = false;
            }
        }
        
        // 운동 종료 이벤트 핸들러
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

        // 휴식시간 입력후 타이머 설정 이벤트 핸들러 --> 입력받은 값이 카운트 다운된다
        private void BtnSet_Click(object sender, EventArgs e)
        {
            ResetTime();
        }


        //--------------------------------------------------------------------------//
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


        #region 'Click and Rest'
        private void Chkone_Click(object sender, EventArgs e)
        {
            try
            {
            ResetTime();
            Txtone.Text = (Convert.ToInt32(Txtone.Text) + 1).ToString();
            Chkone.Checked = false; // 체크박스를 다시 선택 해제
            timer2.Start();
         

            }
            catch (Exception )
            {
                MessageBox.Show("쉬는 시간을 설정해주세요", "설정 누락", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Chkone.Checked = false; // 체크박스를 다시 선택 해제

            }
        }

        private void Chktwo_Click(object sender, EventArgs e)
        {

            try
            {
                ResetTime();
                Txttwo.Text = (Convert.ToInt32(Txttwo.Text) + 1).ToString();
                Chktwo.Checked = false;
                timer2.Start();

            }
            catch (Exception)
            {
                MessageBox.Show("쉬는 시간을 설정해주세요", "설정 누락", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Chktwo.Checked = false;

            }

        }

        private void Chkthree_Click(object sender, EventArgs e)
        {

            try
            {
                ResetTime();
                Txtthree.Text = (Convert.ToInt32(Txtthree.Text) + 1).ToString();
                Chkthree.Checked = false;
                timer2.Start();

            }
            catch (Exception)
            {
                MessageBox.Show("쉬는 시간을 설정해주세요", "설정 누락", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Chkthree.Checked = false;

            }

        }

        private void Chkfour_Click(object sender, EventArgs e)
        {
            try
            {
                ResetTime();
                Txtfour.Text = (Convert.ToInt32(Txtfour.Text) + 1).ToString();
                Chkfour.Checked = false;
                timer2.Start();

            }
            catch (Exception)
            {
                MessageBox.Show("쉬는 시간을 설정해주세요", "설정 누락", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Chkfour.Checked = false;

            }

        }

        private void Chkfive_Click(object sender, EventArgs e)
        {
            try
            {
                ResetTime();
                Txtfive.Text = (Convert.ToInt32(Txtfive.Text) + 1).ToString();
                Chkfour.Checked = false;
                timer2.Start();

            }
            catch (Exception)
            {
                MessageBox.Show("쉬는 시간을 설정해주세요", "설정 누락", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Chkfour.Checked = false;

            }

        }
        #endregion
        #endregion
    }
}


/*
 추가로 할 것
1. Chest, Back, Leg 데이터 베이스로 만들기 및 연결하기
2. MultiForm을 통해 랜덤 운동, 자신이 원하는 운동 선택할 수 있게 만들기, 자신이 만든 운동 루틴 불러오기 기능
 */


/*
프로그램 설명

- 운동을 시작한지 얼마 안된 헬린이들을 위한 프로그램
- 가슴, 등, 하체  버튼을 클릭하면 자동으로 운동 5개가 정해진다
- 자동으로 정해진 운동이 마음이 안들시 콤보박스를 이용해 자신이 원하는 운동으로 대체 할 수 있다.

- Start 버튼을 누르면 전체 운동 시간을 잴 수 있으며
- Stop 을 누르면 일시정지 및 재시작을 할 수 있다.

- 휴식시간 설정에 자신이 원하는 세트 수 사이의  시간(ex 180) 을 입력한 후, Set 버튼을 클릭한다.
- 세트가 끝나면 콤보박스 옆 체크박스를 체크한다. 자동으로 SET 수가 올라가며 
- 지정한 쉬는 시간이 줄어들게 된다.
- 쉬는 시간이 끝난다면 알람이 뜬다.

 */