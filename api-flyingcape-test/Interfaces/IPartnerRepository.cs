using api_flyingcape_test.Models;

namespace api_flyingcape_test.Interfaces;

public interface IPartnerRepository
{
    ICollection<Partner> GetPartners(string keyword = "");
}