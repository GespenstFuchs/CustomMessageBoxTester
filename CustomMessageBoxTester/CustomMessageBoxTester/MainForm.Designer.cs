namespace CustomMessageBoxTester
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ShowMsgBoxButton2 = new System.Windows.Forms.Button();
            this.ShowMsgBoxButton1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.WidthChangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.WidthChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DefaultButtonComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Button3TextTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button2TextTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button1TextTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IconComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BeepSoundNonRadioButton = new System.Windows.Forms.RadioButton();
            this.BeepSoundInfomationWarningRadioButton = new System.Windows.Forms.RadioButton();
            this.BeepSoundErrorRadioButton = new System.Windows.Forms.RadioButton();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChangeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Controls.Add(this.BeepSoundErrorRadioButton);
            this.MainPanel.Controls.Add(this.BeepSoundInfomationWarningRadioButton);
            this.MainPanel.Controls.Add(this.BeepSoundNonRadioButton);
            this.MainPanel.Controls.Add(this.label12);
            this.MainPanel.Controls.Add(this.label11);
            this.MainPanel.Controls.Add(this.ShowMsgBoxButton2);
            this.MainPanel.Controls.Add(this.ShowMsgBoxButton1);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.WidthChangeNumericUpDown);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.WidthChangeCheckBox);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.DefaultButtonComboBox);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.Button3TextTextBox);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.Button2TextTextBox);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.Button1TextTextBox);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.IconComboBox);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.MessageTextBox);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.TitleTextBox);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(900, 549);
            this.MainPanel.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 504);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(495, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "メッセージボックスの内容は、Ｃｔｒｌ＋Ｃキーを押下すると、コピー出来ます。";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "ビープ音";
            // 
            // ShowMsgBoxButton2
            // 
            this.ShowMsgBoxButton2.Location = new System.Drawing.Point(358, 431);
            this.ShowMsgBoxButton2.Name = "ShowMsgBoxButton2";
            this.ShowMsgBoxButton2.Size = new System.Drawing.Size(350, 60);
            this.ShowMsgBoxButton2.TabIndex = 24;
            this.ShowMsgBoxButton2.Text = "メッセージボックス表示\r\n（戻り値を受け取り、更にメッセージボックスを表示）";
            this.ShowMsgBoxButton2.UseVisualStyleBackColor = true;
            this.ShowMsgBoxButton2.Click += new System.EventHandler(this.ShowMsgBoxButton2_Click);
            // 
            // ShowMsgBoxButton1
            // 
            this.ShowMsgBoxButton1.Location = new System.Drawing.Point(152, 431);
            this.ShowMsgBoxButton1.Name = "ShowMsgBoxButton1";
            this.ShowMsgBoxButton1.Size = new System.Drawing.Size(180, 60);
            this.ShowMsgBoxButton1.TabIndex = 23;
            this.ShowMsgBoxButton1.Text = "メッセージボックス表示\r\n（表示のみ）";
            this.ShowMsgBoxButton1.UseVisualStyleBackColor = true;
            this.ShowMsgBoxButton1.Click += new System.EventHandler(this.ShowMsgBoxButton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(451, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "（なお、高さについては、ソース、もしくはデザイナにて変更して下さい。）";
            // 
            // WidthChangeNumericUpDown
            // 
            this.WidthChangeNumericUpDown.Enabled = false;
            this.WidthChangeNumericUpDown.Location = new System.Drawing.Point(453, 355);
            this.WidthChangeNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.WidthChangeNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WidthChangeNumericUpDown.Name = "WidthChangeNumericUpDown";
            this.WidthChangeNumericUpDown.Size = new System.Drawing.Size(70, 29);
            this.WidthChangeNumericUpDown.TabIndex = 20;
            this.WidthChangeNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WidthChangeNumericUpDown.Leave += new System.EventHandler(this.WidthChangeNumericUpDown_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "（指定可能範囲：５００～２０００）";
            // 
            // WidthChangeCheckBox
            // 
            this.WidthChangeCheckBox.AutoSize = true;
            this.WidthChangeCheckBox.Location = new System.Drawing.Point(203, 356);
            this.WidthChangeCheckBox.Name = "WidthChangeCheckBox";
            this.WidthChangeCheckBox.Size = new System.Drawing.Size(244, 25);
            this.WidthChangeCheckBox.TabIndex = 19;
            this.WidthChangeCheckBox.Text = "メッセージボックスの幅を変更する。";
            this.WidthChangeCheckBox.UseVisualStyleBackColor = true;
            this.WidthChangeCheckBox.CheckedChanged += new System.EventHandler(this.WidthChangeCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "メッセージボックスの幅";
            // 
            // DefaultButtonComboBox
            // 
            this.DefaultButtonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultButtonComboBox.FormattingEnabled = true;
            this.DefaultButtonComboBox.Items.AddRange(new object[] {
            "ボタン１",
            "ボタン２",
            "ボタン３"});
            this.DefaultButtonComboBox.Location = new System.Drawing.Point(152, 290);
            this.DefaultButtonComboBox.Name = "DefaultButtonComboBox";
            this.DefaultButtonComboBox.Size = new System.Drawing.Size(100, 29);
            this.DefaultButtonComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "デフォルトボタン";
            // 
            // Button3TextTextBox
            // 
            this.Button3TextTextBox.Location = new System.Drawing.Point(716, 255);
            this.Button3TextTextBox.MaxLength = 0;
            this.Button3TextTextBox.Name = "Button3TextTextBox";
            this.Button3TextTextBox.Size = new System.Drawing.Size(150, 29);
            this.Button3TextTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "ボタン３テキスト";
            // 
            // Button2TextTextBox
            // 
            this.Button2TextTextBox.Location = new System.Drawing.Point(434, 255);
            this.Button2TextTextBox.MaxLength = 0;
            this.Button2TextTextBox.Name = "Button2TextTextBox";
            this.Button2TextTextBox.Size = new System.Drawing.Size(150, 29);
            this.Button2TextTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "ボタン２テキスト";
            // 
            // Button1TextTextBox
            // 
            this.Button1TextTextBox.Location = new System.Drawing.Point(152, 255);
            this.Button1TextTextBox.MaxLength = 0;
            this.Button1TextTextBox.Name = "Button1TextTextBox";
            this.Button1TextTextBox.Size = new System.Drawing.Size(150, 29);
            this.Button1TextTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ボタン１テキスト";
            // 
            // IconComboBox
            // 
            this.IconComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IconComboBox.FormattingEnabled = true;
            this.IconComboBox.Items.AddRange(new object[] {
            "0：情報",
            "1：エラー",
            "2：警告",
            "3：質問"});
            this.IconComboBox.Location = new System.Drawing.Point(152, 220);
            this.IconComboBox.Name = "IconComboBox";
            this.IconComboBox.Size = new System.Drawing.Size(100, 29);
            this.IconComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "アイコン";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(152, 64);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageTextBox.Size = new System.Drawing.Size(714, 150);
            this.MessageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "メッセージ";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(152, 29);
            this.TitleTextBox.MaxLength = 0;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(714, 29);
            this.TitleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイトル";
            // 
            // BeepSoundNonRadioButton
            // 
            this.BeepSoundNonRadioButton.AutoSize = true;
            this.BeepSoundNonRadioButton.Location = new System.Drawing.Point(152, 325);
            this.BeepSoundNonRadioButton.Name = "BeepSoundNonRadioButton";
            this.BeepSoundNonRadioButton.Size = new System.Drawing.Size(55, 25);
            this.BeepSoundNonRadioButton.TabIndex = 15;
            this.BeepSoundNonRadioButton.Text = "無し";
            this.BeepSoundNonRadioButton.UseVisualStyleBackColor = true;
            // 
            // BeepSoundInfomationWarningRadioButton
            // 
            this.BeepSoundInfomationWarningRadioButton.AutoSize = true;
            this.BeepSoundInfomationWarningRadioButton.Checked = true;
            this.BeepSoundInfomationWarningRadioButton.Location = new System.Drawing.Point(213, 325);
            this.BeepSoundInfomationWarningRadioButton.Name = "BeepSoundInfomationWarningRadioButton";
            this.BeepSoundInfomationWarningRadioButton.Size = new System.Drawing.Size(100, 25);
            this.BeepSoundInfomationWarningRadioButton.TabIndex = 16;
            this.BeepSoundInfomationWarningRadioButton.TabStop = true;
            this.BeepSoundInfomationWarningRadioButton.Text = "情報・警告";
            this.BeepSoundInfomationWarningRadioButton.UseVisualStyleBackColor = true;
            // 
            // BeepSoundErrorRadioButton
            // 
            this.BeepSoundErrorRadioButton.AutoSize = true;
            this.BeepSoundErrorRadioButton.Location = new System.Drawing.Point(319, 325);
            this.BeepSoundErrorRadioButton.Name = "BeepSoundErrorRadioButton";
            this.BeepSoundErrorRadioButton.Size = new System.Drawing.Size(61, 25);
            this.BeepSoundErrorRadioButton.TabIndex = 17;
            this.BeepSoundErrorRadioButton.TabStop = true;
            this.BeepSoundErrorRadioButton.Text = "エラー";
            this.BeepSoundErrorRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 549);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "カスタムメッセージボックステスター";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthChangeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IconComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox Button1TextTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown WidthChangeNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox WidthChangeCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DefaultButtonComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Button3TextTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Button2TextTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ShowMsgBoxButton2;
        private System.Windows.Forms.Button ShowMsgBoxButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton BeepSoundNonRadioButton;
        private System.Windows.Forms.RadioButton BeepSoundErrorRadioButton;
        private System.Windows.Forms.RadioButton BeepSoundInfomationWarningRadioButton;
    }
}

