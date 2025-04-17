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
    public partial class EventList_form : Form
    {
        private BindingSource _bindingSource;
        public EventList_form()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            EventList_dgv.DataSource = _bindingSource;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var context = new BusinessContext())
                {
                    var meetings = context.Meetings.ToList();
                    _bindingSource.DataSource = meetings;
                }
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

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int eventId = Convert.ToInt32(EventList_dgv.Rows[e.RowIndex].Cells["EventId"].Value);
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
        private void RefreshDataGridView()
        {
            using (var context = new BusinessContext())
            {
                EventList_dgv.AutoGenerateColumns = true;

                var meetings = context.Meetings.ToList();
                EventList_dgv.DataSource = meetings;

                if (EventList_dgv.Columns.Count > 0)
                {
                    EventList_dgv.Columns["EventId"].HeaderText = "ID";
                    EventList_dgv.Columns["EventName"].HeaderText = "Название события";
                    EventList_dgv.Columns["Date"].HeaderText = "Дата и время события";
                    EventList_dgv.Columns["Participants"].HeaderText = "Участники события";
                    EventList_dgv.Columns["Categories"].HeaderText = "Категория события";
                }
            }
        }
    }
}
