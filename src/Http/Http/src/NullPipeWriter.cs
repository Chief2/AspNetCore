using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Pipelines
{
    public class NullPipeWriter : PipeWriter
    {
        public override void Advance(int bytes)
        {
        }

        public override void CancelPendingFlush()
        {
        }

        public override void Complete(Exception exception = null)
        {
        }

        public override ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken = default)
        {
            return new ValueTask<FlushResult>(new FlushResult(isCanceled: false, isCompleted: true));
        }

        public override Memory<byte> GetMemory(int sizeHint = 0)
        {
            return Memory<byte>.Empty;
        }

        public override Span<byte> GetSpan(int sizeHint = 0)
        {
            return Memory<byte>.Empty.Span;
        }

        public override void OnReaderCompleted(Action<Exception, object> callback, object state)
        {
        }
    }
}
