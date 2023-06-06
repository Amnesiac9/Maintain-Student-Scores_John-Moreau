using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintain_Student_Scores_John_Moreau
{
    [Serializable]
    public class StudentList : IEnumerable<Student>
    {
        private List<Student> studentList = new List<Student>();

        public int Count => studentList.Count;

        public Student this[int i] => studentList[i];

        public void Add(Student student)
        {
            studentList.Add(student);
            SortStudentList();
        }

        public void Remove(Student student)
        {
            studentList.Remove(student);
        }

        public void RemoveAt(int index)
        {
            studentList.RemoveAt(index);
        }

        public int IndexOf(Student student) => studentList.IndexOf(student);

        public void Sort() => studentList.Sort();

        public IEnumerator<Student> GetEnumerator() => studentList.GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => studentList.GetEnumerator();

        private void SortStudentList() => studentList.Sort();

    }
}
