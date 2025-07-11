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

        
    }

}