using System;
using System.Net;


namespace Amazon.Runtime
{
    public static class AmazonWebServiceResponseExtensions
    {
        public static bool Ok(this AmazonWebServiceResponse response)
        {
            var isOk = response.HttpStatusCode.IsOk();
            return isOk;
        }
    }
}
