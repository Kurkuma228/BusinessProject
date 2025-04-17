using BusinessProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BusinessTestProject
{
    [TestClass]
    public class EventListFormTests
    {
        private Mock<BusinessContext> _mockContext;
        private List<Meeting> _mockMeetings;

        [TestInitialize]
        public void Setup()
        {
            _mockContext = new Mock<BusinessContext>();

            _mockMeetings = new List<Meeting>
        {
            new Meeting
            {
                Id = 1,
                EventName = "Встреча команды",
                Date = new DateTime(2025, 04, 15),
                Participants = "Камиль, Сергей",
                Categories = Categories.Неофициальный
            },
            new Meeting
            {
                Id = 2,
                EventName = "Встреча с клиентом",
                Date = new DateTime(2025, 04, 26),
                Participants = "Сергей, Радмир",
                Categories = Categories.Официальный
            }
        };

            var mockDbSet = MockHelper.MockDbSet(_mockMeetings);
            _mockContext.Setup(c => c.Meetings).Returns(mockDbSet.Object);
        }

        [TestMethod]
        public void LoadData_ShouldLoadMeetingsIntoDataGridView()
        {
            // Arrange
            var form = new EventList_form(_mockContext.Object);
            var dataGridView = new DataGridView();
            form.EventList_dgv = dataGridView;

            // Act
            form.LoadData();

            // Assert
            Assert.AreEqual(_mockMeetings.Count, dataGridView.Rows.Count - 1);
            Assert.AreEqual("Встреча команды", dataGridView.Rows[0].Cells["EventName"].Value);
            Assert.AreEqual(new DateTime(2025, 04, 15).ToString("dd.MM.yyyy"), dataGridView.Rows[0].Cells["Date"].Value);
        }

        [TestMethod]
        public void RefreshDataGridView_ShouldUpdateDataGridViewColumns()
        {
            // Arrange
            var form = new EventList_form(_mockContext.Object);
            var dataGridView = new DataGridView();
            form.EventList_dgv = dataGridView;

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

            Assert.AreEqual(_mockMeetings.Count, dataGridView.Rows.Count - 1);
            Assert.AreEqual("Встреча команды", dataGridView.Rows[0].Cells["EventName"].Value);
        }

        [TestMethod]
        public void DataGridView1_CellDoubleClick_ShouldOpenManageEventForm()
        {
            // Arrange
            var form = new EventList_form();
            var dataGridView = new DataGridView();
            form.EventList_dgv = dataGridView;

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("EventName", "Event Name");
            dataGridView.Columns.Add("Date", "Date");
            dataGridView.Columns.Add("Participants", "Participants");
            dataGridView.Columns.Add("Categories", "Categories");

            dataGridView.Rows.Add(1, "Встреча команды", "15.04.2025", "Камиль, Сергей", Categories.Неофициальный.ToString());

            var mockForm = new Mock<ManageEvent_form>(1, "Встреча команды", new DateTime(2025, 04, 15), "Камиль, Сергей", Categories.Неофициальный, form.RefreshDataGridView);

            // Act
            form.DataGridView1_CellDoubleClick(null, new DataGridViewCellEventArgs(0, 0));

            // Assert
            mockForm.Verify(f => f.ShowDialog(form), Times.Once);
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
        public static class MockHelper
        {
            public static Mock<DbSet<T>> MockDbSet<T>(IEnumerable<T> data) where T : class
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
}