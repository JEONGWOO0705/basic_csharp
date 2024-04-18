namespace Assistant_Workout
{
    public partial class Frm_Main : Form
    {
        string[] Chest = {"바벨 플랫 벤치 프레스", "플레이트 인클라인 체스트 프레스", "덤벨 인클라인 벤치 프레스", "머신 플라이",
                             "머신 체스트 프레스","덤벨 플랫 벤치 프레스", "케이블 체스트 프레스","케이블 크로스 오버 로우 플라이","플레이트 체스트 프레스",
                             "덤벨 플라이","딥스","덤벨 디클라인 벤치 프레스"};
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


        // 랜덤 운동 종목 체인지 이벤트 핸들러( ex.. 벤치 프레스 -> 딥스)
        private void CboFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CboFirst.SelectedIndex
            int a = 10;
        }
    }
}

