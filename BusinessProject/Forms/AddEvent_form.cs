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
    public partial class AddEvent_form : Form
    {
        public AddEvent_form()
        {
            InitializeComponent();
            Date_dtp.MinDate = DateTime.Today;
            Date_dtp.CustomFormat = "dd.MM.yyyy HH:mm";
            Categories_cb.DataSource = Enum.GetValues(typeof(Categories));
        }

        private void AddEvent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string eventName = EventName_txt.Text;
                DateTime eventDate = Date_dtp.Value;
                string participants = Participants_txt.Text;
                Categories category = (Categories)Categories_cb.SelectedItem;

                if (string.IsNullOrWhiteSpace(eventName))
                {
                    MessageBox.Show("Введите название события.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(participants))
                {
                    MessageBox.Show("Введите участников события.");
                    return;
                }

                using (var context = new BusinessContext())
                {
                    var meeting = new Meeting
                    {
                        EventName = eventName,
                        Date = eventDate,
                        Participants = participants,
                        Categories = category
                    };

                    context.Meetings.Add(meeting);
                    context.SaveChanges();
                }
                MessageBox.Show("Событие успешно добавлено!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении события: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
