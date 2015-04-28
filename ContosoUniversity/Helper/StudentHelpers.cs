using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Helper
{
    public static class StudentHelpers
    {

       
        public static double CalculateGPA(Student student)
        {
            var gpa = 0.0;
            var points = 0.0;
            var totalCredits = 0.0;
            var studentClasses = student.Enrollments;
            foreach (var item in studentClasses)
            {
                var letter = item.Grade;
                var credit = item.Course.Credits;

                switch (letter)
                {
                    case Grade.A:
                        points += (4 * credit);
                        totalCredits += credit;
                        break;
                    case Grade.B:
                        points += (3 * credit);
                        totalCredits += credit;
                        break;
                    case Grade.C:
                        points += (2 * credit);
                        totalCredits += credit;
                        break;
                    case Grade.D:
                        points += credit;
                        totalCredits += credit;
                        break;
                    case Grade.F:
                        totalCredits += credit;
                        break;
                    default:
                        break;
                }
            }

            if (points == 0 || totalCredits == 0)
            {
                return 0;
            }
            else
            {
                gpa = Math.Round((points / totalCredits), 2, MidpointRounding.AwayFromZero);
                return gpa;
            }

        }// End CalculateGPA
        
    }
}