using DefaultDotNetCoreProject.Domain.Services.TextMessage.Dto;
using System.Collections.Generic;

namespace DefaultDotNetCoreProject.Domain.Services.TextMessage
{
    public interface ITextMessageService
    {
        IEnumerable<TextMessageDto> GetAll();
        TextMessageDto GetById(int id);
        bool Post(TextMessageDto dto);
        bool Put(TextMessageDto dto);
        bool Delete(int id);
    }
}