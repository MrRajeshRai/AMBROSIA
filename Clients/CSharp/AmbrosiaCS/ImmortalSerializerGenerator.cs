﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Ambrosia
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Git\Franklin\AmbrosiaCS\ImmortalSerializerGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class ImmortalSerializerGenerator : ImmortalSerializerGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml;

using Ambrosia;
using static Ambrosia.StreamCommunicator;
");
            
            #line 18 "C:\Git\Franklin\AmbrosiaCS\ImmortalSerializerGenerator.tt"

    foreach (var N in this.classNamespaces) {

            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 21 "C:\Git\Franklin\AmbrosiaCS\ImmortalSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(N));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 22 "C:\Git\Franklin\AmbrosiaCS\ImmortalSerializerGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write(@"
namespace Ambrosia
{
    /// <summary>
    /// This class is the serializer that supports serialization of a Immortal and has the generated classes as a known types
    /// </summary>]
    public class ImmortalSerializer : ImmortalSerializerBase
    {		
		public ImmortalSerializer()
		{
			base.KnownTypes = new SerializableType[] 
			{
");
            
            #line 35 "C:\Git\Franklin\AmbrosiaCS\ImmortalSerializerGenerator.tt"

    foreach (var T in this.typeNames) {

            
            #line default
            #line hidden
            this.Write("\t\t\t\tnew SerializableType(typeof(");
            
            #line 38 "C:\Git\Franklin\AmbrosiaCS\ImmortalSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(T));
            
            #line default
            #line hidden
            this.Write(")),\r\n");
            
            #line 39 "C:\Git\Franklin\AmbrosiaCS\ImmortalSerializerGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\tnew SerializableType(this.GetType())\r\n\t\t\t};\r\n\t\t}\r\n\r\n        public override l" +
                    "ong SerializeSize(Immortal c)\r\n        {\r\n            var serializer = new DataC" +
                    "ontractSerializer(c.GetType(), this.KnownTypes.Select(kt => kt.Type).ToArray());" +
                    "\r\n            long retVal = -1;\r\n            using (var countStream = new CountS" +
                    "tream())\r\n            {\r\n                using (var writer = XmlDictionaryWriter" +
                    ".CreateBinaryWriter(countStream))\r\n                {\r\n                    serial" +
                    "izer.WriteObject(writer, c);\r\n                }\r\n                retVal = countS" +
                    "tream.Length;\r\n            }\r\n            return retVal;\r\n        }\r\n\r\n        p" +
                    "ublic override void Serialize(Immortal c, Stream writeToStream)\r\n        {\r\n    " +
                    "        // nned to create\r\n            var serializer = new DataContractSerializ" +
                    "er(c.GetType(), this.KnownTypes.Select(kt => kt.Type).ToArray());\r\n            u" +
                    "sing (var writer = XmlDictionaryWriter.CreateBinaryWriter(writeToStream))\r\n     " +
                    "       {\r\n                serializer.WriteObject(writer, c);\r\n            }\r\n   " +
                    "     }\r\n\r\n\t\tpublic override Immortal Deserialize(Type runtimeType, Stream stream" +
                    ")\r\n        {\r\n            var serializer = new DataContractSerializer(runtimeTyp" +
                    "e, this.KnownTypes.Select(kt => kt.Type).ToArray());\r\n            using (var rea" +
                    "der = XmlDictionaryReader.CreateBinaryReader(stream, XmlDictionaryReaderQuotas.M" +
                    "ax))\r\n            {\r\n                return (Immortal)serializer.ReadObject(read" +
                    "er);\r\n            }\r\n        }\r\n    }\r\n\r\n\tpublic interface Empty : IEmpty \r\n\t{\r\n" +
                    "\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal class ImmortalSerializerGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
