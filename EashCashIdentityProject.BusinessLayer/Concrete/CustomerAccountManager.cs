using EashCashIdentiyProject.DataAccessLayer;
using EasycashIdentityProject.EntityLayer.Concrete;

namespace EashCashIdentityProject.BusinessLayer;

public class CustomerAccountManager : ICustomerAccountService
{
    private readonly ICustomerAccountDal _customerAccountDal;
    public CustomerAccountManager(ICustomerAccountDal customerAccountDal) 
    {
        _customerAccountDal = customerAccountDal; //dependecy injection ile içiçe birbirine bağımlı classlar oluşturmaktan kaçındık. Dependecy injection, bir sınıfın bağımlılıklarını taklit eder ve sahte nesneler ile değiştirilmesini sağlar.
    }
    public void TDelete(CustomerAccount t)
    {
        _customerAccountDal.Delete(t);
    }

    public CustomerAccount TGetById(int id)
    {
        return _customerAccountDal.GetById(id);
    }

    public List<CustomerAccount> TGetList()
    {
        return _customerAccountDal.GetList();
    }

    public void TInsert(CustomerAccount t)
    {
        _customerAccountDal.Insert(t);
    }

    public void TUpdate(CustomerAccount t)
    {
        _customerAccountDal.Update(t);
    }
}
