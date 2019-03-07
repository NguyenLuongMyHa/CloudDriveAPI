using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace Google_Drive_API
{
    public partial class Form1 : Form
    {
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        private int SoFile=10;
        UserCredential credential;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile()
        {
            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }


            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = SoFile;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                .Files;
            if (files != null && files.Count > 0)
            {
                DataTable table = new DataTable("File");
                table.Columns.Add(new DataColumn("FileName", typeof(string)));
                table.Columns.Add(new DataColumn("FileID", typeof(string)));
                foreach (var file in files)
                {
                    table.Rows.Add(file.Name, file.Id);
                    //        Console.WriteLine("{0} ({1})", file.Name, file.Id);
                }
                int fc = table.Columns.Count;

                lsv_ListFile.Columns.Clear();
                lsv_ListFile.Items.Clear();

                lsv_ListFile.Columns.Add("FileName");
                lsv_ListFile.Columns.Add("FileID");

                foreach (DataRow row in table.Rows)
                {
                    string[] subitems = new string[fc];

                    object[] o = row.ItemArray;
                    for (int i = 0; i < fc; i++)
                    {
                        subitems[i] = o[i].ToString();
                    }
                    ListViewItem item = new ListViewItem(subitems);
                    lsv_ListFile.Items.Add(item);
                }

                lsv_ListFile.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                MessageBox.Show("No files found.");
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SoFile = int.Parse(numericUpDown1.Value.ToString());
            LoadFile();
        }
        private void CreateFolder(string FolderName)
        {
            
        }

        private void btn_ThemFile_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
