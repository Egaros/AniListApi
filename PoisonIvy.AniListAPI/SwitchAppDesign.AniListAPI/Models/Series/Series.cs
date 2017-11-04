﻿using System;
using System.Collections.Generic;
using PoisonIvy.AniListAPI.DTO;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Series
    {
        public long Id { get; set; }
        public string TitleRomaji { get; set; }
        public string TitleEnglish { get; set; }
        public string TitleJapanese { get; set; }
        public MediaTypes? Type { get; set; }
        public SeriesType? SeriesType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Seasons? Season { get; set; }
        public int? Year { get; set; }
        public string Description { get; set; }
        public bool IsAdult { get; set; }
        public decimal AverageScore { get; set; }
        public int? Popularity { get; set; }
        public bool IsFavourite { get; set; }
        public string ImageUrlSmall { get; set; }
        public string ImageUrlMedium { get; set; }
        public string ImageUrlLarge { get; set; }
        public string ImageUrlBanner { get; set; }
        public List<Genres> Genres { get; set; }
        public List<string> Synonyms { get; set; }
        public string YoutubeId { get; set; }
        public string Hashtag { get; set; }
        public long UpdatedAt { get; set; }
        public Dictionary<string, int> ScoreDistribution { get; set; }
        public ListStats ListStats { get; set; }
        public int? TotalEpisodes { get; set; }
        public int? Duration { get; set; }
        public AiringStatus? AiringStatus { get; set; }
        public AnimeSourceTypes? Source { get; set; }
        public string Classification { get; set; }
        public Dictionary<string, AiringStats> AiringStats { get; set; }

    }
}
