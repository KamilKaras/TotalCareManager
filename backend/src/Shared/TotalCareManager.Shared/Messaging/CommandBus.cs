using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace TotalCareManager.Shared.Messaging
{
    public abstract class CommandHandler<TCommand> : IRequestHandler<TCommand, Unit>
        where TCommand : ICommand
    {
        public async Task<Unit> Handle(TCommand request, CancellationToken cancellationToken)
        {
            await Handle(request);
            return Unit.Value;
        }

        protected abstract Task Handle(TCommand command);
    }

    public abstract class CommandHandler<TCommand, TResult> : IRequestHandler<TCommand, TResult>
        where TCommand : ICommand<TResult>
    {
        public async Task<TResult> Handle(TCommand request, CancellationToken cancellationToken) => await Handle(request);

        protected abstract Task<TResult> Handle(TCommand command);
    }

    public sealed class CommandBus : ICommandBus
    {
        private readonly IServiceScopeFactory _scope;

        public CommandBus(IServiceScopeFactory scope)
        {
            _scope = scope;
        }

        public async Task<TResult> Execute<TResult>(ICommand<TResult> command)
        {
            using var scope = _scope.CreateScope();
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            return await mediator.Send(command);
        }

        public async Task Execute(ICommand command)
        {
            using var scope = _scope.CreateScope();
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            await mediator.Send(command);
        }
    }
}