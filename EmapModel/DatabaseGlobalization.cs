using Devart.Data.Oracle;


namespace EmapModel
{
    public class DatabaseGlobalization
    {
        public static string ConnectionString { get; set; }
        public static OracleConnectionStringBuilder GetConnection()
        {
            OracleConnectionStringBuilder oraCsb =
                new OracleConnectionStringBuilder
                {
                    ConnectionString = ConnectionString,
                    LicenseKey = @"wf0FKMlpbgMhRQ8qVdzPzurzMCHDhNPz5+QYQykUxi2FcWBIDOmSLjVP73PwvJfq1/uo2Uc6CEIq4BqT7QdW0+DpzzZDplc+eMF8bslL4X7PJxygp8bNkgp7bkSu/fiBj5qF2b39e6jMOj9Nz/y012/FNCzuq5PK8kmIBVMuzyKMQo7Y4goSMdsGBvH8KUZkUEH2FGrDxO43UMaCxdiqJiOk+wom5LyF8f2/Xtjkh2ed/RPRYnCCMfiPw0nxElohOHM2dGDHfK6mcbbgwuyii+oYRlkTcY6aRtiGZITvLAo=",
                    Direct = true,
                    InitializationCommand =
                        "ALTER SESSION SET NLS_TERRITORY='DENMARK' NLS_LANGUAGE='DANISH' NLS_DATE_LANGUAGE='DANISH' NLS_CURRENCY='kr.' NLS_DATE_FORMAT='DD-MM-YYYY' NLS_ISO_CURRENCY='DENMARK' NLS_NUMERIC_CHARACTERS=',.' NLS_DUAL_CURRENCY='kr.' NLS_NCHAR_CONV_EXCP='True' NLS_TIMESTAMP_FORMAT='DD-MM-YYYY HH24:MI:SS' NLS_TIMESTAMP_TZ_FORMAT='DD-MM-YYYY HH24:MI:SS TZH:TZM' TIME_ZONE='Europe/Copenhagen'"
                };
            return oraCsb;
        }
    }
}
