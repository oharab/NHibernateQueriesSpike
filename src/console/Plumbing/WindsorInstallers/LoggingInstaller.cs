/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 14:21
 * 
 *  */
using System;
using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace console.Plumbing.WindsorInstallers
{
	/// <summary>
	/// Description of LoggingInstaller.
	/// </summary>
	public class LoggingInstaller:IWindsorInstaller
	{
		public LoggingInstaller()
		{
		}
		
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.AddFacility<LoggingFacility>(f =>f.WithAppConfig()
			                                       .LogUsing(LoggerImplementation.Log4net)
			                                      );
		}
	}
}
