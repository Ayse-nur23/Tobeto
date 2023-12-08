using Business.Absracts;
using Core.DataAccess.Dynamic;
using DataAccess.Absracts;
using Entities.Concretes;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public async Task Add(Course course)
    {
        await _courseDal.AddAsync(course);
    }
    public async Task Delete(Course course)
    {
        await _courseDal.DeleteAsync(course, true);
    }
    //public async Task<IPaginate<CourseDetailDto>> GetCourseDetails()
    //{
    //    return await _courseDal.GetCourseDetails();
    //}

    public async Task<IPaginate<Course>> GetListAsync()
    {
        return await _courseDal.GetListAsync();
    }
}
