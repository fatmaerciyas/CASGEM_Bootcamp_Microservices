﻿using CasgemMicroservices.Services.Basket.Dtos;
using CasgemMicroservices.Services.Basket.Services;
using CasgemMicroservices.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservices.Services.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _sharedIdentityService;

        public BasketsController(IBasketService basketService, ISharedIdentityService sharedIdentityService)
        {
            _basketService = basketService;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {
            //var claims = User.Claims;
            return Ok(await _basketService.GetBasket(_sharedIdentityService.GetUserID));
        }
        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketDto)
        {
            basketDto.UserID = _sharedIdentityService.GetUserID;
            var response = await _basketService.SaveOrUpdate(basketDto);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            //Sepetin tamamnııı silmek için ürn kaldırmak istesek ajax kullanabilirz
            return Ok(await _basketService.DeleteBasket(_sharedIdentityService.GetUserID));
        }
    }
}
