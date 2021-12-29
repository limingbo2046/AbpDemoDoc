using System.Threading.Tasks;

namespace lcn.demo.Data
{
    public interface IdemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
