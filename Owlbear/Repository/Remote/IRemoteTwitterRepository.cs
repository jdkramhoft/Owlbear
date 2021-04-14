using System.Threading.Tasks;
using Owlbear.Model;

namespace Owlbear.Repository.Remote
{
    public interface IRemoteTwitterRepository
    {
        public Task<Twitter> GetTwitter(string handle);
    }
}