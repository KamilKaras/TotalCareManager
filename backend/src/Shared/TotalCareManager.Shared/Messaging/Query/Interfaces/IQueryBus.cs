using MediatR;

namespace TotalCareManager.Shared.Messaging.Query.Interfaces
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }

    public interface IQueryBus
    {
        Task<TResult> Get<TResult>(IQuery<TResult> query);
    }
}