using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test_Azure_API.Model;

namespace Test_Azure_API.Context
{
    public class ContextDataBase : DbContext
    {
        public ContextDataBase(DbContextOptions<ContextDataBase> options) : base(options)
        {
            
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}