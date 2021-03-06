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

namespace NMF.Models.Changes
{
    
    
    /// <summary>
    /// The public interface for CompositionListDeletion
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CompositionListDeletion))]
    [XmlDefaultImplementationTypeAttribute(typeof(CompositionListDeletion))]
    public interface ICompositionListDeletion : NMF.Models.IModelElement, IListDeletion
    {
        
        /// <summary>
        /// The deletedElement property
        /// </summary>
        [XmlElementNameAttribute("deletedElement")]
        [XmlAttributeAttribute(true)]
        NMF.Models.IModelElement DeletedElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the DeletedElement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeletedElementChanging;
        
        /// <summary>
        /// Gets fired when the DeletedElement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeletedElementChanged;
    }
}

