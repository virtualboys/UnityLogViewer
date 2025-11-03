using System.Drawing;

namespace LogViewer
{
    /// <summary>
    /// 
    /// </summary>
    internal class LogLine
    {
        #region Member Variables/Properties
        public int LineNumber { get; set; } = 0;
        public int CharCount { get; set; } = 0;
        public long Offset { get; set; } = 0;
        public bool IsTerms { get; set; } = true;   // Multi-condition filtering
        public bool IsCurSearch { get; set; }
        public bool IsContextLine { get; set; } = false;    // Contextual Functions
        public long StackTraceOffset { get; set; } = 0;
        public int StackTraceCharCount { get; set; } = 0;
        public bool IsCrLine { get; set; } = false;
        public Global.LogType LogType { get; set; } = 0;
        public Color ForeColor { get; set; }       // Foreground
        #endregion
    }
}
