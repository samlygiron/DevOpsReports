const authorization = "Basic " + btoa(":" + PAT);
const organizationName = OrganizationName;
const projectName = ProjectName;
const repoId = RepoId;
const gitBaseUrl = `https://dev.azure.com/${organizationName}/${projectName}/_apis/git/`;
const wiBaseUrl = `https://${organizationName}.visualstudio.com/${projectName}/_workitems/edit/`;
const prBaseUrl = `https://${organizationName}.visualstudio.com/${projectName}/_git/`;
const witBaseUrl = `https://dev.azure.com/${organizationName}/${projectName}/_apis/wit/workitems?api-version=6.0`;
const buildBaseUrl = `https://dev.azure.com/${organizationName}/${projectName}/_apis/build/builds`;
const buildResultUrl = `https://${organizationName}.visualstudio.com/${projectName}/_build/results?buildId=`;
const commitBaseUrl = `https://${organizationName}.visualstudio.com/${projectName}/_git/${CommitURL}`;
const teamBaseUrl = `https://dev.azure.com/${organizationName}/_apis/projects/${projectName}/teams/${TeamURL}`;
const teamQABaseUrl = `https://dev.azure.com/${organizationName}/_apis/projects/${projectName}/teams/${QATeamURL}`;
const teamSABaseUrl = `https://dev.azure.com/${organizationName}/_apis/projects/${projectName}/teams/${SATeamURL}`;
const branchBaseUrl = `https://dev.azure.com/${organizationName}/${projectName}/_apis/git/repositories/${repoId}/refs?api-version=6.0`;

const apiUrl = ApiUrl;
const authorizationApi = "Basic " + btoa(ApiCredential);

function fetchApi(url, type) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url: url,
            type: type === undefined ? 'GET' : 'POST',
            beforeSend: function (xhr) {
                if (type === undefined)
                    xhr.setRequestHeader("Authorization", authorizationApi);
            },
            error: function () { resolve(); },
            success: function (resp) { resolve(resp); }
        });
    });
}

function fetch(url, type) {
    return new Promise((resolve, reject) => {
        $.ajax({
            url: url,
            type: type === undefined ? 'GET' : 'POST',
            beforeSend: function (xhr) {
                if (type === undefined)
                    xhr.setRequestHeader("Authorization", authorization);
            },
            error: function () { resolve(); },
            success: function (resp) { resolve(resp); }
        });
    });
}

function formatLink(url, text){
    return text == null ? '' : `<a href='${url}' target='_blank'> ${text} </a>`;
}

function formatDate(date) {
    return date == undefined ? null : moment(date).format('MM/D/YYYY'); 
}

function formatDatetime(date) {
    return date == undefined ? null : moment(date).format('MM/D/YYYY HH:mm');
}

function customize() {
    if (isWidget) {
        $(".mn-navbar").hide();
        $(".widget").css("height", "830px");
    }
    else {
        $(".is-widget").hide();
        $("#collapse").addClass("show")
    }
}

function CharacterTrim50(value) {
    if (value !== undefined && value.length > 50) {
        return value.substring(0, 50) + "...";
    }
    return value;
}