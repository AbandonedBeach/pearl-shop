namespace PearlShop.Cqrs.Commands
{
    public interface ICommandHandler<C> where C : Command
    {
        void Execute(C command);
    }
}
