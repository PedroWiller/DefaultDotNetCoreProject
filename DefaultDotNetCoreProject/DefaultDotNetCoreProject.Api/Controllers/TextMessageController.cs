using DefaultDotNetCoreProject.Domain.Services.TextMessage;
using DefaultDotNetCoreProject.Domain.Services.TextMessage.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DefaultDotNetCoreProject.Api.Controllers
{
    [Route("api/textmessage")]
    public class TextMessageController : ControllerBase
    {
        private readonly ITextMessageService _textMessageService;

        public TextMessageController(ITextMessageService textMessageService)
        {
            _textMessageService = textMessageService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_textMessageService.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_textMessageService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(TextMessageDto dto)
        {
            if (!_textMessageService.Post(dto))
                return BadRequest();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TextMessageDto dto)
        {
            if (!_textMessageService.Put(dto))
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_textMessageService.Delete(id))
                return BadRequest();

            return Ok();
        }
    }
}