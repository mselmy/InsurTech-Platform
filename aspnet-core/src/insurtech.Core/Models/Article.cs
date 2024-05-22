using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateOnly Date {  get; set; }
        public string ArticleImg {  get; set; }
        public int InsuranceUserId { get; set; } 
        public virtual InsuranceUser User { get; set; }
    }
}
