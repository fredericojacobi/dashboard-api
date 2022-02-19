namespace Generics.Settings
{
    public static class Token
    {
        public static string BearerToken => Configuration.GetConfiguration("Token");
    }
}