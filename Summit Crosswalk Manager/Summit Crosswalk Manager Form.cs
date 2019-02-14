using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace Summit_Crosswalk_Manager
{
    public partial class Summit_Crosswalk_Manager : Form
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Summit_Crosswalk_Manager()
        {
            InitializeComponent();

            SearchBox.KeyPress += new KeyPressEventHandler(keypressed);

            MainDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;

            BasicConfigurator.Configure();

            UserTXT.Text = new System.Security.Principal.WindowsPrincipal(System.Security.Principal.WindowsIdentity.GetCurrent()).Identity.Name;

            log.Info(UserTXT.Text + " - Started Application");
        }

        private void Summit_Crosswalk_Manager_Load(object sender, EventArgs e)
        {

            //populate Database dropdown from connections setting
            string setting = Properties.Settings.Default.Connections;
            string[] comboRows = setting.Split('|');
            foreach (var i in comboRows)
            {
                ConnectionStrings.Items.Add(i);
            }
        }

        private void AddConection_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info(UserTXT.Text + " - Started Adding Conection String");

                //Add new Database value to Connections setting
                Properties.Settings.Default.Connections = Properties.Settings.Default.Connections + "|" + (ConnectionStrings.Text);
                Properties.Settings.Default.Save();

                //Clear the dropdown
                ConnectionStrings.Items.Clear();

                //Import the list agian with the new value to the dropdown
                string setting = Properties.Settings.Default.Connections;
                string[] comboRows = setting.Split('|');
                foreach (var i in comboRows)
                {
                    ConnectionStrings.Items.Add(i);
                    log.Info(i);
                }

                log.Info(UserTXT.Text + " - Finished Adding Conection string");
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void RefreshTables_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info(UserTXT.Text + " - Started Return Table Names");

                //SQL to return Database table names
                string strConnection = ConnectionStrings.Text;
                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand sqlCmdTableNames = new SqlCommand();
                sqlCmdTableNames.Connection = con;
                sqlCmdTableNames.CommandType = CommandType.Text;
                sqlCmdTableNames.CommandText = "SELECT [Name] FROM sys.Tables";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmdTableNames);

                //Populate Tables Dropdown
                DataTable TableNames = new DataTable();
                sqlDataAdap.Fill(TableNames);
                Tables.DataSource = TableNames.DefaultView;
                Tables.DisplayMember = "Name";

                //Populate Log with table Names
                for (int i = 0; i < Tables.Items.Count; i++)
                {
                    log.Info(Tables.GetItemText(Tables.Items[i]));
                }

                log.Info(UserTXT.Text + " - Finished Return Table Names");

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void ConnectionStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTables.PerformClick();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            try
            {

                log.Info(UserTXT.Text + " - Started SQL Download");

                // Set Progress Bar
                MainProBar.Visible = true;
                MainProBar.Minimum = 1;
                MainProBar.Maximum = 7;
                MainProBar.Value = 1;
                MainProBar.Step = 1;
                MainProBar.PerformStep();


                //Sql to download Table contents
                MainProBar.PerformStep();
                string strConnection = ConnectionStrings.Text;
                string strTable = Tables.Text;
                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand sqlCmdDownload = new SqlCommand();
                sqlCmdDownload.Connection = con;
                sqlCmdDownload.CommandType = CommandType.Text;
                sqlCmdDownload.CommandText = "Select * from [" + strTable + "]";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmdDownload);
                MainProBar.PerformStep();
                log.Info(strTable);

                //Populate DataGrid with Table contents
                MainProBar.PerformStep();
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                MainDataGrid.DataSource = dtRecord;
                MainProBar.PerformStep();

                //Populate Row count Lable
                MainProBar.PerformStep();
                RowCount.Text = MainDataGrid.Rows.Count.ToString();
                int Rows = int.Parse(RowCount.Text) - 1;
                RowCount.Text = Rows.ToString();
                ColumnCount.Text = MainDataGrid.Columns.Count.ToString();
                SourceTXT.Text = "SQL";
                Current.Text = "";
                Total.Text = "";
                Properties.Settings.Default.Search = "";
                MainProBar.PerformStep();

                log.Info(UserTXT.Text + " - Finished SQL Download");
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message.ToString());
                MainProBar.Value = 1;
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {

                log.Info(UserTXT.Text + " - Started SQL Upload");

                // Set Progress Bar
                MainProBar.Visible = true;
                MainProBar.Minimum = 1;
                MainProBar.Maximum = MainDataGrid.Rows.Count + 5;
                MainProBar.Value = 1;
                MainProBar.Step = 1;
                MainProBar.PerformStep();

                //Create connection string
                string strConnection = ConnectionStrings.Text;
                string strTable = Tables.Text;
                SqlConnection con = new SqlConnection(strConnection);
                MainProBar.PerformStep();

                //Create Insert SQL
                StringBuilder sb = new StringBuilder();
                for (int x = 0; x < MainDataGrid.Rows.Count - 1; x++)
                {
                    sb.Append("INSERT INTO [" + strTable + "] VALUES ");
                    sb.Append("(");
                    for (int i = 0; i < MainDataGrid.Columns.Count; i++)
                    {
                        string Row = Convert.ToString(MainDataGrid.Rows[x].Cells[i].Value);
                        Row = Row.Replace("'", "''");
                        sb.Append("'" + Row + "',");
                    }
                    sb.Length = sb.Length - 1;
                    sb.Append(")");
                    MainProBar.PerformStep();
                }
                string Insert = (sb.ToString());
                MainProBar.PerformStep();
                log.Info(strTable);

                //Setup Insert command
                SqlCommand Update = new SqlCommand();
                Update.Connection = con;
                Update.CommandType = CommandType.Text;
                Update.CommandText = Insert;
                SqlDataAdapter sqlDataAdapUpdate = new SqlDataAdapter();
                sqlDataAdapUpdate.InsertCommand = Update;
                MainProBar.PerformStep();

                //Setup Delete command
                SqlCommand Delete = new SqlCommand();
                Delete.Connection = con;
                Delete.CommandType = CommandType.Text;
                Delete.CommandText = "TRUNCATE TABLE [" + strTable + "]";
                SqlDataAdapter sqlDataAdapDelete = new SqlDataAdapter();
                sqlDataAdapDelete.InsertCommand = Delete;
                MainProBar.PerformStep();

                con.Open();
                //Run insert to confirm no error
                Update.ExecuteNonQuery();
                //Delete table contents
                Delete.ExecuteNonQuery();
                //Run Insert to recreate table with updated values
                Update.ExecuteNonQuery();
                con.Close();
                MainProBar.PerformStep();

                log.Info(UserTXT.Text + " - Finished SQL Upload");
            }


            catch (Exception ex)
            {
                log.Error(ex);
                MainProBar.Value = 1;
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info(UserTXT.Text + " - Started Paste Clipboard");

                if (MainDataGrid.Rows.Count == 0)
                {
                    return;
                }

                //Paste contents of clipboard into selected fields
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int iRow = MainDataGrid.CurrentCell.RowIndex;
                int iCol = MainDataGrid.CurrentCell.ColumnIndex;
                DataGridViewCell oCell;
                log.Info(lines[0]);


                foreach (string line in lines)
                {
                    if (iRow < MainDataGrid.RowCount && line.Length > 0)
                    {
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < this.MainDataGrid.ColumnCount)
                            {
                                oCell = MainDataGrid[iCol + i, iRow];
                                if (!oCell.ReadOnly)
                                {
                                    if (oCell.Value.ToString() != sCells[i])
                                    {
                                        oCell.Value = Convert.ChangeType(sCells[i], oCell.ValueType);
                                        oCell.Style.BackColor = Color.LightGreen;
                                    }
                                }
                            }
                        }
                    }
                }

                log.Info(UserTXT.Text + " - Finished Paste Clipboard");
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {

                log.Info(UserTXT.Text + " - Started Export CSV");

                // Set Progress Bar
                MainProBar.Visible = true;
                MainProBar.Minimum = 1;
                MainProBar.Maximum = 6;
                MainProBar.Value = 1;
                MainProBar.Step = 1;


                // Don't save if no data is returned
                if (MainDataGrid.Rows.Count == 0)
                {
                    return;
                }
                StringBuilder sb = new StringBuilder();
                MainProBar.PerformStep();

                // Column headers
                string columnsHeader = "";
                for (int i = 0; i < MainDataGrid.Columns.Count; i++)
                {
                    columnsHeader += "\"" + MainDataGrid.Columns[i].Name + "\"" + ",";
                }
                sb.Append(columnsHeader);
                sb.Length = sb.Length - 1;
                sb.Append(Environment.NewLine);
                MainProBar.PerformStep();

                // Go through each cell in the datagridview
                foreach (DataGridViewRow dgvRow in MainDataGrid.Rows)
                {
                    // Make sure it's not an empty row.
                    if (!dgvRow.IsNewRow)
                    {
                        for (int c = 0; c < dgvRow.Cells.Count; c++)
                        {
                            // Append the cells data followed by a comma to delimit.
                            sb.Append("\"" + dgvRow.Cells[c].Value + "\"" + ",");
                        }

                        // Add a new line in the text file.
                        sb.Length = sb.Length - 1;
                        sb.Append(Environment.NewLine);
                    }
                    sb.Length = sb.Length - 1;

                }
                MainProBar.PerformStep();

                // Load up the save file dialog with the default option as saving as a .csv file.
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = Tables.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MainProBar.PerformStep();
                    // If they've selected a save location...
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false))
                    {
                        // Write the stringbuilder text to the the file.
                        sw.WriteLine(sb.ToString());
                        MainProBar.PerformStep();
                        log.Info(sfd.FileName);
                    }
                    MainProBar.PerformStep();
                }
                else
                {
                    MainProBar.Value = 1;
                }

                log.Info(UserTXT.Text + " - Finished Export CSV");
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message.ToString());
                MainProBar.Value = 1;
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Proceed = MessageBox.Show("Unsaved changes will be lost, would you like to proceed?", "Proceed?", MessageBoxButtons.YesNo);
                if (Proceed == DialogResult.No)
                {
                    return;
                }

                log.Info(UserTXT.Text + " - Started Import CSV");

                // Set Progress Bar
                MainProBar.Visible = true;
                MainProBar.Minimum = 1;
                MainProBar.Maximum = 5;
                MainProBar.Value = 1;
                MainProBar.Step = 1;


                // Displays an OpenFileDialog so the user can select a file.
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "CSV|*.csv";
                openFileDialog1.Title = "Select a CSV File";
                MainProBar.PerformStep();

                // If the user selected a file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    MainProBar.PerformStep();
                    // Assign the cursor in the Stream to the Form's Cursor property.
                    string strFileName = openFileDialog1.FileName;
                    ADODB.Connection oConn = new ADODB.Connection();
                    oConn.Open("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + System.IO.Path.GetDirectoryName(strFileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";", "", "", 0);
                    string strQuery = "SELECT * FROM [" + System.IO.Path.GetFileName(strFileName) + "]";
                    ADODB.Recordset rs = new ADODB.Recordset();

                    MainProBar.PerformStep();
                    log.Info(strFileName);

                    System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
                    DataTable dt = new DataTable();
                    rs.Open(strQuery, "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + System.IO.Path.GetDirectoryName(strFileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";",
                    ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, 1);
                    adapter.Fill(dt, rs);
                    MainDataGrid.DataSource = dt.DefaultView;

                    //Close Conection
                    oConn.Close();
                    rs.Close();
                    MainProBar.PerformStep();

                    //Populate Row Count Lable
                    RowCount.Text = MainDataGrid.Rows.Count.ToString();
                    int Rows = int.Parse(RowCount.Text) - 1;
                    RowCount.Text = Rows.ToString();
                    ColumnCount.Text = MainDataGrid.Columns.Count.ToString();
                    SourceTXT.Text = "CSV";
                    Current.Text = "";
                    Total.Text = "";
                    Properties.Settings.Default.Search = "";
                    MainProBar.PerformStep();

                    log.Info(UserTXT.Text + " - Finished Import CSV");
                }
                else
                {
                    MainProBar.Value = 1;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message.ToString());
                MainProBar.Value = 1;
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                log.Info(UserTXT.Text + " - Started Search");

                // Set Progress Bar
                MainProBar.Visible = true;
                MainProBar.Minimum = 1;
                MainProBar.Maximum = 5;
                MainProBar.Value = 1;
                MainProBar.Step = 1;

                //Check for Search Criteria
                if (SearchBox.Text == "")
                {
                    return;
                }
                MainProBar.PerformStep();
                log.Info(SearchBox.Text);

                //Set variables and SB
                String search = SearchBox.Text;
                Properties.Settings.Default.Search = "";
                StringBuilder sb = new StringBuilder();
                int Count = 0;
                MainProBar.PerformStep();

                //Clear already Highlighted values
                for (int x = 0; x < MainDataGrid.Rows.Count - 1; x++)
                {
                    for (int i = 0; i < MainDataGrid.Columns.Count; i++)
                    {
                        MainDataGrid.Rows[x].Cells[i].Style.BackColor = Color.White;
                    }
                }
                MainProBar.PerformStep();

                //Highlight values and store location
                for (int x = 0; x < MainDataGrid.Rows.Count - 1; x++)
                {
                    for (int i = 0; i < MainDataGrid.Columns.Count; i++)
                    {
                        if (MainDataGrid.Rows[x].Cells[i].Value.ToString().ToUpper().Contains(search.ToUpper()) == true)
                        {
                            MainDataGrid.Rows[x].Cells[i].Style.BackColor = Color.Yellow;
                            sb.Append(x + "," + i + "|");
                            Count = Count + 1;
                        }
                    }
                }
                MainProBar.PerformStep();
                log.Info(Count + " Results");

                //Set end Variables
                Properties.Settings.Default.Search = sb.ToString();
                Properties.Settings.Default.Count = "-1";
                if (Count.ToString() != "0")
                {
                    Current.Text = "0";
                    Total.Text = Count.ToString();
                }
                else
                {
                    Current.Text = "";
                    Total.Text = "";
                }
                MainProBar.PerformStep();

                log.Info(UserTXT.Text + " - Finished Search");
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void keypressed(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchButton.PerformClick();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                int Count = Convert.ToInt32(Properties.Settings.Default.Count);
                Count = Count + 1;
                var Array = Properties.Settings.Default.Search.Split('|');
                var Cord = Array[Count].Split(',');
                int x = Convert.ToInt32(Cord[0]);
                int i = Convert.ToInt32(Cord[1]);
                MainDataGrid.CurrentCell = MainDataGrid.Rows[x].Cells[i];
                int Display = Count + 1;
                Properties.Settings.Default.Count = Count.ToString();
                Current.Text = Display.ToString();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void Last_Click(object sender, EventArgs e)
        {
            try
            {
                int Count = Convert.ToInt32(Properties.Settings.Default.Count);
                Count = Count - 1;
                var Array = Properties.Settings.Default.Search.Split('|');
                var Cord = Array[Count].Split(',');
                int x = Convert.ToInt32(Cord[0]);
                int i = Convert.ToInt32(Cord[1]);
                MainDataGrid.CurrentCell = MainDataGrid.Rows[x].Cells[i];
                int Display = Count + 1;
                Properties.Settings.Default.Count = Count.ToString();
                Current.Text = Display.ToString();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Proceed = MessageBox.Show("Unsaved changes will be lost, would you like to proceed?", "Proceed?", MessageBoxButtons.YesNo);
                if (Proceed == DialogResult.No)
                {
                    return;
                }

                File.Copy(@"C:\ProgramData\SummitHealthcare\Summit_Crosswalk_Manager\LogFiles\logfile.txt", "Audit.txt", true);
                string[] Audit = File.ReadAllLines("Audit.txt");

                // Set Progress Bar
                MainProBar.Visible = true;
                MainProBar.Minimum = 1;
                MainProBar.Maximum = (Audit.Length + 3);
                MainProBar.Value = 1;
                MainProBar.Step = 1;


                MainProBar.PerformStep();
                Array.Reverse(Audit);
                List<string> Info = new List<string>();

                for (int i = 0; i < Audit.Length; i++)
                {
                    if (Audit[i].IndexOf("] INFO") != -1)
                    {
                        Info.Add(Audit[i]);
                    }
                    MainProBar.PerformStep();
                }

                String[] AuditLog = Info.ToArray();
                MainDataGrid.DataSource = AuditLog.Select(x => new { Audit_Log = x }).ToList();

                //Populate Row Count Lable
                RowCount.Text = MainDataGrid.Rows.Count.ToString();
                int Rows = int.Parse(RowCount.Text);
                RowCount.Text = Rows.ToString();
                ColumnCount.Text = MainDataGrid.Columns.Count.ToString();
                SourceTXT.Text = "AUDIT";
                Tables.Text = "Audit";
                Current.Text = "";
                Total.Text = "";
                Properties.Settings.Default.Search = "";
                MainProBar.PerformStep();

                log.Info(UserTXT.Text + " - Viewed Audit Log");
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Info(UserTXT.Text + " - Started Delete");
            string Deleted = "";

            foreach (DataGridViewCell cell in MainDataGrid.SelectedCells)
            {

                Deleted = Deleted + "|" + cell.Value.ToString();
                MainDataGrid.CurrentCell.Value = "";
                MainDataGrid.CurrentCell.Style.BackColor = Color.MistyRose;
            }

            log.Info(Deleted);
            SendKeys.Send("{Delete}");
            log.Info(UserTXT.Text + " - Finished Delete");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste_Click(sender, e);
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            log.Info(UserTXT.Text + " - Started Copy");
            string Copy = "";

            foreach (DataGridViewCell cell in MainDataGrid.SelectedCells)
            {

                Copy = Copy + cell.Value.ToString() + (Char)9;
                Clipboard.SetText(Copy);

            }

            Copy = Copy.Remove(Copy.Length - 1, 1);
            Clipboard.SetText(Copy);

            log.Info(Copy);
            log.Info(UserTXT.Text + " - Finished Copy");
        }
    }
}
