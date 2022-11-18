using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class TexteTransformationService
    {
        public event Action<string?> TransformationTermine;
        public void Transformation(string? str)
        {
            str = Transforme(str);
            TransformationTermine(str);
        }

        public string Transforme(string str)
        {
            return str.ToUpper();
        }
    }
}
