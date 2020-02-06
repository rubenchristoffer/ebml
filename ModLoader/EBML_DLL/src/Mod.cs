﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace EBML {

    /// <summary>
    /// This is a an abstract class representation
    /// of a mod. The ModLoader searches for a subclass
    /// of this object after loading a Mod DLL.
    /// In other words, create a subclass of this
    /// class when creating your mod.
    /// </summary>
    public abstract class Mod {

        /// <summary>
        /// This contains information about the mod (metadata).
        /// </summary>
        public abstract ModInfo modInfo { get; }

        /// <summary>
        /// This will be called right after the mod is loaded
        /// and might be called before other mods are loaded.
        /// </summary>
        public virtual void OnLoad() {}

        /// <summary>
        /// This will be called after every mod has been loaded
        /// and should be used to initialize data.
        /// </summary>
        public virtual void OnInit() {}

        /// <summary>
        /// This will be called after every mod has been initialized.
        /// </summary>
        public virtual void OnPostInit() {}

    }

}
