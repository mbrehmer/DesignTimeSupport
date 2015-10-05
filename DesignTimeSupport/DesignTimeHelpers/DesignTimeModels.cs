using Caliburn.Micro;
using DesignTimeSupport.Windows.ViewModels;
using System;

namespace DesignTimeSupport.DesignTimeHelpers
{
	/// <summary>
	/// Instances of all view models needed for Design Time Support
	/// </summary>
	public static class DesignTimeModels
	{
		/// <summary>
		/// Gets or sets the main window view model.
		/// </summary>
		/// <value>
		/// The main window view model.
		/// </value>
		public static MainWindowViewModel MainWindowViewModel { get; set; }

		/// <summary>
		/// Initializes the <see cref="DesignTimeModels"/> class.
		/// </summary>
		static DesignTimeModels()
		{
			var eventAggregator = IoC.Get<IEventAggregator>();
			var windowManager = IoC.Get<IWindowManager>();

			MainWindowViewModel = new MainWindowViewModel(eventAggregator, windowManager);
		}
	}
}