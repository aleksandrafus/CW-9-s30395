using PrescriptionApplication.Data;
using PrescriptionApplication.DTOs;

namespace PrescriptionApplication.Services;

public interface IDbService
{
    
}

public class DbService(AppDbContext data) : IDbService
{
    
}