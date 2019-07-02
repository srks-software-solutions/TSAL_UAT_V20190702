using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;

namespace i_facility
{
    class MsqlConnection : IDisposable
    {
        #region Local Server
        static String ServerName = @"TCP:TSAL-DAS\TSALSQLEXPDAS"; // Server
        //static String ServerName = @"PAVANKUMARV013\SQL2017EXPDELL"; //local
        static String username = "sa";
        static String password = "srks4$tsal";//server
        //static String password = "srks4$";//local
        //static String port = "3306";
        static String DB = "i_facility_tsal";
        #endregion

        //public SqlConnection msqlConnection = new SqlConnection("server = " + ServerName + ";userid = " + username + ";Password = " + password + ";database = " + DB + ";port = " + port + ";persist security info=False");

        public SqlConnection msqlConnection = new SqlConnection(@"Data Source = " + ServerName + ";User ID = " + username + ";Password = " + password + ";Initial Catalog = " + DB + ";Persist Security Info=True");

        public void open()
        {
            if (msqlConnection.State != System.Data.ConnectionState.Open)
                msqlConnection.Open();
        }

        public void close()
        {
            msqlConnection.Close();
        }

        void IDisposable.Dispose()
        { }
    }
}
