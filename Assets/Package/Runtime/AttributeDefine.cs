using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EUI
{
    [AttributeUsage(AttributeTargets.Method)]
    public class PropertyWatcherAttribute : Attribute
    {
        public string Model { get; set; }
        public string Name { get; set; }
    }

}