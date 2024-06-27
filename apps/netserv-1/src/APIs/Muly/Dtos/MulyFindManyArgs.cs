using Microsoft.AspNetCore.Mvc;
using Netserv1.APIs.Common;
using Netserv1.Infrastructure.Models;

namespace Netserv1.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class MulyFindManyArgs : FindManyInput<Muly, MulyWhereInput> { }
