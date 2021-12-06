using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greads
{
    public class Proffesor
    {
        public string proffesorName;
        public string studentName;
        public int studentId;
        public int[] studentGrade;

        public Proffesor()
        {

        }

        public Proffesor(string proffesorName, string studentName, int studentId, int[] studentGrade)
        {
            this.proffesorName = proffesorName;
            this.studentName = studentName;
            this.studentId = studentId;
            this.studentGrade = studentGrade;
        }
    }
}
