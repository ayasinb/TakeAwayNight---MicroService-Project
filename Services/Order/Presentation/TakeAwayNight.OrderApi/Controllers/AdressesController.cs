using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Application.Features.CQRS.Commands.AdressCommands;
using TakeAwayNight.Application.Features.CQRS.Handlers.AdressHandlers;
using TakeAwayNight.Application.Features.CQRS.Queries.AdressQueries;

namespace TakeAwayNight.OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly GetAdressQueryHandler _getAdressQueryHandler;
        private readonly GetAdressByIdQueryHandler _getAdressByIdQueryHandler;
        private readonly CreateAdressCommandHandler _createAdressCommandHandler;
        private readonly UpdateAdressCommandHandler _updateAdressCommandHandler;
        private readonly RemoveAdressCommandHandler _removeAdressCommandHandler;

        public AdressesController(GetAdressQueryHandler getAdressQueryHandler, GetAdressByIdQueryHandler getAdressByIdQueryHandler, CreateAdressCommandHandler createAdressCommandHandler, UpdateAdressCommandHandler updateAdressCommandHandler, RemoveAdressCommandHandler removeAdressCommandHandler)
        {
            _getAdressQueryHandler = getAdressQueryHandler;
            _getAdressByIdQueryHandler = getAdressByIdQueryHandler;
            _createAdressCommandHandler = createAdressCommandHandler;
            _updateAdressCommandHandler = updateAdressCommandHandler;
            _removeAdressCommandHandler = removeAdressCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> AdressList()
        {
            var value = await _getAdressQueryHandler.Handle();

            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAdressCommand command)
        {
            await _createAdressCommandHandler.Handle(command);
            return Ok("Ekleme işlemi yapıldı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAdress(int id)
        {
            await _removeAdressCommandHandler.Handle(new RemoveAdressCommand(id));
            return Ok("Silme Başarılı");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdress(int id)

        {
            var values = await _getAdressByIdQueryHandler.Handle(new GetAdressByIdQuery(id));
            return Ok(values);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateAdress(UpdateAdressCommand command)
        {
            await _updateAdressCommandHandler.Handle(command);
            return Ok("Güncelleme Başarılı");
        }

    }
}
