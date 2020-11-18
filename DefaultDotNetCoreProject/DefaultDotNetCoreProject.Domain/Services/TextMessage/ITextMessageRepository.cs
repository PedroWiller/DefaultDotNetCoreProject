using DefaultDotNetCoreProject.Domain.Services.TextMessage.Dto;
using System.Collections.Generic;

namespace DefaultDotNetCoreProject.Domain.Services.TextMessage
{
    public interface ITextMessageRepository
    {
        IEnumerable<TextMessageDto> GetAll();
        TextMessageDto GetById(int id);
        void Post(TextMessageDto dto);
        void Put(TextMessageDto dto);
        void Delete(int id);
    }
}
