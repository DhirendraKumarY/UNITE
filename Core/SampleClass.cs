using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Authlete.Util;

using Newtonsoft.Json.Linq;
using RestSharp;

namespace UNITE.Core
{
    public class SampleClass
    {
        
        public static void main(String[] arg)
        {
            Console.WriteLine("Starting of main method");
            Console.ReadLine();
        }

        /*public void Main()
        {
           
            //Console.WriteLine("Starting of main method");
            //Console.ReadLine();
            APIHelper apidriver;
            apidriver = new BaseDriverHelper();
            string uri = apidriver.getBaseURI("v1/home");
            uri = uri + "v1/home";
            apidriver.generatePayLoad();
            apidriver.submitRequest(Method.GET, uri);
            //apidriver.updateRequestHeader("");
        }*/
    }
}
