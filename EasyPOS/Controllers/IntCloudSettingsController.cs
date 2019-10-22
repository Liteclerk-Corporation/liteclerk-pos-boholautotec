﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class IntCloudSettingsController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // =====================
        // Detail Cloud Settings
        // =====================
        public Entities.IntCloudSettings DetailCloudSettings()
        {
            var cloudSettings = from d in db.IntCloudSettings
                                select new Entities.IntCloudSettings
                                {
                                    Id = d.Id,
                                    BranchCode = d.BranchCode,
                                    UserCode = d.UserCode,
                                    PostUserId = d.PostUserId,
                                    PostSupplierId = d.PostSupplierId,
                                    UseItemPrice = d.UseItemPrice,
                                    Domain = d.Domain,
                                    LogFileLocation = d.LogFileLocation
                                };

            return cloudSettings.FirstOrDefault();
        }
    }
}
