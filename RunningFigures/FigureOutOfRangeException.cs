namespace RunningFigures
{
    using System;

    class FigureOutOfRangeException : Exception
    {
        private string name = string.Empty;

        public FigureOutOfRangeException()
            : base()
        {
        }

        public FigureOutOfRangeException(string name, string message)
            : base(message)
        {
            this.name = name;
        }

        public FigureOutOfRangeException(string message)
            : base(message)
        { }

        public FigureOutOfRangeException(string message, System.Exception inner)
            : base(message, inner)
        { }

        protected FigureOutOfRangeException(
                  System.Runtime.Serialization.SerializationInfo info,
                  System.Runtime.Serialization.StreamingContext context)
        { }

        public override string Message
        {
            get { return this.Message; }
        }
    }
}
