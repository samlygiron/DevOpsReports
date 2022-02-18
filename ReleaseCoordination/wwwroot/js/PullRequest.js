const PullRequest = {

    getPullRequestList: async (n, state) => {

        //actives
        let lstActive = await fetch(`${gitBaseUrl}pullrequests`);
        n -= lstActive.value.length;

        let lstComplete = await fetch(`${gitBaseUrl}pullrequests?searchCriteria.status=completed&$skip=0&$top=${n}`);

        return [...lstActive.value, ...lstComplete.value];
    },

    getWorkItems: (lstPR, detail) => {
        return new Promise((resolve, reject) => {
            let s = lstPR.length - 1;
            for (let pr of lstPR) {
                if (pr.pullRequestId === undefined) {
                    if ((s--) == 0)
                        resolve(lstPR);
                }
                else {
                    fetch(`${gitBaseUrl}repositories/${pr.repository.id}/pullRequests/${pr.pullRequestId}/workitems`)
                        .then((lstWI) => {
                            if (detail) {
                                pr.workItem = [];
                                if (lstWI !== undefined) {
                                    pr.lstWIDetail = lstWI.value;
                                    for (let widet of pr.lstWIDetail) {
                                        fetch(`${widet.url}`)
                                            .then((wiDetail) => {
                                                widet.fields = wiDetail.fields !== undefined ? wiDetail.fields : {};
                                            });
                                    }
                                }
                            }

                            if (lstWI !== undefined)
                                pr.lstWI = lstWI.value.map((wi) => { return parseInt(wi.id) });
                            if ((s--) == 0)
                                resolve(lstPR);
                        });
                }
            }
        });
    }
};
