﻿/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

namespace Piranha.Manager
{
    /// <summary>
    /// Static class for defining the manager menu.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// The basic manager menu.
        /// </summary>
        public static MenuItemList Items { get; } = new MenuItemList
        {
            new MenuItem
            {
                InternalId = "Content",
                Name = "Content",
                Css = "fas fa-pencil-alt",
                Items = new MenuItemList
                {
                    new MenuItem
                    {
                        InternalId = "Pages",
                        Name = "Pages",
                        Route = "~/manager/pages",
                        Policy = Permission.Pages,
                        Css = "fas fa-copy"
                    },
                    new MenuItem
                    {
                        InternalId = "Media",
                        Name = "Media",
                        Route = "~/manager/media",
                        Policy = Permission.Media,
                        Css = "fas fa-images"
                    },
                    new MenuItem
                    {
                        InternalId = "Comments",
                        Name = "Comments",
                        Route = "~/manager/comments",
                        Policy = Permission.Comments,
                        Css = "fas fa-comments"
                    },
                     new MenuItem
                    {
                        InternalId = "Contacts",
                        Name = "Contacts",
                        Route = "~/manager/contacts",
                        Policy = Permission.Comments,
                        Css = "fas fa-comments"
                    }
                }
            },
            new MenuItem
            {
                InternalId = "Settings",
                Name = "Settings",
                Css = "fas fa-wrench",
                Items = new MenuItemList
                {
                    new MenuItem
                    {
                        InternalId = "Aliases", Name = "Aliases", Route = "~/manager/aliases",
                        Policy = Permission.Aliases, Css = "fas fa-random"
                    }
                }
            },
            new MenuItem
            {
                InternalId = "System",
                Name = "System",
                Css = "fas fa-cog",
                Items = new MenuItemList
                {
                    new MenuItem
                    {
                        InternalId = "Config",
                        Name = "Config",
                        Route = "~/manager/config",
                        Policy = Permission.Config,
                        Css = "fas fa-cogs"
                    },
                    new MenuItem
                    {
                        InternalId = "Modules",
                        Name = "Modules",
                        Route = "~/manager/modules",
                        Policy = Permission.Modules,
                        Css = "fas fa-code-branch"
                    }
                }
            } // công- Thêm siteMap
            ,new MenuItem
            {
                InternalId = "Quản lý vé",
                Name = "Quản lý vé",
                Css = "fa fa-newspaper",
                Items = new MenuItemList
                {
                    new MenuItem
                    {
                        InternalId = "Tạo vé", Name = "Tạo vé", Route ="/Manager/TaoVe",
                        Policy = Permission.Admin, Css = "fas fa-caret-right nav-icon"
                    },
                    new MenuItem
                    {
                        InternalId = "Danh sách vé", Name = "Danh sách vé", Route = "/quan-ly-ve/",
                        Policy = Permission.Admin, Css = "fas fa-caret-right nav-icon"
                    }
                }
            },
             new MenuItem
            {
                InternalId = "Quản lý khách hàng",
                Name = "Quản lý khách hàng",
                Css = "fa fa-user nav-icon",
                Items = new MenuItemList
                {                                  
                    new MenuItem
                    {
                        InternalId = "Khách hàng", Name = "Khách hàng", Route = "/quan-ly-kh/",
                        Policy = Permission.Admin, Css = "fas fa-caret-right nav-icon"
                    },
                    new MenuItem
                    {
                        InternalId = "Đơn hàng", Name = "Đơn hàng", Route = "/quan-ly-ma-giam-gia/",
                        Policy = Permission.Admin, Css = "fas fa-caret-right nav-icon"
                    }
                }
            },
            new MenuItem
            {
                InternalId = "Quản lý mã giảm giá",
                Name = "Quản lý mã giảm giá",
                Css = "fa fa-percent",
                Items = new MenuItemList
                {
                    new MenuItem
                    {
                        InternalId = "Tạo giảm giá", Name = "Tạo giảm giá", Route = "/tao-ma-giam-gia/",
                        Policy = Permission.Admin, Css = "fa fa-plus-circle"
                    }
                    ,
                    new MenuItem
                    {
                        InternalId = "Mã giảm giá", Name = "Mã giảm giá", Route = "/quan-ly-ma-giam-gia/",
                        Policy = Permission.Admin, Css = "fas fa-caret-right nav-icon"
                    }
                }
            }
        };
    }
}