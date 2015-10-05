using Caliburn.Micro;
using System;

namespace DesignTimeSupport.Windows.ViewModels
{
	/// <summary>
	/// The view model of the Shell (main window)
	/// </summary>
	public class MainWindowViewModel : PropertyChangedBase, IShell
	{
		private string _windowTitle;
		private readonly IEventAggregator eventAggregator;
		private readonly IWindowManager windowManager;

		/// <summary>
		/// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
		/// </summary>
		/// <param name="eventAggregator">The event aggregator.</param>
		/// <param name="windowManager">The window manager.</param>
		public MainWindowViewModel(IEventAggregator eventAggregator, IWindowManager windowManager)
		{
			this.eventAggregator = eventAggregator;
			this.windowManager = windowManager;

			WindowTitle = "Design Time Support Test";
		}

		/// <summary>
		/// Gets or sets the window title.
		/// </summary>
		/// <value>
		/// The window title.
		/// </value>
		public string WindowTitle
		{
			get { return _windowTitle; }
			set
			{
				_windowTitle = value;
				NotifyOfPropertyChange(() => WindowTitle);
			}
		}
	}
}