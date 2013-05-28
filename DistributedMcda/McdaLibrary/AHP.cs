using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra.Double;
using McdaMethodsContract;

namespace McdaLibrary
{
    [Export(typeof(IMcdaMethod))]
    public class AHP : IMcdaMethod
    {
        private DenseMatrix criteriaPreferenceMatrix;
        private List<DenseMatrix> alternativesPreferenceMatrixes;
        
        private static readonly McdaMethodInfo _mcdaMethodInfo;

        static AHP()
        {
            _mcdaMethodInfo = new McdaMethodInfo
            {
                Name = "AHP",
                ObjectType = typeof(AHP),
                Input = new List<string> { "criteriaPreferenceMatrix", "alternativesPreferenceMatrixesN (N is number of criteria)" },
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
                alternativesPreferenceMatrixes = new List<DenseMatrix>();
                var criteriaPreferenceData = input.Single(p => p.Key == "criteriaPreferenceMatrix").Value;
                criteriaPreferenceMatrix = DenseMatrix.OfArray(criteriaPreferenceData.ToMultiD());
                for (int i = 1; i <= criteriaPreferenceMatrix.ColumnCount; i++)
                {
                    var alternativesPreferenceMatrix = input.Single(p => p.Key.Equals("alternativesPreferenceMatrixes" + i)).Value;
                    alternativesPreferenceMatrixes.Add(DenseMatrix.OfArray(alternativesPreferenceMatrix.ToMultiD()));
                }
            }
            catch (Exception)
            {
                throw new Exception("Cannot retreive parameters from input list");
            }
            DenseVector normalizedCrtieriaWeights = calculateNormalizedWeights(criteriaPreferenceMatrix);
            List<DenseVector> normalizedAlternativesWeights = new List<DenseVector>();
            foreach (DenseMatrix alternativesPreferenceMatrix in alternativesPreferenceMatrixes)
            {
                var AW = calculateNormalizedWeights(alternativesPreferenceMatrix);
                normalizedAlternativesWeights.Add(AW);
                //Console.WriteLine(AW.ToVectorString(AW.Count, 100));
                //Console.WriteLine("-------------------------------");
            }
            DenseMatrix alternativesWithCriteriaWeigthsMatrix = DenseMatrix.OfColumns(normalizedAlternativesWeights[0].Count, normalizedAlternativesWeights.Count, normalizedAlternativesWeights);
            var matrix = alternativesWithCriteriaWeigthsMatrix;
            //Console.WriteLine("==============================");
            //Console.WriteLine(matrix.ToMatrixString(matrix.RowCount, matrix.ColumnCount));

            DenseVector result = (DenseVector)alternativesWithCriteriaWeigthsMatrix.Multiply(normalizedCrtieriaWeights);
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine(result.ToVectorString(result.Count, 100));

            //List<double> alternativesNumber = new List<double>();
            //for (int i = 1; i <= result.Count; i++)
            //{
            //    alternativesNumber.Add(i);
            //}
            //List<DenseVector> alternativesRank = new List<DenseVector>();
            //alternativesRank.Add(DenseVector.OfEnumerable(alternativesNumber));
            //alternativesRank.Add((DenseVector)result);

            //DenseMatrix rank = DenseMatrix.OfColumns(alternativesRank[0].Count, alternativesRank.Count, alternativesRank);
            //Console.WriteLine("==============================");
            //Console.WriteLine(rank.ToMatrixString(rank.RowCount, rank.ColumnCount));
            return createFullRank(result);
        }
        
        
        
        private DenseVector calculateNormalizedWeights(DenseMatrix matrix)
        {
            //Console.WriteLine("Criteria preference matrix");
            //Console.WriteLine(matrix.ToMatrixString(matrix.RowCount, matrix.ColumnCount));
            var matrixSize = matrix.ColumnCount;
            //Console.WriteLine("size: " + matrixSize);
            var matrixBasicValues = matrix;
            matrix = (DenseMatrix)matrix.Multiply(matrixBasicValues);
            //Console.WriteLine("Criteria preference matrix after .*");
            //Console.WriteLine(matrix.ToMatrixString(matrix.RowCount, matrix.ColumnCount));
            double[] summedRowValues = new double[matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                summedRowValues[i] = matrix.Row(i).Sum();
            }
            var summedRowsValuesVector = DenseVector.OfEnumerable(summedRowValues);
            //Console.WriteLine("Summed rows");
            //Console.WriteLine(summedRowsValuesVector.ToVectorString(matrixSize, 100));
            DenseVector normalizedWeights = (DenseVector)summedRowsValuesVector.Normalize(1);
            //Console.WriteLine("normalize summed rows");
            //Console.WriteLine(normalizedWeights.ToVectorString(matrixSize, 100));
            DenseVector oldNormlaizedWeights;
            do  
            {
                oldNormlaizedWeights = normalizedWeights;
                matrix = (DenseMatrix)matrix.Multiply(matrixBasicValues);
                for (int i = 0; i < matrixSize; i++)
                {
                    summedRowValues[i] = matrix.Row(i).Sum();
                }
                summedRowsValuesVector = DenseVector.OfEnumerable(summedRowValues);
                normalizedWeights = (DenseVector)summedRowsValuesVector.Normalize(1);

                var weightsIterationDifference = oldNormlaizedWeights.Subtract(normalizedWeights).AbsoluteMaximum();

            } while (oldNormlaizedWeights.Subtract(normalizedWeights).Max() < 0.0001);
            
            //Console.WriteLine("normalize summed rows");
            //Console.WriteLine(normalizedWeights.ToVectorString(matrixSize, 100));
            return normalizedWeights;
        }

        private class AlternativeData : IComparable
        {
            public double id { get; set; }
            public double weight { get; set; }
            public AlternativeData(double _id, double _weight)
            {
                id = _id;
                weight = _weight;
            }


            public int CompareTo(object obj)
            {
                if (obj is AlternativeData)
                {
                    return ((obj as AlternativeData).weight.CompareTo(this.weight));

                }
                throw new ArgumentException("Object is not an AlternativeData");
            }
        };

        private double[][] createFullRank(DenseVector alternativesWeights)
        {
            List<AlternativeData> rank = new List<AlternativeData>();
            List<double[]> finalRank = new List<double[]>();
            for (int i = 0; i < alternativesWeights.Count; i++)
            {
                rank.Add(new AlternativeData(i + 1, alternativesWeights.ElementAt(i)));
            }
            rank.Sort();
            int rankPosition = 1;
            foreach (AlternativeData ad in rank)
            {
                //Console.WriteLine("AD: " + ad.id + " " + ad.weight);
                finalRank.Add(new double[] { ad.id, rankPosition });
                rankPosition++;
            }
            var result = finalRank.OrderBy(a => a.GetValue(0));
            return result.ToArray();
        }
    }
}
