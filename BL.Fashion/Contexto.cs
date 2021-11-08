using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BL.Fashion
{
    public class Contexto: DbContext 
    {
        public Contexto() : base("MiBDL3-6pm")
        {

        }

        //public Contexto() :base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=D:\_Proyectos\MisBDs\\MiBDL3-6pm.mdf") //'+
        //  //  Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MiBDL3-6pm.mdf")
        //{

        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); //Agrega Datos de Inicio a la Base de Datos después de Inicializarla
        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set;}
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<TblClaseClte> TblClaseCltes { get; set; }
        public DbSet<TblPais> TblPaises { get; set; }
        public DbSet<TblDepto> TblDeptos { get; set; }
        public DbSet<TblMunicipio> TblMunicipios { get; set; }
        public DbSet<TblSectorBoCol> TblSectorBoCols { get; set; }
        
        public DbSet<TblTipoPersona> TblTiposPersonas { get; set; }
        public DbSet<TblCategoria> TblCategorias { get; set; }
        
    }
}
