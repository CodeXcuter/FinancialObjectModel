﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System;

namespace FinancialObjectModel
{
	/// <summary>
	///   IUnderlying
	/// </summary>
	public class Underlying<T> where T : Security
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="security"></param>
        public Underlying(Security security)
        {
            Security = security as T;
        }

		/// <summary>
		/// Get the specified name and ticker.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="ticker">Ticker.</param>
		internal static T GetSecurity(string name, string ticker)
		{
			return Activator.CreateInstance(typeof(T), name, ticker)  as T;
		}

		/// <summary>
		/// Gets or sets the security.
		/// </summary>
		/// <value>
		/// The security.
		/// </value>
		public T Security { get; set; }

		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return Security.ToString();
		}
	}
}

