using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Drawing;
using PGPS;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PGPS
{
public class MainFormModel
{
	private string _attributeDecorator;

	private string _input;

	private bool _isInitializing;

	private bool _isINotifyPropertyChanged;

	private string _result;

	private List<Entry> _variables;

	public string AttributeDecorator
	{
		get
		{
			return this._attributeDecorator;
		}
		set
		{
			if (this._attributeDecorator != value)
			{
				this._attributeDecorator = value;
				this.parse();
			}
		}
	}

	public string Input
	{
		get
		{
			return this._input;
		}
		set
		{
			if (this._input != value)
			{
				this._input = value;
				this.loadLines();
				this.parse();
			}
		}
	}

	public bool IsINotifyPropertyChanged
	{
		get
		{
			return this._isINotifyPropertyChanged;
		}
		set
		{
			if (this._isINotifyPropertyChanged != value)
			{
				this._isINotifyPropertyChanged = value;
				this.parse();
			}
		}
	}

	public string Result
	{
		get
		{
			return this._result;
		}
	}

	public MainFormModel()
	{
	}

	public void BeginInit()
	{
		this._isInitializing = true;
	}

	public void EndInit()
	{
		this._isInitializing = false;
		this.parse();
	}

	private void generateHeader(StringBuilder sb)
	{
		sb.AppendLine("//Don't forget to include the following:");
		sb.AppendLine("//public myClass : INotifyPropertyChanged");
		sb.AppendLine("");
		sb.AppendLine("public event PropertyChangedEventHandler PropertyChanged;");
		sb.AppendLine("private void NotifyPropertyChanged(String info)");
		sb.AppendLine("{");
		sb.AppendLine("\tif (PropertyChanged != null)");
		sb.AppendLine("\t{");
		sb.AppendLine("\t\tPropertyChanged(this, new PropertyChangedEventArgs(info));");
		sb.AppendLine("\t}");
		sb.AppendLine("}");
		sb.AppendLine();
		sb.AppendLine();
	}

	private void generatePrivateRegion(StringBuilder sb)
	{
		sb.Append("#region Private Variables");
		sb.AppendLine();
		sb.AppendLine();
		foreach (Entry _variable in this._variables)
		{
			sb.Append(_variable.Private);
			sb.AppendLine();
		}
		sb.AppendLine();
		sb.Append("#endregion");
		sb.AppendLine();
		sb.AppendLine();
		sb.AppendLine();
		sb.AppendLine();
	}

	private void generatePublicRegion(StringBuilder sb)
	{
		sb.Append("#region Public Properties");
		sb.AppendLine();
		foreach (Entry _variable in this._variables)
		{
			sb.Append(_variable.Public);
			sb.AppendLine();
		}
		sb.AppendLine();
		sb.Append("#endregion");
	}

	private void loadLines()
	{
		this._variables = new List<Entry>();
		Entry entry = null;
		string[] strArrays = this._input.Split(Environment.NewLine.ToCharArray());
		for (int i = 0; i < (int)strArrays.Length; i++)
		{
			string str = strArrays[i].Replace("\t", "").Trim();
			if (str.Length > 0)
			{
				if (entry == null)
				{
					entry = new Entry(this);
				}
				if (entry.AddLine(str))
				{
					this._variables.Add(entry);
					entry = null;
				}
			}
		}
		if (entry != null)
		{
			this._variables.Add(entry);
		}
	}

	private void parse()
	{
		if (this._isInitializing)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this._isINotifyPropertyChanged )
			{
				this.generateHeader(stringBuilder);
			}
			this.generatePrivateRegion(stringBuilder);
			this.generatePublicRegion(stringBuilder);
			this._result = stringBuilder.ToString();
		}
	}
}
}