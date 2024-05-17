using insurtech.Debugging;

namespace insurtech
{
    public class insurtechConsts
    {
        public const string LocalizationSourceName = "insurtech";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5fc666ecc5b843c08eca4232eaeebc9c";
    }
}
