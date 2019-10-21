using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        double Price
        {
            get;
        }

        string Description
        {
            get;
        }

        string[] Special
        {
            get;
        }
    }
}
