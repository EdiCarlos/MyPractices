// Deselects all the checked from items
var fW = (typeof getFormWarpRequest == "function" ? getFormWarpRequest() : document.forms["formWarpRequest"]);
if (!fW || fW == undefined) {
    fW = (formWarpRequest_THIS_ ? formWarpRequest_THIS_ : formWarpRequest_NS_);
}



//main list of combo box
var mainList = [['Issue Date', '1'], ['Create Date', '2'], ['Approval Final Date', '3'], ['Payment Initiated Date', '4'], ['Seller Paid Date', '5'], ['Financial Status Date', '6'], ['Payment Due Date', '7'], ['Summary Invoice Date', '8']];
//call for funds
var callList = [['Payment Initiated Date', '4']];
//actual Paid
var actualList = [['Seller Paid Date', '5']];
//accrual 
var accrualList = [['Financial Status Date', '6']];
// actual list
var customList = [['Issue Date', '1'], ['Create Date', '2'], ['Financial Status Date', '6'], ['Payment Due Date', '7']];
//when AF, PI, PS is selected show only Approval Final Date
var approvalList = [['Issue Date', '1'], ['Create Date', '2'], ['Approval Final Date', '3'], ['Financial Status Date', '6'], ['Payment Due Date', '7']];
//only PI and PS list select show this list
var paymentList = [['Issue Date', '1'], ['Create Date', '2'], ['Approval Final Date', '3'], ['Payment Initiated Date', '4'], ['Financial Status Date', '6'], ['Payment Due Date', '7'], ['Summary Invoice Date', '8']];

function GetPrompt(block) {
    var sp1 = document.getElementById(block);
    var inp = sp1.getElementsByTagName("input");
    var arr = new Array(inp.length - 1);
    for (var x = 0; x < inp.length; x++) {
        if (x == 0) {
            continue;
        }
        arr[x - 1] = inp[x];
    }
    return arr;
}
//function which checks if user has Clicked on any of the option available in Custom Financial Status
var prompt = fW._oLstChoiceslistCustomFin;
//var prompt = GetPrompt("customStatus");
var dt = fW._oLstChoicesdateType;
var cmb = fW._oLstChoicesreportType;

function DeSelectCustom() {
    prompt[0].checked = false;
    prompt[1].checked = false;
    prompt[2].checked = false;
    prompt[3].checked = false;
    prompt[4].checked = false;
    prompt[5].checked = false;
    prompt[6].checked = false;
    prompt[7].checked = false;
    prompt[8].checked = false;
}
function ifExists(cmb, val) {
    try {
        for (var x = 0; x < cmb.length; x++) {
            if (cmb.options[x].value.toString().toUpperCase() == val.toString().toUpperCase()) {
                return true;
            }
        }
    }
    catch (err) {
        var mess = "Error in function ifExists. \r\n";
        mess += "Error Description : " + err.description;
        alert(mess);
    }
    return false;
}

//add list of arrays in a combo box
function AddList(cmb, list) {
    try {
        for (var x = 0; x < list.length; x++) {
            var ele = new Option(list[x][0], list[x][1]);
            if (!ifExists(cmb, list[x][1])) {
                cmb.add(ele, cmb.length);
            }
        }
    }
    catch (err) {
        var mess = "Error in function AddList ";
        mess += "Error Description : " + err.description;
        alert(mess);
    }
}

//Clears the combox
function ClearCombo(cmb) {
    try {
        if (cmb.length > 2) {
            var tempLen = cmb.length;
            for (var x = 2; x < tempLen; x++) {
                cmb.remove(2);
            }
        }
    }
    catch (err) {
        var mess = "Error in function ClearCombo";
        mess += "Error Description : " + err.description;
        alert(mess);
    }
}
function setDefaultForCustom(cmb, val) {
    for (var x = 0; x < cmb.length; x++) {
        if (cmb[x].value.toString() == val.toString()) {
            cmb.selectedIndex = x;
        }
    }
}
function setDefaultForCustomA(cmb, val) {
    for (var x = 0; x < cmb.length; x++) {
        if (cmb[x].selected) {
            cmb[x].selectedIndex = x;
        }
    }
}

function CheckFinancial() {
    try {
        if (!prompt[0].checked && !prompt[2].checked && !prompt[3].checked && !prompt[4].checked && !prompt[5].checked && !prompt[8].checked) {
            if (prompt[1].checked || prompt[6].checked || prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, approvalList);
                setDefaultForCustom(dt, '6');
            }
            //if Only PI is selected then only show payment list
            if (!prompt[1].checked && prompt[6].checked && !prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, paymentList);
                setDefaultForCustom(dt, '6');
            }
            //if Only PI and PS are selected then only show payment list
            if (!prompt[1].checked && prompt[6].checked && prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, paymentList);
                setDefaultForCustom(dt, '6');
            }
            if (!prompt[1].checked && !prompt[6].checked && prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, mainList);
                setDefaultForCustom(dt, '6');
            }
        }
        else {
            ClearCombo(dt);
            AddList(dt, customList);
            setDefaultForCustom(dt, '6');
        }
    }
    catch (Error) {
        alert("Method Name: CheckFinancial() error while setting date list");
    }
}
function CheckFinancialA(def) {
    try {
        if (!prompt[0].checked && !prompt[2].checked && !prompt[3].checked && !prompt[4].checked && !prompt[5].checked && !prompt[8].checked) {
            if (prompt[1].checked || prompt[6].checked || prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, approvalList);
                setDefaultForCustom(dt, def);
            }
            //if Only PI is selected then only show payment list
            if (!prompt[1].checked && prompt[6].checked && !prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, paymentList);
                setDefaultForCustom(dt, def);
            }
            //if Only PI and PS are selected then only show payment list
            if (!prompt[1].checked && prompt[6].checked && prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, paymentList);
                setDefaultForCustom(dt, def);
            }
            if (!prompt[1].checked && !prompt[6].checked && prompt[7].checked) {
                ClearCombo(dt);
                AddList(dt, mainList);
                setDefaultForCustom(dt, '6');
            }
        }
        else {
            ClearCombo(dt);
            AddList(dt, customList);
            setDefaultForCustom(dt, def);
        }
    }
    catch (err) {
        alert("Method Name: CheckFinancialA; Error: Error occurred in CheckFinancial method Description: " + err.description);
    }
}
// JScript source code
//var reportType = document.getElementById("ReportType");
//var cmb = reportType.getElementsByTagName("SELECT")[0];
function cmbItemSelected() {
    var curdate = new Date();
    try {
        if (cmb.selectedIndex == 2)//if call for fund is selected then select Payment Initiated date
        {
            ClearCombo(dt);
            AddList(dt, callList);
            dt.selectedIndex = 2; //Payment initiated date
            //set the from date to seven days ago
            var dDate = new Date();
            dDate.setDate(dDate.getDate() - 7);
            try {
                pickerControlmyFromDate1.setValue(getFormatDate(dDate, 0, 'YMD')); //sets the from date to seven days ago
                pickerControlmyToDate.setValue(getFormatDate(curdate, 0, 'YMD')); //sets the to date to current date
            }
            catch (err) {
             
            }
            DeSelectCustom();
            prompt[6].checked = true;
        }
        else {
            //pickerControlmyFromDate1.setValue(getFormatDate(curdate, 0 , 'YMD'));//sets the from date to current date
            //pickerControlmyToDate.setValue(getFormatDate(curdate, 0, 'YMD'));//sets the to date to current date
        }
        if (cmb.selectedIndex == 3)//if Actual(paid) is selected the select Payment settled date
        {
            ClearCombo(dt);
            AddList(dt, actualList);
            dt.selectedIndex = 2; //Payment settled date
            //set the from date to seven days ago
            var dDate = new Date();
            dDate.setDate(dDate.getDate() - 7);
            try {
                pickerControlmyFromDate1.setValue(getFormatDate(dDate, 0, 'YMD')); //sets the from date to seven days ago
                pickerControlmyToDate.setValue(getFormatDate(curdate, 0, 'YMD')); //sets the to date to current date
            }
            catch (err) {
            }
            DeSelectCustom();
            prompt[7].checked = true;
        }

        if (cmb.selectedIndex == 4) //if accural is selected the select Financial status date
        {
            ClearCombo(dt);
            AddList(dt, accrualList);
            dt.selectedIndex = 2; //Financial status date 
            //set the from date to seven days ago
            var dDate = new Date();
            dDate.setDate(dDate.getDate() - 30);
            try {
                pickerControlmyFromDate1.setValue(getFormatDate(dDate, 0, 'YMD')); //sets the from date to seven days ago
                pickerControlmyToDate.setValue(getFormatDate(curdate, 0, 'YMD')); //sets the to date to current date
            }
            catch (err) {
            }
            DeSelectCustom();
            prompt[0].checked = true;
            prompt[1].checked = true;
            prompt[4].checked = true;
            prompt[5].checked = true;
            prompt[8].checked = true;
        }

        if (cmb.selectedIndex == 5)//if custom is selected the select Issue date
        {
            ClearCombo(dt);
            AddList(dt, customList);
            setDefaultForCustom(dt, '6'); //Select Financial status date
            try {
                document.getElementById("customStatus").style.display = 'block'; //shows the cusom Report financial status block
                document.getElementById("customStatusLabel").style.display = 'block';
            }
            catch (err) {
                alert(err.description);
            }
            try {
                pickerControlmyFromDate1.setValue(getFormatDate(curdate, 0, 'YMD')); //sets the from date to current date
                pickerControlmyToDate.setValue(getFormatDate(curdate, 0, 'YMD')); //sets the to date to current date
            }
            catch (err) {
            }
            DeSelectCustom();
            prompt[0].checked = true;
            prompt[1].checked = true;
            prompt[2].checked = true;
            prompt[3].checked = true;
            prompt[4].checked = true;
            prompt[5].checked = true;
            prompt[8].checked = true;
        }
        else {
            try {
                document.getElementById("customStatus").style.display = 'none'; //hides the cusom Report financial status block
                document.getElementById("customStatusLabel").style.display = 'none';
            }
            catch (err) {
                alert(err.description);
            }
        }
    } catch (err) {
        alert("Method Name: cmbItemSelected");
    }
}
//Call the function cmbSelected so that it checks if call for fund is selected the It should display only relevant item in DateType comboBox
cmb.onchange = cmbItemSelected;

var reportLevel = fW._oLstChoices_reportLevel;
var docType = fW._oLstChoices_docType;
var currencyCode = fW._oLstChoices_currencyCode;
if (currencyCode == null) {
    alert("Currency Code is Null");
}
// hiding select All/deselect All in Cognos 8.3 form.
function DeSelectAllLink() {
    for (j = 0; j < document.links.length; j++) {
        y = document.links[j];
        if (y.id.indexOf("SELECT") != -1) document.getElementById(y.id).style.display = 'None';
    }
}
function getList(sp1, sp2) {
    var sp = document.getElementById(sp1);
    var inp = sp.getElementsByTagName("input");
    var txtBlock = document.getElementById(sp2);
    var txtBox = txtBlock.getElementsByTagName("input");
    for (var i = 0; i < inp.length; i++) {
        if (i == 1 || i == 2) {
            inp[i].onclick = function() { if (txtBox[0] != null) { txtBox[0].value = ""; } if (txtBox[1] != null) { txtBox[1].value = ""; } document.getElementById(sp2).style.display = 'block'; }
        }
        else {
            inp[i].onclick = function() { if (txtBox[0] != null) { txtBox[0].value = ""; } if (txtBox[1] != null) { txtBox[1].value = ""; } document.getElementById(sp2).style.display = 'none'; }
        }
    }
}
function IsListChecked(block) {
    var span = document.getElementById(block);
    var inp = span.getElementsByTagName("input");
    for (var x = 0; x < inp.length; x++) {
        if (inp[x].value.toString().toUpperCase() == 'LIKE') {
            if (inp[x].checked == true)
                return true;
            break;
        }
    }
    return false;
}
function displayBlock(name) {
    document.getElementById(name).style.display = 'block';
}
//Clear the combox when form loads
function init() {
    try {
        getList("buyerList", "buyerBlock");
        if (!IsListChecked("buyerList")) {
            displayBlock("buyerBlock");
        }
    }
    catch (err) {
        alert("Error call function getList on buyerList and buyerBlock");
    }
    try {
        getList("sellerList", "sellerBlock");
        if (!IsListChecked("sellerList")) {
            displayBlock("sellerBlock");
        }
    }
    catch (err) {
        alert("Error call function getList on sellerList and sellerBlock");
    }
    try {
        getList("billAccountList", "billAccountBlock");
        if (!IsListChecked("billAccountList")) {
            displayBlock("billAccountBlock");
        }
    }
    catch (err) {
        alert("Error call function getList on billAccountList and billAccountBlock");
    }
    try {
        getList("accountCodeList", "accountCodeBlock");
        if (!IsListChecked("accountCodeList")) {
            displayBlock("accountCodeBlock");
        }
    }
    catch (err) {
        alert("Error call function getList on accountCodeList and accountCodeBlock");
    }
    try {
        getList("accountAliasList", "accountAliasBlock");
        if (!IsListChecked("accountAliasList")) {
            displayBlock("accountAliasBlock");
        }
    }
    catch (err) {
        alert("Error call function getList on accountCodeList and accountCodeBlock");
    }
    try {
        getList("sellerCompanyList", "sellerCompanyBlock");
        if (!IsListChecked("sellerCompanyList")) {
            displayBlock("sellerCompanyBlock");
        }
    }
    catch (err) {
        alert("Error call function getList on accountCodeList and accountCodeBlock");
    }
    try {
        //set text of reportTypes first element to desired value 
        cmb[0].text = "Select Report Type";
        //set Text of report levels first element to desired value
        reportLevel[0].text = "Select Report Level";
        //set Text of Date Types first element to desired value for the display purpose
        dt[0].text = "Select Date Type";
        //set Text of Document Types first element to desired value for the display purpose
        docType[0].text = "Select Document Type";
        //set currency codes first element to to "Select Currency"
        currencyCode[0].text = "Select Currency";
    }
    catch (err) {
        alert("Error while setting header list in combo box");
    }
    // call this deselect
    try {
        if (cmb.selectedIndex != 5) {
            DeSelectCustom();
        }
        //check if call for fund is selected then select PI 
        if (cmb.selectedIndex == 2) {
            ClearCombo(dt);
            AddList(dt, callList);
            setDefaultForCustom(dt, '4');
            // This is to initialize start date less 7 days while report type is call for  funds
            cmbItemSelected();
            //call for funds is selected then select PI
            prompt[6].checked = true;
        }
        else if (cmb.selectedIndex == 3) {
            ClearCombo(dt);
            AddList(dt, actualList);
            setDefaultForCustom(dt, '5');
            //Actual (Paid) is selected then select 7 element in the Custom Financial status
            prompt[7].checked = true;
        }
        else if (cmb.selectedIndex == 4) {
            ClearCombo(dt);
            AddList(dt, accrualList);
            setDefaultForCustom(dt, '6');
            //Acrrual is selected in Reprot type the select below element
            prompt[0].checked = true;
            prompt[1].checked = true;
            prompt[4].checked = true;
            prompt[5].checked = true;
            prompt[8].checked = true;
        }
        else if (cmb.selectedIndex == 5) {
            var index = dt.selectedIndex;
            CheckFinancialA(dt[index].value);
            try {
                document.getElementById("customStatus").style.display = 'block'; //shows the cusom Report financial status block
                document.getElementById("customStatusLabel").style.display = 'block';
            }
            catch (err) {
                alert(err.description);
            }
        }
    }
    catch (err) {
        alert("Error on cmb.selectedIndex");
    }
    try {
        //on initialization call the function apply event custom prompt
        for (var x = 0; x < prompt.length; x++) {
            //prompt[x].onclick = CheckFinancial;
        }
    }
    catch (err) {
        alert("error while setting CheckFinancial method to onclick event");
    }
    //call DeSelectAllLink which will remove all the links from the document
    try {
        DeSelectAllLink();
    }
    catch (err) {
        alert("Error while removing all select link from report");
    }
}
//call the initialization function 
this.init();

function validateDate() {
}
function getDateElement(dt) {
    var dateBlock = document.getElementById(dt);
    var date = dateBlock.getElementsByTagName("input");
    if (date[1] != null) {
        return date[1];
    }
    return null;
}
function ValidateForSpace(txt) {
    //validation for spatial characters
    if (txt.value.match(/^\s+|\s+$/g, '')) {
        var temp = txt.value.replace(/^\s+|\s+$/g, '');
        if (temp.length <= 0) {
            txt.value = temp;
            return false;
        }
    }
}
//replace this function with ValidateIfEmpty functions to apply new validation
function ValidateIfEmpty(block, txt) {
    try {
        var txtValue = txt.value;
        if (txt.value == '' && document.getElementById(block).style.display == 'block') {
            return false;
        }
        if (txt.value.match(/^\s+|\s+$/g, '')) {
            var temp = txt.value.replace(/^\s+|\s+$/g, '');
            if (temp.length <= 0) {
                txt.value = temp;
                return false;
            }
        }
    }
    catch (err) {
        alert("Error in ValidateIfEmpty() " + err.description);
    }
    return true;
}
function validate() {
    try {
        //ValidateForSpace(fW._textEditBox_txt_buyerId);
        //ValidateForSpace(fW._textEditBox_txt_sellerId);
    }
    catch (err) {
        alert(err.description);
    }
    //if(cmb.selectedIndex == 0 || cmb.selectedIndex == 1)
    //{alert("One or more of the required values is missing.Required values are needed to produce the report."); return;}
    //if(!ValidateIfEmpty("buyerBlock", fW._textEditBoxtxt_buyerName))
    //{alert("One or more of the required values is missing.Required values are needed to produce the report."); return;}
    //if(!ValidateIfEmpty("sellerCompanyBlock", fW._textEditBoxtxt_sellerCompany))
    //{alert("One or more of the required values is missing.Required values are needed to produce the report."); return;}
    //if(!ValidateIfEmpty("sellerBlock", fW._textEditBoxtxt_sellerName))
    //{alert("One or more of the required values is missing.Required values are needed to produce the report."); return;}
    //if(!ValidateIfEmpty("billAccountBlock", fW._textEditBoxtxt_billNumber))
    //{alert("One or more of the required values is missing.Required values are needed to produce the report."); return;}
    //if(!ValidateIfEmpty("accountCodeBlock", fW._textEditBoxtxt_accCode))
    //{alert("One or more of the required values is missing.Required values are needed to produce the report."); return;}
    //if(!ValidateIfEmpty("accountAliasBlock", fW._textEditBoxtxt_accAlias))
    //{alert("One or more of the required values is missing.Required values are needed to produce the report."); return;}
    var startdate = this.getDateElement("fromDate");
    var enddate = this.getDateElement("toDate");
    var canSubmit = true;
    var m = startdate.value
    var n = enddate.value
    var a = m.replace("-", "");
    var b = a.replace("-", "");
    var c = n.replace("-", "");
    var d = c.replace("-", "");
    if (b == '99991231')
    { alert("Invalid Start Date "); return; }
    if (d == '99991231')
    { alert("Invalid  End Date "); return; }
    if (parseInt(b) > parseInt(d)) { alert("End Date cannot be less than Start Date"); canSubmit = false; }
    if (canSubmit) {
        if (!canSubmitPrompt()) {
            return;
        }
        else {
            setTimeout(promptButtonFinish, 0);
        }
    }
    else {
        canSubmit = true;
        return;
    }
}
