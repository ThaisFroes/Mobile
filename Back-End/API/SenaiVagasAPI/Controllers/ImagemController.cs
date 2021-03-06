﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SenaiVagasAPI.Interfaces;

namespace SenaiVagasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagemController : ControllerBase
    {
        public static IWebHostEnvironment _environment;

        public ImagemController (IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet("upload")]
        public async Task<string> EnviaArquivo([FromForm] IFormFile arquivo)
        {
            if(arquivo.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\imagens\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\imagens\\");
                    }
                    using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\imagens\\" + arquivo.FileName))
                    {
                        await arquivo.CopyToAsync(filestream);
                        filestream.Flush();
                        return "\\imagens\\" + arquivo.FileName;
                    }
                }
                catch (Exception error)
                {
                    return error.ToString();
                }
            }
            else
            {
                return "Ocorreu uma falha no envio do arquivo...";
            }
        }


    }
}
