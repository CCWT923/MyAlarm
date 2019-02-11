using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace My_Alarm
{
    class DBAssistant
    {
        SQLiteConnection _Connection = null;
        SQLiteCommand _Command = null;
        SQLiteDataAdapter _Adapter;
        DataSet _Dataset;

        private string _AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\WTstudio\MyAlarm";
        private string _DBFile;
        private string _MainTableName = "AlarmList";

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
            //如果文件不存在，则创建
            if(!File.Exists(_DBFile))
            {
                CreateDatabase(_DBFile);
                Open();
                //初始化表
                InitTables();
            }
            else //文件存在，试图打开
            {
                try
                {
                    Open();
                }
                catch(Exception ex)
                {
                    throw new Exception("打开数据库时发生错误！" + ex.Message);
                }
            }
        }
        /// <summary>
        /// 获取数据库文件路径
        /// </summary>
        public string DBFile
        {
            get { return _DBFile; }
        }
        /// <summary>
        /// 主表名称
        /// </summary>
        public string MainTableName
        {
            get => _MainTableName;
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
            //数据库已存在，则备份数据库
            if(File.Exists(dbName))
            {
                BackupDatabase(dbName);
            }
            //创建数据库并初始化
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
        /// 备份数据库
        /// </summary>
        /// <param name="fileName"></param>
        private void BackupDatabase(string fileName)
        {
            if (!Directory.Exists(_AppDataPath + @"\Backup"))
            {
                Directory.CreateDirectory(_AppDataPath + @"\Backup");
            }
            File.Copy(fileName, _AppDataPath + @"Backup\" + Path.GetFileNameWithoutExtension(fileName) + "_bak_" +
                DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(fileName));
        }

        /// <summary>
        /// 打开数据库的连接
        /// </summary>
        private void Open()
        {
            _Connection = new SQLiteConnection("data source = " + _DBFile);
            _Connection.Open();
            _Command = new SQLiteCommand(_Connection);
            _Adapter = new SQLiteDataAdapter();
            _Dataset = new DataSet();
        }

        #region 初始化数据库表
        /// <summary>
        /// 初始化表
        /// </summary>
        private void InitTables()
        {
            if(_Connection.State == System.Data.ConnectionState.Open)
            {
                string table_AlarmList = "CREATE TABLE IF NOT EXISTS " + MainTableName + " (AlarmID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "CreateTime TEXT, AlarmDate TEXT, IsExpired INTEGER, Recurrence TEXT, Title TEXT, Contents TEXT, Sound TEXT, " +
                    "DelayTime INTEGER, Enable INTEGER)";
                _Command.CommandText = table_AlarmList;
                _Command.ExecuteNonQuery();
            }
        }
        #endregion

        #region 向数据库中添加闹钟信息
        /// <summary>
        /// 向数据库中插入数据
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="data">字符串数组，数据</param>
        public void InsertData(string TableName, string[] data)
        {
            try
            {
                _Command.CommandText = "INSERT INTO " + TableName + " VALUES(@AlarmID, @CreateTime, @AlarmDate, @IsExpired, @Recurrence" +
                    ", @Title, @Contents, @Sound, @DelayTime, @Enable)";
                _Command.Parameters.Add("AlarmID", System.Data.DbType.Int32);
                _Command.Parameters.Add("CreateTime", System.Data.DbType.DateTime);
                _Command.Parameters.Add("AlarmDate", System.Data.DbType.DateTime);
                _Command.Parameters.Add("IsExpired", System.Data.DbType.Boolean);
                _Command.Parameters.Add("Recurrence", System.Data.DbType.String);
                _Command.Parameters.Add("Title", System.Data.DbType.String);
                _Command.Parameters.Add("Contents", System.Data.DbType.String);
                _Command.Parameters.Add("Sound", System.Data.DbType.String);
                _Command.Parameters.Add("DelayTime", System.Data.DbType.Int32);
                _Command.Parameters.Add("Enable", System.Data.DbType.Boolean);

                _Command.Parameters["AlarmID"].Value = DBNull.Value; //自增列插入NULL值即可
                _Command.Parameters["CreateTime"].Value = data[0];
                _Command.Parameters["AlarmDate"].Value = data[1];
                _Command.Parameters["IsExpired"].Value = bool.Parse(data[2]);
                _Command.Parameters["Recurrence"].Value = data[3];
                _Command.Parameters["Title"].Value = data[4];
                _Command.Parameters["Contents"].Value = data[5];
                _Command.Parameters["Sound"].Value = data[6];
                _Command.Parameters["DelayTime"].Value = int.Parse(data[7]);
                _Command.Parameters["Enable"].Value = bool.Parse(data[8]);

                System.Diagnostics.Debug.WriteLine(_Command.CommandText);
                _Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("插入数据时发生错误：" + ex.Message);
            }
        }
        #endregion

        #region 获取数据库中有效的闹钟信息
        /// <summary>
        /// 从数据库中选择有效的Alarm记录
        /// </summary>
        /// <returns>返回一个数据表</returns>
        public DataTable GetValidAlarmList()
        {
            string validList = "SELECT * FROM AlarmList where IsExpired = 0";
            _Command.CommandText = validList;
            _Adapter.SelectCommand = _Command;
            _Adapter.Fill(_Dataset, "ValidAlarm");
            return _Dataset.Tables["ValidAlarm"];
        }
        #endregion

        #region 删除指定的闹钟信息
        public void DeleteAlarmByID(int AlarmID)
        {
            string delCommand = "DELETE FROM AlarmList WHERE AlarmID = " + AlarmID;
            _Command.CommandText = delCommand;
            _Command.ExecuteNonQuery();
        }
        #endregion

    }
}
