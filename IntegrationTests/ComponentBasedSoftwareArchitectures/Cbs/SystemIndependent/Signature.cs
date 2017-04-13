//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
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
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.ComponentBasedSystems.SystemIndependent
{
    
    
    /// <summary>
    /// The default implementation of the Signature class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/SystemIndependent/")]
    [XmlNamespacePrefixAttribute("system")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//SystemIndependent/Signature")]
    [DebuggerDisplayAttribute("Signature {Name}")]
    public partial class Signature : NamedElement, ISignature, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ReturnType property
        /// </summary>
        private Nullable<Type> _returnType;
        
        private static Lazy<ITypedElement> _returnTypeAttribute = new Lazy<ITypedElement>(RetrieveReturnTypeAttribute);
        
        private static Lazy<ITypedElement> _parameterReference = new Lazy<ITypedElement>(RetrieveParameterReference);
        
        /// <summary>
        /// The backing field for the Parameter property
        /// </summary>
        private ObservableCompositionOrderedSet<IParameter> _parameter;
        
        private static IClass _classInstance;
        
        public Signature()
        {
            this._parameter = new ObservableCompositionOrderedSet<IParameter>(this);
            this._parameter.CollectionChanging += this.ParameterCollectionChanging;
            this._parameter.CollectionChanged += this.ParameterCollectionChanged;
        }
        
        /// <summary>
        /// The ReturnType property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual Nullable<Type> ReturnType
        {
            get
            {
                return this._returnType;
            }
            set
            {
                if ((this._returnType != value))
                {
                    Nullable<Type> old = this._returnType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReturnTypeChanging(e);
                    this.OnPropertyChanging("ReturnType", e, _returnTypeAttribute);
                    this._returnType = value;
                    this.OnReturnTypeChanged(e);
                    this.OnPropertyChanged("ReturnType", e, _returnTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Parameter property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IParameter> Parameter
        {
            get
            {
                return this._parameter;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new SignatureChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SignatureReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//SystemIndependent/Signature")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ReturnType property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ReturnTypeChanging;
        
        /// <summary>
        /// Gets fired when the ReturnType property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ReturnTypeChanged;
        
        private static ITypedElement RetrieveReturnTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(Signature.ClassInstance)).Resolve("ReturnType")));
        }
        
        /// <summary>
        /// Raises the ReturnTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReturnTypeChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ReturnTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReturnTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReturnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ReturnTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveParameterReference()
        {
            return ((ITypedElement)(((ModelElement)(Signature.ClassInstance)).Resolve("Parameter")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Parameter property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParameterCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Parameter", e, _parameterReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Parameter property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParameterCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Parameter", e, _parameterReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int parameterIndex = ModelHelper.IndexOfReference(this.Parameter, element);
            if ((parameterIndex != -1))
            {
                return ModelHelper.CreatePath("Parameter", parameterIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "PARAMETER"))
            {
                if ((index < this.Parameter.Count))
                {
                    return this.Parameter[index];
                }
                else
                {
                    return null;
                }
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
            if ((attribute == "RETURNTYPE"))
            {
                return this.ReturnType;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "PARAMETER"))
            {
                return this._parameter;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "RETURNTYPE"))
            {
                this.ReturnType = ((Type)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._parameter))
            {
                return "Parameter";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//SystemIndependent/Signature")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Signature class
        /// </summary>
        public class SignatureChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Signature _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SignatureChildrenCollection(Signature parent)
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
                    count = (count + this._parent.Parameter.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameter.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameter.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IParameter parameterCasted = item.As<IParameter>();
                if ((parameterCasted != null))
                {
                    this._parent.Parameter.Add(parameterCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Parameter.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> parameterEnumerator = this._parent.Parameter.GetEnumerator();
                try
                {
                    for (
                    ; parameterEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parameterEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parameterEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IParameter parameterItem = item.As<IParameter>();
                if (((parameterItem != null) 
                            && this._parent.Parameter.Remove(parameterItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Signature class
        /// </summary>
        public class SignatureReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Signature _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SignatureReferencedElementsCollection(Signature parent)
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
                    count = (count + this._parent.Parameter.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameter.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameter.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IParameter parameterCasted = item.As<IParameter>();
                if ((parameterCasted != null))
                {
                    this._parent.Parameter.Add(parameterCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Parameter.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> parameterEnumerator = this._parent.Parameter.GetEnumerator();
                try
                {
                    for (
                    ; parameterEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parameterEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parameterEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IParameter parameterItem = item.As<IParameter>();
                if (((parameterItem != null) 
                            && this._parent.Parameter.Remove(parameterItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ReturnType property
        /// </summary>
        private sealed class ReturnTypeProxy : ModelPropertyChange<ISignature, Nullable<Type>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReturnTypeProxy(ISignature modelElement) : 
                    base(modelElement, "ReturnType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<Type> Value
            {
                get
                {
                    return this.ModelElement.ReturnType;
                }
                set
                {
                    this.ModelElement.ReturnType = value;
                }
            }
        }
    }
}
