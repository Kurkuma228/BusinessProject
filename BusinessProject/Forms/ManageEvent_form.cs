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
    public partial class ManageEvent_form : Form
    {
        int eventId;
        private Action refreshCallBack;
        public ManageEvent_form(int eventId, string eventName, DateTime eventDate, string eventParticipants, Categories eventCategory, Action refreshCallback)
        {
            InitializeComponent();

            this.eventId = eventId;
            EventName_tb.Text = eventName.ToString();
            Date_dtp.Value = eventDate;
            this.refreshCallBack = refreshCallback;
            EventParticipants_tb.Text = eventParticipants.ToString();
            Date_dtp.MinDate = DateTime.Today;
            Date_dtp.Format = DateTimePickerFormat.Custom;
            Date_dtp.CustomFormat = "dd.MM.yyyy HH:mm";
            Categories_cb.DataSource = Enum.GetValues(typeof(Categories));
            Categories_cb.SelectedItem = eventCategory;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить это событие?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new BusinessContext())
                    {
                        var meeting = context.Meetings.Find(eventId);
                        if (meeting != null)
                        {
                            context.Meetings.Remove(meeting);
                            context.SaveChanges();
                            MessageBox.Show("Событие успешно удалено.");
                            refreshCallBack?.Invoke();
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("Событие не найдено в базе данных.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении события: {ex.Message}");
                }
            }
        }
        private void EditEvent(string eventName, DateTime eventDate, string participants, Categories categories)
        {
            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(participants))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (var context = new BusinessContext())
                {
                    var meeting = context.Meetings.Find(eventId);
                    if (meeting != null)
                    {
                        meeting.EventName = eventName;
                        meeting.Date = eventDate;
                        meeting.Participants = participants;
                        meeting.Categories = categories;

                        context.SaveChanges();
                        MessageBox.Show("Событие успешно обновлено.");

                        refreshCallBack?.Invoke();
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Событие не найдено в базе данных.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении события: {ex.Message}");
            }
        }

        private void ChangeEvent_btn_Click(object sender, EventArgs e)
        {
            string eventName = EventName_tb.Text;
            DateTime eventDate = Date_dtp.Value;
            string participants = EventParticipants_tb.Text;
            Categories category = (Categories)Categories_cb.SelectedItem;
            EditEvent(eventName, eventDate, participants, category);
        }
    }
}