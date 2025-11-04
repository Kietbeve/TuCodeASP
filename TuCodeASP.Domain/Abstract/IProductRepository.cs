using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuCodeASP.Domain.Models;// dung model

namespace TuCodeASP.Domain.Abstract
{
    public interface IProductRepository
    {
        public IEnumerable<Product> Products { get; }
    }
}
