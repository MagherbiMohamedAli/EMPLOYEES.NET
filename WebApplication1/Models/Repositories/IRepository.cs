namespace WebApplication1.Models.Repositories
{
    public interface IRepository<T>
    {
        List<T> Search(string term);
        IList<T> GetAll();
        T FindByID(int id);
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        void Update(int id, object newemployee);
        double SalaryAverage();
        double MaxSalary();
        int HrEmployeesCount();
    }
}
