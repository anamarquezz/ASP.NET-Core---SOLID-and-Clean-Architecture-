using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contracts.Contracts
{
    public interface IGenericRepository<T> where T: class
    {
        /*Generic Repository is a gereic pro function that every DB need to perform*/
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);

    }
}
