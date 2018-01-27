//=========================================================================================
// Help 3 Link Fix Script
//=========================================================================================
// Copyright © 2010, Rob Chandler. The Helpware Group.
// Please don't use this file without purchasing FAR HTML 5 or mshcMigrate. This effectively licenses you to use this code.
// http://helpware.net/FAR/ 
// http://mshcmigrate.helpmvp.com/
//------------------------------------------------------------------------------------------
// 1. Add h3m.js to root of help project
// 2. Include in header... <script type="text/javascript" src="h3m.js"></script>
// 3. To fix links add before </body>... <script type="text/javascript"><!-- h3m_fix(); --></script>
// or... Use "Include h3m.js Fix Script" Migrate option in mshcMigrate
//------------------------------------------------------------------------------------------
// Changes
//   RWC: 2010-04-22, Version 1.0: Original version
//   RWC: 2010-04-23, Version 1.0.0.1 - Fix script error
//   RWC: 2010-04-23, Version 1.0.0.2 - Fix script that fixes IE local bookmarks
//   RWC: 2010-05-20, Version 1.0.0.3 - Now include JS file in header section and call h3m_fix(); at end of file; Added h3m_docPackagePath
//   RWC: 2010-05-21, Version 1.0.0.4 - Added h3m_docPackageShortPath and h3m_docProtocol vars 
//=========================================================================================

// Extracted from topic URL  

var docCatProduct = '';        // eg. vs   -- If (docCatProduct.length == 0) then current topic not in HelpViewer
var docCatProductVersion = ''; // eg. 100  -- If (docCatProductVersion.length == 0) then current topic not in HelpViewer
var docCatLocale = '';         // eg. en-us
var docUrlEmbedded = '';       // &embedded=true


// Extracted from h2m.js script path

var h3m_docPackagePath = '';       // eg. http://127.0.0.1:47873/help/0-3400/ms.help?content/Helpware/store/Link Test.mshc;/
var h3m_docPackageShortPath = '';  // eg. ms.help?content/Helpware/store/Link Test.mshc;/
var h3m_docProtocol = '';          // eg. http://127.0.0.1:47873/help/0-3400/


var mh3Debug = false;

// ** -------------------------------------------------------------------------------------
// ** H3MExtractDocCatInfo()
// **   Populate globals docCatProduct, docCatProductVersion, docCatLocale, docUrlEmbedded
// **   from href. eg. ms.help?product=VS&productVersion=100&locale=en-us&...
// ** -------------------------------------------------------------------------------------

function H3MExtractDocCatInfo(docHref) {
  var regexp=/[&?=]/;
  var ss = docHref.split(regexp);
  for (var n = 0; n < ss.length-1; n++) {   // -1 don't read last since we read ahead
    if (ss[n].toUpperCase() == 'PRODUCT')
      docCatProduct = ss[n+1];
    else if (ss[n].toUpperCase() == 'PRODUCTVERSION')
      docCatProductVersion = ss[n+1];
    else if (ss[n].toUpperCase() == 'LOCALE')
      docCatLocale = ss[n+1];
    else if (ss[n].toUpperCase() == 'EMBEDDED')
      docUrlEmbedded = ss[n+1];
  }
  if (mh3Debug) alert('Extract doc url params: \rproduct='+docCatProduct+'\rproductVersion='+docCatProductVersion + '\rlocale=' + docCatLocale + '\rembedded=' + docUrlEmbedded + '\r' +docHref);

  //* Set Defaults VS\100\* defaults. Normally the TOC shows which is &embedded=false
  //if (docCatProduct.length == 0) 
  //    docCatProduct = 'VS';
  //if (docCatProductVersion.length == 0) 
  //    docCatProductVersion = '100';
  //if (docCatLocale.length == 0) 
  //    docCatLocale = 'en-us';
  if (docUrlEmbedded.length == 0)
      docUrlEmbedded = 'false';
}


// ** -------------------------------------------------------------------------------------
// ** H3MExtractBookmarkFromHvId()
// **   Given a HV URL like ms.help?ID=xxx#bookmark&product=VS&productVersion=100&locale=en-us&... 
// **   return any #bookmark embedded in the ID param.
// ** -------------------------------------------------------------------------------------

function H3MExtractBookmarkFromHvId(xhref) {    //includes the leading # char 
  if (xhref.indexOf('&productVersion=') > 0)  //looks like HV 1.0 URL -- Look for &ID=xxxx; param
  {
    var regexp=/[&?=]/;
    var ss = xhref.split(regexp);
    for (var n = 0; n < ss.length-1; n++) {   // -1 don't read last since we read ahead
      if (ss[n].toUpperCase() == 'ID') {
        var catID = ss[n+1];
        i = catID.indexOf('#');           //is there an embedded bookmark? 
        k = catID.lastIndexOf(';');       //it may be a &#xxx; number 
        if ((i > 0) && (k < i))
          return catID.substr(i);           //return the #bookmark (no ID)
        break;
      }
    }
  }
  return '';
}


// ** -------------------------------------------------------------------------------------
// ** HV1.0 Bookmarks - Fix HV sometimes places &embedded=true on the end and trashes our bookmarks
// ** convert ms.help?method=page&id=RWCTEST1&product=VS&productVersion=100#Bookmark1&embedded=true
// ** to this ms.help?method=page&id=RWCTEST1&product=VS&productVersion=100&embedded=true#Bookmark1
// ** -------------------------------------------------------------------------------------

function H3MFixBookmarkEmbeddedOrder(docHref) {
  var p1 = docHref.indexOf('#');
  var p2 = docHref.indexOf('&amp;embedded=');
  if (p2 < 0) p2 = docHref.indexOf('&embedded=');  //not found try unescaped

  if ((p1 > 0) && (p2 > p1))   // bookmark found, and embedded= follows
  {
     if (docHref.indexOf('&', p1) == p2)   //This only works with simple #bookmarks containing no & or ; (could be #&123;)
     {
        var bmStr = docHref.substr(p1, p2-p1);  //grab the #bookmark
        var result = docHref.replace(bmStr,'') + bmStr;  //Move bookmark to the end
        if (mh3Debug) alert('>> Fix param order: was: ' + docHref + '\r\r now: ' + result);
        return result;
     }   
  }
  return '';   //means no change
}


// ** -------------------------------------------------------------------------------------
// ** HV1.0 Expand * place holders and fix embedded (which may be in our link and also added to end by Agent)
// ** convert ms.help?method=page&id=RWCTEST1&product=*&productVersion=*&embedded=*#Bookmark1
// ** &embedded=! will toggle the existing setting
// ** -------------------------------------------------------------------------------------

function H3MExpandStarFixEmbedded(docHref) {
  var fChange = false;
  var result = docHref;
  if (docHref.indexOf('=*') > 0)
  {
    result = result.replace('product=*','product='+docCatProduct);                        //expand * -> docCatProduct
    result = result.replace('productVersion=*','productVersion='+docCatProductVersion);   //expand * -> docCatProductVersion
    result = result.replace('locale=*','locale='+docCatLocale);                           //expand * -> docCatLocale
    fChange = true;
  }

  //how many &embedded=true/false are there? If > 1 then we had an extra appended by Agent. Delete and keep the authors.
    
  var p1 = result.indexOf('embedded=');
  var p2 = result.lastIndexOf('embedded=');
  if ((p1 > 0) && (p2 > 0) && (p2 > p1))          // more than one found
  {
     var p3 = result.lastIndexOf('&');            // Agent appends as last parameter 
     if ((p3 == p2-1) || (p3 == p2-5))            // either &embedded= or &amp;embedded=
     {
        if (mh3Debug) alert('Strip off duplicate embedded= param: was ' + result + '\r\r now ' + result.substr(0, p3));
        result = result.substr(0, p3);            //stip off trailing embedded= appended by Agent
        fChange = true; 
     } 
  }

  //Now expand any existing embedded=* place holder

  if (result.indexOf('embedded=*') > 0)                //User wants to preserve TOC state
  {
    if (docUrlEmbedded == 'true')                                             // Toc off  
      result = result.replace('embedded=*','embedded=true');                  // now off
    else {
      result = result.replace('&amp;embedded=*','');   // a few alternatives  // now on
      result = result.replace('&embedded=*',''); 
      result = result.replace('?embedded=*','');
    }
    fChange = true; 
  }

  // Toggle 

  if (result.indexOf('embedded=!') > 0)                //User wants to preserve TOC state
  {
    if ((docUrlEmbedded.length == 0) || (docUrlEmbedded == 'false'))  // TOC on
      result = result.replace('embedded=!','embedded=true');          // Now off
    else {                                                            // Now on - removing is same as off
      result = result.replace('&amp;embedded=!',''); // a few alternatives
      result = result.replace('&embedded=!',''); 
      result = result.replace('?embedded=!','');
    }
    fChange = true; 
  }

  if (fChange)
    return result;
  else 
    return '';
}


// ** -------------------------------------------------------------------------------------
// ** Get Package Path
// ** Sets h3m_docPackagePath=""http://127.0.0.1:47873/help/0-3400/ms.help?content/Helpware/store/Link Test.mshc;/"
// ** We get this by looking at <script type="text/javascript" src="http://127.0.0.1:47873/help/0-15836/ms.help?content/Helpware/store/Link Test.mshc;/h3m.js">
// ** -------------------------------------------------------------------------------------

function H3MGetPackagePath() {
  if (docCatProduct.length == 0)
    return '';

  //Walk the <script> tags and find h3m.js
  var d = document.getElementsByTagName('script'); 
  var scriptSrc = '';
  if (mh3Debug) alert("No# <script> tags = " + d.length);
  for (var i = 0; i < d.length; i++) 
  {
    //Bug in IE8.. Can be an execption reading a attribs
    try {
      scriptSrc = d[i].getAttribute('src');
      if (mh3Debug) alert('('+i+') scriptSrc = ' + scriptSrc);
      if ((scriptSrc.length != 0) && (scriptSrc.indexOf('h3m.js') != -1))  //Contains h3m.js? Then Extract the path.
      {
        var p = scriptSrc.lastIndexOf(';');
        return scriptSrc.substring(0, p+2);   // return "http://127.0.0.1:47873/help/0-15836/ms.help?content/Helpware/store/Link Test.mshc;/"
      }     
    }
    catch(e){
      continue;   //Ignore the error. Nothing much we can do.
    }
  }   
}



// ** -------------------------------------------------------------------------------------
// ** h3m_fix -- call when topic is loaded. Fixes bookmarks and links.
// ** -------------------------------------------------------------------------------------

function h3m_fix() {
  var isIE = (/MSIE (\d+\.\d+);/.test(navigator.userAgent)); //test for MSIE x.x;
  var xhref = '';
  var xtarget = '';
  var docUrl_NoBookmark=document.location.href;

  //Trim off bookmark
  var p = docUrl_NoBookmark.indexOf('#');
  if (p > 0)
    docUrl_NoBookmark=docUrl_NoBookmark.substr(0, p);
  
  // * 
  // * Walk the <a> links
  // * 

  var d = document.getElementsByTagName('a'); 
  if (mh3Debug) alert("No# <a> links = " + d.length);
  for (var i = 0; i < d.length; i++) 
  {
    //Bug in IE8.. Can be an exception reading an href attribute containing '%ProgramFiles%'
    try {
      xhref = d[i].getAttribute('href');
      xtarget = d[i].getAttribute('target');
      }
    catch(e){
      continue;   //Ignore the error. Nothing much we can do.
      }

    if ((xhref == null) || (xhref.length == 0))
      continue;

    if (mh3Debug) alert('debug-01: '+i+',' + xhref + ', ' + xtarget);

    // Prepare - To detect if #bookmark remove current doc path from the start
    var xhrefOrig=xhref;
    if (xhref.indexOf(docUrl_NoBookmark) == 0)                  // ThisFile#bookmark --> #bookmark (for IE)
    {
      xhref = xhref.substr(docUrl_NoBookmark.length);
      if (mh3Debug) alert('debug-02: '+i+',' + xhref + ', ' + xtarget);
    }

    xhref = xhref.replace(/\&amp;/g,'&');                            // &amp; --> &

    // ** -------------------------------------------------------------------------------------
    // ** HV1.0 Independant links - <a href="ms.help?method=page&id=xxx&product=*&productVersion=*&locale=*">
    // ** Also sort out Agent when it appends &embedded=.. We may have 2x if our URL also had &embedded=
    // ** -------------------------------------------------------------------------------------
    //xhrefOrig = "ms.help?method=page&id=RWCTEST1&product=VS&productVersion=100&embedded=true#Bookmark1&embedded=true";  //!!test!! 

    var newLink = H3MExpandStarFixEmbedded(xhrefOrig);
    if (newLink.length != 0)
    {
      if (mh3Debug) alert('>> Expand Independent URL: was ' + xhrefOrig + '\r\r now ' + newLink);
      xhrefOrig = newLink;
      if (isIE) d[i].setAttribute('href', xhrefOrig, 0); //[iecase] set 0 to ignore case (default = 1)
      else d[i].setAttribute('href', xhrefOrig);
    }

    // ** -------------------------------------------------------------------------------------
    // ** HV1.0 Bug: HV adds a target to local bookmarks. Fix: Remove target from Bookmarks
    // ** -------------------------------------------------------------------------------------

    if ((xtarget != null) && (xtarget.length != 0) && (xhref.substr(0, 1) == '#'))    // first char = #, ie. bookmark
    {
      d[i].removeAttribute('target'); 
      if (mh3Debug) alert(xhref + ', ' + xtarget + ' <-- Remove target');
    }

    // ** -------------------------------------------------------------------------------------
    // ** HV1.0 Bug: ms.help://?id=xxx#bookmark -- Expanded by HV but bookmark needs to move to the end
    // ** <a href="ms.help?method=page&id=RWCTEST2#BOOKMARK1&product=VS&productVersion=100&topicVersion=&locale=EN-US&topicLocale=EN-US">
    // ** -------------------------------------------------------------------------------------

    var bm = H3MExtractBookmarkFromHvId(xhref);
    if (bm.length != 0) {  // then fix the Original URL
      var xx = xhrefOrig.replace(bm,'') + bm;   
      if (mh3Debug) alert('>> Fixed URL: ' + xx);
      if (isIE) d[i].setAttribute('href', xx, 0); //[iecase] set 0 to ignore case (default = 1)
      else d[i].setAttribute('href', xx);
    } 

    // ** -------------------------------------------------------------------------------------
    // ** HV1.0 Bookmarks - Fix HV sometimes places &embedded=true on the end and trashes our bookmarks
    // ** -------------------------------------------------------------------------------------
   
    // convert ms.help?method=page&id=RWCTEST1&product=VS&productVersion=100#Bookmark1&embedded=true
    // to this ms.help?method=page&id=RWCTEST1&product=VS&productVersion=100&embedded=true#Bookmark1
    //xhrefOrig = "ms.help?method=page&id=RWCTEST1&product=VS&productVersion=100#Bookmark1&embedded=true";  //!!test!! 

    var sFixedURL = H3MFixBookmarkEmbeddedOrder(xhrefOrig);
    if (sFixedURL.length != 0)
    {
       if (mh3Debug) alert('>> Move Bookmark to end past embedded=true: was ' + xhrefOrig + '\r\r now: ' + sFixedURL);
       xhrefOrig = sFixedURL;
       if (isIE) d[i].setAttribute('href', xhrefOrig, 0); //[iecase] set 0 to ignore case (default = 1)
       else d[i].setAttribute('href', xhrefOrig);
    }
  } 
}


// ** -------------------------------------------------------------------------------------
// ** h3m_main() -- called automatically on Script load
// ** -------------------------------------------------------------------------------------

function h3m_main(){ 

  docUrl = document.location.href;
  if (mh3Debug) alert('Doc URL=' + docUrl);

  // * Get catalog info from current URL --> docCatProduct, docCatProductVersion, docCatLocale, docUrlEmbedded 
  // * 
  H3MExtractDocCatInfo(docUrl);       // Extract Catalog params from current doc URL

  // * Get the package path  
  // * 
  h3m_docPackagePath = H3MGetPackagePath();   //eg. http://127.0.0.1:47873/help/0-3400/ms.help?content/Helpware/store/Link Test.mshc;/

  //Split package path into parts 
  if (h3m_docPackagePath.length != 0) {
    var p = h3m_docPackagePath.indexOf('ms.help?');
    h3m_docProtocol = h3m_docPackagePath.substr(0, p);        // eg. http://127.0.0.1:47873/help/0-3400/
    h3m_docPackageShortPath = h3m_docPackagePath.substr(p);   // eg. ms.help?content/Helpware/store/Link Test.mshc;/

    if (mh3Debug) alert('h3m_docPackagePath = '+ h3m_docPackagePath + '\rh3m_docProtocol=' + h3m_docProtocol + '\rh3m_docPackageShortPath='+h3m_docPackageShortPath);
  }

}


//* --------------------------------------------------------------------------------------------
//* 
//* --------------------------------------------------------------------------------------------

h3m_main();


//* --------------------------------------------------------------------------------------------
//* mh3Debug()
//* --------------------------------------------------------------------------------------------

function mh3Test(aMode) {
  mh3Debug = true; 
  alert('mh3Test; Mode = ' + aMode + ', ' + typeof(aMode));
  if (aMode == 0) {
    H3MMain(document.location.href);
    }
  if (aMode == 1) {
    try { alert('test 001'); location.href='%ProgramFiles%/test/xxx.pdf'; } catch(e){}
    try { alert('test 002'); location.href='%ProgramFiles%\\test\\xxx.pdf'; } catch(e){}
    try { alert('test 003'); location.href='file:///%ProgramFiles%/test/xxx.pdf'; } catch(e){}
    try { alert('test 004'); location.href='file:///%ProgramFiles%\\test\\xxx.pdf'; } catch(e){}
    try { alert('test 005'); location.href='file:///c:\\program files\\test\\xxx.pdf'; } catch(e){}
    try { alert('test 006'); location.href='file:///c:/program files/test/xxx.pdf'; } catch(e){}
    try { alert('test 007'); location.href='c:\\program files\\test\\xxx.pdf'; } catch(e){}
    try { alert('test 008'); location.href='ms.help?content/Helpware/store/Link Test.mshc;/xxx.pdf'; } catch(e){}
    try { alert('test 009'); location.href='ms.help?content\\Helpware\\store\\Link Test.mshc;/xxx.pdf'; } catch(e){}
    try { alert('test 010'); location.href='ms-xhelp:///?content/Helpware/store/Link Test.mshc;/xxx.pdf'; } catch(e){}
    try { alert('test 011'); location.href='ms-xhelp:///?content\\Helpware\\store\\Link Test.mshc;/xxx.pdf'; } catch(e){}
  }
}


