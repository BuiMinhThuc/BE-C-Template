﻿namespace QLKS_v1.Entities
{
    public class Role : BaseEntity
    {
        public string Code { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<User>? Users { get; set; }
    }
}
