/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Piranha.Manager.Models;
using Piranha.Manager.Services;

namespace Piranha.Manager.Controllers
{
    /// <summary>
    /// Api controller for alias management.
    /// </summary>
    [Area("Manager")]
    [Route("manager/api/contact")]
    [Authorize(Policy = Permission.Admin)]
    [ApiController]
    public class ContactApiController : Controller
    {
        private readonly ContactService _service;
        private readonly ManagerLocalizer _localizer;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ContactApiController(ContactService service, ManagerLocalizer localizer)
        {
            _service = service;
            _localizer = localizer;
        }

        /// <summary>
        /// Gets the list model.
        /// </summary>
        /// <returns>The list model</returns>
        [Route("{id:Guid?}")]
        [HttpGet]
        [Authorize(Policy = Permission.Contacts)]
        public Task<ContactListModel> List(Guid? id = null)
        {
            return _service.Get(id);
        }

        [Route("delete/{id}")]
        [HttpGet]
        [Authorize(Policy = Permission.ContactsDelete)]
        public async Task<StatusMessage> Delete(Guid id)
        {
            await _service.DeleteAsync(id);

            var result = new StatusMessage
            {
                Type = StatusMessage.Success,
                Body = _localizer.Contact["The Contact was successfully deleted"]
            };
            return result;
        }
    }
}