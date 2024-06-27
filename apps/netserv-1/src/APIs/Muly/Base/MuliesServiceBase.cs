using Microsoft.EntityFrameworkCore;
using Netserv1.APIs;
using Netserv1.APIs.Common;
using Netserv1.APIs.Dtos;
using Netserv1.APIs.Errors;
using Netserv1.APIs.Extensions;
using Netserv1.Infrastructure;
using Netserv1.Infrastructure.Models;

namespace Netserv1.APIs;

public abstract class MuliesServiceBase : IMuliesService
{
    protected readonly Netserv1DbContext _context;

    public MuliesServiceBase(Netserv1DbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Muly
    /// </summary>
    public async Task<Muly> CreateMuly(MulyCreateInput createDto)
    {
        var muly = new MulyDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt,
            F1 = createDto.F1,
            F2 = createDto.F2
        };

        if (createDto.Id != null)
        {
            muly.Id = createDto.Id;
        }

        _context.Mulies.Add(muly);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<MulyDbModel>(muly.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Muly
    /// </summary>
    public async Task DeleteMuly(MulyWhereUniqueInput uniqueId)
    {
        var muly = await _context.Mulies.FindAsync(uniqueId.Id);
        if (muly == null)
        {
            throw new NotFoundException();
        }

        _context.Mulies.Remove(muly);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Mulies
    /// </summary>
    public async Task<List<Muly>> Mulies(MulyFindManyArgs findManyArgs)
    {
        var mulies = await _context
            .Mulies.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return mulies.ConvertAll(muly => muly.ToDto());
    }

    /// <summary>
    /// Get one Muly
    /// </summary>
    public async Task<Muly> Muly(MulyWhereUniqueInput uniqueId)
    {
        var mulies = await this.Mulies(
            new MulyFindManyArgs { Where = new MulyWhereInput { Id = uniqueId.Id } }
        );
        var muly = mulies.FirstOrDefault();
        if (muly == null)
        {
            throw new NotFoundException();
        }

        return muly;
    }

    /// <summary>
    /// Meta data about Muly records
    /// </summary>
    public async Task<MetadataDto> MuliesMeta(MulyFindManyArgs findManyArgs)
    {
        var count = await _context.Mulies.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Update one Muly
    /// </summary>
    public async Task UpdateMuly(MulyWhereUniqueInput uniqueId, MulyUpdateInput updateDto)
    {
        var muly = updateDto.ToModel(uniqueId);

        _context.Entry(muly).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Mulies.Any(e => e.Id == muly.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
