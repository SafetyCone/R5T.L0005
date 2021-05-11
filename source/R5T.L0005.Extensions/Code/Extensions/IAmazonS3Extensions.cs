using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Amazon.S3.Model;


namespace Amazon.S3
{
    public static class IAmazonS3Extensions
    {
        public static async Task<List<S3Object>> ListAllObjects(this IAmazonS3 s3, ListObjectsV2Request listObjectsRequest)
        {
            var output = new List<S3Object>();

            ListObjectsV2Response response;
            do
            {
                response = await s3.ListObjectsV2Async(listObjectsRequest);

                output.AddRange(response.S3Objects);

                listObjectsRequest.ContinuationToken = response.NextContinuationToken;
            }
            while (response.IsTruncated);

            return output;
        }
    }
}
