using DefaultDotNetCoreProject.Domain.Services.TextMessage.Dto;
using System.Collections.Generic;

namespace DefaultDotNetCoreProject.Domain.Services.TextMessage
{
    public class TextMessageService : ITextMessageService
    {
        private readonly ITextMessageRepository _textMessageRepository;

        public TextMessageService(ITextMessageRepository textMessageRepository)
        {
            _textMessageRepository = textMessageRepository;
        }

        public IEnumerable<TextMessageDto> GetAll()
        {
            return _textMessageRepository.GetAll();
        }

        public TextMessageDto GetById(int id)
        {
            return _textMessageRepository.GetById(id);
        }

        public bool Post(TextMessageDto dto)
        {
            if (dto == null)
                return false;

            if (string.IsNullOrEmpty(dto.Message))
                return false;

            _textMessageRepository.Post(dto);

            return true;
        }

        public bool Put(TextMessageDto dto)
        {
            if (dto == null)
                return false;

            if (dto.Id < 1)
                return false;

            if (string.IsNullOrEmpty(dto.Message))
                return false;

            var textMessage = _textMessageRepository.GetById(dto.Id);
            if (textMessage == null)
                return false;

            textMessage.Message = dto.Message;

            _textMessageRepository.Put(textMessage);

            return true;
        }

        public bool Delete(int id)
        {
            if (id < 1)
                return false;

            var textMessage = _textMessageRepository.GetById(id);
            if (textMessage == null)
                return false;

            _textMessageRepository.Delete(id);

            return true;
        }
    }
}