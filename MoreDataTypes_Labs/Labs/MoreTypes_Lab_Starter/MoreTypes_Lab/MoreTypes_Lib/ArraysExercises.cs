using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            return contents.ToArray();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            string[,,] array3D = new string[length1, length2, length3];
            int index = 0;

            if (contents.Count != length1 * length2 * length3)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    for (int k = 0; k < length3; k++)
                    {
                            array3D[i, j, k] = contents[index++];
                        }
                        
                }
            }
            return array3D;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            string[][] arrayJagged2D = new string[2][];
            arrayJagged2D[0] = new string[countRow1];
            arrayJagged2D[1] = new string[countRow2];

            if (contents.Count < countRow1 + countRow2)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }

            int index = 0;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < countRow1; j++)
                    {
                        arrayJagged2D[0][j] = contents[index++];
                    }
                }
                else
                {
                    for (int j = 0; j < countRow2; j++)
                    {
                        arrayJagged2D[1][j] = contents[index++];
                    }
                }
            }
            return arrayJagged2D;
        }
    }
}
