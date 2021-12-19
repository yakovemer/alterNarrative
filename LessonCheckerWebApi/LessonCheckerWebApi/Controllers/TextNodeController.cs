using AltNarrativeLibrary.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltNarrativeWebApi.Controllers
{

    public class Info
    {

        public string externalId { get; set; }
        public string description { get; set; }

        public string type { get; set; }
        public DateTime created { get; set; }
    }

    public class TextNode
    {
        public void Map(TextNodeDb textNodeDb)
        {
            Id = textNodeDb.Id;
            title = textNodeDb.title;
            text = textNodeDb.text;
            createdAt = textNodeDb.createdAt;
            updatedAt = textNodeDb.updatedAt.ToString();
            childNodeIds = textNodeDb.childNodeIds?.Select(x  => x.ToString()).ToArray();
            parentNodeId = textNodeDb?.ToString();
        }
        public string Id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime createdAt { get; set; }

        //[BsonRepresentation(MongoDB.Bson.BsonType.Timestamp)]
        public string updatedAt { get; set; }

        public string[] childNodeIds { get; set; }
        public string parentNodeId { get; set; }

    }

    [ApiController]
    [Route("[controller]")]
    public class TextNodeController : ControllerBase
    {


        private readonly ILogger<TextNodeController> _logger;

        private readonly ITextNodeService _textNodeService;

        public TextNodeController(ILogger<TextNodeController> logger, ITextNodeService textNodeService)
        {
            _logger = logger;
            _textNodeService = textNodeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _textNodeService.GetTextNodes().Select<TextNodeDb, TextNode>(x => {
                var res = new TextNode();
                res.Map(x);
                return res;
            }).ToList();
            return Ok(result);
        }

    }
}
