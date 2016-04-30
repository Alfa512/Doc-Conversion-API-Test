using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ResultBool :  IEquatable<ResultBool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultBool" /> class.
        /// </summary>
        public ResultBool()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public bool? Data { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorId
        /// </summary>
        [DataMember(Name="ErrorId", EmitDefaultValue=false)]
        public int? ErrorId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsError
        /// </summary>
        [DataMember(Name="IsError", EmitDefaultValue=false)]
        public bool? IsError { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultBool {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
            sb.Append("  IsError: ").Append(IsError).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ResultBool);
        }

        /// <summary>
        /// Returns true if ResultBool instances are equal
        /// </summary>
        /// <param name="other">Instance of ResultBool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultBool other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.ErrorId == other.ErrorId ||
                    this.ErrorId != null &&
                    this.ErrorId.Equals(other.ErrorId)
                ) && 
                (
                    this.IsError == other.IsError ||
                    this.IsError != null &&
                    this.IsError.Equals(other.IsError)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.ErrorId != null)
                    hash = hash * 59 + this.ErrorId.GetHashCode();
                
                if (this.IsError != null)
                    hash = hash * 59 + this.IsError.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                return hash;
            }
        }

    }
}
