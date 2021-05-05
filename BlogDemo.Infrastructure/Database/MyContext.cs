using BlogDemo.Core.Entities;
using BlogDemo.Infrastructure.Database.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDemo.Infrastructure.Database
{
    // 继承于DbContext.需安装Microsoft.EntityFrameworkCore.Design包
    public class MyContext : DbContext
    {
        // base继承父类构造方法（连接字符串）
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        // 配置完约束后添加迁移 SQLite不支持修改列
        // 简写代码 override onm
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }

        public DbSet<Post> Posts { get; set; }
    }
}
