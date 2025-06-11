using Azure.Storage.Files.Shares;
using Azure.Storage.Files.Shares.Models;
using KenAzureFileShareLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KenTestAzureFileShareV2
{
    public partial class Form1 : Form
    {
        // 5/17/2025 A ShareClient is almost synonymous with FileShare!
        // This ShareClient (FileShare) will be obtained once and used for any method in KenAzureUtilities.
        ShareClient KenTutorialFileShare { get; set; }
        // Default: F:
        public string DiskDriveForTests { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string azureStorageConnectionString = "<your_azureStorageConnectionString>"; 
            comboBoxDiskDriveForTests.SelectedText = "F:";

            if (azureStorageConnectionString.Equals("<your_azureStorageConnectionString>"))
            {
                string message = "You must modify Form1.cs to specify <your_azureStorageConnectionString>";
                MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                abort();
            }
            else
            {
                GetKenTutorialFileShare(azureStorageConnectionString);
            }
        }
        private void abort()
        {
            buttonTest1a.Enabled = false;
            buttonTest1b.Enabled = false;
            buttonTest1c.Enabled = false;
            buttonTest2a.Enabled = false;
            buttonTest2b.Enabled = false;
            buttonTest3a.Enabled = false;
            buttonTest3b.Enabled = false;
            buttonTest3c.Enabled = false;
            buttonTest4a.Enabled = false;
            buttonTest4b.Enabled = false;
        }
        private bool KenTutorialFileShareExists(string azureStorageConnectionString, string fileShareName)
        {
            KenTutorialFileShare = KenAzureFileUtilities.GetShareClient(azureStorageConnectionString, fileShareName, createIfNotExist: false);
            bool exists = KenTutorialFileShare.Exists();
            return exists;
        }
        private void GetKenTutorialFileShare(string azureStorageConnectionString)
        {
            string fileShareName = "kentutorialfileshare";
            // User must allow us to create the kentutorialfileshare!
            if (!KenTutorialFileShareExists(azureStorageConnectionString, fileShareName))
            {
                string question = $"A File Share named {fileShareName} will be created in your Azure Storage account if you proceed."
                + "\nDo you want to proceed?";
                DialogResult result = MessageBox.Show(question, "KenTestAzureFileShareV2", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    KenTutorialFileShare = KenAzureFileUtilities.GetShareClient(azureStorageConnectionString, fileShareName, createIfNotExist: true);
                }
                else
                {
                    abort();
                }
            }
        }
        private void buttonTest1a_Click(object sender, EventArgs e)
        {
            // This local file must exist!
            string localFilename = "TestFile1.txt";
            string localFolderPath = @"F:\KenTestAzure\testfolder1\testfolder2";
            string localFilepath = Path.Combine(localFolderPath, localFilename);
            // It does not matter if the cloudFilePath starts with a '/' (A leading '/' is essentially ignored).
            // If cloudFilepath specifies only the localFilename, the file will be uploaded to the file share's root directory!
            string cloudFilepath = $"KenTestAzure/testfolder1/testfolder2/{localFilename}";
            ShareFileClient shareFileClient = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilepath);
            KenAzureFileUtilities.UploadFile(shareFileClient, localFilepath, allowOverwrite: true, createCloudDirectories: true);
            string message = $"Successfully uploaded file ({localFilename}) to cloud: {shareFileClient.Uri.AbsolutePath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void buttonTest1b_Click(object sender, EventArgs e)
        {
            // This local file must exist!
            string localFilename = "TestFile1.txt";
            string localFolderPath = @"F:\KenTestAzure\testfolder1\testfolder2";
            string localFilepath = Path.Combine(localFolderPath, localFilename);
            // It does not matter if the cloudFilePath starts with a '/' (A leading '/' is essentially ignored).
            // If cloudFilepath specifies only the localFilename, the file will be uploaded to the file share's root directory!
            string cloudFilepath = localFilename;
            ShareFileClient shareFileClient = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilepath);
            KenAzureFileUtilities.UploadFile(shareFileClient, localFilepath, allowOverwrite: true);
            string message = $"Successfully uploaded file ({localFilename}) to cloud: {shareFileClient.Uri.AbsolutePath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonTest1c_Click(object sender, EventArgs e)
        {
            // Reference: https://learn.microsoft.com/en-us/answers/questions/493399/creating-large-test-file-on-windows
            // These bytes are assigned trivially for testing!
            // For real scenarios the byte array could be the bytes of an Image or many other things.
            //byte[] bytes = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 };
            int size = 5 * 1024 * 1024; // 5 MB
            byte[] bytes = new byte[size];
            for (int iii=0; iii<size; iii++)
            {
                bytes[iii] = (byte)iii;
            }
            // specify the desired cloudFilepath for the bytes we are uploading
            string filename = "TestFile2.bin";
            string cloudFilepath = $"KenTestAzure/testfolder1/{filename}";
            ShareFileClient shareFileClient = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilepath);
            KenAzureFileUtilities.UploadFile(shareFileClient, bytes, allowOverwrite: true);
            string message = $"Successfully uploaded binary data using byte array to cloud: {shareFileClient.Uri.AbsolutePath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonTest2a_Click(object sender, EventArgs e)
        {
            // You need an existing cloud file.  You could use UploadFile above or the Microsoft Azure Storage Explorer Tool.
            string cloudFilepath = $"KenTestAzure/testfolder1/testfolder2/TestFile1.txt";
            ShareFileClient shareFileClient = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilepath);
            // Ken's library has a KenMapping class as a tool to map between local and cloud file names but we just hard code the local filepath here.
            string localFilePath = @"F:\KenTestAzureDownload\testfolder1\testfolder2\TestFile1.txt";
            KenAzureFileUtilities.DownloadFile(shareFileClient, localFilePath, createLocalParentDirectories: true, allowOverwrite: true);
            string message = $"Successfully downloaded file to {localFilePath}.";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonTest2b_Click(object sender, EventArgs e)
        {
            // You need an existing cloud file.  You could use UploadFile above or the Microsoft Azure Storage Explorer Tool.
            string cloudFilepath = $"KenTestAzure/testfolder1/TestFile2.bin";
            ShareFileClient shareFileClient = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilepath);
            byte[] bytes = KenAzureFileUtilities.DownloadFile(shareFileClient);
            string message = $"Successfully downloaded file to byte array: {BitConverter.ToString(bytes,0,10)}...";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonTest3a_Click(object sender, EventArgs e)
        {
            string cloudFilePath = $"KenTestAzure/testfolder1/TestFile2.bin";
            ShareFileClient cloudFile = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilePath);
            // specify my metadata
            string myMetadataKey = "Country";
            string myMetadataValue = "USA data";
            KenAzureFileUtilities.AddMetadataItem(cloudFile, myMetadataKey, myMetadataValue, replaceIfKeyAlreadyExists: true);
            myMetadataKey = "Year";
            myMetadataValue = "1953";
            KenAzureFileUtilities.AddMetadataItem(cloudFile, myMetadataKey, myMetadataValue, replaceIfKeyAlreadyExists: true);
            string message = $"Added metadata item (keys: Country and Year) to cloud file: {cloudFile.Uri.AbsolutePath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayMetadata();
        }
        private void buttonTest4_Click(object sender, EventArgs e)
        {
            string cloudFilePath = $"KenTestAzure/testfolder1/TestFile2.bin";
            ShareFileClient cloudFile = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilePath);
            ShareFileProperties shareFileProperties = cloudFile.GetProperties();
            Dictionary<string, string> metadataDict = (Dictionary<string, string>)shareFileProperties.Metadata;
            string message = $"Current metadata for cloud file: {cloudFile.Uri.AbsolutePath}";
            foreach (KeyValuePair<string, string> kvp in metadataDict)
            {
                message += $"\n{kvp.Key}={kvp.Value}";
            }
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonTest3b_Click(object sender, EventArgs e)
        {
            string cloudFilePath = $"KenTestAzure/testfolder1/TestFile2.bin";
            ShareFileClient cloudFile = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilePath);
            // specify metadata item to remove
            string myMetadataKey = "Country";
            KenAzureFileUtilities.RemoveMetadataItem(cloudFile, myMetadataKey);
            string message = $"Removed metadata item from cloud file: {cloudFile.Uri.AbsolutePath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayMetadata();
        }
        private void buttonTest3c_Click(object sender, EventArgs e)
        {
            string cloudFilePath = $"KenTestAzure/testfolder1/TestFile2.bin";
            ShareFileClient cloudFile = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilePath);
            KenAzureFileUtilities.ClearMetadata(cloudFile);
            string message = $"Cleared all metadata from cloud file: {cloudFile.Uri.AbsolutePath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayMetadata();
        }
        private void buttonTest4aClick(object sender, EventArgs e)
        {
            // Specify the top level cloud directory and the top level local directory for mapping.
            KenMapping kenMapping = new KenMapping(KenTutorialFileShare, "/KenTestAzure", @"F:\KenTestAzure");
            string localFilename = "TestFile1.txt";
            string localFolderPath = @"F:\KenTestAzure\testfolder1";
            string localFilepath = Path.Combine(localFolderPath, localFilename);
            ShareFileClient cloudFile = kenMapping.MapLocalFilePathToCloudFile(localFilepath);
            string message = $"Mapped local filepath: \n{localFilepath} \n to cloud file: \n{cloudFile.Uri.AbsolutePath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void buttonTest4b_Click(object sender, EventArgs e)
        {
            // Specify the top level cloud directory and the top level local directory for mapping.
            KenMapping kenMapping = new KenMapping(KenTutorialFileShare, "/KenTestAzure", @"F:\KenTestAzure");
            string cloudFilePath = $"KenTestAzure/testfolder1/TestFile2.bin";
            ShareFileClient cloudFile = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilePath);
            string localFilepath = kenMapping.MapCloudFileToLocalFilePath(cloudFile);
            string message = $"Mapped cloud file: \n{cloudFile.Uri.AbsolutePath} \n to local file: \n{localFilepath}";
            MessageBox.Show(message, "TestKensAzureLibrary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayMetadata()
        {
            dataGridView1.Rows.Clear();
            string cloudFilePath = $"KenTestAzure/testfolder1/TestFile2.bin";
            ShareFileClient cloudFile = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilePath);
            Dictionary<string, string> metadataDictionary = KenAzureFileUtilities.GetMetadataDictionary(cloudFile);
            foreach (KeyValuePair<string, string> item in metadataDictionary)
            {
                DataGridViewRow dgvrow = dataGridView1.Rows[dataGridView1.Rows.Add()];
                dgvrow.Cells[Column_Key.Index].Value = item.Key;
                dgvrow.Cells[Column_Value.Index].Value = item.Value;
            }
        }

        
    }
}
