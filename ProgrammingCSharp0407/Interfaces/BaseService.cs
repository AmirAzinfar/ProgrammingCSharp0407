using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp0407.Interfaces
{
    //Generic --> Type --> <T> :undependet to Type of Data, therfore, we need "interface"
    internal interface BaseService<T>
    {
        void Add(T item);

        List<T> GetAll();
        
    }
}
