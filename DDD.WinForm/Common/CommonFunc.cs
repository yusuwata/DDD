using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary></summary>
namespace DDD.WinForm
{
    /// <summary>共通関数</summary>
    public static class CommonFunc
    {
        /// <summary>表示桁をまとめる</summary>
        /// <param name="pValue"></param>
        /// <param name="pDecimalPoint"></param>
        /// <returns>小数点二桁で設定したデータを返す </returns>
        public static string RoundString(float pValue, int pDecimalPoint)
        {
            //温度の表示形式を設定する
            var temp = Convert.ToSingle(Math.Round(pValue, pDecimalPoint));
            return temp.ToString("F" + pDecimalPoint);
        }
    }
}
