using BL.Fashion;
using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormTblCategorias : Form
    {

        TblCategoriasBL _categorias;

        public FormTblCategorias()
        {
            InitializeComponent();

            _categorias = new TblCategoriasBL();
            listaTblCategoriasBindingSource.DataSource = _categorias.ObtenerTblCategorias();
        }
    }
}
