using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkIndexersAndProperties
{
    public class RangeOfArray
    {
        private int[] _array;
        private int _size;
        private int _start;
        private int _end;
        public RangeOfArray()
        {

        }
        public RangeOfArray(int size)
        {

            Size = size;
            Start = 0;
            End = Size - 1;
            _array = new int[Size];
        }
        public RangeOfArray(int start ,int end)
        {
            Start = start;
            End = end;
            Size = end - start + 1;        
            _array = new int[Size];
        }

        public int Start
        {
            get { return _start; }
            set
            {
                if(value > End)
                {
                    _start = value;
                }
            }
        }
        public int End
        {
            get { return _end; }
            set
            {
                if(value < Start)
                {
                    _end = value;
                }
            }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public int this[int i]
        {
            get
            {
                return _array[Math.Abs(i) - Math.Abs(Start)];
            }
            set
            {
                _array[Math.Abs(i) - Math.Abs(Start)] = value;
            }
        }

        

       


    }
}
