using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Starter
    {
        public void Run()
        {
            var logic = new Delegates(3, 7);

            logic.SumOfResults((someStr) =>
            {
                throw new Exception(someStr);
            });
        }
    }
}
