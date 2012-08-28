/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 15:29
 * 
 *  */
using System;
using FluentNHibernate.Automapping;

namespace console.Plumbing.NHibernate
{
	/// <summary>
	/// Description of AutoMappingConfiguration.
	/// </summary>
	public class AutoMappingConfiguration:DefaultAutomappingConfiguration
	{
		public override bool ShouldMap(Type type)
		{
			return type.Namespace=="console.Domain";
		}
	}
}
