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
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Tests.Railway
{
    
    
    /// <summary>
    /// The default implementation of the Semaphore class
    /// </summary>
    [XmlNamespaceAttribute("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark")]
    [XmlNamespacePrefixAttribute("hu.bme.mit.trainbenchmark")]
    [ModelRepresentationClassAttribute("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark#//Semaphore/")]
    [DebuggerDisplayAttribute("Semaphore {Id}")]
    public class Semaphore : RailwayElement, ISemaphore, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Signal property
        /// </summary>
        private Signal _signal;
        
        /// <summary>
        /// The signal property
        /// </summary>
        [XmlElementNameAttribute("signal")]
        [XmlAttributeAttribute(true)]
        public virtual Signal Signal
        {
            get
            {
                return this._signal;
            }
            set
            {
                if ((this._signal != value))
                {
                    Signal old = this._signal;
                    this._signal = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSignalChanged(e);
                    this.OnPropertyChanged("Signal", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark#//Semaphore/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Signal property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> SignalChanged;
        
        /// <summary>
        /// Raises the SignalChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSignalChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.SignalChanged;
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
            if ((attribute == "SIGNAL"))
            {
                return this.Signal;
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
            if ((feature == "SIGNAL"))
            {
                this.Signal = ((Signal)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark#//Semaphore/")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the signal property
        /// </summary>
        private sealed class SignalProxy : ModelPropertyChange<ISemaphore, Signal>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SignalProxy(ISemaphore modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Signal Value
            {
                get
                {
                    return this.ModelElement.Signal;
                }
                set
                {
                    this.ModelElement.Signal = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SignalChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SignalChanged -= handler;
            }
        }
    }
}
