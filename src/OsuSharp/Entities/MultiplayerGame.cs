﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OsuSharp.Enums;

namespace OsuSharp.Entities
{
    public sealed class MultiplayerGame : EntityBase
    {
        internal MultiplayerGame() { }

        /// <summary>
        ///     Gets the id of the game.
        /// </summary>
        [JsonProperty("game_id")]
        public long GameId { get; internal set; }

        /// <summary>
        ///     Gets the date time when the game started.
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartTime { get; internal set; }

        /// <summary>
        ///     Gets the date time when the game ended.
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndTime { get; internal set; }

        /// <summary>
        ///     Gets the beatmap id.
        /// </summary>
        [JsonProperty("beatmap_id")]
        public long BeatmapId { get; internal set; }

        /// <summary>
        ///     Game mode this map is made for.
        /// </summary>
        [JsonProperty("play_mode")]
        public GameMode GameMode { get; internal set; }

        /// <summary>
        ///     Gets the used kind of scoring for this game.
        /// </summary>
        [JsonProperty("scoring_type")]
        public Scoring Scoring { get; internal set; }

        /// <summary>
        ///     Gets the used kind of team for this game.
        /// </summary>
        [JsonProperty("team_type")]
        public TeamType TeamType { get; internal set; }

        /// <summary>
        ///     Gets the mods forced for that song.
        /// </summary>
        [JsonProperty("mods")]
        public Mode Modes { get; internal set; }

        /// <summary>
        ///     Gets the scores for each player of this game.
        /// </summary>
        [JsonProperty("scores")]
        public IReadOnlyList<MultiplayerScore> PlayerScores { get; internal set; }
    }
}
