using BusinessProject;
using OfficeOpenXml.Table;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BusinessProject
{
    public partial class EventList_form : Form
    {
        private BindingSource _bindingSource;
        private readonly BusinessContext _context;
        public EventList_form(BusinessContext context = null)
        {
            InitializeComponent();
            _context = context ?? new BusinessContext();
            _bindingSource = new BindingSource();
            EventList_dgv.DataSource = _bindingSource;
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (var context = new BusinessContext())
                {
                    var meetings = context.Meetings.ToList();
                    var bindingList = new BindingList<Meeting>(meetings);
                    _bindingSource.DataSource = bindingList;
                }
                if (EventList_dgv.Columns.Count > 0)
                {
                    EventList_dgv.Columns["Id"].Visible = false;
                    EventList_dgv.Columns["Participants"].Visible = false;
                }
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEvent_btn_Click(object sender, EventArgs e)
        {
            var formAdd = new AddEvent_form();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            var formAdd = new FilterEvent_form(EventList_dgv, RefreshDataGridView);
            formAdd.ShowDialog();
        }

        public void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int eventId = Convert.ToInt32(EventList_dgv.Rows[e.RowIndex].Cells["Id"].Value);
                string eventName = EventList_dgv.Rows[e.RowIndex].Cells["EventName"].Value?.ToString();
                DateTime eventDate = Convert.ToDateTime(EventList_dgv.Rows[e.RowIndex].Cells["Date"].Value);
                string eventParticipants = EventList_dgv.Rows[e.RowIndex].Cells["Participants"].Value?.ToString();
                string categoryString = EventList_dgv.Rows[e.RowIndex].Cells["Categories"].Value?.ToString();
                Categories eventCategory = (Categories)Enum.Parse(typeof(Categories), categoryString);

                using (ManageEvent_form form3 = new ManageEvent_form(eventId, eventName, eventDate, eventParticipants, eventCategory, RefreshDataGridView))
                {
                    form3.ShowDialog(this);
                }
            }
        }
        public void RefreshDataGridView()
        {
            using (var context = new BusinessContext())
            {
                EventList_dgv.AutoGenerateColumns = true;

                var meetings = context.Meetings.ToList();
                var bindingList = new BindingList<Meeting>(meetings);
                _bindingSource.DataSource = bindingList;

                if (EventList_dgv.Columns.Count > 0)
                {
                    EventList_dgv.Columns["Id"].HeaderText = "ID";
                    EventList_dgv.Columns["EventName"].HeaderText = "Название события";
                    EventList_dgv.Columns["Date"].HeaderText = "Дата и время события";
                    EventList_dgv.Columns["Participants"].HeaderText = "Участники события";
                    EventList_dgv.Columns["Categories"].HeaderText = "Категория события";
                }
            }
        }

        private void AddReport_btn_Click(object sender, EventArgs e)
        {
            try
            {

                var meetings = (_bindingSource.DataSource as BindingList<Meeting>)?.Cast<Meeting>().ToList();

                if (meetings == null || meetings.Count == 0)
                {
                    MessageBox.Show("Нет данных для создания отчета.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "Event_Report.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Events");

                        var headerRow = worksheet.Cells[1, 1];
                        worksheet.Cells[1, 1].LoadFromCollection(meetings, true, TableStyles.Medium9);

                        worksheet.Cells[1, 1, 1, 5].Style.Font.Bold = true;

                        using (var stream = File.Create(filePath))
                        {
                            package.SaveAs(stream);
                        }

                        MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}