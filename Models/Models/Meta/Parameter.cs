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
    /// The default implementation of the Parameter class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//Parameter")]
    [DebuggerDisplayAttribute("Parameter {Name}")]
    public partial class Parameter : TypedElement, IParameter, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the Direction property
        /// </summary>
        private NMF.Models.Meta.Direction _direction;
        
        private static Lazy<ITypedElement> _directionAttribute = new Lazy<ITypedElement>(RetrieveDirectionAttribute);
        
        private static Lazy<ITypedElement> _operationReference = new Lazy<ITypedElement>(RetrieveOperationReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Direction property
        /// </summary>
        [CategoryAttribute("Parameter")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.Meta.Direction Direction
        {
            get
            {
                return this._direction;
            }
            set
            {
                if ((this._direction != value))
                {
                    NMF.Models.Meta.Direction old = this._direction;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDirectionChanging(e);
                    this.OnPropertyChanging("Direction", e, _directionAttribute);
                    this._direction = value;
                    this.OnDirectionChanged(e);
                    this.OnPropertyChanged("Direction", e, _directionAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Operation property
        /// </summary>
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Parameters")]
        public IOperation Operation
        {
            get
            {
                return ModelHelper.CastAs<IOperation>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ParameterReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Parameter")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Direction property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DirectionChanging;
        
        /// <summary>
        /// Gets fired when the Direction property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DirectionChanged;
        
        /// <summary>
        /// Gets fired before the Operation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OperationChanging;
        
        /// <summary>
        /// Gets fired when the Operation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OperationChanged;
        
        private static ITypedElement RetrieveDirectionAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(Parameter.ClassInstance)).Resolve("Direction")));
        }
        
        /// <summary>
        /// Raises the DirectionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDirectionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DirectionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DirectionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDirectionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DirectionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveOperationReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(Parameter.ClassInstance)).Resolve("Operation")));
        }
        
        /// <summary>
        /// Raises the OperationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOperationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OperationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            IOperation oldOperation = ModelHelper.CastAs<IOperation>(oldParent);
            IOperation newOperation = ModelHelper.CastAs<IOperation>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldOperation, newOperation);
            this.OnOperationChanging(e);
            this.OnPropertyChanging("Operation", e, _operationReference);
        }
        
        /// <summary>
        /// Raises the OperationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOperationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OperationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            IOperation oldOperation = ModelHelper.CastAs<IOperation>(oldParent);
            IOperation newOperation = ModelHelper.CastAs<IOperation>(newParent);
            if ((oldOperation != null))
            {
                oldOperation.Parameters.Remove(this);
            }
            if ((newOperation != null))
            {
                newOperation.Parameters.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldOperation, newOperation);
            this.OnOperationChanged(e);
            this.OnPropertyChanged("Operation", e, _operationReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "OPERATION"))
            {
                return this.Operation;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "DIRECTION"))
            {
                return this.Direction;
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
            if ((feature == "OPERATION"))
            {
                this.Operation = ((IOperation)(value));
                return;
            }
            if ((feature == "DIRECTION"))
            {
                this.Direction = ((NMF.Models.Meta.Direction)(value));
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
            if ((attribute == "DIRECTION"))
            {
                return Observable.Box(new DirectionProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "OPERATION"))
            {
                return new OperationProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//Parameter")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Parameter class
        /// </summary>
        public class ParameterReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Parameter _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ParameterReferencedElementsCollection(Parameter parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Operation != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.OperationChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.OperationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Operation == null))
                {
                    IOperation operationCasted = item.As<IOperation>();
                    if ((operationCasted != null))
                    {
                        this._parent.Operation = operationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Operation = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Operation))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Operation != null))
                {
                    array[arrayIndex] = this._parent.Operation;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.Operation == item))
                {
                    this._parent.Operation = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Operation).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Direction property
        /// </summary>
        private sealed class DirectionProxy : ModelPropertyChange<IParameter, NMF.Models.Meta.Direction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DirectionProxy(IParameter modelElement) : 
                    base(modelElement, "Direction")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.Direction Value
            {
                get
                {
                    return this.ModelElement.Direction;
                }
                set
                {
                    this.ModelElement.Direction = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Operation property
        /// </summary>
        private sealed class OperationProxy : ModelPropertyChange<IParameter, IOperation>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OperationProxy(IParameter modelElement) : 
                    base(modelElement, "Operation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOperation Value
            {
                get
                {
                    return this.ModelElement.Operation;
                }
                set
                {
                    this.ModelElement.Operation = value;
                }
            }
        }
    }
}

