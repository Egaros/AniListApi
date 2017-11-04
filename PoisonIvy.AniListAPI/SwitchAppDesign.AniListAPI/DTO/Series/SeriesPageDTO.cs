﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.Models.DTO;

namespace PoisonIvy.AniListAPI.DTO
{
    public class SeriesPageDTO
    {
        public long id { get; set; }
        public string title_romaji { get; set; }
        public string title_english { get; set; }
        public string title_japanese { get; set; }
        public string type { get; set; }
        public string series_type { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string start_date_fuzzy { get; set; }
        public string end_date_fuzzy { get; set; }
        public string season { get; set; }
        public string description { get; set; }
        public bool adult { get; set; }
        public decimal average_score { get; set; }
        public int? popularity { get; set; }
        public bool favourite { get; set; }
        public string image_url_sml { get; set; }
        public string image_url_med { get; set; }
        public string image_url_lge { get; set; }
        public string image_url_banner { get; set; }
        public List<string> genres { get; set; }
        public List<string> synonyms { get; set; }
        public string youtube_id { get; set; }
        public string hashtag { get; set; }
        public string updated_at { get; set; }
        public Dictionary<string, int> score_distribution { get; set; }
        public Dictionary<string, int> list_stats { get; set; }
        public int? total_episodes { get; set; }
        public int? duration { get; set; }
        public string airing_status { get; set; }
        public string source { get; set; }
        public string classification { get; set; }
        public Dictionary<string, AiringStatsDTO> airing_stats { get; set; }
        public List<SmallCharacterDTO> characters { get; set; }
        public List<SmallStaffDTO> staff { get; set; }
        public List<StudioDTO> studio { get; set; }
        public List<ExternalLinkDTO> external_links { get; set; }
        public List<RankingDTO> rankings { get; set; }
        public List<RelationDTO> relations { get; set; }
        public List<TagDTO> tags { get; set; }
        public AiringDTO airing { get; set; }
    }
}
