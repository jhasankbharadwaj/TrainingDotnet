﻿namespace Mango.Services.AuthAPI.Models.Dto
{
    public class ResponseDto
    {
            public object? Result { get; set; }
            public bool IsSuccess { get; set; } = true;

            public string Messege { get; set; } = "";
  
    }
}
