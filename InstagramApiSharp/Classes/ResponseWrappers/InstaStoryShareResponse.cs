﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApiSharp.Classes.ResponseWrappers
{
    public class InstaStoryShareResponse
    {     
        //"reel_id": "2169603475",
        //                    "reel_type": "user_reel",
        //                    "is_reel_persisted": false,
        //                    "text": ""
        [JsonProperty("media")] public InstaMediaItemResponse Media { get; set; }
        [JsonProperty("reel_type")] public string ReelType { get; set; }
        [JsonProperty("is_reel_persisted")] public bool IsReelPersisted { get; set; }
        [JsonProperty("text")] public string Text { get; set; }
    }
}
