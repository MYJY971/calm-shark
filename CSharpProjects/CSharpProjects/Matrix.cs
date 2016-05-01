using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects
{
    class Matrix
    {
        private float[,] _values;
        private int _row, _col, _size;
        
        public Matrix(int row, int col)
        {
            this._row = row;
            this._col = col;
            this._values = new float[this._row, this._col];
            computeSize();
        }

        public Matrix(int n)
        {
            this._row = n;
            this._col = n;
            this._values = new float[this._row, this._col];
            computeSize();
        }

        private void computeSize()
        {
            this._size = this._row * this._col;
        }

        public override string ToString()
        {
            string stringValues = "\n";

            for (int r = 0; r < _row; ++r)
            {
                for (int c = 0; c < _col; ++c)
                {
                    if (c != _col - 1)
                        stringValues = stringValues + " " + _values[r, c];
                    else
                        stringValues = stringValues + " " + _values[r, c] + "\n";
                }
            }

            return stringValues;

        }
    }
}
