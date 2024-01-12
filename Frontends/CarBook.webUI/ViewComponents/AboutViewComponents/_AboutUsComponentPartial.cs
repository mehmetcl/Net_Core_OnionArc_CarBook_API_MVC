﻿using CarBook.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.webUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        /// <summary>
        /// Client Consume işlemi Apiyi tüketmek
        /// </summary>
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client =_httpClientFactory.CreateClient();  

            var responseMessage = await client.GetAsync("https://localhost:44360/api/Abouts");

            if (responseMessage.IsSuccessStatusCode) { 
            
                var jsonData=await responseMessage.Content.ReadAsStringAsync(); 

                var values=JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData); 

              
                return View(values);
            }
            return View();
        }
    }
}
