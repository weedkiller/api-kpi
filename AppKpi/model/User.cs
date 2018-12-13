﻿using Newtonsoft.Json;
using SQLite;

namespace AppKpi.model
{
    public class User
    {
        [PrimaryKey, Column("id")]
        [JsonProperty("id")]
        public int UserId { get; set; }

        [Column("name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Column("email")]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Column("token")]
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
