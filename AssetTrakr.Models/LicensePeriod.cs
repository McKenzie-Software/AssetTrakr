﻿namespace AssetTrakr.Models
{
    public class LicensePeriod
    {
        public int? LicenseId { get; set; } = null;
        public virtual required License License { get; set; }

        public int? PeriodId { get; set; } = null;
        public virtual required Period Period { get; set; }
    }
}
