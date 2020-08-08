namespace PearlShop.Cqrs.Queries
{
    public interface IQueryHandler<Q, T> where Q : Query<T>
    {
        T Execute(Q query);
    }
}
