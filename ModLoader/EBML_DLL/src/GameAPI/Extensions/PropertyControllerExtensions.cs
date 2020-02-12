﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Static;
using System.Reflection;

namespace EBML.GameAPI.Extensions {

	/// <summary>
	/// Extension methods for <see cref="PropertyController"/>.
	/// </summary>
	public static class PropertyControllerExtensions {

		private static Type type = typeof(PropertyController);

		/// <summary>
		/// Gets the staticResourceBuildings field.
		/// </summary>
		/// <param name="instance">Instance</param>
		/// <returns>StaticResourceBuildings object</returns>
		public static StaticResourceBuildings GetStaticResourceBuildings (this PropertyController instance) {
			return (StaticResourceBuildings)type
				.GetField("staticResourceBuildings", BindingFlags.NonPublic | BindingFlags.Instance)
				.GetValue(instance);
		}

	}

}