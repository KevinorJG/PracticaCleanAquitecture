using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ListProductoRepository : BaseRepository<Producto>, IProductoModel
    {
        public Producto GetProducto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
