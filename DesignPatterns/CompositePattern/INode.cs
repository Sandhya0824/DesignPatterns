using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface INode
    {
        string GetName();
        List<INode> GetNodes();
    }
}
