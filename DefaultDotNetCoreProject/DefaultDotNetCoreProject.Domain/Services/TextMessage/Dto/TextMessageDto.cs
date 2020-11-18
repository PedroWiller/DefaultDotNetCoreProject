using System;

namespace DefaultDotNetCoreProject.Domain.Services.TextMessage.Dto
{
    public class TextMessageDto
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Message { get; set; }
    }
}