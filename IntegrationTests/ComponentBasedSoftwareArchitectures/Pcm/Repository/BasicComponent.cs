//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Protocol;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Resourcetype;
using NMFExamples.Pcm.Seff;
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
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace NMFExamples.Pcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the BasicComponent class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/BasicComponent")]
    [DebuggerDisplayAttribute("BasicComponent {Id}")]
    public partial class BasicComponent : ImplementationComponentType, IBasicComponent, IModelElement
    {
        
        private static Lazy<ITypedElement> _serviceEffectSpecifications__BasicComponentReference = new Lazy<ITypedElement>(RetrieveServiceEffectSpecifications__BasicComponentReference);
        
        /// <summary>
        /// The backing field for the ServiceEffectSpecifications__BasicComponent property
        /// </summary>
        private BasicComponentServiceEffectSpecifications__BasicComponentCollection _serviceEffectSpecifications__BasicComponent;
        
        private static Lazy<ITypedElement> _passiveResource_BasicComponentReference = new Lazy<ITypedElement>(RetrievePassiveResource_BasicComponentReference);
        
        /// <summary>
        /// The backing field for the PassiveResource_BasicComponent property
        /// </summary>
        private BasicComponentPassiveResource_BasicComponentCollection _passiveResource_BasicComponent;
        
        private static IClass _classInstance;
        
        public BasicComponent()
        {
            this._serviceEffectSpecifications__BasicComponent = new BasicComponentServiceEffectSpecifications__BasicComponentCollection(this);
            this._serviceEffectSpecifications__BasicComponent.CollectionChanging += this.ServiceEffectSpecifications__BasicComponentCollectionChanging;
            this._serviceEffectSpecifications__BasicComponent.CollectionChanged += this.ServiceEffectSpecifications__BasicComponentCollectionChanged;
            this._passiveResource_BasicComponent = new BasicComponentPassiveResource_BasicComponentCollection(this);
            this._passiveResource_BasicComponent.CollectionChanging += this.PassiveResource_BasicComponentCollectionChanging;
            this._passiveResource_BasicComponent.CollectionChanged += this.PassiveResource_BasicComponentCollectionChanged;
        }
        
        /// <summary>
        /// The serviceEffectSpecifications__BasicComponent property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("serviceEffectSpecifications__BasicComponent")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("basicComponent_ServiceEffectSpecification")]
        [ConstantAttribute()]
        public IListExpression<IServiceEffectSpecification> ServiceEffectSpecifications__BasicComponent
        {
            get
            {
                return this._serviceEffectSpecifications__BasicComponent;
            }
        }
        
        /// <summary>
        /// The passiveResource_BasicComponent property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("passiveResource_BasicComponent")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("basicComponent_PassiveResource")]
        [ConstantAttribute()]
        public IListExpression<IPassiveResource> PassiveResource_BasicComponent
        {
            get
            {
                return this._passiveResource_BasicComponent;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new BasicComponentChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new BasicComponentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/BasicComponent")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveServiceEffectSpecifications__BasicComponentReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.BasicComponent.ClassInstance)).Resolve("serviceEffectSpecifications__BasicComponent")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ServiceEffectSpecifications__BasicComponent property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ServiceEffectSpecifications__BasicComponentCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ServiceEffectSpecifications__BasicComponent", e, _serviceEffectSpecifications__BasicComponentReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ServiceEffectSpecifications__BasicComponent property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ServiceEffectSpecifications__BasicComponentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ServiceEffectSpecifications__BasicComponent", e, _serviceEffectSpecifications__BasicComponentReference);
        }
        
        private static ITypedElement RetrievePassiveResource_BasicComponentReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.BasicComponent.ClassInstance)).Resolve("passiveResource_BasicComponent")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the PassiveResource_BasicComponent property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PassiveResource_BasicComponentCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("PassiveResource_BasicComponent", e, _passiveResource_BasicComponentReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the PassiveResource_BasicComponent property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void PassiveResource_BasicComponentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("PassiveResource_BasicComponent", e, _passiveResource_BasicComponentReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int serviceEffectSpecifications__BasicComponentIndex = ModelHelper.IndexOfReference(this.ServiceEffectSpecifications__BasicComponent, element);
            if ((serviceEffectSpecifications__BasicComponentIndex != -1))
            {
                return ModelHelper.CreatePath("serviceEffectSpecifications__BasicComponent", serviceEffectSpecifications__BasicComponentIndex);
            }
            int passiveResource_BasicComponentIndex = ModelHelper.IndexOfReference(this.PassiveResource_BasicComponent, element);
            if ((passiveResource_BasicComponentIndex != -1))
            {
                return ModelHelper.CreatePath("passiveResource_BasicComponent", passiveResource_BasicComponentIndex);
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
            if ((reference == "SERVICEEFFECTSPECIFICATIONS__BASICCOMPONENT"))
            {
                if ((index < this.ServiceEffectSpecifications__BasicComponent.Count))
                {
                    return this.ServiceEffectSpecifications__BasicComponent[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "PASSIVERESOURCE_BASICCOMPONENT"))
            {
                if ((index < this.PassiveResource_BasicComponent.Count))
                {
                    return this.PassiveResource_BasicComponent[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "SERVICEEFFECTSPECIFICATIONS__BASICCOMPONENT"))
            {
                return this._serviceEffectSpecifications__BasicComponent;
            }
            if ((feature == "PASSIVERESOURCE_BASICCOMPONENT"))
            {
                return this._passiveResource_BasicComponent;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._serviceEffectSpecifications__BasicComponent))
            {
                return "serviceEffectSpecifications__BasicComponent";
            }
            if ((container == this._passiveResource_BasicComponent))
            {
                return "passiveResource_BasicComponent";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/BasicComponent")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BasicComponent class
        /// </summary>
        public class BasicComponentChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BasicComponent _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BasicComponentChildrenCollection(BasicComponent parent)
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
                    count = (count + this._parent.ServiceEffectSpecifications__BasicComponent.Count);
                    count = (count + this._parent.PassiveResource_BasicComponent.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ServiceEffectSpecifications__BasicComponent.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.PassiveResource_BasicComponent.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ServiceEffectSpecifications__BasicComponent.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.PassiveResource_BasicComponent.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IServiceEffectSpecification serviceEffectSpecifications__BasicComponentCasted = item.As<IServiceEffectSpecification>();
                if ((serviceEffectSpecifications__BasicComponentCasted != null))
                {
                    this._parent.ServiceEffectSpecifications__BasicComponent.Add(serviceEffectSpecifications__BasicComponentCasted);
                }
                IPassiveResource passiveResource_BasicComponentCasted = item.As<IPassiveResource>();
                if ((passiveResource_BasicComponentCasted != null))
                {
                    this._parent.PassiveResource_BasicComponent.Add(passiveResource_BasicComponentCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ServiceEffectSpecifications__BasicComponent.Clear();
                this._parent.PassiveResource_BasicComponent.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ServiceEffectSpecifications__BasicComponent.Contains(item))
                {
                    return true;
                }
                if (this._parent.PassiveResource_BasicComponent.Contains(item))
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
                IEnumerator<IModelElement> serviceEffectSpecifications__BasicComponentEnumerator = this._parent.ServiceEffectSpecifications__BasicComponent.GetEnumerator();
                try
                {
                    for (
                    ; serviceEffectSpecifications__BasicComponentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = serviceEffectSpecifications__BasicComponentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    serviceEffectSpecifications__BasicComponentEnumerator.Dispose();
                }
                IEnumerator<IModelElement> passiveResource_BasicComponentEnumerator = this._parent.PassiveResource_BasicComponent.GetEnumerator();
                try
                {
                    for (
                    ; passiveResource_BasicComponentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = passiveResource_BasicComponentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    passiveResource_BasicComponentEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IServiceEffectSpecification serviceEffectSpecificationItem = item.As<IServiceEffectSpecification>();
                if (((serviceEffectSpecificationItem != null) 
                            && this._parent.ServiceEffectSpecifications__BasicComponent.Remove(serviceEffectSpecificationItem)))
                {
                    return true;
                }
                IPassiveResource passiveResourceItem = item.As<IPassiveResource>();
                if (((passiveResourceItem != null) 
                            && this._parent.PassiveResource_BasicComponent.Remove(passiveResourceItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ServiceEffectSpecifications__BasicComponent).Concat(this._parent.PassiveResource_BasicComponent).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BasicComponent class
        /// </summary>
        public class BasicComponentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BasicComponent _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BasicComponentReferencedElementsCollection(BasicComponent parent)
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
                    count = (count + this._parent.ServiceEffectSpecifications__BasicComponent.Count);
                    count = (count + this._parent.PassiveResource_BasicComponent.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ServiceEffectSpecifications__BasicComponent.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.PassiveResource_BasicComponent.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ServiceEffectSpecifications__BasicComponent.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.PassiveResource_BasicComponent.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IServiceEffectSpecification serviceEffectSpecifications__BasicComponentCasted = item.As<IServiceEffectSpecification>();
                if ((serviceEffectSpecifications__BasicComponentCasted != null))
                {
                    this._parent.ServiceEffectSpecifications__BasicComponent.Add(serviceEffectSpecifications__BasicComponentCasted);
                }
                IPassiveResource passiveResource_BasicComponentCasted = item.As<IPassiveResource>();
                if ((passiveResource_BasicComponentCasted != null))
                {
                    this._parent.PassiveResource_BasicComponent.Add(passiveResource_BasicComponentCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ServiceEffectSpecifications__BasicComponent.Clear();
                this._parent.PassiveResource_BasicComponent.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ServiceEffectSpecifications__BasicComponent.Contains(item))
                {
                    return true;
                }
                if (this._parent.PassiveResource_BasicComponent.Contains(item))
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
                IEnumerator<IModelElement> serviceEffectSpecifications__BasicComponentEnumerator = this._parent.ServiceEffectSpecifications__BasicComponent.GetEnumerator();
                try
                {
                    for (
                    ; serviceEffectSpecifications__BasicComponentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = serviceEffectSpecifications__BasicComponentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    serviceEffectSpecifications__BasicComponentEnumerator.Dispose();
                }
                IEnumerator<IModelElement> passiveResource_BasicComponentEnumerator = this._parent.PassiveResource_BasicComponent.GetEnumerator();
                try
                {
                    for (
                    ; passiveResource_BasicComponentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = passiveResource_BasicComponentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    passiveResource_BasicComponentEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IServiceEffectSpecification serviceEffectSpecificationItem = item.As<IServiceEffectSpecification>();
                if (((serviceEffectSpecificationItem != null) 
                            && this._parent.ServiceEffectSpecifications__BasicComponent.Remove(serviceEffectSpecificationItem)))
                {
                    return true;
                }
                IPassiveResource passiveResourceItem = item.As<IPassiveResource>();
                if (((passiveResourceItem != null) 
                            && this._parent.PassiveResource_BasicComponent.Remove(passiveResourceItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ServiceEffectSpecifications__BasicComponent).Concat(this._parent.PassiveResource_BasicComponent).GetEnumerator();
            }
        }
    }
}
