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
using System.Linq;
using System.Threading.Tasks;
using Piranha.Manager.Models;
using Piranha.Models;

namespace Piranha.Manager.Services
{
    public class ContactService
    {
        private readonly IApi _api;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="api">The current api</param>
        public ContactService(IApi api)
        {
            _api = api;
        }

        /// <summary>
        /// Gets the comment model.
        /// </summary>
        /// <param name="id">The optional content id</param>
        /// <returns>The model</returns>
        public async Task<ContactListModel> Get(Guid? id = null)
        {
            var model = new ContactListModel
            {
                ContentId = id
            };

            var Contacts = await _api.Sites.GetAllContactsAsync(id, onlyApproved: false, pageSize: 0);

            foreach (var contact in Contacts)
            {
                var site = await _api.Sites.GetByIdAsync(contact.SiteId);

                model.Contacts.Add(new ContactListModel.ListItem
                {
                    Id = contact.Id,
                    ArticleTitle = site?.Title,
                    ArticleUrl = $"manager/contact/edit/{ site?.Id }",
                    Author = contact.Author,
                    AuthorImage = Utils.GenerateGravatarUrl(contact.Email, 25),
                    Email = contact.Email,
                    Body = contact.Body,
                    IsApproved = contact.IsApproved,
                    Created = contact.Created.ToString("yyyy-MM-dd"),
                    CreatedDate = contact.Created
                });
            }

            model.Contacts = model.Contacts
                .OrderByDescending(c => c.CreatedDate)
                .ToList();

            return model;
        }

        public async Task DeleteAsync(Guid id)
        {
            var contact = await _api.Sites.GetContactByIdAsync(id);

            if (contact != null)
            {
                await _api.Sites.DeletecontactAsync(id);
            }
            else
            {
                contact = await _api.Sites.GetContactByIdAsync(id);

                if (contact != null)
                {
                    await _api.Sites.DeletecontactAsync(id);
                }
            }
        }
    }
}