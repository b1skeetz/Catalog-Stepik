

namespace Catalog.Features.Query;

public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull
{
    
}