﻿using eAppointmentServer.Domain.Entities;
using GenericRepository;

namespace eAppointmentServer.Domain.Repositories
{
    public interface IAppoinmentRepository : IRepository<Appointment>
    {
    }
}
