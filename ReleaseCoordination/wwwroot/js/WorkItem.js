const WorkItem = {

    getDetail: (lstWIds) => {
        return new Promise((resolve, reject) => {
            fetch(`${witBaseUrl}&ids=${lstWIds.slice(0, 200).toString()}`).then((lstWI) => {
                resolve(lstWI);
            });
        });
    }
};
