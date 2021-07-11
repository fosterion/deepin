using Deepin.Variances.Contravariance;
using Deepin.Variances.Covariance;
using Deepin.Variances.Invariance;
using System;

namespace Deepin.Variances
{
    class Program
    {
        static void Main(string[] args)
        {
            new CovarianceExample().ValidCovariance();
            InsertDelimeter();

            new ContravarianceExample().ValidContravariance();
            InsertDelimeter();

            new InvarianceExample().ValidInvariance();
            InsertDelimeter();
        }

        private static void InsertDelimeter()
        {
            Console.WriteLine("==========\n");
        }
    }
}
