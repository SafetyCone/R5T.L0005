using System;


namespace Amazon.S3
{
    /// <summary>
    /// This exception type allows use to stop on this exception type, but not on <see cref="AmazonS3Exception"/> types, since those are used internally and the debugging experience is crazy.
    /// </summary>
    public class UnhandledAmazonS3Exception : Exception
    {
        public AmazonS3Exception AmazonS3Exception { get; }


        public UnhandledAmazonS3Exception(AmazonS3Exception amazonS3Exception)
            : base()
        {
            this.AmazonS3Exception = amazonS3Exception;
        }
    }
}
