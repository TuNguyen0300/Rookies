using CoreFramework.APICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFramework.Services
{
    public class MockAPILoginService
    {
        public string userLoginPath = "/userlogin";
        private APIResponse LoginRequest(string username, string pasword)
        {
            APIRequest request = new APIRequest()
                .SetUrl("http://602e2a04410730017c5025a.mockapi.io" + "/userlogin")
                .AddHeader("Content-type", "application/x-www-form-urlencoded")
                .AddFormData("username", username)
                .AddFormData("password", pasword)
                .Post();
            return response;
        }
    }
}
