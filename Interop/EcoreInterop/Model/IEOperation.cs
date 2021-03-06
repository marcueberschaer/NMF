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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Interop.Ecore
{
    
    
    /// <summary>
    /// The public interface for EOperation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EOperation))]
    [XmlDefaultImplementationTypeAttribute(typeof(EOperation))]
    public interface IEOperation : IModelElement, IETypedElement
    {
        
        /// <summary>
        /// The eContainingClass property
        /// </summary>
        IEClass EContainingClass
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eTypeParameters property
        /// </summary>
        IOrderedSetExpression<IETypeParameter> ETypeParameters
        {
            get;
        }
        
        /// <summary>
        /// The eParameters property
        /// </summary>
        IOrderedSetExpression<IEParameter> EParameters
        {
            get;
        }
        
        /// <summary>
        /// The eExceptions property
        /// </summary>
        IOrderedSetExpression<IEClassifier> EExceptions
        {
            get;
        }
        
        /// <summary>
        /// The eGenericExceptions property
        /// </summary>
        IOrderedSetExpression<IEGenericType> EGenericExceptions
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the EContainingClass property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EContainingClassChanging;
        
        /// <summary>
        /// Gets fired when the EContainingClass property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EContainingClassChanged;
    }
}

