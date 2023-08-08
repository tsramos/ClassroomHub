using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;

namespace ClassroomHub.Data.Repositories
{
    public class DeliveryRepository : BaseRepository<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(Context context) : base(context)
        {
        }
    }
}
