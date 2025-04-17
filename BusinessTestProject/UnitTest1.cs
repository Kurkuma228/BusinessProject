using BusinessProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusinessProjectTests
{
    [TestClass]
    public class EventListFormTests
    {
        private Mock<BusinessContext> _mockContext;
        private List<Meeting> _mockMeetings;

        [TestInitialize]
        public void Setup()
        {
            // Создаем мок контекста базы данных
            _mockContext = new Mock<BusinessContext>();

            // Создаем тестовые данные
            _mockMeetings = new List<Meeting>
            {
                new Meeting
                {
                    Id = 1,
                    EventName = "Team Meeting",
                    Date = new DateTime(2023, 10, 1),
                    Participants = "Alice, Bob",
                    Categories = Categories.Work
                },
                new Meeting
                {
                    Id = 2,
                    EventName = "Client Meeting",
                    Date = new DateTime(2023, 10, 5),
                    Participants = "Charlie, Dave",
                    Categories = Categories.Business
                }
            };

            // Настройка мока для метода Meetings.ToList()
            var mockDbSet = MockDbSet(_mockMeetings);
            _mockContext.Setup(c => c.Meetings).Returns(mockDbSet.Object);
        }

        [TestMethod]
        public void LoadData_ShouldLoadMeetingsIntoDataGridView()
        {
            // Arrange
            var form = new EventList_form();
            var dataGridView = new DataGridView();
            form.EventList_dgv = dataGridView; // Заменяем реальный DataGridView на тестовый

            // Act
            form.LoadData();

            // Assert
            Assert.AreEqual(_mockMeetings.Count, dataGridView.Rows.Count - 1); // -1 из-за строки заголовков
            Assert.AreEqual("Team Meeting", dataGridView.Rows[0].Cells["EventName"].Value);
            Assert.AreEqual("01.10.2023", dataGridView.Rows[0].Cells["Date"].Value);
        }

        [TestMethod]
        public void RefreshDataGridView_ShouldUpdateDataGridViewColumns()
        {
            // Arrange
            var form = new EventList_form();
            var dataGridView = new DataGridView();
            form.EventList_dgv = dataGridView; // Заменяем реальный DataGridView на тестовый

            // Act
            form.RefreshDataGridView();

            // Assert
            Assert.IsTrue(dataGridView.Columns.Contains("Id"));
            Assert.IsTrue(dataGridView.Columns.Contains("EventName"));
            Assert.IsTrue(dataGridView.Columns.Contains("Date"));
            Assert.IsTrue(dataGridView.Columns.Contains("Participants"));
            Assert.IsTrue(dataGridView.Columns.Contains("Categories"));

            Assert.AreEqual("ID", dataGridView.Columns["Id"].HeaderText);
            Assert.AreEqual("Название события", dataGridView.Columns["EventName"].HeaderText);
            Assert.AreEqual("Дата и время события", dataGridView.Columns["Date"].HeaderText);
        }

        [TestMethod]
        public void DataGridView1_CellDoubleClick_ShouldOpenManageEventForm()
        {
            // Arrange
            var form = new EventList_form();
            var dataGridView = new DataGridView();
            form.EventList_dgv = dataGridView; // Заменяем реальный DataGridView на тестовый

            // Добавляем тестовую строку
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("EventName", "Event Name");
            dataGridView.Columns.Add("Date", "Date");
            dataGridView.Columns.Add("Participants", "Participants");
            dataGridView.Columns.Add("Categories", "Categories");

            dataGridView.Rows.Add(1, "Team Meeting", "01.10.2023", "Alice, Bob", Categories.Work.ToString());

            // Act
            form.DataGridView1_CellDoubleClick(null, new DataGridViewCellEventArgs(0, 0));

            // Assert
            // Здесь можно проверить, что форма ManageEvent_form была открыта.
            // Для этого нужно добавить дополнительный механизм отслеживания (например, мок формы).
        }

        private Mock<DbSet<T>> MockDbSet<T>(IEnumerable<T> data) where T : class
        {
            var queryable = data.AsQueryable();
            var mockSet = new Mock<DbSet<T>>();
            mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());
            return mockSet;
        }
    }
}