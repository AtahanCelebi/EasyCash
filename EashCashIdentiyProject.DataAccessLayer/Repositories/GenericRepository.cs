
using EasycashIdentityProject.DataAccess.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EashCashIdentiyProject.DataAccessLayer;

public class GenericRepository<T>: IGenericDal<T> where T: class
{
    public void Insert(T t) {

    }
    public void Delete(T t) {
        using var context = new Context();
        context.Set<T>().Remove(t);
        context.SaveChanges();
    }

    void IGenericDal<T>.Update(T t)
    {
        using var context = new Context();
        context.Set<T>().Update(t);
        context.SaveChanges();
    }

    T IGenericDal<T>.GetById(int id)
    {
        using var context = new Context();
        return context.Set<T>().Find(id);
    }

    List<T> IGenericDal<T>.GetList()
    {
        using var context = new Context();
        return context.Set<T>().ToList();
    }
}
