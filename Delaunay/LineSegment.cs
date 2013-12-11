using System.Drawing;

namespace Delaunay
{

    public class LineSegment
    {
        public static float compareLengths_MAX(LineSegment segment0, LineSegment segment1)
        {
            float length0 = Utilities.Distance(segment0.p0, segment0.p1);
            float length1 = Utilities.Distance(segment1.p0, segment1.p1);
            if (length0 < length1)
            {
                return 1;
            }
            if (length0 > length1)
            {
                return -1;
            }
            return 0;
        }

        public static float compareLengths(LineSegment edge0, LineSegment edge1)
        {
            return -compareLengths_MAX(edge0, edge1);
        }

        public PointF p0;
        public PointF p1;

        public LineSegment(PointF p0, PointF p1)
        {
            this.p0 = p0;
            this.p1 = p1;
        }

    }
}