﻿using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult TokenOlustur()
        {
            return Ok(new CreateToken().TokenCreate());
        }

        [HttpGet("[action]")]
        public IActionResult AdminTokenOlustur ()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Deneme2()
        {
            return Ok("Hoşgeldiniz");
        }

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Deneme3()
        {
            return Ok("Token Başarılı Bir Şekilde Giriş Yaptı ");
        }
    }
}
