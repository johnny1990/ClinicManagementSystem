using Clinic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Web.Models
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext(DbContextOptions<ClinicDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Discharge> Discharges { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorCharges> DoctorCharges { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomCharges> RoomCharges { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<SpecialVisitDoctor> SpecialVisitDoctors { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Test> Test { get; set; }
    }
}

