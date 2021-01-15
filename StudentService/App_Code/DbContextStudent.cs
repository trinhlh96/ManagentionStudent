using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for DbContextStudent
/// </summary>
[ServiceContract]
public class DbContextStudent : DbContext
{
    public DbContextStudent() : base("DbContextStudent90")
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DbSet<Student> Students { get; set; }
}