using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Infrastructure
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public BaseRepository()
        {

        }

        public virtual async Task AddSingle(T model)
        {
            await this.Add(model);
        }

        public virtual async Task AddMultiple(IEnumerable<T> model)
        {
            foreach (T item in model)
            {
                await this.Add(item);
            }
        }

        private virtual async Task Add(T model)
        {
            // Adcionar model
        }

        public virtual async Task<T> GetSingle(T filter)
        {
            await this.Get(filter);
        }

        public virtual async Task<IEnumerable<T>> GetAll(T filter)
        {
            await this.Get(filter);
        }

        private virtual async Task Get(T filter)
        {
            // Retornar por filtro
        }
    }
}
