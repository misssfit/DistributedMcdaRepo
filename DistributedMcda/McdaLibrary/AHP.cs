using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra.Double;

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
                Input = new List<string> { "criteriaPreferenceMatrix", "alternativesPreferenceMatrixes" },
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
                var criteriaPreferenceData = input.Single(p => p.Key == "criteriaPreferenceMatrix").Value;
                
                criteriaPreferenceMatrix = DenseMatrix.OfArray(criteriaPreferenceData.ToMultiD());

                //for (int i = 1; i <= criteriaPreferenceMatrix.ColumnCount; i++)
                //{
                //    var alternativesPreferenceMatrix = input.Single(p => p.Key == ("alternativesPreferenceMatrixes" + i)).Value;
                //    alternativesPreferenceMatrixes.Add(DenseMatrix.OfArray(alternativesPreferenceMatrix.ToMultiD()));
                //}

            }
            catch (Exception)
            {
                throw new Exception("Cannot retreive parameters from input list");
            }

            

            
            return new double[1][];
        }
        
        private DenseVector calculateNormalizedWeights(DenseMatrix)
        {
            Console.WriteLine("Criteria preference matrix");
            Console.WriteLine(criteriaPreferenceMatrix.ToMatrixString(criteriaPreferenceMatrix.RowCount, criteriaPreferenceMatrix.ColumnCount));
            var matrixSize = criteriaPreferenceMatrix.ColumnCount;
            Console.WriteLine("size: " + matrixSize);

            var criteriaPreferenceMatrixBasicValues = criteriaPreferenceMatrix;

            criteriaPreferenceMatrix = (DenseMatrix)criteriaPreferenceMatrix.Multiply(criteriaPreferenceMatrixBasicValues);

            Console.WriteLine("Criteria preference matrix after .*");
            Console.WriteLine(criteriaPreferenceMatrix.ToMatrixString(criteriaPreferenceMatrix.RowCount, criteriaPreferenceMatrix.ColumnCount));

            double[] summedRowValues = new double[matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                summedRowValues[i] = criteriaPreferenceMatrix.Row(i).Sum();
            }
            var summedRowsValuesVector = DenseVector.OfEnumerable(summedRowValues);
            Console.WriteLine("Summed rows");
            Console.WriteLine(summedRowsValuesVector.ToVectorString(matrixSize, 100));

            DenseVector normalizedWeights = (DenseVector)summedRowsValuesVector.Normalize(1);
            Console.WriteLine("normalize summed rows");
            Console.WriteLine(normalizedWeights.ToVectorString(matrixSize, 100));

            DenseVector oldNormlaizedWeights;

            //do  
            //{
            //    oldNormlaizedWeights = normalizedWeights;
            //    criteriaPreferenceMatrix = (DenseMatrix)criteriaPreferenceMatrix.Multiply(criteriaPreferenceMatrixBasicValues);
            //    for (int i = 0; i < matrixSize; i++)
            //    {
            //        summedRowValues[i] = criteriaPreferenceMatrix.Row(i).Sum();
            //    }
            //    summedRowsValuesVector = DenseVector.OfEnumerable(summedRowValues);
            //    normalizedWeights = (DenseVector)summedRowsValuesVector.Normalize(1);

            //} while();


            return normalizedWeights;
        }
    }
}
