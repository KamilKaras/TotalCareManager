using MediatR;

namespace TotalCareManager.Shared.Messaging.Command
{
    public interface ICommand : IRequest<Unit>
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }

    public interface ICommandBus
    {
        Task<TResult> Execute<TResult>(ICommand<TResult> command);

        Task Execute(ICommand command);
    }
}