﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DB_993
{
    public class BlackListTable
    {
        public int Id { get; set; }
        public int Id_Realty { get; set; }
        [ForeignKey("ReltyInIdBlL")]
        public Realty? Realty_id { get; set; }
    }
}
