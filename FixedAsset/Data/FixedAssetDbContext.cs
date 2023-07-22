using FixedAsset.Models;
using Microsoft.EntityFrameworkCore;

namespace FixedAsset.Data
{
    public class FixedAssetDbContext:DbContext
    {
        public FixedAssetDbContext(DbContextOptions<FixedAssetDbContext> dbContextOptions):base(dbContextOptions) 
        {

        }
        DbSet<TFAMtrlGrp> tFAMtrlGrp { get; set; }  
    }
}
