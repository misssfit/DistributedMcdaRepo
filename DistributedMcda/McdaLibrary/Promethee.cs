using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;


namespace McdaLibrary
{
    [Export(typeof(IMcdaMethod))]
    public class Promethee : IMcdaMethod
    {
        // liczba wszystkich alternatyw
        private int N;
        // liczba wszystkich kryteriow
        private int J;

        private double[,] ET;
        private double[,] W;

        private static readonly McdaMethodInfo _mcdaMethodInfo;

        static Promethee()
        {
            _mcdaMethodInfo = new McdaMethodInfo
            {
                Name = "Promethee",
                ObjectType = typeof(Promethee),
                Input = new List<string> { "weights", "evaluationTable" },
            };
        }

        public McdaMethodInfo MethodMetadata
        {
            get { return _mcdaMethodInfo; }
        }

        public double[][] Calculate(List<KeyValuePair<string, double[][]>> input)
        {
            try
            {
                var etData = input.Single(p => p.Key == "evaluationTable").Value;
                var wData = input.Single(p => p.Key == "weights").Value;

                ET = etData.ToMultiD();
                W = wData.ToMultiD();
            }
            catch (Exception)
            {
                throw new Exception("Cannot retreive parameters from input list");
            }

            N = ET.GetLength(0);
            J = ET.GetLength(1);

            var fiPlus = FiPlus();
            var fiMinus = FiMinus();
            var ranking2 = Ranking2(fiPlus, fiMinus);

            //var x = new Random().Next(10000, 150000);
            //Console.WriteLine("@ " + x);
            //Thread.Sleep(x); //todo);

            return ranking2.ToJagged();
        }

        private double[] FiPlus()
        {
            // Obliczenie dodatniego przeplywu preferencji. Tablica fi_plus zawiera
            // wartosci fi_plus[a), fi_plus[b), ..., fi_plus[n) dla kazdej z alternatyw
            // Indeks tablicy to numer alternatywy. fi_plus[1) ==> fi_plus[a)
            var fiPlus = new double[N];
            for (int alternative = 0; alternative < N; alternative++)
            {
                var suma = 0.0;
                for (int j = 0; j < J; j++) //numer kryterium
                {
                    for (int n = 0; n < N; n++) //numer alternatywy/wariantu

                        if (n != alternative)
                        {
                            suma = suma + FunctionP(j, alternative, n, W[1, j]) * W[0, j];
                        }
                }
                fiPlus[alternative] = 1.0 / (N - 1) * suma;
            }
            return fiPlus;
        }

        private double[] FiMinus()
        {
            // Obliczenie ujemnego przeplywu preferencji.
            var fi_minus = new double[N];
            for (int alternative = 0; alternative < N; alternative++)
            {
                var suma = 0.0;
                for (int j = 0; j < J; j++) //numer kryterium
                {
                    for (int n = 0; n < N; n++) //numer alternatywy/wariantu

                        if (n != alternative)
                        {
                            suma = suma + FunctionP(j, n, alternative, W[1, j]) * W[0, j];
                        }
                }
                fi_minus[alternative] = 1.0 / (N - 1) * suma;
            }
            return fi_minus;
        }

        private double FunctionP(int j, int alternative1, int alternative2, double direction)
        {
            //direction == -1 minimalizacja, direction = 1 maksymilizacja
            // p is a threshold  of stric t preference

            const double p = 0.1;
            //z = v_shape_criterion(ET(alternative1,j) - ET(alternative2,j),p);

            if (direction == -1)
            {
                return gaussian_criterion(-(ET[alternative1, j] - ET[alternative2, j]), p);

            }

            //zaloz max
            return gaussian_criterion(ET[alternative1, j] - ET[alternative2, j], p);


        }

        private double gaussian_criterion(double d, double s)
        {
            if (d <= 0)
                return 0;
            else
                return 1 - Math.Exp(-Math.Pow(d, 2) / (2 * Math.Pow(s, 2)));

        }

        private double[,] Ranking1(double[] fi_plus, double[] fi_minus)
        {
            var ranking1 = new double[N, 2];

            for (int i = 0; i < N; i++)
            {
                ranking1[i, 0] = i;
                ranking1[i, 1] = i;
            }

            for (int alternative = 0; alternative < N; alternative++)
            {
                for (int alternativeToCompare = 0; alternativeToCompare < N; alternativeToCompare++)
                {
                    if (alternativeToCompare != alternative)
                    {
                        // Multiple Criteria Decision Analisis str. 173 wzor (5.15)
                        // relacja aPb 
                        if (((fi_plus[alternative] > fi_plus[alternativeToCompare]) &&
                             (fi_minus[alternative] < fi_minus[alternativeToCompare]))
                            || ((fi_plus[alternative] == fi_plus[alternativeToCompare]) &&
                             (fi_minus[alternative] < fi_minus[alternativeToCompare]))
                            || ((fi_plus[alternative] > fi_plus[alternativeToCompare]) &&
                             (fi_minus[alternative] == fi_minus[alternativeToCompare])))
                        {
                            if (ranking1[alternative, 1] > ranking1[alternativeToCompare, 1])
                            {
                                var tmp = ranking1[alternative, 1];
                                ranking1[alternative, 1] = ranking1[alternativeToCompare, 1];
                                ranking1[alternativeToCompare, 1] = tmp;
                            }
                        }

                    }
                }
            }
            return ranking1;
        }

        private double[,] Ranking2(double[] fi_plus, double[] fi_minus)
        {
            var ranking2 = new double[N, 2];

            for (int i = 0; i < N; i++)
            {
                ranking2[i, 0] = i;
                ranking2[i, 1] = i;
            }
            var fi = CalculateFi(fi_plus, fi_minus);
            for (int alternative = 0; alternative < N; alternative++)
            {
                for (int alternativeToCompare = 0; alternativeToCompare < N; alternativeToCompare++)
                {
                    if (alternativeToCompare != alternative)
                    {
                        if (fi[alternative] > fi[alternativeToCompare])
                        {
                            if (ranking2[alternative, 1] > ranking2[alternativeToCompare, 1])
                            {
                                var tmp = ranking2[alternative, 1];
                                ranking2[alternative, 1] = ranking2[alternativeToCompare, 1];
                                ranking2[alternativeToCompare, 1] = tmp;
                            }
                        }
                    }
                }
            }
            return ranking2;
        }

        private double[] CalculateFi(double[] fi_plus, double[] fi_minus)
        {
            var fi = new double[N];
            for (int alternative = 0; alternative < N; alternative++)
            {
                fi[alternative] = fi_plus[alternative] - fi_minus[alternative];
            }

            return fi;
        }



    }
}
