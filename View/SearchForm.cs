using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Model;

namespace View
{
    public partial class SearchForm : Form
    {
        int Index = -1;
        public readonly List<IFigures> ListFind = new List<IFigures>();
        

        public SearchForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 MainForm = (Form1)Owner;
            MainForm.MainDataGridView.Rows.Clear();
            foreach (IFigures item in MainForm.ListFigures)
            {
                MainForm.MainDataGridView.Rows.Add(item.Name(), item.Output());
            }
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Form1 MainForm = (Form1)Owner;
            MainForm.MainDataGridView.Rows.Clear();
            ListFind.Clear();
            try
            {
                if (Index == -1)
                    throw new Exception("Выберите фигуру");
                else if (Index == 0)
                {
                    if (textBox1.Text != "")
                    {
                        foreach (var item in MainForm.ListFigures)
                        {
                            if (item.Volume() > float.Parse(textBox1.Text) && item.Volume() < float.Parse(textBox2.Text)
                                && item.Name() == "Шар")
                                ListFind.Add(item);
                        }
                        foreach (IFigures figure in ListFind)
                        {
                            MainForm.MainDataGridView.Rows.Add(figure.Name(), figure.Output());
                        }
                    }
                    else throw new Exception("Нет данных");
                }
                else if (Index == 1)
                {
                    if (textBox1.Text != "")
                    {
                        foreach (var item in MainForm.ListFigures)
                        {
                            if (item.Volume() > float.Parse(textBox1.Text) && item.Volume() < float.Parse(textBox2.Text)
                                && item.Name() == "Пирамида")
                                ListFind.Add(item);
                        }
                        foreach (IFigures figure in ListFind)
                        {
                            MainForm.MainDataGridView.Rows.Add(figure.Name(), figure.Output());
                        }
                    }
                    else throw new Exception("Нет данных");
                }
                else if (Index == 2)
                {
                    if (textBox1.Text != "")
                    {
                        foreach (var item in MainForm.ListFigures)
                        {
                            if (item.Volume() > float.Parse(textBox1.Text) && item.Volume() < float.Parse(textBox2.Text)
                                && item.Name() == "Параллелепипед")
                                ListFind.Add(item);
                        }
                        foreach (IFigures figure in ListFind)
                        {
                            MainForm.MainDataGridView.Rows.Add(figure.Name(), figure.Output());
                        }
                    }
                    else throw new Exception("Нет данных");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = SearchComboBox.SelectedIndex;
        }
    }
}
