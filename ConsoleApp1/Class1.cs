using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coordinate
    {
        int x;
        int y;
    }

    public interface IList
    {
        Coordinate get(int i);
        void add(Coordinate point);
        int size();
        void remove(Coordinate point);
        void remove(int i);
    }

    public class DimaList : IList
    {
        private Coordinate[] coordinates;
        private int length;
        public DimaList() : this(15)
        {
        }
        public DimaList(int size)
        {
            coordinates = new Coordinate[size];
            this.length = size;
        }
        public void add(Coordinate point)
        {
            if (coordinates.Length == length)
            {
                Coordinate[] newOne = new Coordinate[length * 2];
                Array.Copy(coordinates, 0, newOne, 0, length);
                this.coordinates = newOne;
            }
            coordinates[length] = point;
            length++;
        }

        public Coordinate get(int i)
        {
            if (i < 0 || i >= length)
            {
                throw new ArgumentException();
            }
            return coordinates[i];
        }

        public void remove(Coordinate point)
        {
            throw new NotImplementedException();
        }

        public void remove(int i)
        {
            throw new NotImplementedException();
        }

        public int size()
        {
            return length;
        }
    }
}
