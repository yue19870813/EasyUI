using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EUI
{
    public class ModelBase : Property
    {
        public void _Init_()
        {
            OnInit();
        }

       
        public virtual void OnInit()
        {

        }

    }
}
