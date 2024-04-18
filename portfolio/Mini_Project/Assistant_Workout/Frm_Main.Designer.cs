namespace Assistant_Workout
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button6 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("휴먼둥근헤드라인", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "오늘의 운동";
            // 
            // button1
            // 
            button1.Font = new Font("휴먼모음T", 14.25F, FontStyle.Bold);
            button1.Location = new Point(9, 45);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 0;
            button1.Text = "가슴";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("휴먼모음T", 14.25F, FontStyle.Bold);
            button2.Location = new Point(111, 45);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 0;
            button2.Text = "등";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("휴먼모음T", 14.25F, FontStyle.Bold);
            button3.Location = new Point(210, 45);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 0;
            button3.Text = "하체";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(9, 105);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(287, 289);
            listBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Font = new Font("휴먼둥근헤드라인", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(330, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "운동 타이머";
            // 
            // button4
            // 
            button4.Font = new Font("휴먼매직체", 12F, FontStyle.Bold);
            button4.Location = new Point(21, 145);
            button4.Name = "button4";
            button4.Size = new Size(100, 40);
            button4.TabIndex = 0;
            button4.Text = "START";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("휴먼매직체", 12F, FontStyle.Bold);
            button5.Location = new Point(253, 145);
            button5.Name = "button5";
            button5.Size = new Size(100, 40);
            button5.TabIndex = 1;
            button5.Text = "STOP";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 2;
            label1.Text = "휴식 시간 설정";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(78, 25);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 35);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 5;
            label2.Text = "SEC";
            // 
            // button6
            // 
            button6.Font = new Font("휴먼매직체", 12F, FontStyle.Bold);
            button6.Location = new Point(138, 145);
            button6.Name = "button6";
            button6.Size = new Size(100, 40);
            button6.TabIndex = 1;
            button6.Text = "DONE";
            button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 90);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 6;
            label3.Text = "Rest Time";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 7;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(716, 466);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Main";
            Text = "운동 도우미";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button6;
        private TextBox textBox1;
    }
}
