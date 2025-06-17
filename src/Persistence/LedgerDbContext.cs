using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Wangkanai.Ledger.Identity;

namespace Wangkanai.Ledger.Data;

public class LedgerDbContext(DbContextOptions<LedgerDbContext> options) : IdentityDbContext<LedgerUser>(options)
{
	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
	}
}
