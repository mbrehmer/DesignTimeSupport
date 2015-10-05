using Caliburn.Micro;
using DesignTimeSupport.ContentControls.ViewModels;
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
		private MainWindowContentViewModel _windowContent;

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
			WindowContent = DesignTimeHelpers.DesignTimeModels.MainWindowContentViewModel;
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

		/// <summary>
		/// Gets or sets the content of the window.
		/// </summary>
		/// <value>
		/// The content of the window.
		/// </value>
		public MainWindowContentViewModel WindowContent
		{
			get { return _windowContent; }
			set
			{
				_windowContent = value;
				NotifyOfPropertyChange(() => WindowContent);
			}
		}
	}
}