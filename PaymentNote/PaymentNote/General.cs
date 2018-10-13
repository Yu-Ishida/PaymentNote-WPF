/*
 * 共用定数及びメソッド定義クラス 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace PaymentNote
{
    class General
    {

        /// <summary>
        /// エラーメッセージを表示します。
        /// </summary>
        /// <param name="errMessage">表示するエラーメッセージ</param>
        public static void showErrorDlg(string errMessage)
        {
            MessageBox.Show("以下のエラーが発生しました。\n" + errMessage, "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
