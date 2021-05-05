using BlogDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDemo.Core.Entities
{
    // 抽象类，用来实现接口
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
