using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProject
{
    public partial class FilterEvent_form : Form
    {

        private DataGridView _eventListDgv;
        private Action _refreshDataCallback;
        public FilterEvent_form(DataGridView eventListDgv, Action refreshDataCallback)
        {
            InitializeComponent();
            _eventListDgv = eventListDgv;
            _refreshDataCallback = refreshDataCallback;
        }


        private void FilterCategory_btn_Click(object sender, EventArgs e)
        {
            if (_eventListDgv.Rows.Count > 0 && _eventListDgv.Columns.Count > 0)
            {

                try
                {
                    var dataSource = _eventListDgv.DataSource as BindingSource;
                    if (dataSource == null || dataSource.List == null)
                    {
                        MessageBox.Show("Невозможно применить фильтр: источник данных не найден.");
                        return;
                    }

                    var meetings = (dataSource.List as IList).Cast<Meeting>().ToList();

                    var categories = Enum.GetValues(typeof(Categories)).Cast<Categories>();

                    var filteredMeetings = new List<Meeting>();
                    foreach (var category in categories)
                    {
                        var categoryMeetings = meetings.Where(m => m.Categories == category).ToList();
                        filteredMeetings.AddRange(categoryMeetings);
                    }

                    dataSource.DataSource = filteredMeetings;

                    MessageBox.Show("Данные отфильтрованы по всем категориям.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при фильтрации данных: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Нет данных для фильтрации.");
            }
            this.Close();
        }

        private void FilterDate_btn_Click(object sender, EventArgs e)
        {
            if (_eventListDgv.Rows.Count > 0 && _eventListDgv.Columns.Count > 0)
            {
                try
                {
                    var dataSource = _eventListDgv.DataSource as BindingSource;
                    if (dataSource == null || dataSource.List == null)
                    {
                        MessageBox.Show("Невозможно применить фильтр: источник данных не найден.");
                        return;
                    }

                    var meetings = (dataSource.List as IList).Cast<Meeting>().ToList();

                    var sortedMeetings = meetings
                        .OrderBy(m => m.Date)
                        .ToList();

                    dataSource.DataSource = sortedMeetings;

                    MessageBox.Show("События отсортированы по датам.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сортировке данных: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Нет данных для сортировки.");
            }
            this.Close();
        }
    }
}
