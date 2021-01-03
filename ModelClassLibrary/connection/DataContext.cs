using Microsoft.EntityFrameworkCore;
using ModelClassLibrary.area.user;
using ModelClassLibrary.contract;
using ModelClassLibrary.salary;
using ModelClassLibrary.staff;
using ModelClassLibrary.unit;
using ModelClassLibrary.work;

namespace ModelClassLibrary.connection
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Units> Units { get; set; }
        public DbSet<UnitTypes> UnitTypes { get; set; }
        public DbSet<WorkGroup> WorkGroups { get; set; }
        public DbSet<Works> Works { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<UnitProject> UnitProject { get; set; }
        public DbSet<WorkProject> WorkProject { get; set; }
        public DbSet<WorkDetail> WorkDetail { get; set; }
        public DbSet<WorkFile> WorkFile { get; set; }
        public DbSet<ScheduleWork> ScheduleWork { get; set; }
        public DbSet<ScheduleGroup> ScheduleGroup { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<ScheduleStaff> ScheduleStaff { get; set; }

        //contract
        public DbSet<C_Contract> C_Contract { get; set; }
        public DbSet<C_Revenue_Contract> C_Revenue_Contract { get; set; }
        public DbSet<C_Ratio_Revenue_Share> C_Ratio_Revenue_Share { get; set; }
        //salary
        public DbSet<S_SalaryCycle> S_SalaryCycle { get; set; }
        public DbSet<S_StaffMonth> S_StaffMonth { get; set; }
        public DbSet<S_MonthSalary> S_MonthSalary { get; set; }
        public DbSet<S_TotalSalaryMonth> S_TotalSalaryMonth { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UnitProject>().HasKey(i => new { i.unitid, i.projectid });
            builder.Entity<WorkProject>().HasKey(i => new { i.workid, i.projectid });
            builder.Entity<ScheduleStaff>().HasKey(i => new { i.scheduleid, i.staffid });
        }
    }
    
}
