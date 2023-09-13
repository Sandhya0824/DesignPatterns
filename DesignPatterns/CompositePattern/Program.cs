namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new StudentLeafNode("student1 of teacher1");
            var student2 = new StudentLeafNode("student2 of teacher1");
            var student3 = new StudentLeafNode("student3 of teacher1");
            var student4 = new StudentLeafNode("student1 of teacher2");
            var student5 = new StudentLeafNode("student2 of teacher2");
            var student6 = new StudentLeafNode("student3 of teacher2");
            var student7 = new StudentLeafNode("student1 of teacher3");
            var student8 = new StudentLeafNode("student2 of teacher3");
            var student9 = new StudentLeafNode("student3 of teacher3");

            var teacher1 = new TeacherParentNode("teacher1");
            var teacher2 = new TeacherParentNode("teacher2");
            var teacher3 = new TeacherParentNode("teacher3");

            teacher1.Add(teacher2);
            teacher2.Add(teacher3);

            teacher1.Add(student1);
            teacher1.Add(student2);
            teacher1.Add(student3);

            teacher2.Add(student4);
            teacher2.Add(student5);
            teacher2.Add(student6);

            teacher3.Add(student7);
            teacher3.Add(student8);
            teacher3.Add(student9);

            Console.WriteLine(teacher1.GetName());

            foreach(var child in teacher1.GetNodes())
            {
                PrintMembers(child);
            }
        }

        static void PrintMembers(INode node)
        {
            Console.WriteLine(node.GetName());

            if (node.GetNodes()!=null) 
            {
                foreach (var child in node.GetNodes())
                {
                    PrintMembers(child);
                }
            }
        }
    }
}