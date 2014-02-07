﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlmsSdk.Domain
{
    public class OrganizationalUnit
    {
        public OrganizationalUnit()
        {
            this.OrganizationalUnitGuid = Guid.Empty.ToString();
            this.ParentGuid = Guid.Empty.ToString();
        }

        public string OrganizationalUnitGuid { get; set; }
        public string Name { get; set; }
        public bool IsProgram { get; set; }
        public string Url { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public string HeadTitle { get; set; }
        public string HeadName { get; set; }
        public string ExternalKey { get; set; }
        public int OrganizationId { get; set; }
        public string ParentGuid { get; set; }
    }
}
