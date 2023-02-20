using System;
using System.Data.Entity;
using System.Linq;
using System.Data.SqlClient;

namespace EntityWeb
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("SeminarBD") { }
        public DbSet<GuestResponse> GuestResponses { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}