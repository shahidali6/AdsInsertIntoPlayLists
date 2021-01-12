using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsIntoPlayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ReadBothPlayListItemsandGeneratePlayListFile(string PlayListFileandPath)
        {
            List<string> currentPlayListFile = new List<string>();
            List<string> refinePlayListFile = new List<string>();
            List<string> currentPlayListForm = new List<string>();
            List<string> refinePlayListForm = new List<string>();
            List<string> processedPlayList = new List<string>();
            //string PlayListFileandPath = @"C:\Users\Shahid\Desktop\temp\Fiverr\Final 1-1-2021 playlists\SEM Records 2020 Thursday Mania Keep Distance.m3u8";
            string file = ReadPlayListFileAndReturnString(PlayListFileandPath);
            currentPlayListFile = StringSplittoListbyNewLine(file);
            refinePlayListFile = RefinePlayListbyCombineTwoLines(currentPlayListFile);
            string form = tbNewListItems.Text;
            currentPlayListForm = StringSplittoListbyNewLine(form);
            refinePlayListForm = RefinePlayListbyCombineTwoLines(currentPlayListForm);
            int currentItrationFormList = 0;
            int intervalValue = int.Parse(tbInterval.Text);

            processedPlayList.Add("#EXTM3U");
            for (int i = 0; i < refinePlayListFile.Count; i++)
            {
                if (i == refinePlayListFile.Count)
                {
                    continue;
                }
                if (i == intervalValue)
                {
                    processedPlayList.Add(refinePlayListForm[currentItrationFormList]);
                    intervalValue += int.Parse(tbInterval.Text);
                    currentItrationFormList++;
                    if (currentItrationFormList == refinePlayListForm.Count)
                    {
                        currentItrationFormList = 0;
                    }
                }
                processedPlayList.Add(refinePlayListFile[i]);
                //if (i == 0)
                //{
                //    for (; i < intervalValue; i++)
                //    {
                //        processedPlayList.Add(refinePlayListFile[i]);

                //    }
                //}
                //if ((i % intervalValue) == 0)
                //{
                //    processedPlayList.Add(refinePlayListFile[i]);
                //    processedPlayList.Add(refinePlayListForm[currentItrationFormList]);
                //    if (currentItrationFormList == refinePlayListForm.Count - 1)
                //    {
                //        currentItrationFormList = 0;
                //    }
                //    else
                //    {
                //        currentItrationFormList++;
                //    }
                //}
                //else
                //{
                //    processedPlayList.Add(refinePlayListFile[i]);
                //}
            }
            var result = WritePlayListFileFromList(PlayListFileandPath, processedPlayList);
        }

        private List<string> StringSplittoListbyNewLine(string fileContent)
        {
            string stringSplitter = Environment.NewLine;
            string[] stringSpliterArray = { stringSplitter };
            return fileContent.Split(stringSpliterArray, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private string ReadPlayListFileAndReturnString(string PlayListFileandPath)
        {
            string fileContent = String.Empty;
            using (StreamReader reader = new StreamReader(PlayListFileandPath))
            {
                fileContent = reader.ReadToEnd();
                reader.Dispose();
                reader.Close();
            }
            return fileContent;
        }

        private bool WritePlayListFileFromList(string playListFileandPath, List<string> listToWrite)
        {
            try
            {
                // Full file name. Change your file name   
                FileInfo fileName = new FileInfo(playListFileandPath);

                // Get File Name  
                string justFileName = fileName.Name;
                // Get file extension   
                string extn = fileName.Extension;

                string fileNamewithoutExt = justFileName.Replace(extn, String.Empty);

                //string playListStart = "#EXTM3U";
                string dateTimeNow = "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                //` tring playListExt = ".m3u8";
                string finalFileName = fileNamewithoutExt + dateTimeNow + extn;

                string finalCombinePathandFile = Path.Combine(fileName.DirectoryName, finalFileName);
                //using (StreamWriter writer = new StreamWriter(finalCombinePathandFile, append: true))
                //using (StreamWriter writer = new StreamWriter(finalCombinePathandFile))
                using (StreamWriter writer = new StreamWriter(File.Open(finalCombinePathandFile, FileMode.Create), Encoding.Unicode))
                {
                    //writer.WriteLine(playListStart);
                    foreach (var item in listToWrite)
                    {
                        writer.WriteLine(item);
                    }
                    writer.Dispose();
                    writer.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Test Caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        List<string> allPlayListsM3U8 = new List<string>();
        List<string> RefinecurrentPlayListfromList = new List<string>();
        List<string> RefinecurrentPlayListform = new List<string>();

        private List<string> RefinePlayListbyCombineTwoLines(List<string> currentPlayList)
        {
            string listItemStart = "#EXTINF";
            List<string> RefinePlayListfromList = new List<string>();
            for (int i = 0; i < currentPlayList.Count; i++)
            {
                if (currentPlayList[i].StartsWith(listItemStart))
                {
                    RefinePlayListfromList.Add(currentPlayList[i] + Environment.NewLine + currentPlayList[i + 1]);
                }
            }
            return RefinePlayListfromList;
        }

        static List<string> ReturnListofPlayListsFromFolder(string folderPath, out string textToDisplay)
        {
            //FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            //folderBrowser.Description = "Select PlayList folder";
            //DialogResult dialogResults1 = folderBrowser.ShowDialog();
            //OpenFileDialog openDialogBox = new OpenFileDialog();
            //openDialogBox.Title = "Select PlayList Folder";
            //openDialogBox.Filter = "Text Files (*.txt)|*.txt|All Files|*.*";

            //DialogResult dialogResults = openDialogBox.ShowDialog();
            List<string> allFileList = new List<string>();
            List<string> filteredPlayLists = new List<string>();
            string listOfAllPlayLists = String.Empty;
            string path = folderPath;
            //string path = @"C:\Users\Shahid\Desktop\temp\Fiverr\Final 1-1-2021 playlists\";
            string playListExt = "m3u8";

            //allFileList = Directory.GetFiles(@"C:\Users\Shahid\Desktop\temp\Fiverr\Final 1-1-2021 playlists\", "*", SearchOption.AllDirectories).ToList(); 
            allFileList = Directory.GetFiles(path).ToList();

            int loopCounter = 1;
            foreach (var file in allFileList)
            {
                string onlyFileName = String.Empty;
                onlyFileName = file.Replace(path, String.Empty);
                if (onlyFileName.Contains(playListExt))
                {
                    filteredPlayLists.Add(file);
                    listOfAllPlayLists += loopCounter.ToString() + ": " + onlyFileName + Environment.NewLine;
                    loopCounter++;
                }
            }
            textToDisplay = listOfAllPlayLists;
            return filteredPlayLists;
        }

        private void btnLoadPlayLists_Click(object sender, EventArgs e)
        {
            string textToDisplayonForm;
            allPlayListsM3U8 = ReturnListofPlayListsFromFolder(tbFolderPath.Text, out textToDisplayonForm);
            lbPlayListsAfterLoad.Text = textToDisplayonForm;
            //string path = folderBrowserDialog1.RootFolder.ToString();
            //string path = openFileDialog1.SafeFileNames();
            //string[] tempStrings = openFileDialog1.SafeFileNames;
        }

        private void btnAdsintoPlayLists_Click(object sender, EventArgs e)
        {
            ReadBothPlayListItemsandGeneratePlayListFile(@"C:\Users\Shahid\Desktop\temp\Fiverr\Final 1-1-2021 playlists\SEM Records 2020 Thursday Mania Keep Distance.m3u8");
        }
    }
}
