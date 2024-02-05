using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared.Messaging.Query.Interfaces;

namespace TotalCareManager.Shared.Messaging.Query.Implementations
{
    public abstract class QueryHandler<TQuery, TResult> : IRequestHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        public Task<TResult> Handle(TQuery request, CancellationToken cancellationToken) => Handle(request);

        protected abstract Task<TResult> Handle(TQuery request);
    }

    internal class QueryBus : IQueryBus
    {
        private readonly IServiceScopeFactory _scope;

        public QueryBus(IServiceScopeFactory scope)
        {
            _scope = scope;
        }

        public async Task<TResult> Get<TResult>(IQuery<TResult> query)
        {
            using var scope = _scope.CreateScope();
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            return await mediator.Send(query);
        }
    }
}