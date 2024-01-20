using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_C_SHARP_DIO.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_C_SHARP_DIO.Context
{
    public class AgendaContext : DbContext
    {  
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) 
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
