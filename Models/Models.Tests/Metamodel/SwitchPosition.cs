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
    /// The default implementation of the SwitchPosition class
    /// </summary>
    [XmlNamespaceAttribute("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark")]
    [XmlNamespacePrefixAttribute("hu.bme.mit.trainbenchmark")]
    [ModelRepresentationClassAttribute("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark#//SwitchPosition/")]
    [DebuggerDisplayAttribute("SwitchPosition {Id}")]
    public class SwitchPosition : RailwayElement, ISwitchPosition, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Position property
        /// </summary>
        private Position _position;
        
        /// <summary>
        /// The backing field for the Switch property
        /// </summary>
        private ISwitch _switch;
        
        /// <summary>
        /// The position property
        /// </summary>
        [XmlElementNameAttribute("position")]
        [XmlAttributeAttribute(true)]
        public virtual Position Position
        {
            get
            {
                return this._position;
            }
            set
            {
                if ((this._position != value))
                {
                    Position old = this._position;
                    this._position = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPositionChanged(e);
                    this.OnPropertyChanged("Position", e);
                }
            }
        }
        
        /// <summary>
        /// The switch property
        /// </summary>
        [XmlElementNameAttribute("switch")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("positions")]
        public virtual ISwitch Switch
        {
            get
            {
                return this._switch;
            }
            set
            {
                if ((this._switch != value))
                {
                    ISwitch old = this._switch;
                    this._switch = value;
                    if ((old != null))
                    {
                        old.Positions.Remove(this);
                        old.Deleted -= this.OnResetSwitch;
                    }
                    if ((value != null))
                    {
                        if ((value.Positions.Contains(this) != true))
                        {
                            value.Positions.Add(this);
                        }
                        value.Deleted += this.OnResetSwitch;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSwitchChanged(e);
                    this.OnPropertyChanged("Switch", e);
                }
            }
        }
        
        /// <summary>
        /// The route property
        /// </summary>
        [XmlElementNameAttribute("route")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("follows")]
        public virtual IRoute Route
        {
            get
            {
                return ModelHelper.CastAs<IRoute>(this.Parent);
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
                return base.ReferencedElements.Concat(new SwitchPositionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark#//SwitchPosition/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Position property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> PositionChanged;
        
        /// <summary>
        /// Gets fired when the Switch property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> SwitchChanged;
        
        /// <summary>
        /// Gets fired when the Route property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> RouteChanged;
        
        /// <summary>
        /// Raises the PositionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPositionChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.PositionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SwitchChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSwitchChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.SwitchChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Switch property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSwitch(object sender, EventArgs eventArgs)
        {
            this.Switch = null;
        }
        
        /// <summary>
        /// Raises the RouteChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRouteChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.RouteChanged;
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
            IRoute oldRoute = ModelHelper.CastAs<IRoute>(oldParent);
            IRoute newRoute = ModelHelper.CastAs<IRoute>(newParent);
            if ((oldRoute != null))
            {
                oldRoute.Follows.Remove(this);
            }
            if ((newRoute != null))
            {
                newRoute.Follows.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRoute, newRoute);
            this.OnRouteChanged(e);
            this.OnPropertyChanged("Route", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "POSITION"))
            {
                return this.Position;
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
            if ((feature == "SWITCH"))
            {
                this.Switch = ((ISwitch)(value));
                return;
            }
            if ((feature == "ROUTE"))
            {
                this.Route = ((IRoute)(value));
                return;
            }
            if ((feature == "POSITION"))
            {
                this.Position = ((Position)(value));
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
            if ((attribute == "SWITCH"))
            {
                return new SwitchProxy(this);
            }
            if ((attribute == "ROUTE"))
            {
                return new RouteProxy(this);
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
            if ((reference == "SWITCH"))
            {
                return new SwitchProxy(this);
            }
            if ((reference == "ROUTE"))
            {
                return new RouteProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://www.semanticweb.org/ontologies/2015/ttc/trainbenchmark#//SwitchPosition/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SwitchPosition class
        /// </summary>
        public class SwitchPositionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SwitchPosition _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SwitchPositionReferencedElementsCollection(SwitchPosition parent)
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
                    if ((this._parent.Switch != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Route != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SwitchChanged += this.PropagateValueChanges;
                this._parent.RouteChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SwitchChanged -= this.PropagateValueChanges;
                this._parent.RouteChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Switch == null))
                {
                    ISwitch switchCasted = item.As<ISwitch>();
                    if ((switchCasted != null))
                    {
                        this._parent.Switch = switchCasted;
                        return;
                    }
                }
                if ((this._parent.Route == null))
                {
                    IRoute routeCasted = item.As<IRoute>();
                    if ((routeCasted != null))
                    {
                        this._parent.Route = routeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Switch = null;
                this._parent.Route = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Switch))
                {
                    return true;
                }
                if ((item == this._parent.Route))
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
                if ((this._parent.Switch != null))
                {
                    array[arrayIndex] = this._parent.Switch;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Route != null))
                {
                    array[arrayIndex] = this._parent.Route;
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
                if ((this._parent.Switch == item))
                {
                    this._parent.Switch = null;
                    return true;
                }
                if ((this._parent.Route == item))
                {
                    this._parent.Route = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Switch).Concat(this._parent.Route).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the position property
        /// </summary>
        private sealed class PositionProxy : ModelPropertyChange<ISwitchPosition, Position>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PositionProxy(ISwitchPosition modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Position Value
            {
                get
                {
                    return this.ModelElement.Position;
                }
                set
                {
                    this.ModelElement.Position = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PositionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PositionChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the switch property
        /// </summary>
        private sealed class SwitchProxy : ModelPropertyChange<ISwitchPosition, ISwitch>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SwitchProxy(ISwitchPosition modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISwitch Value
            {
                get
                {
                    return this.ModelElement.Switch;
                }
                set
                {
                    this.ModelElement.Switch = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SwitchChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SwitchChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the route property
        /// </summary>
        private sealed class RouteProxy : ModelPropertyChange<ISwitchPosition, IRoute>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RouteProxy(ISwitchPosition modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRoute Value
            {
                get
                {
                    return this.ModelElement.Route;
                }
                set
                {
                    this.ModelElement.Route = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RouteChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RouteChanged -= handler;
            }
        }
    }
}

