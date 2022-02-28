using System.Collections.Generic;

namespace Lesson23.Models
{
    public class PolygonAreaICompareble : IComparer<IPolygon>
    {
        int IComparer<IPolygon>.Compare(IPolygon x, IPolygon y)
        {
            if (x.GetArea() > y.GetArea()) return 1;
            else if (x.GetArea() < y.GetArea()) return -1;
            else return 0;

        }
    }
}
