/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 13:46
 * 
 *  */
using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using console.Plumbing.NHibernate;

namespace console.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of NHibernateInstaller.
	/// </summary>
	public class NHibernateInstaller:IWindsorInstaller
	{
		public NHibernateInstaller()
		{
		}
		
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.AddFacility<NHibernateFacility>();
		}
	}
}
