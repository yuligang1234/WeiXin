
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using WeiXin.Tools.Common;

namespace WeiXin.Tools.DAL.Helper
{
    public class SqLiteHelper
    {

        private static readonly string SqliteConnection = string.Format("Data Source={0}{1}", AppDomain.CurrentDomain.SetupInformation.ApplicationBase, PublicFileds.DbName);

        /// <summary>
        ///  打开数据库
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 09:05:36
        private static SQLiteConnection OpenConnection()
        {

            SQLiteConnection conn = new SQLiteConnection(SqliteConnection);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        /// <summary>
        ///  获取DataSet
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 09:09:44
        public static DataSet GetDateSet(string sql)
        {
            DataSet ds = new DataSet();
            using (SQLiteConnection conn = OpenConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        ///  获取DataTable
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 09:12:36
        public static DataTable GetDataTable(string sql)
        {
            DataSet ds = GetDateSet(sql);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        /// <summary>
        ///  获取实体类集合
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 09:19:32
        public static List<T> GetEnumerables<T>(string sql) where T : new()
        {
            using (IDbConnection conn = OpenConnection())
            {
                return conn.Query<T>(sql).ToList();
            }
        }

        /// <summary>
        ///  获取单个实体类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">The SQL.</param>
        /// <returns>``0.</returns>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 09:22:43
        public static T GetEnumerable<T>(string sql) where T : new()
        {
            List<T> list = GetEnumerables<T>(sql);
            if (list.Count > 0)
            {
                return list[0];
            }
            return default(T);
        }

        /// <summary>
        ///  查询个数
        /// </summary>
        /// <param name="sql">SQL</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 09:22:43
        public static int QueryCount(string sql)
        {
            using (SQLiteConnection conn = OpenConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                int row;
                try
                {
                    row = (int)cmd.ExecuteScalar();
                }
                catch (Exception)
                {
                    row = 0;
                }
                return row;
            }
        }

        /// <summary>
        ///  增加、删除、修改操作
        /// </summary>
        /// <param name="sql">SQL</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-01 21:04:20
        public static int ExecuteSql(string sql)
        {
            using (SQLiteConnection conn = OpenConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                return cmd.ExecuteNonQuery();
            }
        }



    }
}
