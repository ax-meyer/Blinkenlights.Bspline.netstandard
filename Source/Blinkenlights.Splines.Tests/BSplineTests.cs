﻿using NUnit.Framework;

namespace Blinkenlights.Splines.Tests
{
    /// <summary>
    /// These tests are based on the samples from the b-spline page hosted on GitHub at
    /// https://github.com/thibauts/b-spline
    /// 
    /// The expected values for these tests were generated by the original JavaScript code.
    /// </summary>

    [TestFixture]
    public class BSplineTests
    {
        [Test]
        public void Interpolate_ForUnclampedKnotVector_GeneratesCorrectValues()
        {
            double[][] points =
            {
                new[] {-1.0, 0.0},
                new[] {-0.5, 0.5},
                new[] {0.5, -0.5},
                new[] {1.0, 0.0}
            };

            var degree = 2;

            var actual = new List<double[]>();
            for (double t = 0; t < 1; t += 0.01)
            {
                var point = BSpline.Interpolate(t, degree, points, null, null, null);
                actual.Add(point);
            }

            double[][] expected =
            {
                new[] {-0.75, 0.25},
                new[] {-0.7399, 0.25970000000000004},
                new[] {-0.7295999999999999, 0.2688},
                new[] {-0.7191, 0.2773},
                new[] {-0.7084, 0.2852},
                new[] {-0.6975, 0.29250000000000004},
                new[] {-0.6864, 0.2992},
                new[] {-0.6750999999999999, 0.3053},
                new[] {-0.6635999999999999, 0.3108},
                new[] {-0.6518999999999999, 0.31570000000000004},
                new[] {-0.6399999999999999, 0.32000000000000006},
                new[] {-0.6279000000000001, 0.3237},
                new[] {-0.6156000000000001, 0.3268},
                new[] {-0.6031000000000002, 0.3293},
                new[] {-0.5904000000000001, 0.3312},
                new[] {-0.5775000000000001, 0.3325},
                new[] {-0.5644000000000001, 0.3332},
                new[] {-0.5511000000000001, 0.3333},
                new[] {-0.5376000000000001, 0.3328},
                new[] {-0.5239, 0.3317},
                new[] {-0.51, 0.33},
                new[] {-0.4959, 0.3277},
                new[] {-0.48160000000000003, 0.3248},
                new[] {-0.46710000000000007, 0.32130000000000003},
                new[] {-0.4524, 0.31720000000000004},
                new[] {-0.4375, 0.3125},
                new[] {-0.4224, 0.30720000000000003},
                new[] {-0.4071, 0.3013},
                new[] {-0.39159999999999995, 0.29479999999999995},
                new[] {-0.3758999999999999, 0.28769999999999996},
                new[] {-0.35999999999999993, 0.27999999999999997},
                new[] {-0.34389999999999993, 0.27169999999999994},
                new[] {-0.3275999999999999, 0.2627999999999999},
                new[] {-0.3110999999999999, 0.2532999999999999},
                new[] {-0.2943999999999999, 0.24319999999999992},
                new[] {-0.27749999999999986, 0.23249999999999993},
                new[] {-0.26039999999999985, 0.2211999999999999},
                new[] {-0.24309999999999982, 0.20929999999999988},
                new[] {-0.2255999999999998, 0.19679999999999986},
                new[] {-0.20789999999999978, 0.18369999999999984},
                new[] {-0.18999999999999975, 0.16999999999999982},
                new[] {-0.17189999999999972, 0.15569999999999978},
                new[] {-0.15359999999999974, 0.14079999999999976},
                new[] {-0.1350999999999997, 0.12529999999999974},
                new[] {-0.11639999999999968, 0.10919999999999973},
                new[] {-0.09749999999999967, 0.0924999999999997},
                new[] {-0.07839999999999964, 0.07519999999999968},
                new[] {-0.059099999999999625, 0.05729999999999964},
                new[] {-0.039599999999999594, 0.03879999999999961},
                new[] {-0.019899999999999578, 0.019699999999999586},
                new[] {4.4408920985006257e-16, -4.4408920985006247e-16},
                new[] {0.01990000000000046, -0.019700000000000446},
                new[] {0.03960000000000047, -0.03880000000000045},
                new[] {0.059100000000000485, -0.05730000000000045},
                new[] {0.0784000000000005, -0.07520000000000046},
                new[] {0.0975000000000005, -0.09250000000000044},
                new[] {0.11640000000000052, -0.10920000000000045},
                new[] {0.13510000000000053, -0.12530000000000044},
                new[] {0.15360000000000054, -0.14080000000000045},
                new[] {0.17190000000000055, -0.15570000000000045},
                new[] {0.19000000000000056, -0.17000000000000043},
                new[] {0.20790000000000058, -0.18370000000000042},
                new[] {0.22560000000000058, -0.19680000000000042},
                new[] {0.2431000000000006, -0.20930000000000043},
                new[] {0.2604000000000006, -0.2212000000000004},
                new[] {0.27750000000000064, -0.2325000000000004},
                new[] {0.2944000000000006, -0.24320000000000036},
                new[] {0.3111000000000006, -0.25330000000000036},
                new[] {0.32760000000000067, -0.26280000000000037},
                new[] {0.34390000000000065, -0.27170000000000033},
                new[] {0.36000000000000065, -0.28000000000000036},
                new[] {0.3759000000000007, -0.2877000000000003},
                new[] {0.3916000000000006, -0.2948000000000003},
                new[] {0.40710000000000063, -0.30130000000000023},
                new[] {0.42240000000000066, -0.30720000000000025},
                new[] {0.43750000000000067, -0.3125000000000002},
                new[] {0.45240000000000063, -0.3172000000000002},
                new[] {0.4671000000000007, -0.3213000000000002},
                new[] {0.4816000000000007, -0.32480000000000014},
                new[] {0.4959000000000007, -0.3277000000000001},
                new[] {0.5100000000000007, -0.33000000000000007},
                new[] {0.5239000000000007, -0.3317000000000001},
                new[] {0.5376000000000007, -0.33280000000000004},
                new[] {0.5511000000000007, -0.33330000000000004},
                new[] {0.5644000000000007, -0.33319999999999994},
                new[] {0.5775000000000007, -0.3324999999999999},
                new[] {0.5904000000000007, -0.33119999999999994},
                new[] {0.6031000000000006, -0.32929999999999987},
                new[] {0.6156000000000007, -0.32679999999999987},
                new[] {0.6279000000000007, -0.32369999999999977},
                new[] {0.6400000000000007, -0.31999999999999973},
                new[] {0.6519000000000007, -0.31569999999999976},
                new[] {0.6636000000000006, -0.3107999999999997},
                new[] {0.6751000000000007, -0.3052999999999997},
                new[] {0.6864000000000007, -0.2991999999999996},
                new[] {0.6975000000000007, -0.29249999999999954},
                new[] {0.7084000000000007, -0.2851999999999995},
                new[] {0.7191000000000007, -0.2772999999999995},
                new[] {0.7296000000000007, -0.26879999999999943},
                new[] {0.7399000000000007, -0.2596999999999994}
            };

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual.ToArray(), Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void Interpolate_ForClampedKnotVector_GeneratesCorrectValues()
        {
            double[][] points =
            {
                new[] {-1.0, 0.0},
                new[] {-0.5, 0.5},
                new[] {0.5, -0.5},
                new[] {1.0, 0.0}
            };

            var degree = 2;

            double[] knots = {0, 0, 0, 1, 2, 2, 2};

            var actual = new List<double[]>();
            for (double t = 0; t < 1; t += 0.01)
            {
                var point = BSpline.Interpolate(t, degree, points, knots, null, null);
                actual.Add(point);
            }

            double[][] expected =
            {
                new[] {-1.0, 0.0},
                new[] {-0.98, 0.0196},
                new[] {-0.96, 0.0384},
                new[] {-0.94, 0.05639999999999999},
                new[] {-0.9200000000000002, 0.0736},
                new[] {-0.9000000000000001, 0.09},
                new[] {-0.88, 0.1056},
                new[] {-0.86, 0.12040000000000001},
                new[] {-0.84, 0.13440000000000002},
                new[] {-0.8200000000000001, 0.1476},
                new[] {-0.8, 0.16},
                new[] {-0.78, 0.17159999999999997},
                new[] {-0.76, 0.18239999999999998},
                new[] {-0.74, 0.19239999999999996},
                new[] {-0.72, 0.20159999999999997},
                new[] {-0.7, 0.21},
                new[] {-0.6799999999999999, 0.2176},
                new[] {-0.6599999999999999, 0.2244},
                new[] {-0.6399999999999999, 0.2304},
                new[] {-0.6199999999999999, 0.2356},
                new[] {-0.5999999999999999, 0.24},
                new[] {-0.5799999999999998, 0.24359999999999998},
                new[] {-0.5599999999999998, 0.24639999999999998},
                new[] {-0.5399999999999998, 0.24839999999999998},
                new[] {-0.5199999999999998, 0.2496},
                new[] {-0.4999999999999999, 0.25},
                new[] {-0.4799999999999999, 0.2496},
                new[] {-0.45999999999999985, 0.2484},
                new[] {-0.43999999999999984, 0.2464},
                new[] {-0.4199999999999999, 0.24359999999999998},
                new[] {-0.39999999999999986, 0.24},
                new[] {-0.3799999999999998, 0.23559999999999998},
                new[] {-0.3599999999999998, 0.23039999999999994},
                new[] {-0.3399999999999998, 0.22439999999999993},
                new[] {-0.3199999999999998, 0.2175999999999999},
                new[] {-0.29999999999999977, 0.2099999999999999},
                new[] {-0.27999999999999975, 0.2015999999999999},
                new[] {-0.25999999999999973, 0.19239999999999985},
                new[] {-0.2399999999999997, 0.18239999999999984},
                new[] {-0.2199999999999997, 0.1715999999999998},
                new[] {-0.19999999999999965, 0.1599999999999998},
                new[] {-0.17999999999999963, 0.1475999999999998},
                new[] {-0.15999999999999961, 0.13439999999999974},
                new[] {-0.1399999999999996, 0.12039999999999972},
                new[] {-0.11999999999999958, 0.10559999999999968},
                new[] {-0.09999999999999956, 0.08999999999999965},
                new[] {-0.07999999999999954, 0.07359999999999961},
                new[] {-0.059999999999999526, 0.05639999999999959},
                new[] {-0.03999999999999951, 0.038399999999999546},
                new[] {-0.01999999999999949, 0.01959999999999951},
                new[] {4.440892098500626e-16, -4.440892098500624e-16},
                new[] {0.020000000000000462, -0.019600000000000443},
                new[] {0.04000000000000048, -0.03840000000000044},
                new[] {0.0600000000000005, -0.056400000000000436},
                new[] {0.08000000000000052, -0.07360000000000043},
                new[] {0.10000000000000053, -0.09000000000000043},
                new[] {0.12000000000000055, -0.10560000000000042},
                new[] {0.14000000000000057, -0.12040000000000041},
                new[] {0.1600000000000006, -0.1344000000000004},
                new[] {0.1800000000000006, -0.1476000000000004},
                new[] {0.20000000000000062, -0.16000000000000036},
                new[] {0.22000000000000064, -0.17160000000000036},
                new[] {0.24000000000000066, -0.18240000000000034},
                new[] {0.2600000000000007, -0.19240000000000032},
                new[] {0.2800000000000007, -0.2016000000000003},
                new[] {0.3000000000000007, -0.2100000000000003},
                new[] {0.32000000000000073, -0.21760000000000027},
                new[] {0.34000000000000075, -0.22440000000000024},
                new[] {0.36000000000000076, -0.23040000000000022},
                new[] {0.3800000000000008, -0.2356000000000002},
                new[] {0.4000000000000008, -0.24000000000000016},
                new[] {0.4200000000000008, -0.24360000000000012},
                new[] {0.44000000000000083, -0.2464000000000001},
                new[] {0.46000000000000085, -0.24840000000000007},
                new[] {0.48000000000000087, -0.24960000000000004},
                new[] {0.5000000000000009, -0.25},
                new[] {0.5200000000000009, -0.24959999999999996},
                new[] {0.5400000000000009, -0.24839999999999993},
                new[] {0.5600000000000009, -0.2463999999999999},
                new[] {0.580000000000001, -0.24359999999999984},
                new[] {0.600000000000001, -0.2399999999999998},
                new[] {0.620000000000001, -0.23559999999999975},
                new[] {0.640000000000001, -0.23039999999999972},
                new[] {0.660000000000001, -0.22439999999999968},
                new[] {0.680000000000001, -0.21759999999999963},
                new[] {0.7000000000000011, -0.20999999999999958},
                new[] {0.7200000000000011, -0.20159999999999953},
                new[] {0.7400000000000011, -0.19239999999999946},
                new[] {0.7600000000000011, -0.18239999999999942},
                new[] {0.7800000000000011, -0.17159999999999936},
                new[] {0.8000000000000012, -0.1599999999999993},
                new[] {0.8200000000000012, -0.14759999999999926},
                new[] {0.8400000000000012, -0.1343999999999992},
                new[] {0.8600000000000012, -0.12039999999999913},
                new[] {0.8800000000000012, -0.10559999999999907},
                new[] {0.9000000000000012, -0.08999999999999901},
                new[] {0.9200000000000013, -0.07359999999999894},
                new[] {0.9400000000000013, -0.056399999999998875},
                new[] {0.9600000000000013, -0.03839999999999881},
                new[] {0.9800000000000013, -0.019599999999998736}
            };

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual.ToArray(), Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void Interpolate_ForClosedCurves_GeneratesCorrectValues()
        {
            double[][] points =
            {
                new[] {-1.0, 0.0},
                new[] {-0.5, 0.5},
                new[] {0.5, -0.5},
                new[] {1.0, 0.0},
                new[] {-1.0, 0.0},
                new[] {-0.5, 0.5},
                new[] {0.5, -0.5}
            };

            var degree = 2;

            double[] knots = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            var actual = new List<double[]>();
            for (double t = 0; t < 1; t += 0.01)
            {
                var point = BSpline.Interpolate(t, degree, points, knots, null, null);
                actual.Add(point);
            }

            double[][] expected =
            {
                new[] {-0.75, 0.25}, new[] {-0.7243750000000001, 0.27312499999999995}, new[] {-0.6975, 0.29250000000000004}, new[] {-0.669375, 0.308125},
                new[] {-0.6399999999999999, 0.32000000000000006}, new[] {-0.609375, 0.328125}, new[] {-0.5775000000000001, 0.3325},
                new[] {-0.5443749999999999, 0.333125}, new[] {-0.51, 0.33}, new[] {-0.4743749999999999, 0.323125}, new[] {-0.4375, 0.3125},
                new[] {-0.39937500000000015, 0.2981250000000001}, new[] {-0.36000000000000026, 0.28000000000000014},
                new[] {-0.3193750000000001, 0.25812500000000005}, new[] {-0.27749999999999986, 0.23249999999999993}, new[] {-0.234375, 0.203125},
                new[] {-0.19000000000000017, 0.17000000000000012}, new[] {-0.14437499999999992, 0.13312499999999994},
                new[] {-0.09749999999999967, 0.0924999999999997}, new[] {-0.04937499999999983, 0.048124999999999835}, new[] {0.0, 0.0},
                new[] {0.04937500000000026, -0.048125000000000244}, new[] {0.0975000000000005, -0.09250000000000044},
                new[] {0.14437500000000034, -0.13312500000000027}, new[] {0.19000000000000017, -0.17000000000000012}, new[] {0.234375, -0.203125},
                new[] {0.27750000000000025, -0.23250000000000015}, new[] {0.3193750000000004, -0.25812500000000027},
                new[] {0.36000000000000026, -0.28000000000000014}, new[] {0.39937500000000015, -0.2981250000000001},
                new[] {0.43750000000000033, -0.3125000000000001}, new[] {0.47437500000000055, -0.3231250000000001},
                new[] {0.5100000000000003, -0.33000000000000007}, new[] {0.5443750000000003, -0.333125}, new[] {0.5775000000000003, -0.33249999999999996},
                new[] {0.6093750000000006, -0.3281249999999999}, new[] {0.6400000000000003, -0.31999999999999984},
                new[] {0.6693750000000003, -0.30812499999999987}, new[] {0.6975000000000005, -0.29249999999999976},
                new[] {0.7243750000000005, -0.2731249999999995}, new[] {0.7500000000000004, -0.24999999999999956},
                new[] {0.7718750000000003, -0.22562499999999966}, new[] {0.7875000000000003, -0.20249999999999935},
                new[] {0.7968750000000001, -0.18062499999999948}, new[] {0.8, -0.1599999999999996}, new[] {0.7968749999999998, -0.14062499999999933},
                new[] {0.7874999999999999, -0.12249999999999975}, new[] {0.7718749999999994, -0.10562499999999954},
                new[] {0.7499999999999993, -0.08999999999999962}, new[] {0.7218749999999994, -0.0756249999999997},
                new[] {0.6874999999999993, -0.06249999999999978}, new[] {0.6468749999999994, -0.05062499999999984},
                new[] {0.5999999999999985, -0.039999999999999716}, new[] {0.5468749999999986, -0.03062499999999978},
                new[] {0.48749999999999866, -0.02249999999999984}, new[] {0.42187499999999756, -0.015624999999999778},
                new[] {0.3499999999999976, -0.00999999999999984}, new[] {0.2718749999999977, -0.005624999999999893},
                new[] {0.18749999999999784, -0.002499999999999938}, new[] {0.096874999999998, -0.0006249999999999733},
                new[] {-3.552713678800497e-15, 7.888609052210118e-31}, new[] {-0.09687500000000299, 0.00062500000000004},
                new[] {-0.1875000000000025, 0.002500000000000071}, new[] {-0.2718750000000035, 0.00562500000000016},
                new[] {-0.3500000000000029, 0.010000000000000196}, new[] {-0.42187500000000244, 0.015625000000000222},
                new[] {-0.487500000000002, 0.02250000000000024}, new[] {-0.5468750000000016, 0.03062500000000025},
                new[] {-0.6000000000000021, 0.040000000000000424}, new[] {-0.6468750000000018, 0.05062500000000044},
                new[] {-0.6875000000000013, 0.06250000000000044}, new[] {-0.7218750000000016, 0.07562500000000068},
                new[] {-0.7500000000000011, 0.09000000000000069}, new[] {-0.7718750000000008, 0.10562500000000069},
                new[] {-0.7875000000000004, 0.12250000000000068}, new[] {-0.7968750000000002, 0.14062500000000067},
                new[] {-0.7999999999999999, 0.160000000000001}, new[] {-0.7968749999999997, 0.18062500000000098},
                new[] {-0.7874999999999994, 0.20250000000000096}, new[] {-0.771874999999999, 0.22562500000000135},
                new[] {-0.7499999999999987, 0.25000000000000133}, new[] {-0.7243749999999988, 0.27312500000000106},
                new[] {-0.6974999999999988, 0.2925000000000008}, new[] {-0.6693749999999988, 0.3081250000000006},
                new[] {-0.6399999999999982, 0.32000000000000056}, new[] {-0.6093749999999983, 0.32812500000000033},
                new[] {-0.5774999999999983, 0.33250000000000013}, new[] {-0.5443749999999978, 0.3331249999999999},
                new[] {-0.5099999999999979, 0.32999999999999974}, new[] {-0.47437499999999794, 0.3231249999999995},
                new[] {-0.437499999999998, 0.31249999999999933}, new[] {-0.39937499999999804, 0.2981249999999992},
                new[] {-0.35999999999999743, 0.2799999999999987}, new[] {-0.3193749999999975, 0.2581249999999986},
                new[] {-0.2774999999999976, 0.23249999999999843}, new[] {-0.2343749999999969, 0.20312499999999778},
                new[] {-0.18999999999999695, 0.16999999999999765}, new[] {-0.14437499999999703, 0.13312499999999752},
                new[] {-0.09749999999999713, 0.09249999999999743}, new[] {-0.04937499999999723, 0.04812499999999737}
            };

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual.ToArray(), Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void Interpolate_ForNonUniformRational_GeneratesCorrectValues()
        {
            double[][] points =
            {
                new[] {0.0, -0.5},
                new[] {-0.5, -0.5},
                new[] {-0.5, 0.0},
                new[] {-0.5, 0.5},
                new[] {0.0, 0.5},
                new[] {0.5, 0.5},
                new[] {0.5, 0.0},
                new[] {0.5, -0.5},
                new[] {0.0, -0.5}
            };

            double[] knots = { 0.0, 0.0, 0.0, 1.0 / 4.0, 1.0 / 4.0, 1.0 / 2.0, 1.0 / 2.0, 3.0 / 4.0, 3.0 / 4.0, 1.0, 1.0, 1.0 };

            var w = Math.Pow(2, 0.5) / 2;
            double[] weights = {1, w, 1, w, 1, w, 1, w, 1};

            var degree = 2;

            var actual = new List<double[]>();
            for (double t = 0; t < 1; t += 0.01)
            {
                var point = BSpline.Interpolate(t, degree, points, knots, weights, null);
                actual.Add(point);
            }

            double[][] expected =
            {
                new[] {0, -0.5},
                new[] {-0.028596147843650513, -0.4991815905344508},
                new[] {-0.05773211466353691, -0.49665581939254094},
                new[] {-0.08726884366627154, -0.4923252470929679},
                new[] {-0.11705050197073215, -0.48610614066106966},
                new[] {-0.14690596885579393, -0.47793162305348713},
                new[] {-0.17665098333004992, -0.4677546686977335},
                new[] {-0.2060909434530637, -0.4555507908308645},
                new[] {-0.2350243095261886, -0.4413202623172182},
                new[] {-0.26324652040529967, -0.42508971934698936},
                new[] {-0.2905542905574594, -0.4069130180255376},
                new[] {-0.31675011936850456, -0.38687124716116866},
                new[] {-0.3416468178429142, -0.36507184478922866},
                new[] {-0.3650718447892286, -0.34164681784291423},
                new[] {-0.38687124716116866, -0.3167501193685047},
                new[] {-0.4069130180255376, -0.2905542905574595},
                new[] {-0.42508971934698936, -0.26324652040529967},
                new[] {-0.44132026231721827, -0.23502430952618855},
                new[] {-0.4555507908308645, -0.2060909434530636},
                new[] {-0.4677546686977336, -0.17665098333004983},
                new[] {-0.4779316230534872, -0.14690596885579382},
                new[] {-0.48610614066106966, -0.11705050197073201},
                new[] {-0.49232524709296793, -0.0872688436662714},
                new[] {-0.49665581939254094, -0.05773211466353673},
                new[] {-0.4991815905344508, -0.02859614784365029},
                new[] {-0.5, 1.5700924586837754e-16},
                new[] {-0.49918159053445077, 0.02859614784365069},
                new[] {-0.4966558193925409, 0.057732114663537115},
                new[] {-0.4923252470929678, 0.0872688436662718},
                new[] {-0.4861061406610696, 0.11705050197073243},
                new[] {-0.477931623053487, 0.14690596885579424},
                new[] {-0.46775466869773347, 0.17665098333005025},
                new[] {-0.45555079083086436, 0.206090943453064},
                new[] {-0.44132026231721805, 0.23502430952618897},
                new[] {-0.42508971934698914, 0.26324652040530006},
                new[] {-0.40691301802553725, 0.29055429055745985},
                new[] {-0.3868712471611684, 0.31675011936850506},
                new[] {-0.3650718447892283, 0.34164681784291456},
                new[] {-0.3416468178429138, 0.36507184478922905},
                new[] {-0.31675011936850417, 0.386871247161169},
                new[] {-0.2905542905574589, 0.40691301802553786},
                new[] {-0.26324652040529906, 0.4250897193469897},
                new[] {-0.23502430952618797, 0.44132026231721855},
                new[] {-0.206090943453063, 0.4555507908308648},
                new[] {-0.17665098333004922, 0.4677546686977338},
                new[] {-0.14690596885579324, 0.47793162305348735},
                new[] {-0.11705050197073143, 0.4861061406610699},
                new[] {-0.08726884366627079, 0.492325247092968},
                new[] {-0.057732114663536144, 0.496655819392541},
                new[] {-0.02859614784364973, 0.4991815905344508},
                new[] {6.280369834735102e-16, 0.5},
                new[] {0.028596147843651172, 0.49918159053445077},
                new[] {0.05773211466353761, 0.49665581939254083},
                new[] {0.08726884366627229, 0.49232524709296777},
                new[] {0.11705050197073291, 0.48610614066106944},
                new[] {0.14690596885579474, 0.4779316230534869},
                new[] {0.17665098333005072, 0.4677546686977332},
                new[] {0.20609094345306447, 0.45555079083086414},
                new[] {0.2350243095261894, 0.4413202623172178},
                new[] {0.26324652040530044, 0.4250897193469888},
                new[] {0.2905542905574603, 0.4069130180255369},
                new[] {0.31675011936850545, 0.386871247161168},
                new[] {0.34164681784291495, 0.3650718447892279},
                new[] {0.36507184478922944, 0.3416468178429134},
                new[] {0.3868712471611694, 0.3167501193685037},
                new[] {0.40691301802553825, 0.2905542905574585},
                new[] {0.4250897193469899, 0.2632465204052986},
                new[] {0.4413202623172188, 0.23502430952618747},
                new[] {0.4555507908308651, 0.2060909434530625},
                new[] {0.46775466869773397, 0.17665098333004872},
                new[] {0.4779316230534875, 0.14690596885579277},
                new[] {0.48610614066107, 0.11705050197073094},
                new[] {0.4923252470929681, 0.08726884366627032},
                new[] {0.49665581939254105, 0.05773211466353566},
                new[] {0.4991815905344508, 0.028596147843649247},
                new[] {0.5, -1.256073966947021e-15},
                new[] {0.4991815905344507, -0.028596147843651814},
                new[] {0.4966558193925408, -0.05773211466353826},
                new[] {0.49232524709296765, -0.08726884366627295},
                new[] {0.4861061406610693, -0.11705050197073358},
                new[] {0.47793162305348663, -0.1469059688557954},
                new[] {0.467754668697733, -0.1766509833300514},
                new[] {0.4555507908308639, -0.20609094345306517},
                new[] {0.4413202623172175, -0.23502430952619005},
                new[] {0.42508971934698847, -0.2632465204053011},
                new[] {0.40691301802553653, -0.29055429055746085},
                new[] {0.38687124716116755, -0.31675011936850606},
                new[] {0.36507184478922733, -0.34164681784291545},
                new[] {0.3416468178429128, -0.3650718447892299},
                new[] {0.3167501193685032, -0.3868712471611699},
                new[] {0.29055429055745796, -0.40691301802553864},
                new[] {0.263246520405298, -0.4250897193469903},
                new[] {0.2350243095261869, -0.44132026231721916},
                new[] {0.2060909434530619, -0.45555079083086536},
                new[] {0.1766509833300481, -0.46775466869773424},
                new[] {0.14690596885579207, -0.4779316230534877},
                new[] {0.11705050197073028, -0.4861061406610701},
                new[] {0.08726884366626965, -0.49232524709296815},
                new[] {0.057732114663535006, -0.4966558193925411},
                new[] {0.028596147843648605, -0.4991815905344509}
            };

            Assert.That(actual.Count, Is.EqualTo(expected.Length));
            Assert.That(actual.ToArray(), Is.EqualTo(expected).Within(0.00001));
        }
    }
}