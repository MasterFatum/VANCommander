using System;
using System.IO;
using System.Windows.Forms;

namespace VANCommanderWF
{
    class Bll
    {
        public void GetAllLocalDrives(ListBox listBox1, ComboBox comboBox1)
        {
            try
            {
                listBox1.Items.Clear();
                comboBox1.Items.Clear();
                
                DriveInfo[] di = DriveInfo.GetDrives();

                foreach (var drive in di)
                {
                    listBox1.Items.Add(drive.Name);
                    comboBox1.Items.Add(drive.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        
        public void GetAllFolderAndFiles(ListBox listBox, string path)
        {
            try
            {
                listBox.Items.Clear();

                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                listBox.Items.Add(String.Empty);

                foreach (var folder in directories)
                {
                    listBox.Items.Add(folder);
                }
                foreach (var file in files)
                {
                    listBox.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdatePanels(ListBox listBox1, ListBox listBox2, String path1, String path2)
        {
            GetAllFolderAndFiles(listBox1, path1);
            GetAllFolderAndFiles(listBox2, path2);
        }

        public void CreateDirectory(string path, string name)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(String.Format(path + "\\" + name));
                directory.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void RemoveDirectory(string path)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                directory.Delete(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OpenFile(string path)
        {
            try
            {
                var proc = new System.Diagnostics.Process
                {
                    StartInfo = { FileName = path, UseShellExecute = true }
                };
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CopyFile(string source, string destination)
        {
            try
            {
                File.Copy(source, destination);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void RemoveFile(string source)
        {
            try
            {
                File.Delete(source);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CopyDirectory(string source, string destination)
        {
            try
            {
                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);

                    string[] files = Directory.GetFiles(source);
                    
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        
                        File.Copy(file, destination + "\\" + fileName, true);
                    }
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MoveDirectory(string source, string destination)
        {
            try
            {
                Directory.Move(source, destination);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Search(string path, string fileName, ListBox listBox)
        {
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (string file in directories)
            {
                string directoryNameCut = Path.GetFileName(file);

                if (fileName == directoryNameCut)
                {
                    directoryNameCut = Path.GetFullPath(file);

                    listBox.Items.Clear();
                    listBox.Items.Add(directoryNameCut);
                }
            }

            foreach (string file in files)
            {
                string fileNameCut = Path.GetFileName(file);

                if (fileName == fileNameCut)
                {
                    fileNameCut = Path.GetFullPath(file);

                    listBox.Items.Clear();
                    listBox.Items.Add(fileNameCut);
                }
            }
        }
    }
}
