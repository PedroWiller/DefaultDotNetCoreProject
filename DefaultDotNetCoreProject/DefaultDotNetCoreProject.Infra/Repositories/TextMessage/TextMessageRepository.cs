using DefaultDotNetCoreProject.Domain.Services.TextMessage;
using DefaultDotNetCoreProject.Domain.Services.TextMessage.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultDotNetCoreProject.Infra.Repositories.TextMessage
{
    public class TextMessageRepository : ITextMessageRepository
    {
        public IEnumerable<TextMessageDto> GetAll()
        {
            return CreateFakeData();
        }

        public TextMessageDto GetById(int id)
        {
            return CreateFakeData().FirstOrDefault(x => x.Id == id);
        }

        public void Post(TextMessageDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Put(TextMessageDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        private List<TextMessageDto> CreateFakeData()
        {
            var textMessages = new List<TextMessageDto>
            {
                new TextMessageDto
                {
                    Id = 1,
                    Guid = Guid.NewGuid(),
                    Message = "Desta maneira, a constante divulgação das informações representa uma " +
                              "abertura para a melhoria de alternativas às soluções ortodoxas"
                },
                new TextMessageDto
                {
                    Id = 2,
                    Guid = Guid.NewGuid(),
                    Message =
                        "Acima de tudo, é fundamental ressaltar que o novo modelo estrutural aqui preconizado agrega valor " +
                        "ao estabelecimento das posturas dos órgãos dirigentes com relação às suas atribuições."
                },
                new TextMessageDto
                {
                    Id = 3,
                    Guid = Guid.NewGuid(),
                    Message =
                        "Desta maneira, o surgimento do comércio virtual aponta para a melhoria das formas de ação."
                }
            };

            return textMessages;
        }
    }
}
