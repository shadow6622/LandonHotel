﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonApi.Infrastructure
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class SearchableStringAttribute : SearchableAttribute
    {
        public SearchableStringAttribute()
        {
            ExpressionProvider = new StringSearchExpressionProvider();
        }
    }
}