using SolutionGestionMedecin.SharedKernel.Interfaces;
using SolutionGestionMedecin.SharedKernel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SolutionGestionMedecin.Infrastructure.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T>, IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly SolutionGestionMedecinContext _SolutionGestionMedecinContext;

        public EfRepository(SolutionGestionMedecinContext solutionGestionClientsContext)
        {
            _SolutionGestionMedecinContext = solutionGestionClientsContext;
        }

        
        public async Task<T> GetByIdAsync(int id)
        {
            return await _SolutionGestionMedecinContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _SolutionGestionMedecinContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _SolutionGestionMedecinContext.Set<T>().AddAsync(entity);
            await _SolutionGestionMedecinContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _SolutionGestionMedecinContext.Entry(entity).State = EntityState.Modified;
            await _SolutionGestionMedecinContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _SolutionGestionMedecinContext.Set<T>().Remove(entity);
            await _SolutionGestionMedecinContext.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_SolutionGestionMedecinContext.Set<T>().AsQueryable(), spec);
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

       
        public T GetById(int id)
        {
            return _SolutionGestionMedecinContext.Set<T>().Find(id);
        }

        public IReadOnlyList<T> ListAll()
        {
            return _SolutionGestionMedecinContext.Set<T>().ToList();
        }

        public IReadOnlyList<T> List(ISpecification<T> spec)
        {
            return ApplySpecification(spec).ToList();
        }

        public T Add(T entity)
        {
            _SolutionGestionMedecinContext.Set<T>().Add(entity);
            _SolutionGestionMedecinContext.SaveChanges();
            return entity;
        }

        public int Update(T entity)
        {
            _SolutionGestionMedecinContext.Entry(entity).State = EntityState.Modified;
            return _SolutionGestionMedecinContext.SaveChanges();
        }

        public int Delete(T entity)
        {
            _SolutionGestionMedecinContext.Set<T>().Remove(entity);
            return _SolutionGestionMedecinContext.SaveChanges();
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }
    }
}
