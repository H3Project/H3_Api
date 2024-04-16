﻿using ICE_Repository.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public string Continent { get; set; }
        public List<Regions> RegionId { get; set; }
        public List<Language> LanguageId { get; set; }
        public List<Kitchen> KitchenId { get; set;}
    }
}
