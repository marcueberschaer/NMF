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
using NMFExamples.Pcm.Core.Composition;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
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
using System.Linq;

namespace NMFExamples.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The default implementation of the Workload class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/UsageModel/5.0")]
    [XmlNamespacePrefixAttribute("usagemodel")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Workload")]
    public abstract partial class Workload : ModelElement, IWorkload, IModelElement
    {
        
        private static Lazy<ITypedElement> _usageScenario_WorkloadReference = new Lazy<ITypedElement>(RetrieveUsageScenario_WorkloadReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The usageScenario_Workload property
        /// </summary>
        [XmlElementNameAttribute("usageScenario_Workload")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("workload_UsageScenario")]
        public IUsageScenario UsageScenario_Workload
        {
            get
            {
                return ModelHelper.CastAs<IUsageScenario>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new WorkloadReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Workload")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the UsageScenario_Workload property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> UsageScenario_WorkloadChanging;
        
        /// <summary>
        /// Gets fired when the UsageScenario_Workload property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> UsageScenario_WorkloadChanged;
        
        private static ITypedElement RetrieveUsageScenario_WorkloadReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Usagemodel.Workload.ClassInstance)).Resolve("usageScenario_Workload")));
        }
        
        /// <summary>
        /// Raises the UsageScenario_WorkloadChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUsageScenario_WorkloadChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.UsageScenario_WorkloadChanging;
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
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IUsageScenario oldUsageScenario_Workload = ModelHelper.CastAs<IUsageScenario>(oldParent);
            IUsageScenario newUsageScenario_Workload = ModelHelper.CastAs<IUsageScenario>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldUsageScenario_Workload, newUsageScenario_Workload);
            this.OnUsageScenario_WorkloadChanging(e);
            this.OnPropertyChanging("UsageScenario_Workload", e, _usageScenario_WorkloadReference);
        }
        
        /// <summary>
        /// Raises the UsageScenario_WorkloadChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUsageScenario_WorkloadChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.UsageScenario_WorkloadChanged;
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
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IUsageScenario oldUsageScenario_Workload = ModelHelper.CastAs<IUsageScenario>(oldParent);
            IUsageScenario newUsageScenario_Workload = ModelHelper.CastAs<IUsageScenario>(newParent);
            if ((oldUsageScenario_Workload != null))
            {
                oldUsageScenario_Workload.Workload_UsageScenario = null;
            }
            if ((newUsageScenario_Workload != null))
            {
                newUsageScenario_Workload.Workload_UsageScenario = this;
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldUsageScenario_Workload, newUsageScenario_Workload);
            this.OnUsageScenario_WorkloadChanged(e);
            this.OnPropertyChanged("UsageScenario_Workload", e, _usageScenario_WorkloadReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "USAGESCENARIO_WORKLOAD"))
            {
                this.UsageScenario_Workload = ((IUsageScenario)(value));
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
            if ((attribute == "UsageScenario_Workload"))
            {
                return new UsageScenario_WorkloadProxy(this);
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
            if ((reference == "UsageScenario_Workload"))
            {
                return new UsageScenario_WorkloadProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Workload")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Workload class
        /// </summary>
        public class WorkloadReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Workload _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public WorkloadReferencedElementsCollection(Workload parent)
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
                    if ((this._parent.UsageScenario_Workload != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.UsageScenario_WorkloadChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.UsageScenario_WorkloadChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.UsageScenario_Workload == null))
                {
                    IUsageScenario usageScenario_WorkloadCasted = item.As<IUsageScenario>();
                    if ((usageScenario_WorkloadCasted != null))
                    {
                        this._parent.UsageScenario_Workload = usageScenario_WorkloadCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.UsageScenario_Workload = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.UsageScenario_Workload))
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
                if ((this._parent.UsageScenario_Workload != null))
                {
                    array[arrayIndex] = this._parent.UsageScenario_Workload;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.UsageScenario_Workload == item))
                {
                    this._parent.UsageScenario_Workload = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.UsageScenario_Workload).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the usageScenario_Workload property
        /// </summary>
        private sealed class UsageScenario_WorkloadProxy : ModelPropertyChange<IWorkload, IUsageScenario>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UsageScenario_WorkloadProxy(IWorkload modelElement) : 
                    base(modelElement, "usageScenario_Workload")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IUsageScenario Value
            {
                get
                {
                    return this.ModelElement.UsageScenario_Workload;
                }
                set
                {
                    this.ModelElement.UsageScenario_Workload = value;
                }
            }
        }
    }
}
