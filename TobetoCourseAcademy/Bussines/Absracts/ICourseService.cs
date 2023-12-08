using Core.DataAccess.Dynamic;
using Entities.Concretes;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absracts;

public interface ICourseService
{
    Task<IPaginate<Course>> GetListAsync();
    Task Add(Course course);
    Task Delete(Course course);
    //Task<IPaginate<CourseDetailDto>> GetCourseDetails();
}
