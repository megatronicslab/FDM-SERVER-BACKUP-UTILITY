using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using Ionic.Zip;


namespace backup
{
    public partial class Form1 : Form
    {
        string backupPath;
        string selectRestorePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBackupFolder(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                backupPath = folderBrowserDialog1.SelectedPath;
                showPath.Text = backupPath;
            }
        }
        private void selectRestoreFolder(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                selectRestorePath = folderBrowserDialog2.SelectedPath;
                pathLabel.Text = selectRestorePath;
            }
        }

        private void backupSetting_Click(object sender, EventArgs e)
        {
            if (backupPath == null)
            {
                MessageBox.Show("Please Select Save Data folder");
                return;
            }
            string connstr = "server=localhost;user=root;pwd=12345;sslmode=none;";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            conn.Open();
                        }
                        catch
                        {
                            MessageBox.Show("MySql Connection Error !");
                            return;
                        }
                        cmd.Connection = conn;
                        cmd.CommandText = "show databases";
                        MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();mda.Fill(dt);
                        foreach(DataRow dr in dt.Rows)
                        {
                            string dbname = dr[0] + "";
                            // skip mysql default tables
                            switch (dbname)
                            {
                                case "sys":
                                case "performance_schema":
                                case "mysql":
                                case "information_schema":
                                    continue;
                            }
                            string dumpfile = System.IO.Path.Combine(backupPath, dbname)+".sql";
                            cmd.CommandText = "use`" + dbname + "`;";
                            cmd.ExecuteNonQuery();
                            mb.ExportToFile(dumpfile);                     
                        }
                        conn.Close();
                       MessageBox.Show("All Settings Backup successfully");
                    }
                }
            }           
        }

        private void backupAllData(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string userPath = desktopPath.Remove(desktopPath.Length - 7);
            
            string copyPath = userPath + ".influxdb";
            if (backupPath == null)
            {
                MessageBox.Show("Please Select Save Data Folder");
                return;
            }
            foreach (string dirPath in Directory.GetDirectories(copyPath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(copyPath, backupPath));
            }
           
            try
            {
                //Copy all the files & Not Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(copyPath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(copyPath, backupPath), false);
                }
                MessageBox.Show("Data Backup Successfully !");
            }
            catch
            {
                MessageBox.Show("File Already exist !");
            }
        }

        private void restoreSettings_Click(object sender, EventArgs e)
        {
            if (selectRestorePath == null)
            {
                MessageBox.Show("Please select Restore Folder");
                return;
            }
            string connstr = "server=localhost;user=root;pwd=12345;sslmode=none;";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            conn.Open();
                        }
                        catch
                        {
                            MessageBox.Show("MySql Connection Error !");
                            return;
                        }
                        cmd.Connection = conn;
                        string[] files = Directory.GetFiles(selectRestorePath);
                        foreach(string file in files)
                        {
                            if (file.ToLower().EndsWith(".sql"))
                            {
                                string dbname = System.IO.Path.GetFileNameWithoutExtension(file);
                                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `" + dbname + "`";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "use `" + dbname + "`";
                                cmd.ExecuteNonQuery();
                                mb.ImportFromFile(file);
                            }
                        }
                        conn.Close();
                        MessageBox.Show("All Settings Restore Successfully !");
                    }
                }
            }
        }

        private void restoreAllData(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string userPath = desktopPath.Remove(desktopPath.Length - 7);
            string saveDataPath = userPath + ".influxdb";
            saveDataPath = "C:\\copy folder";
            if (selectRestorePath == null)
            {
                MessageBox.Show("Please Select Restore Folder");
                return;
            }
            try
            {
                foreach (string dirPath in Directory.GetDirectories(selectRestorePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(selectRestorePath, saveDataPath));
                }
            }
            catch
            {
                MessageBox.Show("Directory Not Founds !");
            }
            
            try
            {
                //Copy all the files & Not Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(selectRestorePath, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(selectRestorePath, saveDataPath), false);
                }
                MessageBox.Show("Data Restore Successfully");
            }
            catch
            {
                MessageBox.Show("File Already Exist !");
            }
        }
    }
}
