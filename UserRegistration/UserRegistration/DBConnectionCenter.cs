using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace UserRegistration
{
    class DBConnectionCenter
    {
        OleDbDataAdapter oleDaAc = new OleDbDataAdapter();
        OleDbConnection oleCon = new OleDbConnection();
        private bool dbCheckConnection = false;

        internal string userFirstName = "";
        internal string userLastName = "";
        internal string userEmail = "";

        public void ConnectDB()
        {
            try
            {
                string sPath = System.Windows.Forms.Application.StartupPath.ToLower();
                string sDatabaseName = "users.accdb";
                string sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + sPath + "\\" + sDatabaseName;

                MessageBox.Show(sPath + "\\" + sDatabaseName, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (oleCon.State == System.Data.ConnectionState.Open)
                {
                    oleCon.Close();
                    dbCheckConnection = false;
                }

                oleCon.ConnectionString = sConnectionString;
                oleCon.Open();
                dbCheckConnection = true;

                MessageBox.Show("Connected to DB: " + "\n" + sPath + "\\" + sDatabaseName, "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            } catch(Exception e)
            {
                dbCheckConnection = false;
                MessageBox.Show(e.Message.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet ShowData(string _sSQL, string _sTable, DataSet _ds)
        {

            DataSet dataSet;

            if(!dbCheckConnection)
            {
                ConnectDB();
            }

            try
            {
                _ds.Clear();
                oleDaAc = new OleDbDataAdapter(_sSQL, oleCon);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(oleDaAc);
                oleDaAc.Fill(_ds, _sTable);
                dataSet = _ds;
            } catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSet = null;

            } finally
            {
                dbCheckConnection = false;
                oleCon.Close();
            }


            return dataSet;
        }

        public OleDbDataAdapter ReturnAda
        {
            get
            {
                return oleDaAc;
            } set
            {
                oleDaAc = value;
            }
        }
    }
}
