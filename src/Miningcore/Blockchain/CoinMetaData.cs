using System.Collections.Generic;

namespace Miningcore.Blockchain
{
    public static class DevDonation
    {
        public const decimal Percent = 0.0m;

        public static readonly Dictionary<string, string> Addresses = new Dictionary<string, string>
        {
            { "BTC", "" },
            { "BCH", "" },
            { "BCD", "" },
            { "LTC", "" },
            { "LCC", "" },
            { "DOGE", "" },
            { "DGB", "" },
            { "ETH", "" },
            { "ETC", "" },
            { "DASH", "" },
            { "MONA", "" },
            { "VTC", "" },
            { "ZEC", "" },
            { "ZCL", "" },
            { "ZEN", "" },
            { "BTG", "" },
            { "XVG", "" },
            { "XMR", "" },
            { "ETN", "" },
            { "RVN", "" },
            { "TUBE", "" },
        };
    }

    public static class CoinMetaData
    {
        public const string BlockHeightPH = "$height$";
        public const string BlockHashPH = "$hash$";
    }
}
