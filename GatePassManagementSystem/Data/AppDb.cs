using Microsoft.EntityFrameworkCore;
using GatePassManagementSystem.Models.EntityModels;

namespace GatePassManagementSystem.Data
{
    public class AppDb:DbContext
    {
        public AppDb(DbContextOptions<AppDb> options) : base (options)
        {

        }

        public DbSet<TblAdminAccessDetails> TblAdminAccessDetails { get; set; }

        public DbSet<TblAdminUserDetails> TblAdminUserDetails { get; set; }

        public DbSet<TblAllApprovedRequests> TblAllApprovedRequests { get; set; }


        public DbSet<TblAllFinalDetailsOfApprovedRequests> TblAllFinalDetailsOfApprovedRequests { get; set; }


        public DbSet<TblAllPendingRequests> TblAllPendingRequests { get; set; } 

        public DbSet<TblAllRejectedRequests> TblAllRejectedRequests { get; set; }


        public DbSet<TblUserAccountDetails> TblUserAccountDetails { get; set; }

    }
}
