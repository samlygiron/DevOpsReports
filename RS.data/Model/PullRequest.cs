namespace RS.data.Model
{
    public class PullRequest
    {
        /*
        public Repository repository { get; set; }
        public int pullRequestId { get; set; }
        public int codeReviewId { get; set; }
        public string status { get; set; }
        public CreatedBy createdBy { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime closedDate { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string sourceRefName { get; set; }
        */
        public string targetRefName { get; set; }
        /*
        public string mergeStatus { get; set; }
        public bool isDraft { get; set; }
        public string mergeId { get; set; }
        public LastMergeSourceCommit lastMergeSourceCommit { get; set; }
        public LastMergeTargetCommit lastMergeTargetCommit { get; set; }
        public LastMergeCommit lastMergeCommit { get; set; }
        public List<Reviewer> reviewers { get; set; }
        public string url { get; set; }
        public CompletionOptions completionOptions { get; set; }
        public bool supportsIterations { get; set; }
        public DateTime completionQueueTime { get; set; }
        public ClosedBy closedBy { get; set; }
        public string artifactId { get; set; }
        */
    }

    /*
    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string state { get; set; }
        public int revision { get; set; }
        public string visibility { get; set; }
        public DateTime lastUpdateTime { get; set; }
    }

    public class Repository
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public Project project { get; set; }
        public int size { get; set; }
        public string remoteUrl { get; set; }
        public string sshUrl { get; set; }
        public string webUrl { get; set; }
        public bool isDisabled { get; set; }
    }

    public class Avatar
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Avatar avatar { get; set; }
    }

    public class CreatedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class LastMergeSourceCommit
    {
        public string commitId { get; set; }
        public string url { get; set; }
    }

    public class LastMergeTargetCommit
    {
        public string commitId { get; set; }
        public string url { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }
    }

    public class Committer
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime date { get; set; }
    }

    public class LastMergeCommit
    {
        public string commitId { get; set; }
        public Author author { get; set; }
        public Committer committer { get; set; }
        public string comment { get; set; }
        public bool commentTruncated { get; set; }
        public string url { get; set; }
    }

    public class Reviewer
    {
        public string reviewerUrl { get; set; }
        public int vote { get; set; }
        public bool hasDeclined { get; set; }
        public bool isFlagged { get; set; }
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
    }

    public class CompletionOptions
    {
        public string mergeCommitMessage { get; set; }
        public bool deleteSourceBranch { get; set; }
        public bool squashMerge { get; set; }
        public string mergeStrategy { get; set; }
        public bool transitionWorkItems { get; set; }
        public List<object> autoCompleteIgnoreConfigIds { get; set; }
    }

    public class ClosedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }
    */
}
