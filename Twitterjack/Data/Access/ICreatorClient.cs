using System.Collections.Generic;
using System.Threading.Tasks;
using Owlbear.Model;

namespace Twitterjack.Data.Access
{
    public interface ICreatorClient
    {
        public Task<List<Creator>> GetCreators();
    }
}