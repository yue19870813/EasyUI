using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EUI
{
    [AttributeUsage(AttributeTargets.Method)]
    public class WatcherAttribute : Attribute
    {
        public string Model { get; set; }
        public string Name { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ObserveObjectAttribute : Attribute
    {

    }

}