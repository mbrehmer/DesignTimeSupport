using Caliburn.Micro;
using System;

namespace DesignTimeSupport.ContentControls.ViewModels
{
	/// <summary>
	/// The view model for the content of the main window
	/// </summary>
	public class MainWindowContentViewModel : PropertyChangedBase
	{
		private readonly IEventAggregator eventAggregator;
		private readonly IWindowManager windowManager;

		/// <summary>
		/// Initializes a new instance of the <see cref="MainWindowContentViewModel"/> class.
		/// </summary>
		/// <param name="eventAggregator">The event aggregator.</param>
		/// <param name="windowManager">The window manager.</param>
		public MainWindowContentViewModel(IEventAggregator eventAggregator, IWindowManager windowManager)
		{
			this.eventAggregator = eventAggregator;
			this.windowManager = windowManager;
		}
	}
}