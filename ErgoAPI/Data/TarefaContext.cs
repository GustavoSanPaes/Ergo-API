using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErgoAPI.Controllers;
using ErgoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ErgoAPI.Data
{
    public class TarefaContext : DbContext
    {
        //public TarefaContext(DbContextOptions<TarefaContext>opt) : base (opt)
        //{

        //}


        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ErgoTarefa;Trusted_Connection=true;");
        }

        internal new void SavedChanges()
        {
            throw new NotImplementedException();
        }
    }
}
