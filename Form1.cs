using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //привести к стандартному виду
        private void button1_Click(object sender, EventArgs e)
        {
            standart_vid newForm = new standart_vid(this);
            newForm.Show();
        }
        //вычислить при заданном x
        private void button5_Click(object sender, EventArgs e)
        {
            vichislit newForm = new vichislit(this);
            newForm.Show();
        }
        //вычитание
        private void button3_Click(object sender, EventArgs e)
        {
            subtract newForm = new subtract(this);
            newForm.Show();
        }
        //умножение
        private void button4_Click(object sender, EventArgs e)
        {
            multiply newForm = new multiply(this);
            newForm.Show();
        }
        //деление
        private void button6_Click(object sender, EventArgs e)
        {
            dividecs newForm = new dividecs(this);
            newForm.Show();
        }
        //сложение
        private void button2_Click(object sender, EventArgs e)
        {
            Add newForm = new Add(this);
            newForm.Show();
        }
        public void output_errors(Exception ex, string form)//принимаемые ошибки
        {
           using (ApplicationContext db = new ApplicationContext())
           {
                UserExceptions exception = new UserExceptions
                {
                    Message = ex.Message,
                    TargetSite = $"{ex.TargetSite}",
                    dateTimeExc = DateTime.Now,
                    indexForm = form
                };
                db.UserException.Add(exception);
                db.SaveChanges();
           }
        }
    }
    public partial class UserExceptions
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string TargetSite { get; set; }
        public DateTime dateTimeExc { get; set; }
        public string indexForm { get; set; }
    }
    public partial class ApplicationContext : DbContext
    {
        public DbSet<UserExceptions> UserException { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserExceptions>().Property(u => u.dateTimeExc).HasDefaultValue(DateTime.Now);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            //// установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            //// получаем конфигурацию из файла jsconfig1.json
            builder.AddJsonFile("jsconfig1.json");
            //// создаем конфигурацию
            var config = builder.Build();
            //// получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");
            //подключаемся к базе данных
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}