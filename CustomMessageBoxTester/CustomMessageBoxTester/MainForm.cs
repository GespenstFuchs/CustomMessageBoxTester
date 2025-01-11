using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomMessageBoxTester
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            IconComboBox.SelectedIndex = 0;
            DefaultButtonComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// メッセージ幅チェックボックス
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void WidthChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WidthChangeCheckBox.Checked)
            {
                WidthChangeNumericUpDown.Enabled = true;
            }
            else
            {
                WidthChangeNumericUpDown.Enabled = false;
            }
        }

        /// <summary>
        /// メッセージ幅ニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void WidthChangeNumericUpDown_Leave(object sender, EventArgs e)
        {
            TextBox numericUpDownTextBox = WidthChangeNumericUpDown.Controls[1] as TextBox;
            if (string.IsNullOrWhiteSpace(numericUpDownTextBox.Text))
            {
                numericUpDownTextBox.Text = "500";
                numericUpDownTextBox.SelectionStart = numericUpDownTextBox.Text.Length;
            }
        }

        /// <summary>
        /// メッセージボックス表示（表示のみ）ボタン
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ShowMsgBoxButton1_Click(object sender, EventArgs e)
        {
            ShowMsg(false);
        }

        /// <summary>
        /// メッセージボックス表示（戻り値を受け取り、更にメッセージボックスを表示）ボタン
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ShowMsgBoxButton2_Click(object sender, EventArgs e)
        {
            ShowMsg(true);
        }

        /// <summary>
        /// メッセージ表示処理
        /// </summary>
        /// <param name="showReturnValueFlg">戻り値表示フラグ（true：表示・false：非表示）</param>
        private void ShowMsg(bool showReturnValueFlg)
        {
            // 各ボタンテキストを保持する。
            var buttonTextList = new List<string>();
            if (!string.IsNullOrEmpty(Button1TextTextBox.Text))
            {
                buttonTextList.Add(Button1TextTextBox.Text);
            }

            if (!string.IsNullOrEmpty(Button2TextTextBox.Text))
            {
                buttonTextList.Add(Button2TextTextBox.Text);
            }

            if (!string.IsNullOrEmpty(Button3TextTextBox.Text))
            {
                buttonTextList.Add(Button3TextTextBox.Text);
            }

            // ビープ音値を設定する。
            int beepSoundValue = 0;
            if (BeepSoundInfomationWarningRadioButton.Checked)
            {
                beepSoundValue = 1;
            }
            else if (BeepSoundErrorRadioButton.Checked)
            {
                beepSoundValue = 2;
            }

            // カスタムメッセージボックスクラスのインスタンスを生成する。
            CustomMessageBox msgBox = new CustomMessageBox();

            // メッセージ幅チェックボックスのチェックの有無を判定する。
            if (WidthChangeCheckBox.Checked)
            {
                // チェックが入っている場合
                msgBox.MessageBoxSetting(
                    TitleTextBox.Text,
                    MessageTextBox.Text,
                    IconComboBox.SelectedIndex,
                    buttonTextList,
                    DefaultButtonComboBox.SelectedIndex,
                    beepSoundValue,
                    false);

                // 幅を設定する。
                msgBox.Width = (int)WidthChangeNumericUpDown.Value;
            }
            else
            {
                // チェックが外れている場合
                msgBox.MessageBoxSetting(
                    TitleTextBox.Text,
                    MessageTextBox.Text,
                    IconComboBox.SelectedIndex,
                    buttonTextList,
                    DefaultButtonComboBox.SelectedIndex,
                    beepSoundValue);
            }

            // メッセージボックスを表示する。
            msgBox.ShowDialog(this);

            // 戻り値表示フラグを判定する。
            if (showReturnValueFlg)
            {
                // 表示する場合

                // 結果を保持する。
                var messageBoxResult = msgBox.MessageBoxResult;

                // 設定を初期化するため、インスタンスを再生成する。
                msgBox = new CustomMessageBox();

                // 戻り値の比較例として、分岐させる。
                if (string.Equals(messageBoxResult, CustomMessageBox.RETURN_BUTTON1))
                {
                    // ボタン１の場合
                    msgBox.MessageBoxSetting(
                        "戻り値表示（ボタン１の場合）",
                        string.Concat("戻り値：", messageBoxResult),
                        0,
                        new List<string>() { "ＯＫ" },
                        0);

                    // メッセージボックスを表示する。
                    msgBox.ShowDialog(this);
                }
                else
                {
                    // ボタン１以外の場合
                    msgBox.MessageBoxSetting(
                        "戻り値表示（ボタン１以外の場合）",
                        string.Concat("戻り値：", messageBoxResult),
                        0,
                        new List<string>() { "ＯＫ" },
                        0);

                    // メッセージボックスを表示する。
                    msgBox.ShowDialog(this);
                }
            }
        }
    }
}
