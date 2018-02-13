﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ombi.Helpers;
using Ombi.Store.Entities;

namespace Ombi.Store.Repository
{
    public interface INotificationTemplatesRepository
    {
        IQueryable<NotificationTemplates> All();
        Task<IEnumerable<NotificationTemplates>> GetAllTemplates();
        Task<IEnumerable<NotificationTemplates>> GetAllTemplates(NotificationAgent agent);
        Task<NotificationTemplates> Insert(NotificationTemplates entity);
        Task Update(NotificationTemplates template);
        Task UpdateRange(IEnumerable<NotificationTemplates> template);
        Task<NotificationTemplates> GetTemplate(NotificationAgent agent, NotificationType type);
    }
}