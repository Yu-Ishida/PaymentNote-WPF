using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaymentNote
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「名前をつけて保存」メニューを選択したときのイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void SaveAsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                // エラーが発生
                General.showErrorDlg(ex.Message);
            }
            finally
            { }
        }

        /// <summary>
        /// 「終了」メニューを選択したときのイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // アプリケーションを終了する。
                Application.Current.Shutdown();
            }
            catch(Exception ex)
            {
                // エラーが発生
                General.showErrorDlg(ex.Message);
            }
            finally
            { }
        }

        /// <summary>
        /// 「バージョン情報」メニューを選択したときのイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void ShowVerInfoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("簡単支出帳\n(c) 2018 Yu Ishida.", "バージョン情報", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                // エラーが発生
                General.showErrorDlg(ex.Message);
            }
            finally
            { }
        }

        /// <summary>
        /// 「追加」ボタンを押下した時のイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                // エラーが発生
                General.showErrorDlg(ex.Message);
            }
            finally
            { }
        }

        /// <summary>
        /// 「削除」ボタンを押下したときのイベント
        /// </summary>
        /// <param name="sender">イベント発生元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                // エラーが発生
                General.showErrorDlg(ex.Message);
            }
            finally { }
        }
    }
}
