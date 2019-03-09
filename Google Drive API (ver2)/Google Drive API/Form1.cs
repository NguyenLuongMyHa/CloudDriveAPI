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
using Google.Apis.Download;

namespace Google_Drive_API
{
    public partial class Form1 : Form
    {
        static string[] Scopes = { DriveService.Scope.DriveReadonly, DriveService.Scope.Drive };
        static string ApplicationName = "Drive API .NET Quickstart";
        private int SoFile=10;
        UserCredential credential;
        public string fileid;
        string path, filename;

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
        }

        private void ListFile()
        {
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

        private void ListFolder()
        {
            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            var request = service.Files.List();
            request.Q = "mimeType='application/vnd.google-apps.folder'";
            request.Spaces = "drive";
            request.Fields = "nextPageToken, files(id, name)";
            request.PageSize = SoFile;
            var result = request.Execute();

            if (result != null && result.Files.Count > 0)
            {
                DataTable table = new DataTable("File");
                table.Columns.Add(new DataColumn("FolderName", typeof(string)));
                table.Columns.Add(new DataColumn("FolderID", typeof(string)));
                foreach (var file in result.Files)
                {
                    table.Rows.Add(file.Name, file.Id);
                }
                int fc = table.Columns.Count;

                lsv_ListFile.Columns.Clear();
                lsv_ListFile.Items.Clear();

                lsv_ListFile.Columns.Add("FolderName");
                lsv_ListFile.Columns.Add("FolderID");

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
                MessageBox.Show("No folder found.");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SoFile = int.Parse(numericUpDown1.Value.ToString());
            if (radioButton1.Checked)
                ListFolder();

            else
                ListFile();

        }

        private void btn_ThemFile_Click(object sender, EventArgs e)
        {
            var driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            // ID thư mục file, các bạn thay bằng ID của các bạn khi chạy
            var folderId = fileid;
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                path = openfile.FileName;
                filename = openfile.SafeFileName;
            }
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                // Tên file sẽ lưu trên Google Drive
                Name = filename,

                // Thư mục chưa file
                Parents = new List<string>
                {
                    folderId
                }
            };

            // Đường dẫn file trong thiết bị của bạn, dùng để upload lên Goolge Drive
            string pathFile = path;


            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(pathFile, System.IO.FileMode.Open))
            {
                request = driveService.Files.Create(fileMetadata, stream, "image/jpeg");

                // Cấu hình thông tin lấy về là ID
                request.Fields = "id";

                // thực hiện Upload
                request.Upload();
            }

            // Trả về thông tin file đã được upload lên Google Drive
            var file = request.ResponseBody;

            MessageBox.Show("Da Them File!" + Environment.NewLine + "File ID: " + file.Id);
            ListFile();
        }

        private void btn_ThemFolder_Click(object sender, EventArgs e)
        {
            
            var driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string folname;
            if (this.txt_FolderName.Text != "")
                folname = this.txt_FolderName.Text;
            else
                folname = "My Google Drive Folder";
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                
                Name = folname,
                MimeType = "application/vnd.google-apps.folder"
            };

            // Thực hiện việc tạo folder trên Google Drive bằng phương thức Create.
            var request = driveService.Files.Create(fileMetadata);
            request.Fields = "id";

            // Nhận về Id của Folder đã tạo do Google Drive cung cấp
            var file = request.Execute();

            // Hiển thị thông tin Folder
            MessageBox.Show("Da Them Folder!"+Environment.NewLine+" Folder ID: " + file.Id);
            ListFolder();
        }
        

        private void rbt_File_CheckedChanged(object sender, EventArgs e)
        {
            ListFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ListFolder();
        }

        private void lsv_ListFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_ListFile.SelectedItems.Count == 0)
                return;
            fileid = lsv_ListFile.SelectedItems[0].SubItems[1].Text;
        }
    }
}
//private void button2_Click(object sender, EventArgs e)
//{
//    var driveService = new DriveService(new BaseClientService.Initializer()
//    {
//        HttpClientInitializer = credential,
//        ApplicationName = ApplicationName,
//    });
//    var request = driveService.Files.Get(fileid);
//    var stream = new System.IO.MemoryStream();

//    // Add a handler which will be notified on progress changes.
//    // It will notify on each chunk download and when the
//    // download is completed or failed.
//    request.MediaDownloader.ProgressChanged +=
//        (IDownloadProgress progress) =>
//        {
//            switch (progress.Status)
//            {
//                //case DownloadStatus.Downloading:
//                //    {
//                //        //MessageBox.Show(progress.BytesDownloaded.ToString());
//                //        break;
//                //    }
//                case DownloadStatus.Completed:
//                    {
//                        MessageBox.Show("Download complete.");
//                        break;
//                    }
//                case DownloadStatus.Failed:
//                    {
//                        MessageBox.Show("Download failed.");
//                        break;
//                    }
//            }
//        };
//    request.Download(stream);
//}