using System.Threading.Tasks;
using Owlbear.Model;

namespace Owlbear.Repository.Remote
{
    public interface IRemoteYoutubeRepository
    {
        public Task<Youtube> GetYoutube(string channelId);
    }
}