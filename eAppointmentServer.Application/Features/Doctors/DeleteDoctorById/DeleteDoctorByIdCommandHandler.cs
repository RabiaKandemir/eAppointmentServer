﻿using eAppointmentServer.Application.Features.Doctors.DeleteDoctorById;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

public sealed class DeleteDoctorByIdCommandHandler(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteDoctorByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteDoctorByIdCommand request, CancellationToken cancellationToken)
    {
        Doctor? doctor = await doctorRepository.GetByExpressionAsync(p => p.Id == request.id, cancellationToken);
        if (doctor == null)
        {
            return Result<string>.Failure("Docotr not found");
        }
        doctorRepository.Delete(doctor);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Doctor delete is successful";
    }
}