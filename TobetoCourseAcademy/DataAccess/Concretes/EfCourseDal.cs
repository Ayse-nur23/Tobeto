

using Core.DataAccess.Dynamic;
using Core.DataAccess.Repositories;
using Core.Entities;
using DataAccess.Absracts;
using DataAccess.Context;
using Entities.Concretes;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class EfCourseDal : EfRepositoryBase<Course, int, NorthwindContext>, ICourseDal
{
    public EfCourseDal(NorthwindContext context) : base(context)
    {
    }

 
    public async Task<IPaginate<CourseDetailDto>> GetCourseDetails()
    {
        int index = 0;
        int size = 20;
        using (NorthwindContext context = new NorthwindContext())
        {
            var result = await (from course in context.Courses
                                join category in context.Categories
                                on course.CategoryId equals category.Id
                                select new CourseDetailDto
                                {
                                    CategoryName = category.Name,
                                    CourseName = course.Name
                                }).ToPaginateAsync(index, size, 0);

            return result;
        }

    }
}
