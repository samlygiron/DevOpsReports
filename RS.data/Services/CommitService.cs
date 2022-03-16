using RS.data.Context;
using RS.data.Filters;
using RS.data.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RS.data.Services
{
    public class CommitService : ICommitService
    {
        private readonly RSContext _context;

        public CommitService(RSContext context)
        {
            _context = context;
        }

        public void Insert(Commit obj)
        {
            _context.SaveChanges();

        }

        public void InsertComplete(List<Commit> lst)
        {
            string releaseName = lst.FirstOrDefault().Release.Name;

            Release release = new Release();

            foreach (Commit commit in lst)
            {
                if (commit.Release.Name != release.Name)
                {
                    release = _context.Releases.Where(r => r.Name == commit.Release.Name).FirstOrDefault();
                }

                if (release == null)
                {
                    release = new Release()
                    {
                        Name = commit.Release.Name,
                        Date = commit.Release.Date
                    };

                    _context.Releases.Add(release);
                    _context.SaveChanges();
                }

                foreach (WorkItem workItem in commit.WorkItems)
                {
                    _context.WorkItems.Add(workItem);
                }

                commit.Release = release;
                _context.Commits.Add(commit);
            }

            _context.SaveChanges();

        }

        public IEnumerable List(CommitFilter filter)
        {
            var lst = (from c in _context.Commits
                       join w in _context.WorkItems on c.CommitId equals w.CommitId
                       join r in _context.Releases on c.ReleaseId equals r.ReleaseId
                       where w.WorkItemId == (filter.WorkItemId == 0 ? w.WorkItemId : filter.WorkItemId)
                       orderby r.Date descending, c.CommitId
                       select
                       new Commit
                       {
                           CommitId = c.CommitId,
                           Comment = c.Comment,
                           PullRequest = c.PullRequest,
                           Release = c.Release,
                           ReleaseId = c.ReleaseId,
                           Sha = c.Sha,
                           WorkItems = c.WorkItems
                       }
                       ).ToList().GroupBy(o => o.CommitId).Select(o => o.FirstOrDefault());

            return lst;
        }
    }

    public interface ICommitService
    {
        void Insert(Commit obj);
        void InsertComplete(List<Commit> lst);
        IEnumerable List(CommitFilter commit);
    }
}
