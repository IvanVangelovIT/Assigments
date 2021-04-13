//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InvoiceCalculator
//{
//    class Test
//    {
//        double mesechnaTaksa = 9.99;
//        double izprateniSMS = 2;
//        double izprateniMMS = 0;

//        int minutiKamA1IzvanVkliucheniteVPaketa = 15;
//        int minutiKamTelenorIzvanVkliucheniteVPaketa = 6;
//        int minutiKamVivakomIzvanVkliucheniteVPaketa = 32;

//        int minutiRouming = 0;
//        int izpolzvaniMBvSTranataIzvanVkliucheniteVPaketa = 0;
//        int izpolzvaniMBvESIzvanVkliucheniteVPaketa = 0;
//        int izpolzvaniMBIzvanESIzvanVkliucheniteVPaketa = 0;

//        double drugiTaksi = 1.99;
//        double otstapki = 1.5;

//            if (izprateniSMS< 50)
//            {
//                izprateniSMS *= 0.18;
//            }
//            else if (izprateniSMS >= 50 && izprateniSMS <= 100)
//            {
//                izprateniSMS *= 0.16;
//            }
//            else
//{
//    izprateniSMS *= 0.11;
//}

//if (izprateniMMS < 50)
//{
//    izprateniMMS *= 0.25;
//}
//else if (izprateniMMS >= 50 && izprateniMMS <= 100)
//{
//    izprateniMMS *= 0.23;
//}
//else
//{
//    izprateniMMS *= 0.18;
//}

//double S = mesechnaTaksa +
//    izprateniSMS + izprateniMMS +
//    minutiKamA1IzvanVkliucheniteVPaketa * 0.03
//    + minutiKamTelenorIzvanVkliucheniteVPaketa * 0.09
//    + minutiKamVivakomIzvanVkliucheniteVPaketa * 0.09
//    + minutiRouming * 0.15
//    + izpolzvaniMBvSTranataIzvanVkliucheniteVPaketa * 0.02
//    + izpolzvaniMBvESIzvanVkliucheniteVPaketa * 0.05
//    + izpolzvaniMBIzvanESIzvanVkliucheniteVPaketa * 0.20
//    + drugiTaksi - otstapki;

//Console.WriteLine(S);
//    }
//}
