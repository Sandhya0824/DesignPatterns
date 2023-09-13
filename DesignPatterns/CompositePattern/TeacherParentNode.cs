using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class TeacherParentNode : INode
    {
        private readonly string _memberName;
        private readonly List<INode> _memberList;

        public TeacherParentNode(string memberName)
        {
            _memberName = memberName;
            _memberList = new List<INode>();
        }

        public string GetName()
        {
            return _memberName;
        }

        public List<INode> GetNodes()
        {
            return _memberList;
        }

        public void Add(INode node)
        {
            _memberList.Add(node);
        }
    }
}
