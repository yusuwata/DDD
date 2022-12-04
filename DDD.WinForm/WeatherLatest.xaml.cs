using DDD.WinForm.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/// <summary>DDD</summary>
namespace DDD.WinForm
{
    /// <summary>WeatherLatest.xaml の相互作用ロジック</summary>
    public partial class WeatherLatest : Window
    {
        /// <summary>初期化</summary>
        public WeatherLatest()
        {
            InitializeComponent();
        }

        /// <summary>ボタンクリック</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>やりにくい</remarks>
        private void btnLatest_Click(object sender, RoutedEventArgs e)
        {
            //SQLを取得
            var dt = WhetherSQLite.GetLastest(Convert.ToInt32(txtAreaID.Text));

            if (dt.Rows.Count > 0)
            {//データがある場合表示する
                //日時
                lblDataDate.Content = dt.Rows[0]["DataDate"].ToString();
                //状態
                lblCondition.Content = dt.Rows[0]["Condition"].ToString();
                //温度
                string temptureData = CommonFunc.RoundString(Convert.ToSingle(dt.Rows[0]["Temperature"]), 
                                      CommonConst.TemperatureDecimalPoint) + CommonConst.TemperatureUnitName;
                lblTemperture.Content = temptureData;
            }
        }
    }
}