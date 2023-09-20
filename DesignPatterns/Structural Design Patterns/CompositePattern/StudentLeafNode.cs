using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class StudentLeafNode : INode
    {
        private readonly string _name;

        public StudentLeafNode(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public List<INode> GetNodes()
        {
            return null;
        }
    }
}
