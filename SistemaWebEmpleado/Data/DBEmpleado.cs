using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    public class DBEmpleado : DbContext 
    {
        public DBEmpleado(DbContextOptions<DBEmpleado> options) : base(options) { }


        public DbSet<Empleado> Empleados { get; set; }

    }
}
