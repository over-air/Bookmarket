﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models.Model;

namespace Models
{
    public class BookContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BookMajor> BookMajors { get; set; }
        public DbSet<Classify> Classifies{ get; set; }
        public DbSet<Img> Imgs { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderinfo> Orderinfos { get; set; }
        public DbSet<ProDetail> ProDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
 
    }
}