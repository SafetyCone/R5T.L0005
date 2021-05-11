using System;


namespace Amazon.S3
{
    public static class AmazonS3ExceptionExtensions
    {
        public static bool BucketAlreadyExists(this AmazonS3Exception exception)
        {
            var output = S3ExceptionHelper.IsBucketAlreadyExists(exception);
            return output;
        }

        public static bool BucketNameAlreadyTaken(this AmazonS3Exception exception)
        {
            var output = S3ExceptionHelper.IsBucketNameAlreadyTaken(exception);
            return output;
        }

        public static bool BucketNotFound(this AmazonS3Exception exception)
        {
            var output = S3ExceptionHelper.IsBucketNotFound(exception);
            return output;
        }
    }
}
