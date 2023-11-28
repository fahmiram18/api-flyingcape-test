using api_flyingcape_test.Data;
using api_flyingcape_test.Interfaces;
using api_flyingcape_test.Models;
using Microsoft.IdentityModel.Tokens;

namespace api_flyingcape_test.Repository;

public class PartnerRepository : IPartnerRepository
{
    private DataContext _context;

    public PartnerRepository(DataContext context)
    {
        _context = context;
    }


    public ICollection<Partner> GetPartners(string keyword = "")
    {
        if (keyword.IsNullOrEmpty())
        {
            return _context.Partners.ToList();
        }
        else
        { 
            return _context.Partners.Where(p => p.Name.Contains(keyword)).ToList();
        }

    }
}