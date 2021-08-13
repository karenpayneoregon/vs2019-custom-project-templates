using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerTablesColumns.Classes;

namespace SqlServerTablesColumns
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _databaseBindingSource = new();
        public Form1()
        {
            InitializeComponent();

            DataOperations.Server = ".\\SQLEXPRESS";
            DataOperations.GeneratedHandler += DataOperationsOnGeneratedHandler;

            CreateArrayButton.Enabled = false;
            Shown += OnShown;
            
            _databaseBindingSource.PositionChanged += DatabaseBindingSourceOnPositionChanged;
            
            TableNamesListBox.MouseDoubleClick += TableNamesListBoxOnMouseDoubleClick;
        }


        private void DataOperationsOnGeneratedHandler(string sender)
        {
            // ReSharper disable once LocalizableElement
            textBox1.Text = textBox1.Text + $"{sender}{Environment.NewLine}";
            textBox1.Text = textBox1.Text.TrimStart();
        }

        private async void DatabaseBindingSourceOnPositionChanged(object? sender, EventArgs e)
        {
            await PositionForTables();
        }

        private async Task PositionForTables()
        {
            if (DatabaseNamesListBox.SelectedItem is not null)
            {
                DataOperations.Database = DatabaseNamesListBox.Text;

                try
                {
                    var tables = await DataOperations.TableNamesList();
                    TableNamesListBox.DataSource = tables;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
        }

        private async void OnShown(object? sender, EventArgs e)
        {
            try
            {
                _databaseBindingSource.DataSource = await DataOperations.DatabaseNameList();
                DatabaseNamesListBox.DataSource = _databaseBindingSource;

                var position = DatabaseNamesListBox.FindString("NorthWind2020");
                CreateArrayButton.Enabled = true;
                if (position <= -1) return;

                _databaseBindingSource.Position = position;

                await Task.Delay(1000);
                await PositionForTables();
            }
            catch (Exception exception)
            {
                CreateArrayButton.Enabled = false;
                MessageBox.Show(exception.Message);
            }
        }

        #region Generate string array

        private void CreateArrayButton_Click(object sender, EventArgs e)
        {
            GenerateArrayForTable();
        }
        private void TableNamesListBoxOnMouseDoubleClick(object? sender, MouseEventArgs e)
        {
            GenerateArrayForTable();
        }

        private void GenerateArrayForTable()
        {
            if (DatabaseNamesListBox.SelectedItem is not null && TableNamesListBox.SelectedItem is not null)
            {
                try
                {
                    DataOperations.Database = DatabaseNamesListBox.Text;
                    DataOperations.Generate(TableNamesListBox.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Must select a database and a table");
            }
        }

        #endregion



    }
}
