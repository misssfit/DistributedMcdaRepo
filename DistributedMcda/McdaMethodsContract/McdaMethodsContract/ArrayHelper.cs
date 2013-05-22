using System.Linq;

namespace McdaMethodsContract
{
    public static class ArrayHelper
    {
        public static T[,] ToMultiD<T>(this T[][] jArray)
        {
            int i = jArray.Count();
            int j = jArray.Select(x => x.Count()).Aggregate(0, (current, c) => (current > c) ? current : c);


            var mArray = new T[i, j];

            for (int ii = 0; ii < i; ii++)
            {
                for (int jj = 0; jj < j; jj++)
                {
                    mArray[ii, jj] = jArray[ii][jj];
                }
            }

            return mArray;
        }

        public static T[][] ToJagged<T>(this T[,] mArray)
        {
            var cols = mArray.GetLength(0);
            var rows = mArray.GetLength(1);
            var jArray = new T[cols][];
            for (int i = 0; i < cols; i++)
            {
                jArray[i] = new T[rows];
                for (int j = 0; j < rows; j++)
                {
                    jArray[i][j] = mArray[i, j];
                }
            }
            return jArray;
        }
    }
}
