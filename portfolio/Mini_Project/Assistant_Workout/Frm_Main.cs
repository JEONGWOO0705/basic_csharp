namespace Assistant_Workout
{
    public partial class Frm_Main : Form
    {
        string[] Chest = {"�ٺ� �÷� ��ġ ������", "�÷���Ʈ ��Ŭ���� ü��Ʈ ������", "���� ��Ŭ���� ��ġ ������", "�ӽ� �ö���",
                             "�ӽ� ü��Ʈ ������","���� �÷� ��ġ ������", "���̺� ü��Ʈ ������","���̺� ũ�ν� ���� �ο� �ö���","�÷���Ʈ ü��Ʈ ������",
                             "���� �ö���","����","���� ��Ŭ���� ��ġ ������"};
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


        // ���� � ���� ü���� �̺�Ʈ �ڵ鷯( ex.. ��ġ ������ -> ����)
        private void CboFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CboFirst.SelectedIndex
            int a = 10;
        }
    }
}

