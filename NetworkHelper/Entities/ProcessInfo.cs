using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace NetworkHelper.Entities
{
    internal class ProcessInfo
    {
        public int HandleCount { get; internal set; }
        public int ID { get; internal set; }
        public string FileName { get; internal set; }
        public string MainWindowTitle { get; internal set; }
        public IntPtr MainWindowHandle { get; internal set; }
        public string ProcessName { get; internal set; }
        public DateTime StartTime { get; internal set; }
        public int ThreadsCount { get; internal set; }
        public long WorkingSet64 { get; internal set; }
        public TimeSpan TotalProcessorTime { get; internal set; }
    }
}
