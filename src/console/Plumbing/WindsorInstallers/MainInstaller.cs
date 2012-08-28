/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 13:30
 * 
 *  */
using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace console.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of ProgramInstaller.
	/// </summary>
	public class MainInstaller:IWindsorInstaller
	{		
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(
				Component.For<IMain>().ImplementedBy<Main>()
			);
				
		}
	}
}
