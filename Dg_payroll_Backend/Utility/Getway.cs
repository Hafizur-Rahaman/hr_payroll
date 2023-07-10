namespace ReportApi.Utility
{
    public class Getway
    {
        private static string _Mr_AspCore = "";
        private static string _DG_Payroll = "";

        public static string AspCoreCon
        {
            get
            {
                if (_Mr_AspCore == "")
                {
                    _Mr_AspCore = String.Format("Data Source=.;Initial Catalog=AspCore;Persist Security Info=true; User ID=sa; Password=moin;Connection Timeout=1000");
                }
                return _Mr_AspCore;
            }
        }

        public static string Payroll
        {
            get
            {
                if (_DG_Payroll == "")
                {
                    _DG_Payroll = String.Format("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
                }
                return _DG_Payroll;
            }
        }
    }
}
