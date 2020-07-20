using EduSmart.Application.Common.Interfaces;
using System;

namespace EduSmart.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
