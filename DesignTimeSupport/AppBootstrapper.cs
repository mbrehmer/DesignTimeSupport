using Caliburn.Micro;
using DesignTimeSupport.Windows.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;

namespace DesignTimeSupport
{
	/// <summary>
	/// The bootstrapper of the application
	/// </summary>
	public class AppBootstrapper : BootstrapperBase
	{
		private SimpleContainer container;

		/// <summary>
		/// Initializes a new instance of the <see cref="AppBootstrapper"/> class.
		/// </summary>
		public AppBootstrapper()
		{
			Initialize();
		}

		/// <summary>
		/// Override to configure the framework and setup your IoC container.
		/// </summary>
		protected override void Configure()
		{
			container = new SimpleContainer();

			container.Singleton<IWindowManager, WindowManager>();
			container.Singleton<IEventAggregator, EventAggregator>();
			container.PerRequest<IShell, MainWindowViewModel>();
		}

		/// <summary>
		/// Override this to provide an IoC specific implementation.
		/// </summary>
		/// <param name="service">The service to locate.</param>
		/// <param name="key">The key to locate.</param>
		/// <returns>
		/// The located service.
		/// </returns>
		protected override object GetInstance(Type service, string key)
		{
			return container.GetInstance(service, key);
		}

		/// <summary>
		/// Override this to provide an IoC specific implementation
		/// </summary>
		/// <param name="service">The service to locate.</param>
		/// <returns>
		/// The located services.
		/// </returns>
		protected override IEnumerable<object> GetAllInstances(Type service)
		{
			return container.GetAllInstances(service);
		}

		/// <summary>
		/// Override this to provide an IoC specific implementation.
		/// </summary>
		/// <param name="instance">The instance to perform injection on.</param>
		protected override void BuildUp(object instance)
		{
			container.BuildUp(instance);
		}

		protected override void OnStartup(object sender, StartupEventArgs e)
		{
			DisplayRootViewFor<IShell>();
		}
	}
}