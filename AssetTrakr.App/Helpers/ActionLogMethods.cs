﻿using AssetTrakr.Database;
using AssetTrakr.Models;
using AssetTrakr.Utils.Enums;

namespace AssetTrakr.App.Helpers
{
    public class ActionLogMethods
    {

        /// <summary>
        /// Logs a new 'ADDED' entry to the Action Log
        /// </summary>
        /// <param name="dbContext">
        /// The existing database context that was used to add the entity
        /// </param>
        /// <param name="category">
        /// The <see cref="ActionCategory"/> of the entity
        /// </param>
        /// <param name="actionName">
        /// The name of the entity
        /// </param>
        public static void Added(DatabaseContext dbContext, ActionCategory category, string actionName)
        {
            dbContext.ActionLogEntries.Add(new ActionLog
            {
                ActionCategory = category,
                ActionType = ActionType.ADDED,
                ActionName = actionName,
                ActionBy = Environment.UserName,
            });

        }

        /// <summary>
        /// Logs a new 'UPDATED' entry to the Action Log
        /// </summary>
        /// <param name="dbContext">
        /// The existing database context that was used to add the entity
        /// </param>
        /// <param name="category">
        /// The <see cref="ActionCategory"/> of the entity
        /// </param>
        /// <param name="actionName">
        /// The name of the entity
        /// </param>
        public static void Updated(DatabaseContext dbContext, ActionCategory category, string actionName)
        {
            dbContext.ActionLogEntries.Add(new ActionLog
            {
                ActionCategory = category,
                ActionType = ActionType.UPDATED,
                ActionName = actionName,
                ActionBy = Environment.UserName,
            });
        }

        /// <summary>
        /// Logs a new 'DELETED' entry to the Action Log
        /// </summary>
        /// <param name="dbContext">
        /// The existing database context that was used to add the entity
        /// </param>
        /// <param name="category">
        /// The <see cref="ActionCategory"/> of the entity
        /// </param>
        /// <param name="actionName">
        /// The name of the entity
        /// </param>
        public static void Deleted(DatabaseContext dbContext, ActionCategory category, string actionName)
        {
            dbContext.ActionLogEntries.Add(new ActionLog
            {
                ActionCategory = category,
                ActionType = ActionType.DELETED,
                ActionName = actionName,
                ActionBy = Environment.UserName,
            });
        }

        public static void Archived()
        {
            throw new NotImplementedException();
        }
    }
}
