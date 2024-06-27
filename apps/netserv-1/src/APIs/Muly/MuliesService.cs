using Netserv1.Infrastructure;

namespace Netserv1.APIs;

public class MuliesService : MuliesServiceBase
{
    public MuliesService(Netserv1DbContext context)
        : base(context) { }
}
