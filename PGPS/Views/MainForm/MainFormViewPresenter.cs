using PGPS;
using PGPS.Properties;
using System;

namespace PGPS.Views.MainForm
{
internal class MainFormViewPresenter
{
	private MainFormModel _model;

	private IMainFormView _view;

	public MainFormViewPresenter(IMainFormView view)
	{
		this._view = view;
		this._model = new MainFormModel();
		this.Parse(Resources.SampleInput, Resources.SampleNotify == "true", Resources.SampleAttribute);
	}

	public void Parse(string input, bool generateNotification, string attribute)
	{
		this._model.BeginInit();
		this._model.Input = input;
		this._model.IsINotifyPropertyChanged = generateNotification;
		this._model.AttributeDecorator = attribute;
		this._model.EndInit();
		this._view.ShowResult(this._model);
	}
}
}