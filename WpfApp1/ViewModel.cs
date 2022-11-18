using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ViewModel
    {
        public event Action<string?> TransformationTermine;
        public void Transformation(string? str)
        {
            str = str.ToUpper();
            TransformationTermine(str);
        }
    }
}
