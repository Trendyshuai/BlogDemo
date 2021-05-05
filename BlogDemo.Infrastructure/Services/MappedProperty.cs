using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDemo.Infrastructure.Services
{
    public class MappedProperty
    {
        public string Name { get; set; }

        // 排序是否相反
        public bool Revert { get; set; }
    }
}
