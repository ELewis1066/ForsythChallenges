using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public abstract class Problem
    {
        protected Problem() { }

        public abstract string Name { get; }
        public abstract void Execute();
    }
}
