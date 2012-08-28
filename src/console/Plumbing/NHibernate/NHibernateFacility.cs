/*
 * User: 721116
 * Date: 28/08/2012
 * Time: 14:02
 * 
 *  */

using System.IO;
using System.Reflection;
using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using console.Domain;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace console.Plumbing.NHibernate
{
	/// <summary>
	/// Description of NHibernateFacility.
	/// </summary>
	public class NHibernateFacility:AbstractFacility
	{
		private string DbFile=System.IO.Path.GetFullPath(@"..\..\..\..\nhq.db");
		
		protected override void Init()
		{
			Configuration config = BuildDatabaseConfiguration();
			
			Kernel.Register(
				Component.For<ISessionFactory>()
				.UsingFactoryMethod(_ => config.BuildSessionFactory())
				,
				Component.For<ISession>()
				.UsingFactoryMethod(k => k.Resolve<ISessionFactory>().OpenSession())
				.LifeStyle.Transient
			);
		}
		
		private Configuration BuildDatabaseConfiguration()
		{
			return Fluently.Configure()
				.Database(SetupDatabase)
				.Mappings(m => m.AutoMappings.Add(
					AutoMap.AssemblyOf<Blog>(new AutoMappingConfiguration())
					.Conventions.Add(
						DefaultCascade.All()
					)
				)
				         )
				.ExposeConfiguration(c=>{
				                     	BuildSchema( c );
				                     	c.Properties[ global::NHibernate.Cfg.Environment.ReleaseConnections] = "on_close";
				                     })
				.BuildConfiguration();
		}
		
		protected virtual IPersistenceConfigurer SetupDatabase()
		{
			return SQLiteConfiguration.Standard
				//.InMemory()
				.ShowSql()
				.UseOuterJoin()
				.ConnectionString(string.Format("data source={0};version=3",DbFile))
				.ShowSql();
		}

		// Updates the database schema if there are any changes to the model
		private void BuildSchema( Configuration cfg )
		{
			 if (File.Exists(DbFile))                
			 	File.Delete(DbFile);
			new SchemaExport( cfg )
				.Create(true,true);
		}


	}
}
