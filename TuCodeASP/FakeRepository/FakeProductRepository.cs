using TuCodeASP.Domain.Models;
using TuCodeASP.Domain.Abstract;
namespace TuCodeASP.FakeRepository
{
    public class FakeProductRepository:IProductRepository
    {
        List<Product> products = new List<Product>() { 
        new Product { ProductId=1,Name="San Pham 1",Price=1000, Category="Loai A"},//khoi tao doi tuong product
        };
        public IEnumerable<Product> Products=>products;//ko dc gan =

    }
}
