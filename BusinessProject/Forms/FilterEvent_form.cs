using System;
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


        private void FilterName_btn_Click(object sender, EventArgs e)
        {
            if (_eventListDgv.Rows.Count > 0 && _eventListDgv.Columns.Count > 0)
            {
                string columnName = "EventName";
                if (_eventListDgv.Columns.Contains(columnName))
                {
                    _eventListDgv.Sort(_eventListDgv.Columns[columnName], ListSortDirection.Ascending);
                    MessageBox.Show($"Данные отсортированы по столбцу '{columnName}'.");
                }
                else
                {
                    MessageBox.Show($"Столбец '{columnName}' не найден.");
                }
            }
            else
            {
                MessageBox.Show("Нет данных для сортировки.");
            }

            _refreshDataCallback?.Invoke();
        }
    }
}
