//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The default implementation of the PrimitiveType class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//PrimitiveType")]
    [DebuggerDisplayAttribute("PrimitiveType {Name}")]
    public partial class PrimitiveType : Type, IPrimitiveType, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the SystemType property
        /// </summary>
        private string _systemType;
        
        private static Lazy<ITypedElement> _systemTypeAttribute = new Lazy<ITypedElement>(RetrieveSystemTypeAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The SystemType property
        /// </summary>
        [CategoryAttribute("PrimitiveType")]
        [XmlAttributeAttribute(true)]
        public string SystemType
        {
            get
            {
                return this._systemType;
            }
            set
            {
                if ((this._systemType != value))
                {
                    string old = this._systemType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSystemTypeChanging(e);
                    this.OnPropertyChanging("SystemType", e, _systemTypeAttribute);
                    this._systemType = value;
                    this.OnSystemTypeChanged(e);
                    this.OnPropertyChanged("SystemType", e, _systemTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//PrimitiveType")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the SystemType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SystemTypeChanging;
        
        /// <summary>
        /// Gets fired when the SystemType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> SystemTypeChanged;
        
        private static ITypedElement RetrieveSystemTypeAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(PrimitiveType.ClassInstance)).Resolve("SystemType")));
        }
        
        /// <summary>
        /// Raises the SystemTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystemTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SystemTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SystemTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystemTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.SystemTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "SYSTEMTYPE"))
            {
                return this.SystemType;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SYSTEMTYPE"))
            {
                this.SystemType = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "SYSTEMTYPE"))
            {
                return new SystemTypeProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//PrimitiveType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the SystemType property
        /// </summary>
        private sealed class SystemTypeProxy : ModelPropertyChange<IPrimitiveType, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SystemTypeProxy(IPrimitiveType modelElement) : 
                    base(modelElement, "SystemType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.SystemType;
                }
                set
                {
                    this.ModelElement.SystemType = value;
                }
            }
        }
    }
}

