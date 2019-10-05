using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Services.Interface
{
    public interface IService<T>
    {
        int Delete(int JobId);
        T GetById(int JobId);
        string Update(T obj);
        int Create(T objDetails);
        List<T> ListAll();
    }
}
