using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VANCommanderWF.Forms;

namespace VANCommanderWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        Bll bll = new Bll();

        public string FullPathOnClickPanel1 { get; set; }
        public string FullPathOnClickPanel2 { get; set; }
        public string NowFolderPanel1 { get; set; }
        public string NowFolderPanel2 { get; set; }

        private Stack<String> oldFolderPathsPanel1 = new Stack<string>();
        private Stack<String> oldFolderPathsPanel2 = new Stack<string>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            bll.GetAllLocalDrives(lbPanel1, cbx_LocalDrive1);
            bll.GetAllLocalDrives(lbPanel2, cbx_LocalDrive2);
        }

        private void lbPanel1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbPanel1.SelectedItem != null && lbPanel1.SelectedItem.ToString() != String.Empty)
                {
                    if (Directory.Exists(FullPathOnClickPanel1))
                    {
                        NowFolderPanel1 = lbPanel1.SelectedItem.ToString();
                        oldFolderPathsPanel1.Push(NowFolderPanel1.Substring(0, NowFolderPanel1.LastIndexOf('\\') + 1));
                        txb_path1.Text = NowFolderPanel1;
                        bll.GetAllFolderAndFiles(lbPanel1, lbPanel1.SelectedItem.ToString());
                    }
                    else if (File.Exists(FullPathOnClickPanel1))
                    {
                        bll.OpenFile(FullPathOnClickPanel1);
                    }
                }

                else if (lbPanel1.SelectedItem == null || lbPanel1.SelectedItem.ToString() == String.Empty)
                {
                    bll.GetAllFolderAndFiles(lbPanel1, oldFolderPathsPanel1.Peek());
                    txb_path1.Text = oldFolderPathsPanel1.Pop();
                }
            }
            catch
            {
                // ignored
            }
        }

        private void lbPanel2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbPanel2.SelectedItem != null && lbPanel2.SelectedItem.ToString() != String.Empty)
                {
                    if (Directory.Exists(FullPathOnClickPanel2))
                    {
                        NowFolderPanel2 = lbPanel2.SelectedItem.ToString();
                        oldFolderPathsPanel2.Push(NowFolderPanel2.Substring(0, NowFolderPanel2.LastIndexOf('\\') + 1));
                        txb_path2.Text = NowFolderPanel2;
                        bll.GetAllFolderAndFiles(lbPanel2, lbPanel2.SelectedItem.ToString());
                    }
                    else if (File.Exists(FullPathOnClickPanel2))
                    {
                        bll.OpenFile(FullPathOnClickPanel2);
                    }
                }

                else if (lbPanel2.SelectedItem == null || lbPanel2.SelectedItem.ToString() == String.Empty)
                {
                    bll.GetAllFolderAndFiles(lbPanel2, oldFolderPathsPanel2.Peek());
                    txb_path2.Text = oldFolderPathsPanel2.Pop();
                }
            }
            catch
            {
                // ignored
            }
        }

        private void btn_Ld_Click(object sender, EventArgs e)
        {
            txb_path1.Text = String.Empty;

            bll.GetAllLocalDrives(lbPanel1, cbx_LocalDrive1);
        }

        private void cbx_LocalDrive1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = cbx_LocalDrive1.SelectedItem.ToString();

            txb_path1.Text = path.Trim();

            bll.GetAllFolderAndFiles(lbPanel1, path);
        }

        private void cbx_LocalDrive2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = cbx_LocalDrive2.SelectedItem.ToString();

            txb_path2.Text = path.Trim();

            bll.GetAllFolderAndFiles(lbPanel2, path);
        }

        private void btn_newFolder_Click(object sender, EventArgs e)
        {
            new FormNameDirectory(txb_path1.Text, txb_path2.Text, lbPanel1, lbPanel2).ShowDialog();
        }

        private void btn_newFolder2_Click(object sender, EventArgs e)
        {
            new FormNameDirectory(txb_path2.Text, txb_path1.Text, lbPanel2, lbPanel1).ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txb_path1.Text != String.Empty)
            {
                bll.GetAllFolderAndFiles(lbPanel1, txb_path1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txb_path2.Text != String.Empty)
            {
                bll.GetAllFolderAndFiles(lbPanel2, txb_path2.Text);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(FullPathOnClickPanel1)) // Удаление дериктории
            {
                DialogResult result = MessageBox.Show($"Вы удаляете директорию {FullPathOnClickPanel1}. Удалить данную директорию?",
                    "Удаление директории...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bll.RemoveDirectory(FullPathOnClickPanel1);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
            }
            else if (File.Exists(FullPathOnClickPanel1)) // Удаление файла
            {
                DialogResult result = MessageBox.Show($"Вы удаляете файл {FullPathOnClickPanel1}. Удалить данный файл?",
                    "Удаление файла...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bll.RemoveFile(FullPathOnClickPanel1);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
            }
        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(FullPathOnClickPanel2)) // Удаление дериктории
            {
                DialogResult result = MessageBox.Show($"Вы удаляете директорию {FullPathOnClickPanel2}. Удалить данную директорию?",
                    "Удаление директории...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bll.RemoveDirectory(FullPathOnClickPanel2);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
            }
            else if (File.Exists(FullPathOnClickPanel2)) // Удаление файла
            {
                DialogResult result = MessageBox.Show($"Вы удаляете файл {FullPathOnClickPanel2}. Удалить данный файл?",
                    "Удаление файла...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bll.RemoveFile(FullPathOnClickPanel2);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                bll.GetAllFolderAndFiles(lbPanel1, oldFolderPathsPanel1.Peek());
                txb_path1.Text = oldFolderPathsPanel1.Pop();
            }
            catch
            {
                //ignore
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbPanel1_Click(object sender, EventArgs e)
        {
            btn_copy1.Enabled = true;
            btn_delete1.Enabled = true;
            btn_move1.Enabled = true;

            btn_copy2.Enabled = false;
            btn_delete2.Enabled = false;
            btn_move2.Enabled = false;

            if (lbPanel1.SelectedItem != null)
            {
                FullPathOnClickPanel1 = lbPanel1.SelectedItem.ToString();
            }
        }

        private void lbPanel2_Click(object sender, EventArgs e)
        {
            btn_copy1.Enabled = false;
            btn_delete1.Enabled = false;
            btn_move1.Enabled = false;

            btn_copy2.Enabled = true;
            btn_delete2.Enabled = true;
            btn_move2.Enabled = true;


            if (lbPanel2.SelectedItem != null)
            {
                FullPathOnClickPanel2 = lbPanel2.SelectedItem.ToString();
            }
        }

        private void btn_Ld2_Click(object sender, EventArgs e)
        {
            bll.GetAllLocalDrives(lbPanel2, cbx_LocalDrive2);
            txb_path2.Text = String.Empty;
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            try
            {
                bll.GetAllFolderAndFiles(lbPanel2, oldFolderPathsPanel2.Peek());
                txb_path2.Text = oldFolderPathsPanel2.Pop();
            }
            catch
            {
                //ignore
            }
        }

        private void btn_copy1_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(lbPanel1.SelectedItem.ToString());
            
            if (Directory.Exists(FullPathOnClickPanel1)) // Копирование дериктории
            {
                if (!Directory.Exists(txb_path2.Text.Trim() + "\\" + fileName))
                {
                    bll.CopyDirectory(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Директория уже существует! Заменить?", "Копирование...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveDirectory(txb_path2.Text.Trim() + "\\" + fileName);
                        bll.CopyDirectory(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
            else if (File.Exists(FullPathOnClickPanel1)) // Копирование файла
            {
                if (!File.Exists(txb_path2.Text.Trim() + "\\" + fileName))
                {
                    bll.CopyFile(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Файл уже существует! Заменить?", "Копирование...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveFile(txb_path2.Text.Trim() + "\\" + fileName);
                        bll.CopyFile(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
        }

        private void btn_copy2_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(lbPanel2.SelectedItem.ToString());

            if (Directory.Exists(FullPathOnClickPanel2)) // Копирование дериктории
            {
                if (!Directory.Exists(txb_path1.Text.Trim() + "\\" + fileName))
                {
                    bll.CopyDirectory(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Директория уже существует! Заменить?", "Копирование...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveDirectory(txb_path1.Text.Trim() + "\\" + fileName);
                        bll.CopyDirectory(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
            else if (File.Exists(FullPathOnClickPanel2)) // Копирование файла
            {
                if (!File.Exists(txb_path1.Text.Trim() + "\\" + fileName))
                {
                    bll.CopyFile(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Файл уже существует! Заменить?", "Копирование...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveFile(txb_path1.Text.Trim() + "\\" + fileName);
                        bll.CopyFile(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
        }

        private void btn_move1_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(lbPanel1.SelectedItem.ToString());

            if (Directory.Exists(FullPathOnClickPanel1)) // Перемещение дериктории
            {
                if (!Directory.Exists(txb_path2.Text + "\\" + fileName))
                {
                    bll.RemoveDirectory(txb_path2.Text.Trim() + "\\" + fileName);
                    bll.CopyDirectory(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Директория уже существует! Заменить?", "Перемещение...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveDirectory(txb_path2.Text.Trim() + "\\" + fileName);
                        bll.CopyDirectory(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
            else if (File.Exists(FullPathOnClickPanel1)) // Перемещение файла
            {
                if (!File.Exists(txb_path2.Text + "\\" + fileName))
                {
                    bll.RemoveFile(txb_path2.Text.Trim() + "\\" + fileName);
                    bll.CopyFile(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Файл уже существует! Заменить?", "Перемещение...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveFile(txb_path2.Text.Trim() + "\\" + fileName);
                        bll.CopyFile(lbPanel1.SelectedItem.ToString(), txb_path2.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
        }

        private void btn_move2_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(lbPanel2.SelectedItem.ToString());

            if (Directory.Exists(FullPathOnClickPanel2)) // Перемещение дериктории
            {
                if (!Directory.Exists(txb_path1.Text + "\\" + fileName))
                {
                    bll.RemoveDirectory(txb_path1.Text.Trim() + "\\" + fileName);
                    bll.CopyDirectory(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Директория уже существует! Заменить?", "Перемещение...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveDirectory(txb_path1.Text.Trim() + "\\" + fileName);
                        bll.CopyDirectory(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
            else if (File.Exists(FullPathOnClickPanel2)) // Перемещение файла
            {
                if (!File.Exists(txb_path1.Text + "\\" + fileName))
                {
                    bll.RemoveFile(txb_path1.Text.Trim() + "\\" + fileName);
                    bll.CopyFile(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                    bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Файл уже существует! Заменить?", "Перемещение...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bll.RemoveFile(txb_path1.Text.Trim() + "\\" + fileName);
                        bll.CopyFile(lbPanel2.SelectedItem.ToString(), txb_path1.Text + "\\" + fileName);
                        bll.UpdatePanels(lbPanel1, lbPanel2, txb_path1.Text, txb_path2.Text);
                    }
                }
            }
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            bll.Search(txb_path2.Text.Trim(), txb_search2.Text.Trim(), lbPanel2);
        }

        private void btn_search1_Click(object sender, EventArgs e)
        {
            bll.Search(txb_path1.Text.Trim(), txb_search1.Text.Trim(), lbPanel1);
        }
    }
}
