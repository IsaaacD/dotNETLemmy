using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dotNETLemmy.API.Types.Responses
{
    public class GetCommentResponse : Response
    {
        [JsonInclude] public CommentView CommentView { get; private set; } = null!;
    }

}
