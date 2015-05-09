﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    
    #line 1 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    using NewLife.Model;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/_Left.cshtml")]
    public partial class _Areas_Admin_Views_Index__Left_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index__Left_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
  
    var user = ManageProvider.Provider.Current as IUser;

    var fact = ObjectContainer.Current.Resolve<IMenuFactory>();

    var Menus = fact.Root.Childs;
    if (user != null && user.Role != null)
    {
        Menus = fact.GetMySubMenus(fact.Root.ID);
    }

    // 如果顶级只有一层，并且至少有三级目录，则提升一级
    if (Menus.Count == 1 && Menus[0].Childs.All(m => m.Childs.Count > 0)) { Menus = Menus[0].Childs; }

    String[] icos = new String[] { "fa-tachometer", "fa-desktop", "fa-list", "fa-pencil-square-o", "fa-list-alt", "fa-calendar", "fa-picture-o", "fa-tag", "fa-file-o" };
    Int32 _idx = 0;

            
            #line default
            #line hidden
WriteLiteral("\r\n<ul");

WriteLiteral(" class=\"nav nav-list\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
     foreach (IMenu menu in Menus.Where(m => m.Visible))
    {
        if (_idx >= icos.Length) { _idx = 0; }

            
            #line default
            #line hidden
WriteLiteral("        <li ");

            
            #line 23 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
        Write(menu == Menus[0] ? "class=\"active open\"" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n                <i");

WriteAttribute("class", Tuple.Create(" class=\"", 907), Tuple.Create("\"", 941)
, Tuple.Create(Tuple.Create("", 915), Tuple.Create("menu-icon", 915), true)
, Tuple.Create(Tuple.Create(" ", 924), Tuple.Create("fa", 925), true)
            
            #line 25 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create(" ", 927), Tuple.Create<System.Object, System.Int32>(icos[_idx++]
            
            #line default
            #line hidden
, 928), false)
);

WriteLiteral("></i>\r\n                <span");

WriteLiteral(" class=\"menu-text\"");

WriteLiteral(">");

            
            #line 26 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                   Write(menu.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\r\n                <b");

WriteLiteral(" class=\"arrow fa fa-angle-down\"");

WriteLiteral("></b>\r\n            </a>\r\n\r\n            <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n\r\n            <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n");

            
            #line 34 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                
            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                 foreach (IMenu menu2 in menu.Childs.Where(m => m.Visible))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n");

            
            #line 37 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                         if (menu2.Childs.Count > 0)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                ");

            
            #line 41 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                           Write(menu2.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n");

            
            #line 43 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1710), Tuple.Create("\"", 1740)
            
            #line 46 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 1717), Tuple.Create<System.Object, System.Int32>(Url.Content(menu2.Url)
            
            #line default
            #line hidden
, 1717), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                ");

            
            #line 48 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                           Write(menu2.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n");

            
            #line 50 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n                        <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n");

            
            #line 54 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 54 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                             foreach (IMenu menu3 in menu2.Childs.Where(m => m.Visible))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2240), Tuple.Create("\"", 2270)
            
            #line 57 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 2247), Tuple.Create<System.Object, System.Int32>(Url.Content(menu3.Url)
            
            #line default
            #line hidden
, 2247), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                        ");

            
            #line 59 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                   Write(menu3.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </a>\r\n\r\n                                   " +
" <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n                                </li>\r\n");

            
            #line 64 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </li>\r\n");

            
            #line 67 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </li>\r\n");

            
            #line 70 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n<!-- /.nav-list -->\r\n");

        }
    }
}
#pragma warning restore 1591
