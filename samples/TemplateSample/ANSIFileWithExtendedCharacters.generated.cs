﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemplateSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.1.0.0")]
    public partial class ANSIFileWithExtendedCharacters : ANSIFileWithExtendedCharactersBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n\r\nTest to make sure that non-UTF8 files don\'t get corrupted\r\n\r\nSome french acce" +
"nted characters: éêà\r\n\r\n");


            
            #line 7 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\ANSIFileWithExtendedCharacters.cshtml"
Write();

            
            #line default
            #line hidden
WriteLiteral("\"éêà\"");


        }
        public string TransformText()
        {
            this.Execute();
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    public class ANSIFileWithExtendedCharactersBase
    {
        private System.Text.StringBuilder _generatingEnvironment = new System.Text.StringBuilder();
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                return this._generatingEnvironment;
            }
            set
            {
                this._generatingEnvironment = value;
            }
        }
        public virtual void Execute()
        {
        }
        public void WriteLiteral(string textToAppend)
        {
            
        if (String.IsNullOrEmpty(textToAppend)) {
            return; 
        }
        this.GenerationEnvironment.Append(textToAppend);;
        }
        public void Write(object value)
        {

                if ((value == null))
                {
                    return;
                }
                string stringValue;
                System.Type t = value.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null)) 
                {
                    stringValue = value.ToString();
                }
                else {
                    stringValue = ((string)(method.Invoke(value, new object[] { System.Globalization.CultureInfo.InvariantCulture })));
                }
                WriteLiteral(stringValue);
            
        }
    }
    #endregion
}
#pragma warning restore 1591