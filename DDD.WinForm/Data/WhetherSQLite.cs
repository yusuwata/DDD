using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary></summary>
namespace DDD.WinForm.Data
{
    /// <summary>データクラス</summary>
    public static class WhetherSQLite
    {
        /// <summary>データベース</summary>
        /// <param name="pAreaID">エリアID</param>
        /// <returns>取得したデータを返す</returns>
        /// <remarks>テストしずらいメソッド</remarks>
        public static DataTable GetLastest(int pAreaID)
        {//SQLを記述
            string sql = @"
SELECT DataDate,
       Condition,
       Temperature
FROM Weather
WHERE AreaID = @AreaID
ORDER BY DataDate DESC
LIMIT 1
";

            //SQLのインスタンスを生成 以下の外部接触する部分は極力インターフェースで切り分ける
            DataTable dt = new DataTable();
            using (var connection = new SQLiteConnection(CommonConst.ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@AreaID", pAreaID);
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    //このように外部接触箇所はテストしずらい
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}


