﻿using MediaBrowser.Model.Plugins;

namespace CPULoad.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string OpenWeatherMapApiKey { get; set; }
        public string OpenWeatherMapCityCode { get; set; }
    }
}
