namespace Generics.Settings
{
    public static class Database
    {
        public static string ConnectionString = Configuration.GetConfiguration("ConnectionString:DashboardAPI");
    }
}