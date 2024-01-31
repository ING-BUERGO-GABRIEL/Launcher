using RestSharp;
using RmsUpdateApiNet.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmsUpdateApiNet.Http
{
    public class RmsUpdateHttpClient
    {       
        public RmsUpdateHttpClient(string username, string password) 
        {
            LoginModelo = new LoginModelo { Username = username, Password = password };
        }

        public LoginModelo LoginModelo { get; }
    }
}
