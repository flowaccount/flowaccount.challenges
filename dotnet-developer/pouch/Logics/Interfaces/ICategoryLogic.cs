
using api.Models;
using Flowaccount.Data.Models;

namespace Flowaccount.Logic
{
    public interface ICategoryLogic {
        Category Create(Category model);
        GridResponse<Category> FindBy();
        Category Update(int id, Category model);

        int Remove(int id);
    }
}