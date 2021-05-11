using System;


namespace Amazon.S3
{
    // See: https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList
    public static class S3ErrorCodes
    {
        public const string BucketAlreadyExists = "BucketAlreadyExists";
        public const string BucketAlreadyOwnedByYou = "BucketAlreadyOwnedByYou";
        public const string NoSuchBucket = "NoSuchBucket";
    }
}
