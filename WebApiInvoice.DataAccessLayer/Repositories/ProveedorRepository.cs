using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using WebApiInvoice.Domain.Interfaces;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoice.DataAccessLayer
{
    public class ProveedorRepository : IProveedorRepository
    {
        static List<Proveedor> _proveedorList = new List<Proveedor>();
        static int autoincremento = 0;

        //Crear un nuevo proveedor y agregarlo a la lista
        public int Create(Proveedor model)
        {
            model.Id = ++autoincremento;
            _proveedorList.Add(model);
            return 1;
        }

        //Elimina proveedor existente de la lista
        public int Delete(int id)
        {
            Proveedor pr = _proveedorList.Find( p => p.Id == id);

            if (pr != null)
            {
                _proveedorList.Remove(pr);
                return 1;
            }

            return 0;
        }

        //Devuelve lista de proveedores
        public List<Proveedor> Get(int offset = 0, int limit = 0)
        {
            return _proveedorList.FindAll(p => true);
        }

        

        
        
    }

}