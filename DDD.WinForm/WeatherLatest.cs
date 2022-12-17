using DDD.WinForm.Data;
using DDD.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

/// <summary>DDD</summary>
namespace DDD.WinForm
{
    public partial class WeatherLatest : Form
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
        private void btnLatest_Click(object sender, EventArgs e)
        {
            //SQLを取得
            var dt = WhetherSQLite.GetLastest(Convert.ToInt32(txtAreaID.Text));

            if (dt.Rows.Count > 0)
            {//データがある場合表示する
                //日時
                lblDataDate.Text = dt.Rows[0]["DataDate"].ToString();
                //状態
                lblCondition.Text = dt.Rows[0]["Condition"].ToString();
                //温度
                string temptureData = CommonFunc.RoundString(Convert.ToSingle(dt.Rows[0]["Temperature"]),
                                      CommonConst.TemperatureDecimalPoint) + CommonConst.TemperatureUnitName;
                lblTemperture.Text = temptureData;
            }
        }

    }
}
