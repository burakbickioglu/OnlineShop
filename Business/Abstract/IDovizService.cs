using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDovizService : IBaseService<Doviz>
    {
        Doviz GetByName(string name);
    }
}
