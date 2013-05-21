// ASProxy Dynamic Encoder
// ASProxy encoder for dynamically created objects //
// Last update: 2010-04-23 coded by Salar.Kh //
// Licende: MPL 1.1 License agreement.
_ASProxy={Debug_UseAbsoluteUrl:false,DynamicEncoders:true,TraceCookies:false,LogEnabled:false,ServerSideParser:false,Activities:{},Pages:{pgGetAny:"getany.ashx",pgGetHtml:"gethtml.ashx",pgGetJS:"getjs.ashx",pgImages:"images.ashx",pgDownload:"download.ashx",pgAuthorization:"authorization.aspx",pgAjax:"ajax.ashx",pgParser:"parser.ashx"},ClientSideUrls:["mailto:","file://","javascript:","vbscript:","jscript:","vbs:","ymsgr:","data:"],NonVirtualUrls:["http://","https://","mailto:","ftp://","file://",
"telnet://","news://","nntp://","ldap://","ymsgr:","javascript:","vbscript:","jscript:","vbs:","data:"]};if(typeof _reqInfo=="undefined")_reqInfo={ASProxyPageName:"surf.aspx"};_ASProxy.EncodedUrls=[_reqInfo.ASProxyPageName+"?dec=",_ASProxy.Pages.pgAjax+"?dec=",_ASProxy.Pages.pgGetHtml+"?dec=",_ASProxy.Pages.pgImages+"?dec=",_ASProxy.Pages.pgGetJS+"?dec=",_ASProxy.Pages.pgDownload+"?dec=",_ASProxy.Pages.pgAuthorization+"?dec=",_ASProxy.Pages.pgGetAny+"?dec="];document.OriginalWrite=document.write;
document.OriginalWriteLn=document.writeln;window.OriginalOpen=window.open;window.LocationReplace=window.location.replace;window.LocationAssign=window.location.assign;window.LocationReload=window.location.reload;window.OriginalEval=window.eval;ENC_Page=0;ENC_Images=1;ENC_Any=2;ENC_Frames=3;
function __UrlEncoder(a,b,c,e){if(_ASProxy.IsClientSideUrl(a)||_ASProxy.IsSelfBookmarkUrl(a))return a;if(_ASProxy.IsEncodedByASProxy(a))return a;if(c!=true)a=_ASProxy.CorrectLocalUrlToOrginal(a);if(_ASProxy.IsVirtualUrl(a))a=_ASProxy.JoinUrls(a,_reqInfo.pageUrl,_reqInfo.pagePath,_reqInfo.rootUrl);c=b==ENC_Images?_ASProxy.Pages.pgImages:b==ENC_Any?_ASProxy.Pages.pgGetAny:b==ENC_Frames?_ASProxy.Pages.pgGetHtml:_reqInfo.ASProxyPageName;if(_ASProxy.Debug_UseAbsoluteUrl)c=_reqInfo.ASProxyPath+c;c+="?dec="+
(_userConfig.EncodeUrl+0)+"&url=";b=_ASProxy.ReturnBookmarkPart(a);if(b!="")a=_ASProxy.RemoveBookmarkPart(a);c=c;c+=_userConfig.EncodeUrl?_ASProxy.B64UnknownerAdd(_Base64_encode(a)):escape(a);if(e!=null)c+="&"+e;c+=b;return c}_ASProxy.JoinUrls=function(a,b,c,e){if(typeof a!="string"||a.length==0)return b;if(c.lastIndexOf("/")!=c.length-1)c+="/";if(e.lastIndexOf("/")!=e.length-1)e+="/";return a.indexOf("/",0)==0?e+"."+a:c+a};
_ASProxy.IsClientSideUrl=function(a){if(typeof a!="string")return false;a=a.toLowerCase();for(i=0;i<_ASProxy.ClientSideUrls.length;i++)if(_ASProxy.StrStartsWith(a,_ASProxy.ClientSideUrls[i]))return true;return false};_ASProxy.IsVirtualUrl=function(a){if(typeof a!="string")return true;a=a.toLowerCase();for(i=0;i<_ASProxy.NonVirtualUrls.length;i++)if(_ASProxy.StrStartsWith(a,_ASProxy.NonVirtualUrls[i]))return false;return true};
_ASProxy.IsSelfBookmarkUrl=function(a){if(typeof a!="string")return false;if(_ASProxy.StrStartsWith(a,"#"))return true;a=a.toLowerCase();var b=window.location.href.toLowerCase()+"#";if(a.indexOf(b,0)==0)return true;return false};_ASProxy.ReturnBookmarkPart=function(a){if(typeof a!="string")return"";var b=a.indexOf("#",0);if(b!=-1)return a=a.substring(b,a.length);return""};
_ASProxy.RemoveBookmarkPart=function(a){if(typeof a!="string")return null;var b=a.indexOf("#",0);if(b!=-1)return a=a.substring(0,b);return a};_ASProxy.CorrectLocalUrlToOrginalCheck=function(a){if(_ASProxy.IsClientSideUrl(a)||_ASProxy.IsSelfBookmarkUrl(a))return a;return _ASProxy.CorrectLocalUrlToOrginal(a)};
_ASProxy.CorrectLocalUrlToOrginal=function(a){if(typeof a!="string")return null;var b=a.toLowerCase(),c=_reqInfo.ASProxyRoot.toLowerCase(),e=_reqInfo.ASProxyPath.toLowerCase(),f=_reqInfo.ASProxyPageName.toLowerCase(),d=_reqInfo.pageUrlNoQuery,g=false,j=b.indexOf(f,0);f=f.length;if(j==-1){j=b.indexOf(e,0);f=e.length;d=_reqInfo.pagePath;g=true}if(j==-1){j=b.indexOf(c,0);f=c.length;d=_reqInfo.rootUrl;g=true}if(d.substr(d.length-1,1)=="/"){d=d.substr(0,d.length-1);g=true}if(j==0){a=a.substr(f,a.length);
b="/";if(g==false||a.substr(0,1)=="/")b="";return d+b+a}else return a};_ASProxy.B64UnknownerAdd=function(a){if(typeof a!="string")return _reqInfo.UrlUnknowner;var b=_reqInfo.UrlUnknowner.toLowerCase(),c=a.toLowerCase();return!_ASProxy.StrEndsWith(c,b)?a+_reqInfo.UrlUnknowner:a};_ASProxy.B64UnknownerRemove=function(a){if(typeof a!="string")return a;var b=_reqInfo.UrlUnknowner.toLowerCase();b=a.toLowerCase().indexOf(b);return b>-1?a.substring(0,b):a};
_ASProxy.Log=function(){if(_ASProxy.LogEnabled&&typeof console!="undefined")try{console.debug("ASProxy log:");for(var a="",b=0;b<arguments.length;b++)a+=arguments[b]+"\n";console.debug(a)}catch(c){}};
_ASProxy.IsEncodedByASProxy=function(a){if(typeof a!="string")return false;a=a.toLowerCase();var b=_reqInfo.ASProxyPath.toLowerCase();for(i=0;i<_ASProxy.EncodedUrls.length;i++)if(_ASProxy.StrStartsWith(a,_ASProxy.EncodedUrls[i]))return true;else if(_ASProxy.StrStartsWith(a,b+_ASProxy.EncodedUrls[i]))return true;return false};
_ASProxy.GetBookmarkOnlyForCurrentPage=function(a){var b=document.location.href.toLowerCase(),c=a.toLowerCase(),e=a.indexOf("#",0);if(e!=-1)return c.indexOf(b,0)==-1?a:_reqInfo.pageUrl+a.substring(e,a.length);return a};
_ASProxy.AttachEvent=function(a,b,c,e){try{if(a==null)return false;if(a.addEventListener){a.addEventListener(b,c,e);return true}else if(a.attachEvent)return a.attachEvent("on"+b,c);else try{a["on"+b]=c}catch(f){_ASProxy.Log('AttachEvent"on"',f)}}catch(d){_ASProxy.Log("AttachEvent",d)}};_ASProxy.StrTrimLeft=function(a){return a.replace(/^\s*/,"")};_ASProxy.StrTrimRight=function(a){return a.replace(/\s*$/,"")};_ASProxy.StrTrim=function(a){return a.replace(/^\s+|\s+$/g,"")};
_ASProxy.StrStartsWith=function(a,b){if(a.length==0||a.length<b.length)return false;return a.substr(0,b.length)==b};_ASProxy.StrEndsWith=function(a,b){if(a.length==0||a.length<b.length)return false;return a.substr(a.length-b.length)==b};_ASProxy.GetUrlParamValue=function(a,b){if(b==null||a==null)return"";a=a.replace(/[\[]/,"\\[").replace(/[\]]/,"\\]");var c=(new RegExp("[\\?&]"+a+"=([^&#]*)")).exec(b);if(c==null)return"";return c[1]};_ASProxy.Enc={};
_ASProxy.Enc.EncodeElements=function(a,b,c,e,f,d,g,j){var k=0,h;for(k=0;k<a.length;k++){h=a[k];var l=h.attributes[b],n=h[b];l=l!=null?l.value:n;if(_ASProxy.IsEncodedByASProxy(l)==false){var o=false;if(f!=null&&d!=null){var m=h.attributes[f];m=m!=null?m.value:h[f];if(m!=null)if(m.toLowerCase()!=d.toLowerCase())continue}m=h.attributes.asproxydone;if(m==null||m.value!="1"&&m.value!="2")o=true;else if(m.value=="1"){m=h.attributes.encodedurl;if(m==null){_ASProxy.CallOriginalSetAttr(h,"encodedurl",l);c==
3&&g&&_ASProxy.CallOriginalSetAttr(h,g,j);o=true}else m=m.value;if(l!=m)if(l==window.location)continue;else o=true}if(o){o=_ASProxy.CorrectLocalUrlToOrginalCheck(l);n=_ASProxy.CorrectLocalUrlToOrginalCheck(n);_ASProxy.CallOriginalSetAttr(h,"asproxydone","1");_ASProxy.CallOriginalSetAttr(h,"originalurl",_ASProxy.GetBookmarkOnlyForCurrentPage(n));c==3&&g&&_ASProxy.CallOriginalSetAttr(h,g,j);if(e&&_userConfig.OrginalUrl){typeof ORG_IN_!="undefined"&&_ASProxy.AttachEvent(h,"mouseover",function(){ORG_IN_(this)});
typeof ORG_OUT_!="undefined"&&_ASProxy.AttachEvent(h,"mouseout",function(){ORG_OUT_()})}if(!(l==window.location&&o==l)){o=__UrlEncoder(o,c,true,null);_ASProxy.CallOriginalSetAttr(h,b,o);h[b]=o;_ASProxy.CallOriginalSetAttr(h,"encodedurl",o)}}}}};
_ASProxy.Enc.EncodeForms=function(){if(_userConfig.Forms==true){var a=0,b;for(a=0;a<document.forms.length;a++){b=document.forms.item(a);var c=b.attributes.action;c=c!=null?c.value:b.action;if(_ASProxy.IsEncodedByASProxy(c)==false){var e=false,f=b.attributes.asproxydone,d=b.method;if(f==null||f.value!="1"&&f.value!="2")e=true;else if(f.value=="1"){f=b.attributes.encodedurl;f=f==null?"":f.value;d=b.attributes.methodorginal;d=d==null?b.method:d.value;if(f.indexOf("://",0)==-1)f=document.location.protocol+
"//"+document.location.host+"/"+f;if(c!=f)e=true}if(e){_ASProxy.CallOriginalSetAttr(b,"asproxydone","1");_ASProxy.CallOriginalSetAttr(b,"methodorginal",d);c=__UrlEncoder(c,ENC_Page,false,"method="+d);_ASProxy.CallOriginalSetAttr(b,"action",c);_ASProxy.CallOriginalSetAttr(b,"encodedurl",c);b.method="POST"}}}_ASProxy.DynamicEncoders&&window.setTimeout("_ASProxy.Enc.EncodeForms();",2E3)}};
_ASProxy.Enc.EncodeFrames=function(){if(_userConfig.Frames==true){var a=document.documentElement.getElementsByTagName("iframe");try{_ASProxy.Enc.EncodeElements(a,"src",3,false,null,null,"onload","_ASProxy.Enc.EncodeFrames()")}catch(b){_ASProxy.Log("Enc.EncodeFrames",b)}_ASProxy.DynamicEncoders&&window.setTimeout("_ASProxy.Enc.EncodeFrames();",5E3)}};
_ASProxy.Enc.EncodeLinks=function(){if(_userConfig.Links==true){try{_ASProxy.Enc.EncodeElements(document.links,"href",0,true)}catch(a){_ASProxy.Log("Enc.EncodeLinks",a)}_ASProxy.DynamicEncoders&&window.setTimeout("_ASProxy.Enc.EncodeLinks();",1E3)}};_ASProxy.Enc.EncodeImages=function(){if(_userConfig.Images==true){try{_ASProxy.Enc.EncodeElements(document.images,"src",1,true)}catch(a){_ASProxy.Log("Enc.EncodeImages",a)}_ASProxy.DynamicEncoders&&window.setTimeout("_ASProxy.Enc.EncodeImages();",1E3)}};
_ASProxy.Enc.EncodeInputImages=function(){if(_userConfig.Images==true){var a=document.documentElement.getElementsByTagName("input");try{_ASProxy.Enc.EncodeElements(a,"src",1,true,"type","image")}catch(b){_ASProxy.Log("Enc.EncodeInputImages",b)}_ASProxy.DynamicEncoders&&window.setTimeout("_ASProxy.Enc.EncodeInputImages();",4E3)}};
_ASProxy.Enc.EncodeScriptSources=function(){var a=document.documentElement.getElementsByTagName("script");try{_ASProxy.Enc.EncodeElements(a,"src",2,false)}catch(b){_ASProxy.Log("Enc.EncodeScriptSources",b)}_ASProxy.DynamicEncoders&&window.setTimeout("_ASProxy.Enc.EncodeScriptSources();",4E3)};
_ASProxy.LocationObject=function(){this.search=_reqInfo.location.Search;this.href=_reqInfo.pageUrl;this.hash=window.location.hash!=null&&window.location.hash!=""?window.location.hash:_reqInfo.location.Hash;this.host=_reqInfo.location.Host;this.hostname=_reqInfo.location.Hostname;this.pathname=_reqInfo.location.Pathname;this.port=_reqInfo.location.Port;this.protocol=_reqInfo.location.Protocol;this.replace=window.LocationReplace;this.assign=window.LocationAssign;this.replace=_ASProxy.LocationReplace;
this.assign=_ASProxy.LocationAssign;this.reload=_ASProxy.LocationReload;this.URL=_reqInfo.pageUrl;this.toString=function(){return _reqInfo.pageUrl};this.toLocaleString=function(){return _reqInfo.pageUrl};this.length=this.href.length;this.anchor=this.href.anchor;this.big=this.href.big;this.blink=this.href.blink;this.bold=this.href.bold;this.charAt=this.href.charAt;this.charCodeAt=this.href.charCodeAt;this.fixed=this.href.fixed;this.fontcolor=this.href.fontcolor;this.fontsize=this.href.fontsize;this.fromCharCode=
this.href.fromCharCode;this.indexOf=this.href.indexOf;this.italics=this.href.italics;this.lastIndexOf=this.href.lastIndexOf;this.link=this.href.link;this.match=this.href.match;this.slice=this.href.slice;this.small=this.href.small;this.split=this.href.split;this.strike=this.href.strike;this.sub=this.href.sub;this.substr=this.href.substr;this.substring=this.href.substring;this.toLowerCase=this.href.toLowerCase;this.toUpperCase=this.href.toUpperCase};
function __CookieGet(){return _ASProxy.GetDocumentCookie()}function __CookieSet(a){return _ASProxy.SetDocumentCookie(a)}_ASProxy.DocCookieString=document.cookie;_ASProxy.GetDocumentCookie=function(){_ASProxy.DocCookieString=document.cookie;for(var a="",b=0;b<_reqInfo.appliedCookiesList.length;b++){var c=_ASProxy.GetCookieByName(_reqInfo.appliedCookiesList[b]);if(c!=null){c=_ASProxy.ParseASProxyCookie(c);if(c!=null&&c.length>0)a+=c}}return a};
_ASProxy.ParseASProxyCookie=function(a){var b="";a=a.split("&");for(var c=0;c<a.length;c++){for(var e=null,f=null,d=null,g=a[c].split(";"),j=0;j<g.length;j++){var k=g[j],h=k.indexOf("="),l=k.substr(0,h).replace("+","");l=_ASProxy.StrTrim(l);k=_ASProxy.StrTrim(k.substr(h+1,k.length-h-1));if(l=="Name")e=k;else if(l=="Value")f=k=unescape(k);else if(l=="Path")d=k}if(e!=null&&f!=null){e=e+"="+f;if(d==null||d=="")d="/";d=d.toLowerCase();if(_reqInfo.location.Pathname.toLowerCase().indexOf(d)==0)b+=e+"; "}}return b};
_ASProxy.SetDocumentCookie=function(a){if(!(a==null||a==""))return _ASProxy.ParseStandardCookieForSet(a)};
_ASProxy.ParseStandardCookieForSet=function(a){var b=null,c=null,e=null,f=null,d=null,g=null,j=false;a=a.split(";");for(var k=0;k<a.length;k++){var h=a[k],l=h.indexOf("="),n=h.substr(0,l).replace("+","");n=_ASProxy.StrTrim(n);h=_ASProxy.StrTrim(h.substr(l+1,h.length-l-1));if(k==0){b=n;c=h}else if(n=="expires")e=h;else if(n=="max-age")f=h;else if(n=="domain")d=h;else if(n=="path")g=h;else if(n=="secure")j=true}a="";if(b==null||c==null)return null;else{a="Name="+b;a+="; Value="+escape(c);if(e!=null)a+=
"; Expires="+e;if(f!=null)a+="; Max-Age="+f;if(d!=null)a+="; Domain="+d;if(g!=null)a+="; Path="+g;if(j)a+="; Secure=True"}b=_reqInfo.cookieName;c=c="";if(d!=null&&d!="")b=_ASProxy.GetASProxyCookieName(d);c=a;d=_ASProxy.GetCookieByName(b);if(d!=null&&d!="")c+="& "+d;c=escape(c);c=b+"="+c;if(!_userConfig.TempCookies){if(e!=null)c+="; expires="+e;if(f!=null)c+="; max-age="+f}c+="; path=/";return c};
_ASProxy.GetCookieByName=function(a){for(var b=_ASProxy.DocCookieString.split(";"),c=0;c<b.length;c++){var e=b[c].split("="),f=_ASProxy.StrTrim(e[0]);if(a==f)return unescape(e[1])}return null};_ASProxy.GetASProxyCookieName=function(a){return a+_reqInfo.cookieNameExt};
_ASProxy.ParseHtml=function(a){if(typeof a!="string")return a;var b=/\.(src)\s*=\s*([^;}]+)/ig;a=a.replace(b,".$1=__UrlEncoder($2,ENC_Any)");b=/\.(action|location|href)\s*=\s*([^;}]+)/ig;a=a.replace(b,".$1=__UrlEncoder($2)");b=/\.innerHTML\s*(\+)?=\s*([^};]+)\s*/ig;a=a.replace(b,".innerHTML$1=_ASProxy.ParseHtml($2)");for(b=/\s(href|action)\s*=\s*(["']?)([^"'\s>]+)/ig;match=b.exec(a);)a=a.replace(match[0]," "+match[1]+"="+match[2]+__UrlEncoder(match[3]));for(b=/\s(src|background)\s*=\s*(["']?)([^"'\s>]+)/ig;match=
b.exec(a);)a=a.replace(match[0]," "+match[1]+"="+match[2]+__UrlEncoder(match[3],ENC_Any));for(b=/url\s*\(['"]?([^'"\)]+)['"]?\)/ig;match=b.exec(a);)a=a.replace(match[0],"url("+__UrlEncoder(match[1],ENC_Any)+")");for(b=/@import\s*['"]([^'"\(\)]+)['"]/ig;match=b.exec(a);)a=a.replace(match[0],'@import "'+__UrlEncoder(match[1],ENC_Any)+'"');return a};_ASProxy.ParseJs=function(a){return _ASProxy.ParseServerSide(a,0,false)};
_ASProxy.ParseServerSide=function(a,b,c,e){responseObject={readyState:0,responseText:""};var f=_ASProxy.Pages.pgParser,d="";if(b==0)d="js";else if(b==1)d="html";c=c?true:false;f+="?dec="+(_userConfig.EncodeUrl+0);f+="&type="+d;f+="&url=";f+=_userConfig.EncodeUrl?_ASProxy.B64UnknownerAdd(_Base64_encode(_reqInfo.pageUrl)):escape(url);var g;g=typeof _AJAXInternal!="undefined"?new _AJAXInternal:new XMLHttpRequest;g.onreadystatechange=function(){if(g.readyState==4){responseObject.readyState=g.readyState;
responseObject.responseText=g.responseText;typeof e!="undefined"&&e(responseObject)}};g.open("POST",f,c);g.send(a);if(!c){responseObject.readyState=g.readyState;responseObject.responseText=g.responseText;return responseObject}};_ASProxy.CallOriginalSetAttr=function(a,b,c){if(a!=null)typeof a.OriginalSetAttribute=="undefined"?a.setAttribute(b,c):a.OriginalSetAttribute(b,c)};
_ASProxy.OverrideHtmlSetters=function(){if(typeof window.__defineSetter__!="undefined")try{var a=[HTMLTitleElement,HTMLTextAreaElement,HTMLTableSectionElement,HTMLTableRowElement,HTMLTableElement,HTMLTableColElement,HTMLTableCellElement,HTMLTableCaptionElement,HTMLStyleElement,HTMLSelectElement,HTMLScriptElement,HTMLParamElement,HTMLParagraphElement,HTMLOptionElement,HTMLOListElement,HTMLObjectElement,HTMLMetaElement,HTMLMapElement,HTMLMapElement,HTMLLinkElement,HTMLLIElement,HTMLLegendElement,HTMLLabelElement,
HTMLIsIndexElement,HTMLInputElement,HTMLImageElement,HTMLIFrameElement,HTMLHtmlElement,HTMLHRElement,HTMLHeadingElement,HTMLHeadElement,HTMLFrameSetElement,HTMLFrameElement,HTMLFormElement,HTMLFontElement,HTMLFieldSetElement,HTMLEmbedElement,HTMLDocument,HTMLDListElement,HTMLDivElement,HTMLButtonElement,HTMLBRElement,HTMLBodyElement,HTMLBaseFontElement,HTMLBaseElement,HTMLAreaElement,HTMLAnchorElement];try{a.push([HTMLElement,HTMLUListElement,HTMLQuoteElement,HTMLPreElement,HTMLModElement,HTMLMenuElement,
HTMLDirectoryElement,HTMLAppletElement])}catch(b){_ASProxy.Log("Extra OverrideHtmlSetters",b)}var c=function(d,g,j){if(_ASProxy.IsEncodedByASProxy(g))return g;try{var k=d.toLowerCase();d=j;d=d==null?(this.tagName+"").toLowerCase():(d+"").toLowerCase();if(k=="src")_ASProxy.IsEncodedByASProxy(g)||(g=d=="img"?__UrlEncoder(g,ENC_Images):d=="iframe"||d=="frame"?__UrlEncoder(g,ENC_Frames):__UrlEncoder(g,ENC_Any));else if(k=="href")_ASProxy.IsEncodedByASProxy(g)||(g=d=="a"||d=="base"?__UrlEncoder(g):__UrlEncoder(g,
ENC_Any));else if(k=="background")_ASProxy.IsEncodedByASProxy(g)||(g=__UrlEncoder(g,ENC_Images));else if(k=="action")_ASProxy.IsEncodedByASProxy(g)||(g=d=="form"?g:__UrlEncoder(g,ENC_Any));else if(k=="innerHtml")g=_ASProxy.ParseHtml(g)}catch(h){_ASProxy.Log("_EncodeSetAttributeValue",h)}return g};_ASProxy.SetAttribute=function(d,g){try{if(d.toLowerCase()=="action"&&this.tagName.toLowerCase()=="form")_ASProxy.Setter_FormAction(this,g);else{g=c(d,g,this.tagName);this.OriginalSetAttribute(d,g)}}catch(j){_ASProxy.Log("_ASProxy.SetAttribute",
j)}};_ASProxy.Setter_FormAction=function(d,g){var j=d.attributes.methodorginal;j=j==null?j.value:d.method;d.OriginalSetAttribute("asproxydone","1");d.OriginalSetAttribute("methodorginal",j);j=_ASProxy.IsEncodedByASProxy(g)==false?__UrlEncoder(g,ENC_Page,false,"method="+j):g;d.OriginalSetAttribute("action",j);d.method="POST";d.OriginalSetAttribute("encodedurl",j)};_ASProxy.Setter_Src=function(d){this.OriginalSetAttribute("src",c("src",d,this.tagName))};_ASProxy.Setter_Href=function(d){this.OriginalSetAttribute("href",
c("href",d,this.tagName))};_ASProxy.Setter_Background=function(d){this.OriginalSetAttribute("background",c("background",d,this.tagName))};_ASProxy.Setter_InnerHtml=function(d){this.OriginalSetAttribute("innerHtml",c("innerHtml",d,this.tagName))};_ASProxy.Setter_Action=function(d){try{this.tagName.toLowerCase()=="form"?_ASProxy.Setter_FormAction(this,d):this.OriginalSetAttribute("action",c("action",d,this.tagName))}catch(g){_ASProxy.Log("Setter_Action",g)}};for(i=0;i<a.length;i++){var e=a[i].prototype;
if(e!=null){e.OriginalSetAttribute=e.setAttribute;e.setAttribute=_ASProxy.SetAttribute;e.__defineSetter__("src",_ASProxy.Setter_Src);e.__defineSetter__("action",_ASProxy.Setter_Action);e.__defineSetter__("href",_ASProxy.Setter_Href);e.__defineSetter__("background",_ASProxy.Setter_Background);e.__defineSetter__("innerHtml",_ASProxy.Setter_InnerHtml)}}}catch(f){_ASProxy.Log("OverrideHtmlSetters ALL",f)}};
_ASProxy.OverrideStandardsDeclare=function(){_ASProxy.WindowEval=function(a){if(typeof a=="string"&&_ASProxy.ServerSideParser){var b=a,c=false;if(typeof _XFloatBar!="undefined"){c=true;ORG_MSG_("<div style='padding:5px 4px;font-size:12px;'><strong>ASProxy:</strong> <span style='color:maroon;'>A background proccess is working, please wait a few seconds...</span></div>")}a=_ASProxy.ParseServerSide(a,0,false);c&&ORG_OUT_();if(a.readyState==4)b=a.responseText;return window.OriginalEval(b)}else return window.OriginalEval(a)};
_ASProxy.WindowOpen=function(a,b,c,e){return _ASProxy.IsEncodedByASProxy(a)?window.OriginalOpen(a,b,c,e):window.OriginalOpen(__UrlEncoder(a),b,c,e)};_ASProxy.LocationAssign=function(a){_ASProxy.IsEncodedByASProxy(a)||(a=__UrlEncoder(a));return window.location.href=a};_ASProxy.LocationReplace=function(a){a=_ASProxy.IsEncodedByASProxy(a)?a:__UrlEncoder(a);return window.location.replace==_ASProxy.LocationReplace?window.LocationReplace(a):window.location.replace(a)};_ASProxy.LocationReload=function(){return window.location.reload==
_ASProxy.LocationReload?window.LocationReload():window.location.reload()};_ASProxy.DocumentWrite=function(a){a=a;if(_ASProxy.ParseHtml){a=_ASProxy.ParseHtml(a);return document.OriginalWrite(a)}};_ASProxy.DocumentWriteLn=function(a){a=a;if(_ASProxy.ParseHtml){a=_ASProxy.ParseHtml(a);return document.OriginalWriteLn(a)}}};
_ASProxy.OverrideStandards=function(){if(_ASProxy.ServerSideParser)try{window.eval=_ASProxy.WindowEval}catch(a){_ASProxy.Log("OVR window.eval failed",a)}try{document.XDomain=_WindowLocation.host}catch(b){_ASProxy.Log("document.XDOMAIN failed",b)}try{window.open=_ASProxy.WindowOpen}catch(c){_ASProxy.Log("OVR window.open failed",c)}try{document.open=_ASProxy.WindowOpen}catch(e){_ASProxy.Log("OVR document.open failed",e)}try{open=_ASProxy.WindowOpen}catch(f){_ASProxy.Log("OVR open failed",f)}try{window.location.replace=
_ASProxy.LocationReplace}catch(d){_ASProxy.Log("OVR window.location failed",d)}try{location.replace=_ASProxy.LocationReplace}catch(g){_ASProxy.Log("OVR location.replace failed",g)}try{document.write=_ASProxy.DocumentWrite}catch(j){_ASProxy.Log("OVR document.write failed",j)}try{document.writeln=_ASProxy.DocumentWriteLn}catch(k){_ASProxy.Log("OVR document.writeln failed",k)}};Object.extend=function(a,b,c){for(var e in b)c==false&&a[e]!=null||(a[e]=b[e]);return a};function _ArrayAdd(a,b,c){a[b]=c}
_ASProxyXMLHttpRequest=typeof XMLHttpRequest!="undefined"?XMLHttpRequest:null;_AJAXInternal=function(){try{return new _ASProxyXMLHttpRequest}catch(a){}try{return new ActiveXObject("Msxml2.XMLHTTP.6.0")}catch(b){}try{return new ActiveXObject("Msxml2.XMLHTTP.3.0")}catch(c){}try{return new ActiveXObject("Msxml2.XMLHTTP")}catch(e){}try{return new ActiveXObject("Microsoft.XMLHTTP")}catch(f){}};XMLHttpRequest=function(){};Object.extend(XMLHttpRequest.prototype,{_ajax:new _AJAXInternal},true);
Object.extend(XMLHttpRequest.prototype,{_headers:[],_async:false,_reqUrl:"",_caller:null,_refresh:function(){_caller=this;this._attachAllEvent()},_attachAllEvent:function(){try{this._ajax.onreadystatechange=this._readystatechange}catch(a){}try{this._ajax.onload=this._load}catch(b){}try{if(this.onerror!=null)this._ajax.onerror=this._error}catch(c){}try{if(this.onprogress!=null)this._ajax.onprogress=this._progress}catch(e){}try{if(this.onabort!=null)this._ajax.onabort=this._abort}catch(f){}try{if(this.ontimeout!=
null)this._ajax.ontimeout=this._timeout}catch(d){}try{if(this.onuploadprogress!=null)this._ajax.onuploadprogress=this._uploadprogress}catch(g){}try{if(this.onloadstart!=null)this._ajax.onloadstart=this._loadstart}catch(j){}},_updateProperties:function(){try{this.responseText=this._ajax.responseText}catch(a){}try{this.responseXML=this._ajax.responseXML}catch(b){}try{this.status=this._ajax.status}catch(c){}try{this.statusText=this._ajax.statusText}catch(e){}try{this.readyState=this._ajax.readyState}catch(f){}try{this.responseBody=
this._ajax.responseBody}catch(d){}try{this.multipart=this._ajax.multipart}catch(g){}},_readystatechange:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();_caller.onreadystatechange!=null&&_caller.onreadystatechange(a)}},_load:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();_caller.onload!=null&&_caller.onload(a)}},_error:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();
_caller.onerror!=null&&_caller.onerror(a)}},_progress:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();_caller.onprogress!=null&&_caller.onprogress(a)}},_abort:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();_caller.onabort!=null&&_caller.onabort(a)}},_timeout:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();_caller.ontimeout!=null&&
_caller.ontimeout(a)}},_uploadprogress:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();_caller.onuploadprogress!=null&&_caller.onuploadprogress(a)}},_loadstart:function(a){if(_caller!=null&&typeof _caller._updateProperties!="undefined"){_caller._updateProperties();_caller.onloadstart!=null&&_caller.onloadstart(a)}},UNSENT:0,OPENED:1,HEADERS_RECEIVED:2,LOADING:3,DONE:4,SECURITY_ERR:18,NETWORK_ERR:19,ABORT_ERR:20,abort:function(){this._refresh();
this._ajax.abort();this._updateProperties()},getAllResponseHeaders:function(){this._refresh();this._updateProperties();return this._ajax.getAllResponseHeaders()},getResponseHeader:function(a){this._refresh();this._updateProperties();return this._ajax.getResponseHeader(a)},open:function(a,b,c,e,f){if(arguments.length<3)c=true;this._reqUrl=b;b=this._EncodeAJAXUrl(a,b,e,f);a=this._ASProxyEncodeAJAXMethod(a);this._async=c;this._refresh();this._ajax.open(a,b,c,e,f);this._updateProperties()},send:function(a){this._ajax.setRequestHeader("X-ASProxy-AJAX-Headers",
this._EncodeArray(this._headers));this._ajax.setRequestHeader("X-ASProxy-AJAX-Referrer",_reqInfo.pageUrl);if(a&&a.nodeType){a=window.XMLSerializer?(new window.XMLSerializer).serializeToString(a):a.xml;this._headers["Content-Type"]||this._ajax.setRequestHeader("Content-Type","application/xml")}this._refresh();this._ajax.send(a);this._updateProperties()},sendAsBinary:function(a){this._ajax.setRequestHeader("X-ASProxy-AJAX-Headers",this._EncodeArray(this._headers));this._ajax.setRequestHeader("X-ASProxy-AJAX-Referrer",
_reqInfo.pageUrl);this._refresh();this._ajax.sendAsBinary(a);this._updateProperties()},setRequestHeader:function(a,b){_ArrayAdd(this._headers,a,b);this._refresh();this._ajax.setRequestHeader(a,b);this._updateProperties()},overrideMimeType:function(a){this._refresh();this._ajax.overrideMimeType(a);this._updateProperties()},toString:function(){return"[XMLHttpRequest]"},readyState:0,responseText:"",responseXML:null,responseBody:0,status:0,statusText:"",channel:null,multipart:false,onreadystatechange:null,
onload:null,onerror:null,onprogress:null,onabort:null,ontimeout:null,onuploadprogress:null,onloadstart:null},true);
Object.extend(XMLHttpRequest.prototype,{_ASProxyEncodeAJAXMethod:function(a){if(a==null)return a;if(a.toLowerCase()=="post")return"POST";return"GET"},_EncodeArray:function(a){var b="{";for(var c in a){var e=a[c];if(e!=null&&typeof e!="function")b+='"'+c+'"|#|"'+e+'"|^|'}b+="}";return b},_ASProxyEncoderAJAXUrl:function(a,b,c,e){b=b;var f;if(_ASProxy.IsClientSideUrl(b)||_ASProxy.IsSelfBookmarkUrl(b))return b;if(_ASProxy.IsEncodedByASProxy(b)){f=_ASProxy.GetUrlParamValue("ajaxurl",b)+"";if(f=="")f=_ASProxy.GetUrlParamValue("url",
b)+"";if(f!="")b=f=_userConfig.EncodeUrl?_Base64_decode(_ASProxy.B64UnknownerRemove(f)):unescape(f)}b=_ASProxy.CorrectLocalUrlToOrginal(b);if(_ASProxy.IsVirtualUrl(b))b=_ASProxy.JoinUrls(b,_reqInfo.pageUrl,_reqInfo.pagePath,_reqInfo.rootUrl);f=_ASProxy.Pages.pgAjax;f+="?dec="+(_userConfig.EncodeUrl+0)+"&ajaxurl=";f=f;f+=_userConfig.EncodeUrl?_ASProxy.B64UnknownerAdd(_Base64_encode(b)):escape(b);f+="&method="+a;if(c!=null)f+="&use="+_ASProxy.B64UnknownerAdd(_Base64_encode(c));if(e!=null)f+="&pas="+
_ASProxy.B64UnknownerAdd(_Base64_encode(e));return f},_EncodeAJAXUrl:function(a,b,c,e){return this._ASProxyEncoderAJAXUrl(a,b,c,e)}},true);if(_ASProxyXMLHttpRequest&&_ASProxyXMLHttpRequest.wrapped)XMLHttpRequest.wrapped=_ASProxyXMLHttpRequest.wrapped;
_ASProxy.StartupDynamicEncoders=function(){window.setTimeout("_ASProxy.Enc.EncodeLinks();",500);window.setTimeout("_ASProxy.Enc.EncodeImages();",700);window.setTimeout("_ASProxy.Enc.EncodeInputImages();",2E3);window.setTimeout("_ASProxy.Enc.EncodeForms();",1E3);window.setTimeout("_ASProxy.Enc.EncodeFrames();",2E3);window.setTimeout("_ASProxy.Enc.EncodeScriptSources();",4E3)};
_ASProxy.Initialize=function(){_ASProxy.OverrideStandardsDeclare();_WindowLocation=new _ASProxy.LocationObject;_ASProxy.ReqLocation=_WindowLocation;document._WindowLocation=_WindowLocation;_ASProxy.OverrideStandards();_ASProxy.OverrideHtmlSetters();_ASProxy.DynamicEncoders&&_ASProxy.StartupDynamicEncoders()};_ASProxy.Initialize();