using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyAirport.EF;
using System;
using System.Collections.Generic;
using System.Text;


namespace MF.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
       // public static readonly ILoggerFactory MyAirportLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        
        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options) { }
        public DbSet<Vol>? Vols { get; set; }
        public DbSet<Bagage>? Bagages { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=MyAirportContext;Integrated Security=True");
            //optionsBuilder.UseLoggerFactory(MyAirportLoggerFactory);

        }*/
    }

}
