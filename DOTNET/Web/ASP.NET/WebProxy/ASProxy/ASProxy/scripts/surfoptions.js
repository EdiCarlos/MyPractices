// ASProxy Surf page scripts
// Last update: 2010-04-22 coded by Salar.Kh //
// Licende: MPL 1.1 License agreement.
if(typeof _XPage=="undefined")_XPage={};function _Page_HideASProxyBlock(){document.getElementById("ASProxyFormBlock").style.display="none";document.getElementById("__ASProxyContainer").style.position=""}
function _Page_Initialize(){_XPage.UrlBox=document.getElementById("txtUrl");_XPage.ProcessLinks=document.getElementById("chkProcessLinks");_XPage.DisplayImages=document.getElementById("chkDisplayImages");_XPage.Forms=document.getElementById("chkForms");_XPage.Compression=document.getElementById("chkCompression");_XPage.ImgCompressor=document.getElementById("chkImgCompressor");_XPage.Cookies=document.getElementById("chkCookies");_XPage.TempCookies=document.getElementById("chkTempCookies");_XPage.OrginalUrl=
document.getElementById("chkOrginalUrl");_XPage.Frames=document.getElementById("chkFrames");_XPage.PageTitle=document.getElementById("chkPageTitle");_XPage.UTF8=document.getElementById("chkUTF8");_XPage.RemoveScripts=document.getElementById("chkRemoveScripts");_XPage.RemoveObjects=document.getElementById("chkRemoveObjects");_XPage.EncodeUrl=document.getElementById("chkEncodeUrl");if(!_XPage.UrlBox)_XPage.UrlBox={};if(!_XPage.ProcessLinks)_XPage.ProcessLinks={};if(!_XPage.DisplayImages)_XPage.DisplayImages=
{};if(!_XPage.Forms)_XPage.Forms={};if(!_XPage.Compression)_XPage.Compression={};if(!_XPage.ImgCompressor)_XPage.ImgCompressor={};if(!_XPage.Cookies)_XPage.Cookies={};if(!_XPage.TempCookies)_XPage.TempCookies={};if(!_XPage.OrginalUrl)_XPage.OrginalUrl={};if(!_XPage.Frames)_XPage.Frames={};if(!_XPage.PageTitle)_XPage.PageTitle={};if(!_XPage.UTF8)_XPage.UTF8={};if(!_XPage.RemoveScripts)_XPage.RemoveScripts={};if(!_XPage.RemoveObjects)_XPage.RemoveObjects={};if(!_XPage.EncodeUrl)_XPage.EncodeUrl={}}
function _Page_SaveOptions(){var a=_Page_CookieName+"=";a+="Links="+(_XPage.ProcessLinks.checked+0);a+="&Img="+(_XPage.DisplayImages.checked+0);a+="&Forms="+(_XPage.Forms.checked+0);a+="&ZIP="+(_XPage.Compression.checked+0);a+="&ImgZip="+(_XPage.ImgCompressor.checked+0);a+="&Cookies="+(_XPage.Cookies.checked+0);a+="&TempCookies="+(_XPage.TempCookies.checked+0);a+="&FloatBar="+(_XPage.OrginalUrl.checked+0);a+="&Frames="+(_XPage.Frames.checked+0);a+="&Title="+(_XPage.PageTitle.checked+0);a+="&PgEnc="+
(_XPage.UTF8.checked+0);a+="&RemScript="+(_XPage.RemoveScripts.checked+0);a+="&EncUrl="+(_XPage.EncodeUrl.checked+0);a+="&RemObj="+(_XPage.RemoveObjects.checked+0);var b=new Date;b.setYear(b.getFullYear()+1);a+=" ;Path=/ ;expires="+b.toString();document.cookie=a}
function _Page_HandleTextKey(a){if(window.event)a=window.event;if(a.keyCode==13||a.keyCode==10){var b=_XPage.UrlBox.value.toLowerCase();if(b.lastIndexOf(".com")==-1&&b.lastIndexOf(".net")==-1&&b.lastIndexOf(".org")==-1)if(a.ctrlKey&&a.shiftKey)_XPage.UrlBox.value+=".org";else if(a.ctrlKey)_XPage.UrlBox.value+=".com";else if(a.shiftKey)_XPage.UrlBox.value+=".net";_Page_SubmitForm()}return true}
function _Page_SubmitForm(){_Page_SaveOptions();var a=_XPage.UrlBox.value;if(a!=""){_Page_Navigate(a);return true}else{alert(_Page_UrlIsEmpty);return false}}function _Page_Navigate(){var a=_Page_XNav;if(_XPage.EncodeUrl.checked){a+="?dec=1&url=";a+=_Base64_encode(_XPage.UrlBox.value)+_Page_B64Unknowner}else{a+="?dec=0&url=";a+=escape(_XPage.UrlBox.value)}document.location=a}function _PageOnSubmit(){_Page_SubmitForm();return false};