using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewCategoryUseCase
    {
        IEnumerable<Category> Execute();
    }
}