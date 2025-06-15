
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Collections;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace dictionary
{

    public partial class Form1 : Form
    {

        private Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public List<string> allworlds = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        public void forma()
        {
            loaded.View = View.Details;
            loaded.GridLines = true;
        }
        private void addto_Click(object sender, EventArgs e)
        {
            string english = texteng.Text.Trim();
            string russian = textru.Text.Trim();

            if (string.IsNullOrWhiteSpace(english) || string.IsNullOrWhiteSpace(russian))
            {
                MessageBox.Show("Введите слово и перевод.");
                return;
            }

            if (dictionary.ContainsKey(english))
            {
                MessageBox.Show("Такое слово уже есть в словаре.");
                return;
            }
            /*
            string removed = english.PadRight(20) + "|".PadRight(20) + russian;
            loaded.Items.Add(removed);
            */
            texteng.Clear();
            textru.Clear();
            dictionary.Add(english, russian);


            ListViewItem item = new ListViewItem(english);
            item.SubItems.Add(russian);
            loaded.Items.Add(item);

        }

        private void save_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить как";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in loaded.Items)
                    {
                        string[] columns = new string[item.SubItems.Count];
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            columns[i] = item.SubItems[i].Text;
                        }
                        sw.WriteLine(string.Join(";", columns));
                    }
                }
                MessageBox.Show("Файл успешно сохранён!");
            }
        }


        private void load_Click(object sender, EventArgs e)
        {
            dictionary.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Title = "Открыть файл";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loaded.Items.Clear();
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length > 0)
                        {
                            var item = new ListViewItem(parts[0]);
                            for (int i = 1; i < parts.Length; i++)
                            {
                                item.SubItems.Add(parts[i]);
                            }
                            loaded.Items.Add(item);
                            if (parts.Length >= 2 && !dictionary.ContainsKey(parts[0]))
                            {
                                dictionary.Add(parts[0], parts[1]);
                            } 
                            

                        }
                    }
                }
                MessageBox.Show("Файл успешно загружен!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void seach_Click(object sender, EventArgs e)
        {
            string qwe = seacheng.Text.Trim();
            loaded.Items.Clear();


            string chose1 = takeit.Text;
            if (chose1 == "English")
            {
                if (string.IsNullOrWhiteSpace(qwe))
                {
                    foreach (var pair in dictionary)
                    {
                        loaded.Items.Add($"{pair.Key} - {pair.Value}");
                    }
                    return;
                }
                var found = dictionary
        .Where(pair => pair.Key.IndexOf(qwe, StringComparison.OrdinalIgnoreCase) >= 0)
        .ToList();
                foreach (var word in found)
                {
                    var item = new ListViewItem(word.Key);
                    item.SubItems.Add(word.Value);
                    loaded.Items.Add(item);
                }
            }
            else 
            {
                if (string.IsNullOrWhiteSpace(qwe))
                {
                    foreach (var pair in dictionary)
                    {
                        loaded.Items.Add($"{pair.Key} - {pair.Value}");
                    }
                    return;
                }
                var ru = dictionary
            .Where(pair => pair.Value.IndexOf(qwe, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();
                foreach(var word in ru)
                {
                    var item = new ListViewItem(word.Key);
                    item.SubItems.Add(word.Value);
                    loaded.Items.Add(item);
                }   
            }



            
        }

        private void comeback_Click(object sender, EventArgs e)
        {
            loaded.Items.Clear();
            foreach (var word in dictionary)
            {
                var item = new ListViewItem(word.Key);
                item.SubItems.Add(word.Value);
                loaded.Items.Add(item);
            }
        }

        
    }
}