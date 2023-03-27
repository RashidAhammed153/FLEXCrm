using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Models
{
    public class snmp
    {
        public string oid { get; set; }
        public string datavalue { get; set; }
    }
}
