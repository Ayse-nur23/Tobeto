using Core.DataAccess.Dynamic;
using Core.DataAccess.Repositories;
using Entities.Concretes;
using Entities.Dto;

namespace DataAccess.Absracts;

public interface ICourseDal : IRepository<Course, int>, IAsyncRepository<Course, int>
{
    //Task<IPaginate<CourseDetailDto>> GetCourseDetails();
}
