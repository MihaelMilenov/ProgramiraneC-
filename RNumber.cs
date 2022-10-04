using System;
using System.Collections.Generic;
using System.Text;

namespace УООП_03._2022
{
    class RNumber
    {
        private int chislitel;
        private int znamenatel;
        public int Chislitel
        {
            set { chislitel = value; }
            get { return chislitel; }
        }

        public int Znamenatel
        {
            get { return znamenatel; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Znamenatel cannot be 0");
                    znamenatel = value;
                }
            }
        }
        public RNumber(int chislitel, int znamenatel)
        {
            this.Chislitel = chislitel;
            this.Znamenatel = znamenatel;
        }
        public RNumber() : this(0, 1)
        { }
        public override string ToString()
        {
            return chislitel + "/" + znamenatel;
        }
        public RNumber Add(RNumber rn)
        {
            int ch;
            int z;
            ch = this.chislitel * rn.znamenatel + rn.chislitel * this.znamenatel;
            z = this.znamenatel * rn.znamenatel;
            return new RNumber(ch, z);
        }
        public RNumber Substruct(RNumber rn)
        {
            int ch;
            int z;
            ch = this.chislitel * rn.znamenatel - rn.chislitel * this.znamenatel;
            z = this.znamenatel * rn.znamenatel;
            return new RNumber(ch, z);
        }
        public RNumber Multiply(RNumber rn)
        {
            int ch;
            int z;
            ch = this.chislitel * rn.chislitel;
            z = this.znamenatel * rn.znamenatel;
            return new RNumber(ch, z);
        }
        public RNumber Devide(RNumber rn)
        {
            int ch;
            int z;
            ch = this.chislitel * rn.chislitel;
            z = this.znamenatel * rn.chislitel;
            return new RNumber(ch, z);
        }
    }
}
