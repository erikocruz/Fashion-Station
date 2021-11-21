using System.Data.Entity;


namespace BL.Fashion
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuario1 = new Usuario();
            usuario1.Nombre = "admin";
            usuario1.Contrasena = "123";
            usuario1.TipoUsuario = "Administrador";
            usuario1.Foto = null;

            usuario1.UserAdmin = true;
            usuario1.AccesaClientes = true;
            usuario1.AccesaProductos = true;
            usuario1.AccesaFacturas = true;
            usuario1.AccesaReportes = true;
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.Nombre = "caja";
            usuario2.Contrasena = "456";
            usuario2.TipoUsuario = "Cajero";
            usuario2.Foto = null;
            usuario2.AccesaFacturas = true;
            usuario2.AccesaReportes = true;
            contexto.Usuarios.Add(usuario2);

            var usuario3= new Usuario();
            usuario3.Nombre = "gerente";
            usuario3.Contrasena = "789";
            usuario3.TipoUsuario = "Gerente";
            usuario3.Foto = null;
            usuario3.Activo = true;
            usuario3.UserAdmin = false;
            usuario3.AccesaClientes = true;
            usuario3.AccesaProductos = true;
            usuario3.AccesaFacturas = false;
            usuario3.AccesaReportes = true;
            contexto.Usuarios.Add(usuario3);


            var claseclte1 = new TblClaseClte();
            claseclte1.Descripcion = "Normal";
            contexto.TblClaseCltes.Add(claseclte1);

            var claseclte2 = new TblClaseClte();
            claseclte2.Descripcion = "Accionista";
            contexto.TblClaseCltes.Add(claseclte2);

            var pais1 = new TblPais();
            pais1.Descripcion = "Honduras";
            contexto.TblPaises.Add(pais1);

            var pais2 = new TblPais();
            pais2.Descripcion = "EEUU";
            contexto.TblPaises.Add(pais2);

            var depto1 = new TblDepto();
            depto1.Descripcion = "Atlantida";
            contexto.TblDeptos.Add(depto1);

            var depto2 = new TblDepto();
            depto2.Descripcion = "Cortés";
            contexto.TblDeptos.Add(depto2);

            var muni1 = new TblMunicipio();
            muni1.Descripcion = "San Pedro Sula";
            contexto.TblMunicipios.Add(muni1);

            var muni2 = new TblMunicipio();
            muni2.Descripcion = "San Antonio de Cortés";
            contexto.TblMunicipios.Add(muni2);

            var muni3 = new TblMunicipio();
            muni3.Descripcion = "Villanueva";
            contexto.TblMunicipios.Add(muni3);

            var col1 = new TblSectorBoCol();
            col1.Descripcion = "Col. Prieto";
            contexto.TblSectorBoCols.Add(col1);

            var col2 = new TblSectorBoCol();
            col2.Descripcion = "Bo. El Centro";
            contexto.TblSectorBoCols.Add(col2);

            var col3 = new TblSectorBoCol();
            col3.Descripcion = "Bo. La Tigra";
            contexto.TblSectorBoCols.Add(col3);

            var col4 = new TblSectorBoCol();
            col4.Descripcion = "Col. Los Castaños";
            contexto.TblSectorBoCols.Add(col4);

            var tipopersona1 = new TblTipoPersona();
            tipopersona1.Descripcion = "Hombre";
            contexto.TblTiposPersonas.Add(tipopersona1);

            var tipopersona2 = new TblTipoPersona();
            tipopersona2.Descripcion = "Mujer";
            contexto.TblTiposPersonas.Add(tipopersona2);

            var tipopersona3 = new TblTipoPersona();
            tipopersona3.Descripcion = "Niños";
            contexto.TblTiposPersonas.Add(tipopersona3);

            var tipopersona4 = new TblTipoPersona();
            tipopersona4.Descripcion = "Varios";
            contexto.TblTiposPersonas.Add(tipopersona4);

            var categoria1 = new TblCategoria();
            categoria1.Descripcion = "Ropa";
            contexto.TblCategorias.Add(categoria1);

            var categoria2 = new TblCategoria();
            categoria2.Descripcion = "Calzado";
            contexto.TblCategorias.Add(categoria2);

            var categoria3 = new TblCategoria();
            categoria3.Descripcion = "Cosméticos";
            contexto.TblCategorias.Add(categoria3);

            var categoria4 = new TblCategoria();
            categoria4.Descripcion = "Lencería";
            contexto.TblCategorias.Add(categoria4);

            var categoria5 = new TblCategoria();
            categoria5.Descripcion = "Juguetes";
            contexto.TblCategorias.Add(categoria5);

            var categoria6 = new TblCategoria();
            categoria6.Descripcion = "Cocina";
            contexto.TblCategorias.Add(categoria6);

            var Clte1 = new Cliente();
            Clte1.Nombre = "Cliente No. 1";
            Clte1.TblClaseClte = claseclte1;
            Clte1.TblPais = pais1;
            Clte1.TblDepto = depto1;
            Clte1.TblMunicipio = muni1;
            Clte1.TblSectorBoCol = col1;
            Clte1.Direccion = "fsjdfsdjfgsjdgfsjdfgsjdfhgsfs1";
            Clte1.Tel1 = "95992911";
            Clte1.Tel2 = "95992911";
            Clte1.Email1 = "Prueba1@gmail.com";
            Clte1.Email2 = "Prueba1@gmail.com";
            Clte1.Genero = "Hombre";
            Clte1.Foto = null;
            Clte1.Activo = true;
            contexto.Clientes.Add(Clte1);

            var Clte2 = new Cliente();
            Clte2.Nombre = "Cliente No. 22222222";
            Clte2.TblClaseClte = claseclte2;
            Clte2.TblPais = pais1;
            Clte2.TblDepto = depto1;
            Clte2.TblMunicipio = muni2;
            Clte2.TblSectorBoCol = col2;
            Clte2.Direccion = "fsjdfsdjfgsjdgfsjdfgsjdfhgsfs1";
            Clte2.Tel1 = "95992911";
            Clte2.Email1 = "Prueba1@gmail.com";
            Clte2.Genero = "Hombre";
            contexto.Clientes.Add(Clte2);

            var Clte3 = new Cliente();
            Clte3.Nombre = "Cliente No. 333333333333333333";
            Clte3.TblClaseClte = claseclte2;
            Clte3.TblPais = pais1;
            Clte3.TblDepto = depto1;
            Clte3.TblMunicipio = muni1;
            Clte3.TblSectorBoCol = col1;
            Clte3.Direccion = "fsjdfsdjfgsjdgfsjdfgsjdfhgsfs1";
            Clte3.Tel1 = "95992911";
            Clte3.Email1 = "Prueba1@gmail.com";
            Clte3.Genero = "Hombre";
            contexto.Clientes.Add(Clte3);

            var Prod1 = new Producto();
            Prod1.Descripcion = "Producto #1";
            Prod1.Precio = 121.21;
            Prod1.Existencia = 251;
            Prod1.TblTipoPersona = tipopersona1;
            Prod1.TblCategoria = categoria1;
            Prod1.Foto = null;
            contexto.Productos.Add(Prod1);

            var Prod2 = new Producto();
            Prod2.Descripcion = "Producto #222222";
            Prod2.Precio = 121.50;
            Prod2.Existencia = 251;
            Prod2.TblTipoPersona = tipopersona2;
            Prod2.TblCategoria = categoria5;
            contexto.Productos.Add(Prod2);

            var Prod3 = new Producto();
            Prod3.Descripcion = "Producto #333333333333";
            Prod3.Precio = 121.33;
            Prod3.Existencia = 251;
            Prod3.TblTipoPersona = tipopersona3;
            Prod3.TblCategoria = categoria2;
            contexto.Productos.Add(Prod3);

            var Prod4 = new Producto();
            Prod4.Descripcion = "Producto #444444444444444444444444";
            Prod4.Precio = 121.22;
            Prod4.Existencia = 251;
            Prod4.TblTipoPersona = tipopersona4;
            Prod4.TblCategoria = categoria4;
            contexto.Productos.Add(Prod4);

            base.Seed(contexto);
        }
    }
}
