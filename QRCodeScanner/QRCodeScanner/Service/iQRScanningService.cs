using System.Threading.Tasks;

namespace QRCodeScanner.Droid.Service
{
    public interface iQRScanningService
    {

        Task<string> ScanAsync();

    }
}