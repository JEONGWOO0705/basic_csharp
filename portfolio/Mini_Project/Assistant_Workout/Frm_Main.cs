namespace Assistant_Workout
{
    public partial class Frm_Main : Form
    {
        string[] Chest = {"�ٺ� �÷� ��ġ ������", "�÷���Ʈ ��Ŭ���� ü��Ʈ ������", "���� ��Ŭ���� ��ġ ������", "�ӽ� �ö���",
                             "�ӽ� ü��Ʈ ������","���� �÷� ��ġ ������", "���̺� ü��Ʈ ������","���̺� ũ�ν� ���� �ο� �ö���","�÷���Ʈ ü��Ʈ ������",
                             "���� �ö���","����","���� ��Ŭ���� ��ġ ������"};
        int second;
        private bool Toggle = false;
        public Frm_Main()
        {
            InitializeComponent();
        }



        // �޺��ڽ� Ŭ����
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

        // ���� � ���� ��ư Ŭ���� �̺�Ʈ �ڵ鷯
        private void BtnChest_Click(object sender, EventArgs e)
        {

            CboClear();
            LstDoit.Items.Clear();



            // �޺��ڽ��� � ���� �ֱ�
            for (int i = 0; i < Chest.GetLength(0); i++)
            {
                int num = i;
                CboFirst.Items.Add(Chest[num].ToString());
                CboSecond.Items.Add(Chest[num].ToString());
                CboThird.Items.Add(Chest[num].ToString());
                CboFourth.Items.Add(Chest[num].ToString());
                CboFifth.Items.Add(Chest[num].ToString());
            }


            // ���� ���� � ����Ʈ �� �޺��ڽ��� �ֱ�
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

        #region '�޺��ڽ� � ���ϴ� ������ �ٲ��ִ� �̺�Ʈ �ڵ鷯'

        // ���� � ���� ü���� �̺�Ʈ �ڵ鷯( ex.. ��ġ ������ -> ����)
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



        // �� ��ð�
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


        // � ���� �̺�Ʈ �ڵ鷯
        private void BtnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��� �����ϰڽ��ϴ�!!!");
            timer1.Start();
        }

        // � �Ͻ� ���� �̺�Ʈ �ڵ鷯
        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (Toggle == false)
            {
                timer1.Start();
                //// ���⼭ ���� �ٽ��ϱ�!!!!!!!!!!!!!!!
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
                MessageBox.Show("���� �ð� ����!!!");
                ResetTime();
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("��� �����ðڽ��ϱ�?", "���� ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            Chkone.Checked = false; // üũ�ڽ��� �ٽ� ���� ����
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

