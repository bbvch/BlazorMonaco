using System.Runtime.Serialization;

namespace BlazorMonaco
{
    public enum SeverityLevel
    { 
       [EnumMember(Value = "error")]
       Error,
       [EnumMember(Value = "warning")]
       Warning,
       [EnumMember(Value = "ignore")]
       Ignore
    }
    
    public class Schemas
    {
        public string Uri { get; set; }
        public string[] FileMatch { get; set; }
        public string Schema { get; set; }
    }
    
    public class DiagnosticOptions
    { 
        public bool? Validate { get; set; }
        public bool? AllowComments { get; set; }
        public Schemas[] Schemas { get; set; }
        public bool? EnableSchemaRequest { get; set; }
        public SeverityLevel? SchemaValidation { get; set; }
        public SeverityLevel? SchemaRequest { get; set; }
        public SeverityLevel? TrailingCommas { get; set; }
        public SeverityLevel? Comments { get; set; }
    }
}