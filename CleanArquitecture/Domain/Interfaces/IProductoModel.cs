using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;


namespace Domain.Interfaces
{
    public interface IProductoModel:IModel<Producto>
    {
        Producto GetProducto(int id);
    }
}
