﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AtTheMovies.Models
{
    public class MovieDb : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}