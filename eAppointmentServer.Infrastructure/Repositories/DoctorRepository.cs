using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using eAppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace eAppointmentServer.Infrastructure.Repositories
{
 
        public sealed class DoctorRepository : Repository<Doctor, ApplicationDbContext>, IDoctorRepository
        {
            public DoctorRepository(ApplicationDbContext context) : base(context)
            {
            }
        }
   
}
