using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto;

public class CourseDetailDto
{
    public string CourseName { get; set; }
    public string CategoryName { get; set; }
    public string CourseDescription { get; set; }
}
