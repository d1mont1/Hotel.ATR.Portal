using System.Collections.Generic;

namespace Hotel.ATR.Portal.Models
{
    public interface IRepository
    {
        List<Product> Products();
    }
}
