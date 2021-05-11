using System;

using Amazon.S3;


namespace Amazon.S3
{
    public static class S3ExceptionHelper
    {
        public static bool IsBucketAlreadyExists(AmazonS3Exception exception)
        {
            var output = exception.ErrorCode == S3ErrorCodes.BucketAlreadyOwnedByYou;
            return output;
        }

        public static bool IsBucketNameAlreadyTaken(AmazonS3Exception exception)
        {
            var output = exception.ErrorCode == S3ErrorCodes.BucketAlreadyExists;
            return output;
        }

        public static bool IsBucketNotFound(AmazonS3Exception exception)
        {
            var output = exception.ErrorCode == S3ErrorCodes.NoSuchBucket;
            return output;
        }
    }
}
