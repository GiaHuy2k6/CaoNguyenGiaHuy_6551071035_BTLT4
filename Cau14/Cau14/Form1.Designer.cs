namespace Cau14
{
    partial class Form1
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
            txtTen = new TextBox();
            label1 = new Label();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(234, 81);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(326, 27);
            txtTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 84);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên SV:";
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(127, 180);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(172, 184);
            lstLopA.TabIndex = 2;
            lstLopA.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(505, 180);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(173, 184);
            lstLopB.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(623, 80);
            button1.Name = "button1";
            button1.Size = new Size(92, 39);
            button1.TabIndex = 4;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 180);
            button2.Name = "button2";
            button2.Size = new Size(61, 38);
            button2.TabIndex = 5;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(380, 235);
            button3.Name = "button3";
            button3.Size = new Size(61, 36);
            button3.TabIndex = 6;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(380, 291);
            button4.Name = "button4";
            button4.Size = new Size(61, 29);
            button4.TabIndex = 7;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(380, 333);
            button5.Name = "button5";
            button5.Size = new Size(61, 31);
            button5.TabIndex = 8;
            button5.Text = "<<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(128, 387);
            button6.Name = "button6";
            button6.Size = new Size(168, 35);
            button6.TabIndex = 9;
            button6.Text = "Xóa lớp A";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(372, 389);
            button7.Name = "button7";
            button7.Size = new Size(78, 33);
            button7.TabIndex = 10;
            button7.Text = "Kết thúc";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(508, 388);
            button8.Name = "button8";
            button8.Size = new Size(174, 39);
            button8.TabIndex = 11;
            button8.Text = "Xóa lớp B";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(label1);
            Controls.Add(txtTen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private Label label1;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
