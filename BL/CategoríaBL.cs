﻿using DAL;
using ET;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class CategoriaBL
    {
        private CategoriaDAL dal = new CategoriaDAL();
        public bool IngresarCategoria(Categoria categoria)
        {
            return dal.IngresarCategoria(categoria);
        }
        public bool ActualizarCategoria(Categoria categoria)
        {
            return dal.ActualizarCategoria(categoria);
        }
        public bool BorrarCategoria(int idCat)
        {
            return dal.BorrarCategoria(idCat);
        }
        public DataTable BuscarTodoCategoria()
        {
            return dal.BuscarTodoCategoria();
        }
        public DataTable BuscarCategoria(string descrip)
        {
            return dal.BuscarCategoria(descrip);
        }
    }
}
