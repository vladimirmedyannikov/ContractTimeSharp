using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractTimeSharp.DAO
{
    interface DAO<E>
    {
        E insert(E e);
        void delete(E e);
        void update(E e);
        E getById(int id);
        List<E> getAll();
    }
}
