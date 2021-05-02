using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Owlbear.Model;
using Owlbear.Repository;

namespace Owlbear.Service
{
    public class CreatorRecordService : ICreatorRecordService
    {

        private readonly ICreatorRecordRepository _recordRepository;

        public CreatorRecordService(ICreatorRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public async Task<List<CreatorRecord>> GetCreatorHistoryAsync(int id)
        {
            return await _recordRepository.GetAll()
                .Where(record => record.CreatorId == id)
                .OrderByDescending(record => record.Date)
                .ToListAsync();
        }
    }
}