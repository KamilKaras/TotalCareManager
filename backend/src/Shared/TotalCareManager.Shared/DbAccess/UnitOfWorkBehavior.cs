using MediatR;
using System.Transactions;
using TotalCareManager.Shared.DbAccess.Interfaces;
using TotalCareManager.Shared.Messaging.Command.Interfaces;

namespace TotalCareManager.Shared.DbAccess
{
    public sealed class UnitOfWorkBehavior<TCommand, TResponse> : IPipelineBehavior<TCommand, TResponse>
        where TCommand : class, ICommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkBehavior(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TResponse> Handle(
            TCommand command,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            if (command.GetType() != typeof(TCommand))
                return await next();

            using (var transactionScope = new TransactionScope())
            {
                var response = await next();
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                transactionScope.Complete();

                return response;
            }
        }
    }
}