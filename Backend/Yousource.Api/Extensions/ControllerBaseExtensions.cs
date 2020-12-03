namespace Yousource.Api.Extensions
{
    using System;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Mvc;
    using Yousource.Api.Messages;

    public static class ControllerBaseExtensions
    {
        public static IActionResult CreateResponse<T>(this ControllerBase controller, T value) where T : WebResponse
        {
            var result = default(IActionResult);
            result = controller.StatusCode(value.StatusCode, value);
            return result;
        }
    }
}
