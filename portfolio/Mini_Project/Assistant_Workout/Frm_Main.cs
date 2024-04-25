namespace Assistant_Workout
{
    public partial class Frm_Main : Form
    {
        #region '��������'
        string[] Chest = {"�ٺ� �÷� ��ġ ������", "�÷���Ʈ ��Ŭ���� ü��Ʈ ������", "���� ��Ŭ���� ��ġ ������", "�ӽ� �ö���",
                             "�ӽ� ü��Ʈ ������","���� �÷� ��ġ ������", "���̺� ü��Ʈ ������","���̺� ũ�ν� ���� �ο� �ö���","�÷���Ʈ ü��Ʈ ������",
                             "���� �ö���","����","���� ��Ŭ���� ��ġ ������"};

        string[] Back = {"��Ǯ�ٿ�","���̺� ��Ʈ����Ʈ ��Ǯ �ٿ�","�ӽ� ���̵� Ǯ�ٿ�","���� ����Ʈ","�縶�Ͼ� ���� ����Ʈ", "Ǯ��", "����Ʈ �ο�",
                            "���� ��Ʈ�ο�","���̺� ��Ƽ�� �ο�","���� ���̺� ��Ƽ�� �ο�","Ŭ���� �׸� ��Ǯ �ٿ�","�ٺ� �ο�","�����ο�"
                        ,"�÷��̵� �ο�","Ƽ�� �ο�"," �ӽ� ���ͷ� �ο�" };
        string[] Leg = {"�÷���Ʈ �� ������Ʈ","�ٺ� �� ������Ʈ","�ٺ� �縶�Ͼ� ���� ����Ʈ","���� ���� ��","�� ������","���� ���帮��Ʈ"
                            , "�ٺ� ����Ʈ","���� �ͽ��ټ�","�̱� ���� �ͽ��ټ�","���� ������","�ӽ� ����������","���̽� �ӽ� ����Ʈ",
                            "���� ����Ʈ", "���� �縶�Ͼ� ����Ʈ","����","�ٺ� ����","���� ����"};

        int second;
        private bool Toggle = false;
        #endregion
        public Frm_Main()
        {
            InitializeComponent();
        }


        #region '�޼���'
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
        #endregion

        #region'�̺�Ʈ �ڵ鷯'
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

        // ����,��,��ü � ���� ��ư Ŭ���� �̺�Ʈ �ڵ鷯
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
        private void BtnBack_Click(object sender, EventArgs e)
        {

            CboClear();
            LstDoit.Items.Clear();



            // �޺��ڽ��� � ���� �ֱ�
            for (int i = 0; i < Back.GetLength(0); i++)
            {
                int num = i;
                CboFirst.Items.Add(Back[num].ToString());
                CboSecond.Items.Add(Back[num].ToString());
                CboThird.Items.Add(Back[num].ToString());
                CboFourth.Items.Add(Back[num].ToString());
                CboFifth.Items.Add(Back[num].ToString());
            }


            // ���� �� � ����Ʈ �� �޺��ڽ��� �ֱ�
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



            // �޺��ڽ��� � ���� �ֱ�
            for (int i = 0; i < Leg.GetLength(0); i++)
            {
                int num = i;
                CboFirst.Items.Add(Leg[num].ToString());
                CboSecond.Items.Add(Leg[num].ToString());
                CboThird.Items.Add(Leg[num].ToString());
                CboFourth.Items.Add(Leg[num].ToString());
                CboFifth.Items.Add(Leg[num].ToString());
            }


            // ���� �� � ����Ʈ �� �޺��ڽ��� �ֱ�
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
        
        // � ���� �̺�Ʈ �ڵ鷯
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

        // �޽Ľð� �Է��� Ÿ�̸� ���� �̺�Ʈ �ڵ鷯 --> �Է¹��� ���� ī��Ʈ �ٿ�ȴ�
        private void BtnSet_Click(object sender, EventArgs e)
        {
            ResetTime();
        }


        //--------------------------------------------------------------------------//
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


        #region 'Click and Rest'
        private void Chkone_Click(object sender, EventArgs e)
        {
            try
            {
            ResetTime();
            Txtone.Text = (Convert.ToInt32(Txtone.Text) + 1).ToString();
            Chkone.Checked = false; // üũ�ڽ��� �ٽ� ���� ����
            timer2.Start();
         

            }
            catch (Exception )
            {
                MessageBox.Show("���� �ð��� �������ּ���", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Chkone.Checked = false; // üũ�ڽ��� �ٽ� ���� ����

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
                MessageBox.Show("���� �ð��� �������ּ���", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("���� �ð��� �������ּ���", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("���� �ð��� �������ּ���", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("���� �ð��� �������ּ���", "���� ����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Chkfour.Checked = false;

            }

        }
        #endregion
        #endregion
    }
}


/*
 �߰��� �� ��
1. Chest, Back, Leg ������ ���̽��� ����� �� �����ϱ�
2. MultiForm�� ���� ���� �, �ڽ��� ���ϴ� � ������ �� �ְ� �����, �ڽ��� ���� � ��ƾ �ҷ����� ���
 */


/*
���α׷� ����

- ��� �������� �� �ȵ� �︰�̵��� ���� ���α׷�
- ����, ��, ��ü  ��ư�� Ŭ���ϸ� �ڵ����� � 5���� ��������
- �ڵ����� ������ ��� ������ �ȵ�� �޺��ڽ��� �̿��� �ڽ��� ���ϴ� ����� ��ü �� �� �ִ�.

- Start ��ư�� ������ ��ü � �ð��� �� �� ������
- Stop �� ������ �Ͻ����� �� ������� �� �� �ִ�.

- �޽Ľð� ������ �ڽ��� ���ϴ� ��Ʈ �� ������  �ð�(ex 180) �� �Է��� ��, Set ��ư�� Ŭ���Ѵ�.
- ��Ʈ�� ������ �޺��ڽ� �� üũ�ڽ��� üũ�Ѵ�. �ڵ����� SET ���� �ö󰡸� 
- ������ ���� �ð��� �پ��� �ȴ�.
- ���� �ð��� �����ٸ� �˶��� ���.

 */