using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyDbContext : DbContext
{
    public MyDbContext() { }
     
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    
    }

    public DbSet<Article> Articles{ get; set; }
}
