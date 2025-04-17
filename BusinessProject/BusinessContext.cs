using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusinessProject
{
    public class BusinessContext : DbContext
    {
        public BusinessContext(): base("DBConnection") { }
        public DbSet<Meeting> Meetings { get; set; }
    }
    public class Meeting
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Participants { get; set; }
        public Categories Categories { get; set; }
    }
    public enum Categories
    {
        Официальный,
        Неофициальный,
        Внутренний,
        Внешний
    }
}
