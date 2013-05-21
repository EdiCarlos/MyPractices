
function GetAthletesByWeight()
{
    var service = document.getElementById("txtService").value;
    Athletes.GetAthletesByService(service, OnGetAthletesByServiceComplete, 
                                           OnGetAthletesByServiceTimeOut,
                                           OnGetAthletesByServiceError);    
}

function OnGetAthletesByServiceComplete(athletesList)
{
    var result = "";
    
    for (i=0; i < athletesList.length; i++)
    {
        result = result + athletesList[i].Name + "<br />";
    }
    $get('ResDiv').innerHTML = result;
}

function OnGetAthletesByServiceTimeOut(response)
{
    alert("TIMEOUT");
}

function OnGetAthletesByServiceError(response)
{
    alert("OnError - Exception");
    alert(response.get_message());
    alert(response.get_stackTrace());
    alert(response.get_exceptionType());
}
