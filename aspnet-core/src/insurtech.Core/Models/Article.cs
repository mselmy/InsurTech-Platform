using Abp.Domain.Entities;
using insurtech.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Article : Entity<long>
    {
        //public long ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateOnly Date {  get; set; }
        public string ArticleImg {  get; set; }
        public long UserId { get; set; }
        public User User { get; set; }

        
    }
}
