using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
	public class HotelListingDBContext : DbContext
	{
		public HotelListingDBContext(DbContextOptions options) : base(options)
		{
		
		}

	}
}
