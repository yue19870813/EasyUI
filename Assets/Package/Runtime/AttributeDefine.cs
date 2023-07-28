using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EUI
{
    // 注册model
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public class RegisterModelAttribute : Attribute
    {
        public RegisterModelAttribute(string modelName) 
        {
            Debug.Log("=====ModelAttrbute=====");
        }

    }

    // 生成getter和setter方法
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ChangeWatcherAttribute : Attribute
    {

    }
}