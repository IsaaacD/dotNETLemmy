using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETLemmy.API.Types.Forms
{
    public class GetCommentForm : IForm
    {
        public int Id { get; set; }
        public string EndPoint => "/api/v3/comment";
        public HttpMethod Method => HttpMethod.Get;

        public string? Auth { get; set; }
    }
}
