using System.Threading.Tasks;
using Owlbear.Model;

namespace Owlbear.Repository.Remote
{
    public interface IRemoteTwitchRepository
    {
        public Task<Twitch> GetTwitch(string handle);
    }
}