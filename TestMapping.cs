using Azure.Storage.Files.Shares;
using KenAzureFileShareLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenTestAzureFileShareV2
{
    public partial class TestMapping : Form
    {
        ShareClient KenTutorialFileShare { get; set; }
        public KenMapping KenMapping { get; set; }
        public TestMapping(ShareClient kenTutorialFileShare)
        {
            InitializeComponent();
            KenTutorialFileShare = kenTutorialFileShare;
        }

        private void TestMapping_Load(object sender, EventArgs e)
        {
            refreshResults();
        }
        public void refreshResults()
        {
            RefreshKenMapping();
            PopulateDatagridLocalFileToCloud();
            PopulateDatagridLocalDirectoryToCloud();
            PopulateDatagridCloudFileToLocalFile();
            PopulateDatagridCloudDirectoryToLocalDirectory();
        }

        private void radioButtonANY_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                refreshResults();
            }
        }
        private void RefreshKenMapping()
        {
            string localTopDirectoryPath = null;
            if (radioButtonFdriveKenTestAzure.Checked) { localTopDirectoryPath = radioButtonFdriveKenTestAzure.Text; }
            if (radioButtonFdriveMyTestProjectsKenTestAzure.Checked) { localTopDirectoryPath = radioButtonFdriveMyTestProjectsKenTestAzure.Text; }
            if (radioButtonUncServer2KenTestAzure.Checked) { localTopDirectoryPath = radioButtonUncServer2KenTestAzure.Text; }

            string cloudTopDirectoryPath = null;
            if (radioButtonCloudKenTestAzure.Checked) { cloudTopDirectoryPath = "/KenTestAzure"; }
            if (radioButtonCloudPathCompanyAKenTestAzure.Checked) { cloudTopDirectoryPath = "/CompanyA/KenTestAzure"; }
            //
            KenMapping = new KenMapping(KenTutorialFileShare, cloudTopDirectoryPath, localTopDirectoryPath);
        }
        private void PopulateDatagridLocalFileToCloud()
        {
            dataGridViewLocalFileToCloud.Rows.Clear();
            string prefix = null;
            if (radioButtonFdriveKenTestAzure.Checked) { prefix = radioButtonFdriveKenTestAzure.Text; }
            if (radioButtonFdriveMyTestProjectsKenTestAzure.Checked) { prefix = radioButtonFdriveMyTestProjectsKenTestAzure.Text; }
            if (radioButtonUncServer2KenTestAzure.Checked) { prefix = radioButtonUncServer2KenTestAzure.Text; }

            string[] localFilesToMap = {
                prefix + @"\Invoices\Invoice1.pdf",
                prefix + @"\Accounting\Invoices\Invoice1.pdf" };
            foreach (string localFile in localFilesToMap)
            {
                DataGridViewRow dgvrow = dataGridViewLocalFileToCloud.Rows[dataGridViewLocalFileToCloud.Rows.Add()];
                dgvrow.Cells[Column_LFtoCFLocalFile.Index].Value = localFile;
                ShareFileClient cloudFile = KenMapping.MapLocalFilePathToCloudFile(localFile);
                dgvrow.Cells[Column_LFtoCFCloudFile.Index].Value = cloudFile.Uri.AbsolutePath;
            }
        }
        private void PopulateDatagridLocalDirectoryToCloud()
        {
            dataGridViewLocalDirToCloud.Rows.Clear();
            string prefix = null;
            if (radioButtonFdriveKenTestAzure.Checked) { prefix = radioButtonFdriveKenTestAzure.Text; }
            if (radioButtonFdriveMyTestProjectsKenTestAzure.Checked) { prefix = radioButtonFdriveMyTestProjectsKenTestAzure.Text; }
            if (radioButtonUncServer2KenTestAzure.Checked) { prefix = radioButtonUncServer2KenTestAzure.Text; }

            string[] localDirsToMap = {
                prefix + @"\Invoices",
                prefix + @"\Accounting\Invoices" };
            foreach (string localDir in localDirsToMap)
            {
                DataGridViewRow dgvrow = dataGridViewLocalDirToCloud.Rows[dataGridViewLocalDirToCloud.Rows.Add()];
                dgvrow.Cells[Column_LDtoCDLocalDir.Index].Value = localDir;
                ShareDirectoryClient cloudDir = KenMapping.MapLocalDirectoryPathToCloudDirectory(localDir);
                dgvrow.Cells[Column_LDtoCDCloudDir.Index].Value = cloudDir.Uri.AbsolutePath;
            }
        }
        private void PopulateDatagridCloudFileToLocalFile()
        {
            dataGridViewCloudFileToLocal.Rows.Clear();
            string prefix = null;
            if (radioButtonCloudKenTestAzure.Checked) { prefix = radioButtonCloudKenTestAzure.Text; }
            if (radioButtonCloudPathCompanyAKenTestAzure.Checked) { prefix = radioButtonCloudPathCompanyAKenTestAzure.Text; }

            string[] cloudFilesToMap = {
                prefix + @"/Invoices/Invoice1.pdf",
                prefix + @"/Accounting/Invoices/Invoice1.pdf" };
            foreach (string cloudFilePath in cloudFilesToMap)
            {
                DataGridViewRow dgvrow = dataGridViewCloudFileToLocal.Rows[dataGridViewCloudFileToLocal.Rows.Add()];
                ShareFileClient cloudFile = KenAzureFileUtilities.CreateShareFileClient(KenTutorialFileShare, cloudFilePath);
                dgvrow.Cells[Column_CFtoLFCloudFile.Index].Value = cloudFile.Uri.AbsolutePath;
                string localFile = KenMapping.MapCloudFileToLocalFilePath(cloudFile);
                dgvrow.Cells[Column_CFtoLFLocalFile.Index].Value = localFile;
            }
        }
        private void PopulateDatagridCloudDirectoryToLocalDirectory()
        {
            dataGridViewCloudDirectoryToLocal.Rows.Clear();
            string prefix = null;
            if (radioButtonCloudKenTestAzure.Checked) { prefix = radioButtonCloudKenTestAzure.Text; }
            if (radioButtonCloudPathCompanyAKenTestAzure.Checked) { prefix = radioButtonCloudPathCompanyAKenTestAzure.Text; }

            string[] cloudDirsToMap = {
                prefix + @"/Invoices",
                prefix + @"/Accounting/Invoices" };
            foreach (string cloudDirPath in cloudDirsToMap)
            {
                DataGridViewRow dgvrow = dataGridViewCloudDirectoryToLocal.Rows[dataGridViewCloudDirectoryToLocal.Rows.Add()];
                ShareDirectoryClient cloudDirectory = KenAzureFileUtilities.CreateShareDirectoryClient(KenTutorialFileShare, cloudDirPath);
                dgvrow.Cells[Column_CDtoLDCloudDirectory.Index].Value = cloudDirectory.Uri.AbsolutePath;
                string localDir = KenMapping.MapCloudDirectoryToLocalDirectoryPath(cloudDirectory);
                dgvrow.Cells[Column_CDtoLDLocalDirectory.Index].Value = localDir;
            }
        }
    }
}
