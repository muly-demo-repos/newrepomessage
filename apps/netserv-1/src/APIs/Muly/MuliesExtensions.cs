using Netserv1.APIs.Dtos;
using Netserv1.Infrastructure.Models;

namespace Netserv1.APIs.Extensions;

public static class MuliesExtensions
{
    public static Muly ToDto(this MulyDbModel model)
    {
        return new Muly
        {
            Id = model.Id,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt,
            F1 = model.F1,
            F2 = model.F2,
        };
    }

    public static MulyDbModel ToModel(this MulyUpdateInput updateDto, MulyWhereUniqueInput uniqueId)
    {
        var muly = new MulyDbModel
        {
            Id = uniqueId.Id,
            F1 = updateDto.F1,
            F2 = updateDto.F2
        };

        // map required fields
        if (updateDto.CreatedAt != null)
        {
            muly.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            muly.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return muly;
    }
}
