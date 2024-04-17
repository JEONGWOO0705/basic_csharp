namespace ex18_winControlApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PrgDummy = new ProgressBar();
            TrbDummy = new TrackBar();
            groupBox3 = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox4 = new GroupBox();
            TrvDummy = new TreeView();
            BtnAddChild = new Button();
            button2 = new Button();
            BtnAddRoot = new Button();
            LsvDummy = new ListView();
            groupBox5 = new GroupBox();
            PicNormal = new PictureBox();
            BtnLoad = new Button();
            DlgOpenImage = new OpenFileDialog();
            GrbEditor = new GroupBox();
            BtnFileSave = new Button();
            BtnFileLoad = new Button();
            RtxEditor = new RichTextBox();
            groupBox6 = new GroupBox();
            BtnThread = new Button();
            BtnStop = new Button();
            BtnNothread = new Button();
            PrgProcess = new ProgressBar();
            TxtLog = new TextBox();
            BgwProgress = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNormal).BeginInit();
            GrbEditor.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("나눔고딕", 8.999999F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(28, 59);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(293, 21);
            TxtSampleText.TabIndex = 3;
            TxtSampleText.Text = "Hello, C# !!";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕", 8.999999F);
            ChkItalic.Location = new Point(259, 32);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold);
            ChkBold.Location = new Point(203, 32);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(48, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.Font = new Font("나눔고딕", 8.999999F);
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(73, 30);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(121, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("나눔고딕", 8.999999F);
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(36, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrgDummy);
            groupBox2.Controls.Add(TrbDummy);
            groupBox2.Location = new Point(12, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 126);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙 바, 프로그레스 바";
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(28, 72);
            PrgDummy.Maximum = 20;
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(290, 23);
            PrgDummy.TabIndex = 1;
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(28, 30);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(293, 45);
            TrbDummy.TabIndex = 0;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuestion);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModal);
            groupBox3.Location = new Point(12, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(349, 78);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창, 모달리스창";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnQuestion.Location = new Point(256, 22);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(62, 40);
            BtnQuestion.TabIndex = 3;
            BtnQuestion.Text = "...";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnMsgBox.Location = new Point(179, 22);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(58, 40);
            BtnMsgBox.TabIndex = 1;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnModaless.Location = new Point(103, 22);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(58, 40);
            BtnModaless.TabIndex = 1;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnModal.Location = new Point(30, 22);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(58, 40);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TrvDummy);
            groupBox4.Controls.Add(BtnAddChild);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(BtnAddRoot);
            groupBox4.Controls.Add(LsvDummy);
            groupBox4.Location = new Point(12, 330);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(349, 176);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰, 리스트뷰";
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(28, 22);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(140, 100);
            TrvDummy.TabIndex = 3;
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(125, 125);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(90, 40);
            BtnAddChild.TabIndex = 2;
            BtnAddChild.Text = "자식 추가";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 126);
            button2.Name = "button2";
            button2.Size = new Size(79, 34);
            button2.TabIndex = 2;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(29, 126);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(90, 40);
            BtnAddRoot.TabIndex = 2;
            BtnAddRoot.Text = "루트 추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(179, 22);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(140, 100);
            LsvDummy.TabIndex = 0;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(PicNormal);
            groupBox5.Controls.Add(BtnLoad);
            groupBox5.Location = new Point(367, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(267, 312);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽처박스";
            // 
            // PicNormal
            // 
            PicNormal.BackColor = SystemColors.ActiveBorder;
            PicNormal.Location = new Point(6, 22);
            PicNormal.Name = "PicNormal";
            PicNormal.Size = new Size(255, 255);
            PicNormal.TabIndex = 0;
            PicNormal.TabStop = false;
            PicNormal.Click += PicNormal_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(6, 283);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(97, 21);
            BtnLoad.TabIndex = 2;
            BtnLoad.Text = "이미지 로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // GrbEditor
            // 
            GrbEditor.Controls.Add(BtnFileSave);
            GrbEditor.Controls.Add(BtnFileLoad);
            GrbEditor.Controls.Add(RtxEditor);
            GrbEditor.Location = new Point(634, 12);
            GrbEditor.Name = "GrbEditor";
            GrbEditor.Size = new Size(254, 494);
            GrbEditor.TabIndex = 5;
            GrbEditor.TabStop = false;
            GrbEditor.Text = "텍스트 에디터";
            // 
            // BtnFileSave
            // 
            BtnFileSave.Location = new Point(133, 455);
            BtnFileSave.Name = "BtnFileSave";
            BtnFileSave.Size = new Size(86, 23);
            BtnFileSave.TabIndex = 2;
            BtnFileSave.Text = "파일 세이브";
            BtnFileSave.UseVisualStyleBackColor = true;
            BtnFileSave.Click += BtnFileSave_Click;
            // 
            // BtnFileLoad
            // 
            BtnFileLoad.Location = new Point(32, 455);
            BtnFileLoad.Name = "BtnFileLoad";
            BtnFileLoad.Size = new Size(86, 23);
            BtnFileLoad.TabIndex = 1;
            BtnFileLoad.Text = "파일 로드";
            BtnFileLoad.UseVisualStyleBackColor = true;
            BtnFileLoad.Click += BtnFileLoad_Click;
            // 
            // RtxEditor
            // 
            RtxEditor.BorderStyle = BorderStyle.None;
            RtxEditor.Location = new Point(3, 19);
            RtxEditor.Name = "RtxEditor";
            RtxEditor.Size = new Size(248, 421);
            RtxEditor.TabIndex = 0;
            RtxEditor.Text = "";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnThread);
            groupBox6.Controls.Add(BtnStop);
            groupBox6.Controls.Add(BtnNothread);
            groupBox6.Controls.Add(PrgProcess);
            groupBox6.Controls.Add(TxtLog);
            groupBox6.Location = new Point(373, 330);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(255, 176);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "스레드, 백그라운드 워커";
            // 
            // BtnThread
            // 
            BtnThread.Location = new Point(87, 134);
            BtnThread.Name = "BtnThread";
            BtnThread.Size = new Size(75, 23);
            BtnThread.TabIndex = 2;
            BtnThread.Text = "스레드";
            BtnThread.UseVisualStyleBackColor = true;
            BtnThread.Click += BtnThread_Click;
            // 
            // BtnStop
            // 
            BtnStop.Enabled = false;
            BtnStop.Location = new Point(168, 134);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 23);
            BtnStop.TabIndex = 2;
            BtnStop.Text = "중지";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnNothread
            // 
            BtnNothread.Location = new Point(6, 134);
            BtnNothread.Name = "BtnNothread";
            BtnNothread.Size = new Size(75, 23);
            BtnNothread.TabIndex = 2;
            BtnNothread.Text = "노스레드";
            BtnNothread.UseVisualStyleBackColor = true;
            BtnNothread.Click += BtnNothread_Click;
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(6, 98);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(243, 24);
            PrgProcess.TabIndex = 1;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(6, 22);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(243, 70);
            TxtLog.TabIndex = 0;
            // 
            // BgwProgress
            // 
            BgwProgress.DoWork += BgwProgress_DoWork;
            BgwProgress.ProgressChanged += BgwProgress_ProgressChanged;
            BgwProgress.RunWorkerCompleted += BgwProgress_RunWorkerCompleted;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 562);
            Controls.Add(groupBox6);
            Controls.Add(GrbEditor);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "컨트롤 예제";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNormal).EndInit();
            GrbEditor.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox ChkBold;
        private ComboBox CboFonts;
        private Label label1;
        private TextBox TxtSampleText;
        private CheckBox ChkItalic;
        private GroupBox groupBox2;
        private TrackBar TrbDummy;
        private ProgressBar PrgDummy;
        private GroupBox groupBox3;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private Button BtnQuestion;
        private GroupBox groupBox4;
        private ListView LsvDummy;
        private Button button2;
        private Button BtnAddRoot;
        private TreeView TrvDummy;
        private Button BtnAddChild;
        private GroupBox groupBox5;
        private PictureBox PicNormal;
        private Button BtnLoad;
        private OpenFileDialog DlgOpenImage;
        private GroupBox GrbEditor;
        private RichTextBox RtxEditor;
        private Button BtnFileSave;
        private Button BtnFileLoad;
        private GroupBox groupBox6;
        private Button BtnNothread;
        private ProgressBar PrgProcess;
        private TextBox TxtLog;
        private Button BtnThread;
        private Button BtnStop;
        private System.ComponentModel.BackgroundWorker BgwProgress;
    }
}
