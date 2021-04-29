﻿using System;
using System.Collections.Generic;
using System.Text;

namespace revCore
{
    public class Config
    {
        public string revUrl { get; set; }
        public string workspace  { get; set;}
        public string jwt { get; set; }

        /// <summary>
        /// image upload timeOut in seconds
        /// </summary>
        public int? timeOut { get; set; }



    }
}
