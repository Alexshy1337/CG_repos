using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PolyLine3D: IModel
    {
        private List<Vector3> vertices = new List<Vector3>();
        public Color color = Color.Black;

        public PolyLine3D(IList<Vector3> v, Color LineColor, bool closed = false)
        {
            if(v.Count>0)
            {
                vertices.AddRange(v);
                color = LineColor;
                if (closed)
                    vertices.Add(v[0]);
            }
        }

        public PolyLine3D(IList<Vector3> v, bool closed = false)
        {
            vertices.AddRange(v);
            if (closed)
                vertices.Add(v[0]);
        }

        public List<Vector3> Vertices
        {
            get { return vertices; }
        }

        public List<PolyLine3D> GetLines()
        {
            return new List<PolyLine3D>() { this };
        }
    }
}
