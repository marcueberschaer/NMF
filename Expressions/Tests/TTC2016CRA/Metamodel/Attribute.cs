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

namespace ConsoleApplication1.ArchitectureCRA
{
    
    
    /// <summary>
    /// The default implementation of the Attribute class
    /// </summary>
    [XmlNamespaceAttribute("http://momot.big.tuwien.ac.at/architectureCRA/1.0")]
    [XmlNamespacePrefixAttribute("architectureCRA")]
    [ModelRepresentationClassAttribute("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Attribute/")]
    [DebuggerDisplayAttribute("Attribute {Name}")]
    public class Attribute : Feature, IAttribute, IModelElement
    {
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Attribute/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://momot.big.tuwien.ac.at/architectureCRA/1.0#//Attribute/")));
            }
            return _classInstance;
        }
    }
}

