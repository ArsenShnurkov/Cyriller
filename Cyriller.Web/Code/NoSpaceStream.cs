using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Cyriller
{
    public class NoSpaceStream: Stream
    {
        protected Regex pattern = new Regex(@"^\s+", RegexOptions.Multiline | RegexOptions.Compiled);
        protected readonly Stream stream;
        protected Encoding encoding;

        public NoSpaceStream(Stream Stream)
            : this(Stream, Encoding.UTF8)
        {
        }

        public NoSpaceStream(Stream Stream, Encoding Encoding)
        {
            this.stream = Stream;
            this.encoding = Encoding;
        }

        public override bool CanRead
        {
            get 
            {
                return true;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return true;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        public override long Length
        {
            get
            {
                return 0;
            }
        }

        public override long Position
        {
            get;
            set;
        }

        public override void Flush()
        {
            stream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            stream.SetLength(value);
        }

        public override void Close()
        {
            stream.Close();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            string content = encoding.GetString(buffer);

            content = pattern.Replace(content, string.Empty);

            byte[] output = encoding.GetBytes(content);

            stream.Write(output, 0, output.GetLength(0));
        }
    }
}