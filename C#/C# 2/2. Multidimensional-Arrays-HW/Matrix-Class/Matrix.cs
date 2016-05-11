public class Matrix
{
    private int[,] matrix; //field

    public int Rows //property
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Columns //property
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public Matrix(int rows, int cols) //constructor
    {
        this.matrix = new int[rows, cols];
    }

    //indexer
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    // ToString()
    public override string ToString()
    {
        string answer = null;

        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Columns; j++)
            {
                answer = answer + this.matrix[i, j] + " ";
            }

            answer = answer + "\n";
        }

        return answer;
    }

    public static Matrix Add(Matrix m1, Matrix m2) // without check for correct input data
    {
        Matrix result = new Matrix(m1.Rows, m1.Columns);

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }

        return result;
    }

    // subtracting
    public static Matrix Substract(Matrix m1, Matrix m2) // without check for correct input data
    {
        Matrix result = new Matrix(m1.Rows, m1.Columns);

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }

        return result;
    }

    // multiplying
    public static Matrix Multiply(Matrix m1, Matrix m2) // without check for correct input data
    {
        Matrix result = new Matrix(m1.Rows, m2.Columns);

        for (int row = 0; row < m1.Rows; row++)
        {
            for (int col = 0; col < m2.Columns; col++)
            {
                int temp = 0;

                for (int currentNumbers = 0; currentNumbers < m1.Columns; currentNumbers++)
                {
                    temp += m1[row, currentNumbers] * m2[currentNumbers, col];
                }

                result[row, col] = temp;
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        return Matrix.Multiply(m1, m2);
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        return Matrix.Add(m1, m2);
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        return Matrix.Substract(m1, m2);
    }

}