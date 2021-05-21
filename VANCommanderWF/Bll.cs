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
                DirectoryInfo directory = new DirectoryInfo(String.Format(path));
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

        public void CopyDirectory(string source, string destination)
        {
            try
            {
                
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
    }
}
