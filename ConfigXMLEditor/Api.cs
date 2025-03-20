using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using RestSharp;

namespace ConfigXMLEditor
{
    internal class Api
    {
        public Api()
        {

        }

        public void apicall()
        {
                        var client = new RestClient("https://localhost:7282/api/Users");
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""str"": ""sugu"",
" + "\n" +
            @"    ""str1"": ""sugu""
" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            System.Windows.Forms.MessageBox.Show(response.Content, "API Message");
        }
    }
}
