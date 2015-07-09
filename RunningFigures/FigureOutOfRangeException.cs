namespace RunningFigures
{
    using System;

    /// <summary>
    /// Exception, for Figure. Calling when figure go away from board
    /// </summary>
    public class FigureOutOfRangeException : Exception
    {
        private string name = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureOutOfRangeException"/> class. Without anything.
        /// </summary>
        public FigureOutOfRangeException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureOutOfRangeException"/> class. 
        /// </summary>
        /// <param name="name">Exception name</param>
        /// <param name="message">Exception message</param>
        public FigureOutOfRangeException(string name, string message)
            : base(message)
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureOutOfRangeException"/> class. 
        /// </summary>
        /// <param name="message">Exception message</param>
        public FigureOutOfRangeException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureOutOfRangeException"/> class. 
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Base Exception</param>
        public FigureOutOfRangeException(string message, System.Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FigureOutOfRangeException"/> class. 
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">Streaming context</param>
        protected FigureOutOfRangeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        {
        }

        public override string Message
        {
            get { return this.Message; }
        }
    }
}
