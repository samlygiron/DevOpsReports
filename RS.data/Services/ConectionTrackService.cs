using RS.data.Context;
using RS.data.Interfaces;
using RS.data.Model;

namespace RS.data.Services
{
    public class ConectionTrackService : IConectionTrackService
    {
        private readonly RSContext _context;

        public ConectionTrackService(RSContext context)
        {
            _context = context;
        }

        public void Insert(ConectionTrack obj)
        {
            _context.ConectionTracks.Add(obj);
            _context.SaveChanges();

        }
    }
}
