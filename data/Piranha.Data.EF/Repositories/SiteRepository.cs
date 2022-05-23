/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Piranha.Data;
using Piranha.Data.EF;
using Piranha.Extend.Fields;
using Piranha.Services;

namespace Piranha.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        private readonly IDb _db;
        private readonly IContentService<Site, SiteField, Models.SiteContentBase> _contentService;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="db">The current db context</param>
        /// <param name="factory">The content service factory</param>
        public SiteRepository(IDb db, IContentServiceFactory factory)
        {
            _db = db;
            _contentService = factory.CreateSiteService();
        }

        /// <summary>
        /// Gets all available models.
        /// </summary>
        /// <returns>The available models</returns>
        public async Task<IEnumerable<Models.Site>> GetAll()
        {
            Language defaultLanguage = null;

            var sites = await _db.Sites
                .AsNoTracking()
                .OrderBy(s => s.Title)
                .ToListAsync()
                .ConfigureAwait(false);

            var models = new List<Models.Site>();

            foreach (var site in sites)
            {
                if (!site.LanguageId.HasValue && defaultLanguage == null)
                {
                    defaultLanguage = await _db.Languages
                        .FirstOrDefaultAsync(l => l.IsDefault);
                }

                models.Add(new Models.Site
                {
                    Id = site.Id,
                    LanguageId = site.LanguageId.HasValue ? site.LanguageId.Value : defaultLanguage.Id,
                    SiteTypeId = site.SiteTypeId,
                    Title = site.Title,
                    InternalId = site.InternalId,
                    Description = site.Description,
                    Logo = site.LogoId.HasValue ? site.LogoId.Value : new ImageField(),
                    Hostnames = site.Hostnames,
                    IsDefault = site.IsDefault,
                    Culture = site.Culture,
                    ContentLastModified = site.ContentLastModified,
                    Created = site.Created,
                    LastModified = site.LastModified
                });
            }
            return models;
        }

        /// <summary>
        /// Gets the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        /// <returns>The model, or NULL if it doesn't exist</returns>
        public async Task<Models.Site> GetById(Guid id)
        {
            var site = await _db.Sites
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == id);

            if (site != null)
            {
                Language defaultLanguage = null;
                if (!site.LanguageId.HasValue)
                {
                    defaultLanguage = await _db.Languages
                        .FirstOrDefaultAsync(l => l.IsDefault);
                }

                return new Models.Site
                {
                    Id = site.Id,
                    LanguageId = site.LanguageId.HasValue ? site.LanguageId.Value : defaultLanguage.Id,
                    SiteTypeId = site.SiteTypeId,
                    Title = site.Title,
                    InternalId = site.InternalId,
                    Description = site.Description,
                    Logo = site.LogoId.HasValue ? site.LogoId.Value : new ImageField(),
                    Hostnames = site.Hostnames,
                    IsDefault = site.IsDefault,
                    Culture = site.Culture,
                    ContentLastModified = site.ContentLastModified,
                    Created = site.Created,
                    LastModified = site.LastModified
                };
            }
            return null;
        }

        /// <summary>
        /// Gets the model with the given internal id.
        /// </summary>
        /// <param name="internalId">The unique internal i</param>
        /// <returns>The model</returns>
        public async Task<Models.Site> GetByInternalId(string internalId)
        {
            var site = await _db.Sites
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.InternalId == internalId);

            if (site != null)
            {
                Language defaultLanguage = null;
                if (!site.LanguageId.HasValue)
                {
                    defaultLanguage = await _db.Languages
                        .FirstOrDefaultAsync(l => l.IsDefault);
                }

                return new Models.Site
                {
                    Id = site.Id,
                    LanguageId = site.LanguageId.HasValue ? site.LanguageId.Value : defaultLanguage.Id,
                    SiteTypeId = site.SiteTypeId,
                    Title = site.Title,
                    InternalId = site.InternalId,
                    Description = site.Description,
                    Logo = site.LogoId.HasValue ? site.LogoId.Value : new ImageField(),
                    Hostnames = site.Hostnames,
                    IsDefault = site.IsDefault,
                    Culture = site.Culture,
                    ContentLastModified = site.ContentLastModified,
                    Created = site.Created,
                    LastModified = site.LastModified
                };
            }
            return null;
        }

        /// <summary>
        /// Gets the default side.
        /// </summary>
        /// <returns>The modell, or NULL if it doesnt exist</returns>
        public async Task<Models.Site> GetDefault()
        {
            var site = await _db.Sites
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.IsDefault);

            if (site != null)
            {
                Language defaultLanguage = null;
                if (!site.LanguageId.HasValue)
                {
                    defaultLanguage = await _db.Languages
                        .FirstOrDefaultAsync(l => l.IsDefault);
                }

                return new Models.Site
                {
                    Id = site.Id,
                    LanguageId = site.LanguageId.HasValue ? site.LanguageId.Value : defaultLanguage.Id,
                    SiteTypeId = site.SiteTypeId,
                    Title = site.Title,
                    InternalId = site.InternalId,
                    Description = site.Description,
                    Logo = site.LogoId.HasValue ? site.LogoId.Value : new ImageField(),
                    Hostnames = site.Hostnames,
                    IsDefault = site.IsDefault,
                    Culture = site.Culture,
                    ContentLastModified = site.ContentLastModified,
                    Created = site.Created,
                    LastModified = site.LastModified
                };
            }
            return null;
        }

        /// <summary>
        /// Gets the site content for given site id.
        /// </summary>
        /// <param name="id">Site id</param>
        /// <returns>The site content model</returns>
        public Task<Models.DynamicSiteContent> GetContentById(Guid id)
        {
            return GetContentById<Models.DynamicSiteContent>(id);
        }

        /// <summary>
        /// Gets the site content for given site id.
        /// </summary>
        /// <param name="id">Site id</param>
        /// <typeparam name="T">The site model type</typeparam>
        /// <returns>The site content model</returns>
        public async Task<T> GetContentById<T>(Guid id) where T : Models.SiteContent<T>
        {
            var site = await _db.Sites
                .Include(s => s.Fields)
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync()
                .ConfigureAwait(false);

            if (site == null)
            {
                return null;
            }

            if (string.IsNullOrEmpty(site.SiteTypeId))
            {
                return null;
            }

            var type = App.SiteTypes.GetById(site.SiteTypeId);
            if (type == null)
            {
                return null;
            }

            return await _contentService.TransformAsync<T>(site, type);
        }

        /// <summary>
        /// Gets the hierachical sitemap structure.
        /// </summary>
        /// <param name="id">The optional site id</param>
        /// <param name="onlyPublished">If only published items should be included</param>
        /// <returns>The sitemap</returns>
        public async Task<Models.Sitemap> GetSitemap(Guid id, bool onlyPublished = true)
        {
            var pages = await _db.Pages
                .AsNoTracking()
                .Include(p => p.Permissions)
                .Where(p => p.SiteId == id)
                .OrderBy(p => p.ParentId)
                .ThenBy(p => p.SortOrder)
                .ToListAsync()
                .ConfigureAwait(false);

            if (onlyPublished)
            {
                pages = pages.Where(p => p.Published.HasValue && p.Published.Value <= DateTime.Now).ToList();
            }
            return Sort(pages);
        }

        /// <summary>
        /// Adds or updates the given model in the database
        /// depending on its state.
        /// </summary>
        /// <param name="model">The model</param>
        public async Task Save(Models.Site model)
        {
            var site = await _db.Sites
                .FirstOrDefaultAsync(s => s.Id == model.Id)
                .ConfigureAwait(false);

            if (site == null)
            {
                site = new Data.Site
                {
                    Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid(),
                    Created = DateTime.Now
                };
                await _db.Sites.AddAsync(site).ConfigureAwait(false);
            }
            site.LanguageId = model.LanguageId;
            site.SiteTypeId = model.SiteTypeId;
            site.Title = model.Title;
            site.InternalId = model.InternalId;
            site.Description = model.Description;
            site.LogoId = model.Logo?.Id;
            site.Hostnames = model.Hostnames;
            site.Culture = model.Culture;
            site.IsDefault = model.IsDefault;
            site.ContentLastModified = model.ContentLastModified;
            site.LastModified = DateTime.Now;

            await _db.SaveChangesAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Saves the given site content to the site with the
        /// given id.
        /// </summary>
        /// <param name="siteId">The site id</param>
        /// <param name="content">The site content</param>
        /// <typeparam name="T">The site content type</typeparam>
        public async Task SaveContent<T>(Guid siteId, T content) where T : Models.SiteContent<T>
        {
            var site = await _db.Sites
                .Include(s => s.Fields)
                .FirstOrDefaultAsync(s => s.Id == siteId)
                .ConfigureAwait(false);

            if (site != null)
            {
                if (string.IsNullOrEmpty(site.SiteTypeId))
                {
                    throw new MissingFieldException("Can't save content for a site that doesn't have a Site Type Id.");
                }

                var type = App.SiteTypes.GetById(site.SiteTypeId);
                if (type == null)
                {
                    throw new MissingFieldException("The specified Site Type is missing. Can't save content.");
                }

                content.Id = siteId;
                content.TypeId = site.SiteTypeId;
                content.Title = site.Title;

                _contentService.Transform(content, type, site);

                // Make sure foreign key is set for fields
                foreach (var field in site.Fields)
                {
                    if (field.SiteId == Guid.Empty)
                    {
                        field.SiteId = site.Id;
                        await _db.SiteFields.AddAsync(field).ConfigureAwait(false);
                    }
                }

                // Since we've updated global site content, update the
                // global last modified date for the site.
                site.ContentLastModified = DateTime.Now;

                await _db.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Deletes the model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        public async Task Delete(Guid id)
        {
            var site = await _db.Sites
                .FirstOrDefaultAsync(s => s.Id == id)
                .ConfigureAwait(false);

            if (site != null)
            {
                _db.Sites.Remove(site);
                await _db.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Sorts the items.
        /// </summary>
        /// <param name="pages">The full page list</param>
        /// <param name="parentId">The current parent id</param>
        /// <param name="level">The level in structure</param>
        /// <returns>The sitemap</returns>
        private Models.Sitemap Sort(IEnumerable<Page> pages, Guid? parentId = null, int level = 0)
        {
            var result = new Models.Sitemap();

            foreach (var page in pages.Where(p => p.ParentId == parentId).OrderBy(p => p.SortOrder))
            {
                var item = Module.Mapper.Map<Page, Models.SitemapItem>(page);

                if (!string.IsNullOrEmpty(page.RedirectUrl))
                {
                    item.Permalink = page.RedirectUrl;
                }

                item.Level = level;
                item.PageTypeName = App.PageTypes.First(t => t.Id == page.PageTypeId).Title;
                item.Items = Sort(pages, page.Id, level + 1);

                result.Add(item);
            }
            return result;
        }

        public Task<IEnumerable<Models.Contact>> GetAllContact(Guid? siteId, bool onlyApproved,
           int page, int pageSize)
        {
            return GetAllContact(siteId, onlyApproved, false, page, pageSize);
        }

        public async Task<IEnumerable<Models.Contact>> GetAllContact(Guid? siteId, bool onlyApproved,
         bool onlyPending, int page, int pageSize)
        {
            // Create base query
            IQueryable<SiteContact> query = _db.SiteContacts
                .AsNoTracking();

            // Check if only should include a comments for a certain post
            if (siteId.HasValue)
            {
                query = query.Where(c => c.SiteId == siteId.Value);
            }

            // Check if we should only include approved
            if (onlyPending)
            {
                query = query.Where(c => !c.IsApproved);
            }
            else if (onlyApproved)
            {
                query = query.Where(c => c.IsApproved);
            }

            // Order the comments by date
            query = query.OrderByDescending(c => c.Created);

            // Check if this is a paged query
            if (pageSize > 0)
            {
                query = query
                    .Skip(page * pageSize)
                    .Take(pageSize);
            }

            // Get the comments
            return await query
                .Select(c => new Models.SiteContact
                {
                    Id = c.Id,
                    SiteId = c.SiteId,
                    UserId = c.UserId,
                    Author = c.Author,
                    Email = c.Email,
                    Url = c.Url,
                    IsApproved = c.IsApproved,
                    Body = c.Body,
                    Created = c.Created
                }).ToListAsync().ConfigureAwait(false);
        }

        public async Task DeleteContact(Guid id)
        {
            var contact = await _db.SiteContacts
                .FirstOrDefaultAsync(c => c.Id == id)
                .ConfigureAwait(false);

            if (contact != null)
            {
                _db.SiteContacts.Remove(contact);
                await _db.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        public async Task SaveContact(Guid siteId, Models.Contact model)
        {
            var contact = await _db.SiteContacts
                .FirstOrDefaultAsync(c => c.Id == model.Id);

            if (contact == null)
            {
                contact = new SiteContact
                {
                    Id = model.Id
                };
                await _db.SiteContacts.AddAsync(contact);
            }

            contact.UserId = model.UserId;
            contact.SiteId = model.SiteId;
            contact.Author = model.Author;
            contact.Email = model.Email;
            contact.Url = model.Url;
            contact.IsApproved = model.IsApproved;
            contact.Body = model.Body;
            contact.Created = model.Created;

            await _db.SaveChangesAsync();
        }

        public async Task<Models.Contact> GetContactById(Guid id)
        {
            return await _db.SiteContacts
                .Where(c => c.Id == id)
                .Select(c => new Models.SiteContact
                {
                    Id = c.Id,
                    SiteId = c.SiteId,
                    UserId = c.UserId,
                    Author = c.Author,
                    Email = c.Email,
                    Url = c.Url,
                    IsApproved = c.IsApproved,
                    Body = c.Body,
                    Created = c.Created
                }).FirstOrDefaultAsync().ConfigureAwait(false);
        }

       
    }
}
