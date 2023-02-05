using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Diagnostics;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private string seciliyol;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayFilesAndFolders(string path)
        {
            try
            {
                this.Text = "Zesty File Manager - " + Path.GetFileName(path);
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Dosya İsmi", 150, HorizontalAlignment.Left);
                listView1.Columns.Add("Dosya Yolu", 300, HorizontalAlignment.Left);
                listView1.Columns.Add("Boyut", 100, HorizontalAlignment.Left);

                var directories = Directory.GetDirectories(path);
                var files = Directory.GetFiles(path);

                foreach (var directory in directories)
                {
                    var fileName = Path.GetFileName(directory);
                    var filePath = directory;
                    var fileSize = "";

                    string[] arr = new string[3];
                    arr[0] = fileName;
                    arr[1] = filePath;
                    arr[2] = fileSize;

                    ListViewItem item = new ListViewItem(arr);
                    listView1.Items.Add(item);
                }

                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file);
                    var filePath = file;
                    var fileSize = new FileInfo(file).Length.ToString();

                    string[] arr = new string[3];
                    arr[0] = fileName;
                    arr[1] = filePath;
                    arr[2] = fileSize;

                    ListViewItem item = new ListViewItem(arr);
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    seciliyol = fbd.SelectedPath;
                    DisplayFilesAndFolders(seciliyol);
                }
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string aranantext = Interaction.InputBox("Aranacak değeri girin", "Dosya Arama", "", 200, 200);
            if (!string.IsNullOrWhiteSpace(aranantext))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.Contains(aranantext))
                    {
                        listView1.Focus();
                        item.Selected = true;
                        item.EnsureVisible();
                        break;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string dosyaismi = Interaction.InputBox("Lütfen oluşturmak istediğiniz klasör/dosyanın adını girin", "Klasör/Dosya Oluşturma");
            if (!string.IsNullOrWhiteSpace(dosyaismi))
            {
                // Klasör oluşturma
                Directory.CreateDirectory(Path.Combine(seciliyol, dosyaismi));

                // Dosya oluşturma
                // File.Create(Path.Combine(selectedPath, path));

                DisplayFilesAndFolders(seciliyol);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string silinecekdosyaismi = Path.Combine(seciliyol, listView1.SelectedItems[0].Text);
                if (File.Exists(silinecekdosyaismi))
                {
                    File.Delete(silinecekdosyaismi);
                }
                else if (Directory.Exists(silinecekdosyaismi))
                {
                    Directory.Delete(silinecekdosyaismi, true);
                }

                DisplayFilesAndFolders(seciliyol);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string eskiisim = Path.Combine(seciliyol, listView1.SelectedItems[0].Text);
                string yenisim = Interaction.InputBox("Lütfen yeni adı girin", "Dosya/Klasör Güncelleme");
                if (!string.IsNullOrWhiteSpace(yenisim))
                {
                    string yeniyol = Path.Combine(seciliyol, yenisim);
                    if (File.Exists(eskiisim))
                    {
                        File.Move(eskiisim, yeniyol);
                    }
                    else if (Directory.Exists(eskiisim))
                    {
                        Directory.Move(eskiisim, yeniyol);
                    }

                    DisplayFilesAndFolders(seciliyol);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                var filePath = selectedItem.SubItems[1].Text;

                try
                {
                    Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    var selectedItem = listView1.SelectedItems[0];
                    var selectedPath = Path.Combine(seciliyol, selectedItem.Text);
                    if (selectedItem.Text == "...")
                    {
                        var parentDirectory = Directory.GetParent(seciliyol).FullName;
                        seciliyol = parentDirectory;
                        DisplayFilesAndFolders(seciliyol);
                    }
                    else if (Directory.Exists(selectedPath))
                    {
                        listView1.Items.Add("...");
                        seciliyol = selectedPath;
                        listView1.Items.Insert(0, new ListViewItem("..."));
                        DisplayFilesAndFolders(seciliyol);
                    }
                    else if (File.Exists(selectedPath))
                    {
                        Process.Start(selectedPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}