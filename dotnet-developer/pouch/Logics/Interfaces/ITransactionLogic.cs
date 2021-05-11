
using api.Models;
using Flowaccount.Data.Models;

namespace Flowaccount.Logic
{
    public interface ITransactionLogic {
        Transactions Create(Transactions model);
        GridResponse<Transactions> FindBy();
        Transactions Update(long id, Transactions model);

        int Remove(long id);
    }
}