using Studing.Domain.Graduation;
using Studing.Domain.Student;

namespace Studing.Application.Student
{
    public class SchoolStudent : IStudent
    {
        public void Study()
        {
            throw new System.NotImplementedException();
        }

        public void Graduate(IGraduationCertificate certificate)
        {
            throw new System.NotImplementedException();
        }
    }
}