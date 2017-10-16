﻿using Newtonsoft.Json;
using System;

namespace ElectronNET.API.Entities
{
    public class ThumbarButton
    {
        public string Id { get; internal set; }

        [JsonIgnore]
        public Action Click { get; set; }

        /// <summary>
        /// Control specific states and behaviors of the button. By default, it is ["enabled"].
        /// 
        /// enabled - The button is active and available to the user.
        /// disabled - The button is disabled.It is present, but has a visual state indicating it will not respond to user action.
        /// dismissonclick - When the button is clicked, the thumbnail window closes immediately.
        /// nobackground - Do not draw a button border, use only the image.
        /// hidden - The button is not shown to the user.
        /// noninteractive - The button is enabled but not interactive; no pressed button state is drawn.This value is intended for instances where the button is used in a notification.
        /// </summary>
        public string[] Flags { get; set; }

        /// <summary>
        /// The icon showing in thumbnail toolbar.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The text of the button's tooltip.
        /// </summary>
        public string Tooltip { get; set; }

        public ThumbarButton(string icon)
        {
            Icon = icon;
        }
    }
}