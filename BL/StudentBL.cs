using BasicAPI.Data;
using BasicAPI.Model;

namespace BasicAPI.BL
{
    public class StudentBL
    {
        private readonly AppDbCOntext dbCOntext;
        public StudentBL(AppDbCOntext cOntext)
        {
            this.dbCOntext = cOntext;
        }
        public IEnumerable<Student> GetStudents()
        {

            return dbCOntext.Students;

        }
    }
}
