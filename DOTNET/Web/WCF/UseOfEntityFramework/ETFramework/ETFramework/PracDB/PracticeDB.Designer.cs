﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ETFramework.PracDB
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PracticeDBContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PracticeDBContainer object using the connection string found in the 'PracticeDBContainer' section of the application configuration file.
        /// </summary>
        public PracticeDBContainer() : base("name=PracticeDBContainer", "PracticeDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PracticeDBContainer object.
        /// </summary>
        public PracticeDBContainer(string connectionString) : base(connectionString, "PracticeDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PracticeDBContainer object.
        /// </summary>
        public PracticeDBContainer(EntityConnection connection) : base(connection, "PracticeDBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }
    

    #endregion
    
    
}
