﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Core.AutoUpdate
{
    /// <summary>
    /// Represents a set of updates for a particular module.
    /// </summary>
    public class UpdatePackage
    {
        #region constructor

        public UpdatePackage()
        {
            VersionedCommands = new List<IVersionedUpdateCommand>();
            DependentModules = new List<string>();
        }

        #endregion

        #region public properties

        /// <summary>
        /// Unique identifier for the module
        /// </summary>
        public string ModuleIdentifier { get; set; }

        /// <summary>
        /// Commands to run when updating the module to a specific version
        /// </summary>
        public ICollection<IVersionedUpdateCommand> VersionedCommands { get; set; }

        /// <summary>
        /// Commands to run after all versioned commands have been run
        /// </summary>
        public ICollection<IAlwaysRunUpdateCommand> AlwaysUpdateCommands { get; set; }

        /// <summary>
        /// A collection of module identifiers that this module is dependent on
        /// </summary>
        public ICollection<string> DependentModules { get; set; }

        #endregion
    }
}
