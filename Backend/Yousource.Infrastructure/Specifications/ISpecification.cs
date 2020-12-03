namespace Yousource.Infrastructure.Specifications
{
    using System.Collections.Generic;

    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity, ref ICollection<string> errors);
    }

    public interface ISpecification<TEntity, TResult>
    {
        bool IsSatisfiedBy(TEntity entity, ref TResult result);

        ISpecification<TEntity, TResult> And(ISpecification<TEntity, TResult> specification);
    }
}
