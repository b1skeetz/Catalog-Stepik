

namespace Catalog.Features.Command;

public interface ICommand : ICommand<Unit>
{
    
}

public interface ICommand<out TResponse> : IRequest<TResponse>
{
    
}