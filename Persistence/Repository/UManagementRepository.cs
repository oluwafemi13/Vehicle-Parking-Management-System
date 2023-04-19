using DataAccess.Data;
using DataAccess.Persistence.Interface;
using DataAccess.Persistence.Repository;
using System.Drawing.Text;
using Vehicle_Parking_Management_System.Models;
using Vehicle_Parking_Management_System.Persistence.Interface;

namespace Vehicle_Parking_Management_System.Persistence.Repository
{
    public class UManagementRepository : BaseRepository<UManagement>, IUManagementRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public UManagementRepository(DatabaseContext db, IUnitOfWork unitOfWork) : base(db)
        {
            _unitOfWork = unitOfWork;   
        }   


    }
}
