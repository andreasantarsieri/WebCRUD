#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Santarsieri.Andrea.WebCrud.Models;

    public class CRUDController : DbContext
    {
        public CRUDController (DbContextOptions<CRUDController> options)
            : base(options)
        {
        }

        public DbSet<Santarsieri.Andrea.WebCrud.Models.Movie> Movie { get; set; }
    }
