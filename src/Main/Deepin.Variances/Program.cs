using Deepin.Shared.Helpers;
using Deepin.Variances.Contravariance;
using Deepin.Variances.Covariance;
using Deepin.Variances.Invariance;

namespace Deepin.Variances
{
    class Program
    {
        static void Main(string[] args)
        {
            new CovarianceExample().ValidCovariance();
            Methods.InsertDelimeter();

            new ContravarianceExample().ValidContravariance();
            Methods.InsertDelimeter();

            new InvarianceExample().ValidInvariance();
            Methods.InsertDelimeter();
        }
    }
}
