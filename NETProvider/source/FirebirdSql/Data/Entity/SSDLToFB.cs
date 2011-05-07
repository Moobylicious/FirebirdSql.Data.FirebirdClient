﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace FirebirdSql.Data.Entity
{
    using System.Data.Metadata.Edm;
    using System.Linq;
    using System.Text;
    using System.Runtime.Remoting.Messaging;
    using System.IO;
    using System.Xml;
    using System.Collections.Generic;
    using System;
    
    
    #line 1 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class SSDLToFB : SSDLToFBBase
    {
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
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
        public virtual string TransformText()
        {
            this.GenerationEnvironment = null;
            this.Write("-- Created: ");
            
            #line 13 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now.ToString("R")));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 14 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
 
	if (StoreItems == null)
	{

            
            #line default
            #line hidden
            this.Write("-- No input.\r\n");
            
            #line 19 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

	}
	else
	{
 
            
            #line default
            #line hidden
            this.Write("-- Tables\r\n");
            
            #line 25 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"


		IDictionary<string, string> additionalColumnComments = new Dictionary<string, string>();
		foreach (var entitySet in StoreItems.GetItems<EntityContainer>()[0].BaseEntitySets.OfType<EntitySet>())
		{
			additionalColumnComments.Clear();

            
            #line default
            #line hidden
            this.Write("RECREATE TABLE ");
            
            #line 32 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Quote(entitySet.Name)));
            
            #line default
            #line hidden
            this.Write(" (\r\n");
            
            #line 33 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

			PushIndent("\t");
			foreach (EdmProperty property in entitySet.ElementType.Properties)
			{

            
            #line default
            #line hidden
            
            #line 38 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenerateColumn(property, ref additionalColumnComments)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 39 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

			}
			PopIndent();

            
            #line default
            #line hidden
            this.Write("CONSTRAINT ");
            
            #line 43 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Quote("PK_" + entitySet.Name)));
            
            #line default
            #line hidden
            this.Write(" PRIMARY KEY (");
            
            #line 43 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", entitySet.ElementType.KeyMembers.Select(pk => Quote(pk.Name)).ToArray())));
            
            #line default
            #line hidden
            this.Write(")\r\n);\r\n");
            
            #line 45 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

			foreach(string identity in entitySet.ElementType.KeyMembers.Where(pk => pk.TypeUsage.Facets.Contains("StoreGeneratedPattern") && (StoreGeneratedPattern)pk.TypeUsage.Facets["StoreGeneratedPattern"].Value == StoreGeneratedPattern.Identity).Select(i => i.Name))
			{
				additionalColumnComments.Add(identity, "#PK_GEN#");
			}
			foreach (KeyValuePair<string, string> comment in additionalColumnComments)
			{

            
            #line default
            #line hidden
            this.Write("COMMENT ON COLUMN ");
            
            #line 53 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Quote(entitySet.Name)));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 53 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Quote(comment.Key)));
            
            #line default
            #line hidden
            this.Write(" IS \'");
            
            #line 53 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comment.Value));
            
            #line default
            #line hidden
            this.Write("\';\r\n");
            
            #line 54 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

			}
		}

            
            #line default
            #line hidden
            this.Write("-- Foreign Key Constraints\r\n");
            
            #line 59 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

		foreach (var associationSet in StoreItems.GetItems<EntityContainer>()[0].BaseEntitySets.OfType<AssociationSet>())
		{
			ReferentialConstraint constraint = associationSet.ElementType.ReferentialConstraints.Single<ReferentialConstraint>(); 
			AssociationSetEnd end = associationSet.AssociationSetEnds[constraint.FromRole.Name];
			AssociationSetEnd end2 = associationSet.AssociationSetEnds[constraint.ToRole.Name];


            
            #line default
            #line hidden
            this.Write("ALTER TABLE ");
            
            #line 67 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Quote(end2.EntitySet.Name)));
            
            #line default
            #line hidden
            this.Write(" ADD CONSTRAINT ");
            
            #line 67 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Quote("FK_" + associationSet.Name)));
            
            #line default
            #line hidden
            this.Write(" FOREIGN KEY (");
            
            #line 67 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", constraint.ToProperties.Select(fk => Quote(fk.Name)).ToArray())));
            
            #line default
            #line hidden
            this.Write(")\r\nREFERENCES ");
            
            #line 68 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Quote(end.EntitySet.Name)));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 68 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", constraint.FromProperties.Select(pk => Quote(pk.Name)).ToArray())));
            
            #line default
            #line hidden
            this.Write(")\r\nON DELETE ");
            
            #line 69 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((end.CorrespondingAssociationEndMember.DeleteBehavior == OperationAction.Cascade ? "CASCADE" : "NO ACTION")));
            
            #line default
            #line hidden
            this.Write("\r\n;\r\n\r\n");
            
            #line 72 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

		}

            
            #line default
            #line hidden
            
            #line 75 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

	}

            
            #line default
            #line hidden
            this.Write("-- EOF\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 79 "C:\Users\Jiri\Desktop\NETProvider\source\FirebirdSql\Data\Entity\SSDLToFB.tt"

public StoreItemCollection StoreItemCollection { private get; set; }

private StoreItemCollection _storeItems;
private StoreItemCollection StoreItems
{
	get
	{
		if (_storeItems == null)
		{
			var ssdl = this.GetInput<string>("Ssdl");

			if (StoreItemCollection != null)
			{
				_storeItems = StoreItemCollection;
			}
			else if (ssdl != null)
			{
				 using (TextReader text = new StringReader(ssdl))
				 {
					using (XmlReader xml = XmlReader.Create(text))
					{
						_storeItems = new StoreItemCollection(new[] { xml });
					}
				}
			}
		}
		return _storeItems;
	}
}

private string Quote(string s)
{
	return "\"" + s + "\"";
}

private string GenerateColumn(EdmProperty property, ref IDictionary<string, string> columnComments)
{
	StringBuilder result = new StringBuilder();
	result.Append(Quote(property.Name));
	result.Append(" ");
	switch (property.TypeUsage.EdmType.Name)
	{
		case "varchar":
		case "char":
			result.Append(property.TypeUsage.EdmType.Name.ToUpperInvariant());
			result.AppendFormat("({0})", property.TypeUsage.Facets["MaxLength"].Value);
			break;
		case "decimal":
		case "numeric":
			result.Append(property.TypeUsage.EdmType.Name.ToUpperInvariant());
			result.AppendFormat("({0},{1})", property.TypeUsage.Facets["Precision"].Value, property.TypeUsage.Facets["Scale"].Value);
			break;
		case "clob":
			result.Append("BLOB SUB_TYPE TEXT");
			break;
		case "blob":
			result.Append("BLOB SUB_TYPE BINARY");
			break;
		case "smallint_bool":
			result.AppendFormat("SMALLINT CHECK ({0} IN (1,0))", Quote(property.Name));
			columnComments.Add(property.Name, "#BOOL#");
			break;
		case "guid":
			result.Append("CHAR(16) CHARACTER SET OCTETS");
			columnComments.Add(property.Name, "#GUID#");
			break;
		default:
			result.Append(property.TypeUsage.EdmType.Name.ToUpperInvariant());
			break;
	}
	if (!property.Nullable)
	{
	  result.Append(" NOT NULL");
	}
	return result.ToString();
}

/// <summary>
/// Retrieve data of type T from CallContext given a string-based identity.
/// This is used to pass data from a workflow into the template since the workflow
/// utilizes the VS TextTemplatingService which runs the template in a separate AppDomain.
/// </summary>
private T GetInput<T>(string identity) where T : class
{
    return CallContext.GetData(identity) as T;
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public class SSDLToFBBase
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
    }
    #endregion
}