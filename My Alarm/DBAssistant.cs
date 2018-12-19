using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace My_Alarm
{
    class DBAssistant
    {
        SQLiteConnection _Connection = null;
        SQLiteCommand _Command = null;
        string _AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\WTstudio\MyAlarm";
        string _DBFile = "";

        /// <summary>
        /// 构造函数
        /// </summary>
        public DBAssistant()
        {
#if DEBUG
            _DBFile = _AppDataPath + @"\MyAlarm_Debug.db";
#else
            _DBFile = _AppDataPath + @"\MyAlarm.db";
#endif
        }

        /// <summary>
        /// 创建指定路径的数据库
        /// </summary>
        /// <param name="dbName"></param>
        private void CreateDatabase(string dbName)
        {
            //创建目录
            if(!Directory.Exists(_AppDataPath))
            {
                Directory.CreateDirectory(_AppDataPath);
            }
            //备份数据库
            if(File.Exists(dbName))
            {
                if (!Directory.Exists(_AppDataPath + @"\Backup"))
                {
                    Directory.CreateDirectory(_AppDataPath + @"\Backup");
                }
                File.Copy(dbName, _AppDataPath + @"Backup\" + Path.GetFileNameWithoutExtension(dbName) + "_bak_" +
                    DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(dbName));
            }
            //创建数据库
            try
            {
                SQLiteConnection.CreateFile(dbName);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 打开数据库的连接
        /// </summary>
        public void Open()
        {
            _Connection = new SQLiteConnection("data source = " + _DBFile);
            _Connection.Open();
            _Command = new SQLiteCommand(_Connection);
        }
        /// <summary>
        /// 初始化表
        /// </summary>
        private void InitTables()
        {
            if(_Connection.State == System.Data.ConnectionState.Open)
            {
                string table_AlarmList = "CREATE TABLE IF NOT EXISTS AlarmList(CreateTime TEXT, AlarmDate TEXT," +
                    "IsExpired INTEGER, Recurrence INTEGER, Title TEXT, Contents TEXT, Sound TEXT, DelayTime INTEGER)";
                _Command.CommandText = table_AlarmList;
                _Command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 向数据库中插入数据
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="data">字符串数组，数据</param>
        public void InsertData(string TableName, string[] data)
        {
            _Command.CommandText = "INSERT INTO " + TableName + " VALUES(@CreateTime, @AlarmDate, @IsExpired, @Recurrence" +
                ", @Title, @Contents, @Sound, @DelayTime)";
            _Command.Parameters.Add("CreateTime", System.Data.DbType.DateTime);
            _Command.Parameters.Add("AlarmDate", System.Data.DbType.DateTime);
            _Command.Parameters.Add("IsExpired", System.Data.DbType.Boolean);
            _Command.Parameters.Add("Recurrence", System.Data.DbType.Int32);
            _Command.Parameters.Add("Title", System.Data.DbType.String);
            _Command.Parameters.Add("Contents", System.Data.DbType.String);
            _Command.Parameters.Add("Sound", System.Data.DbType.String);
            _Command.Parameters.Add("DelayTime", System.Data.DbType.Int32);
            _Command.ExecuteNonQuery();
        }

    }
}
