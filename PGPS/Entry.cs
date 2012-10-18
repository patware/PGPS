using System;
using System.Collections;
using System.Text;
using System.Drawing;

namespace PGPS
{
internal class Entry
{
	private string _accessModifier;

	private ArrayList _attributes;

	private ArrayList _comments;

	private string _dataType;

	private string _defaultValue;

	private ArrayList _defaultXmlComments;

	private string _line;

	private MainFormModel _parent;

	private string _privateName;

	private string _publicName;

	private string _suffixComment;

	private string _variableName;

	private ArrayList _xmlComments;

	public string AccessModifier
	{
		get
		{
			return this._accessModifier;
		}
		set
		{
			this._accessModifier = value;
		}
	}

	public ArrayList Attributes
	{
		get
		{
			return this._attributes;
		}
		set
		{
			this._attributes = value;
		}
	}

	public ArrayList Comments
	{
		get
		{
			return this._comments;
		}
		set
		{
			this._comments = value;
		}
	}

	public string DataType
	{
		get
		{
			return this._dataType;
		}
		set
		{
			this._dataType = value;
		}
	}

	public string DefaultValue
	{
		get
		{
			return this._defaultValue;
		}
		set
		{
			this._defaultValue = value;
		}
	}

	public string Line
	{
		get
		{
			return this._line;
		}
		set
		{
			this._line = value;
		}
	}

	public string Private
	{
		get
		{
			return this.getPrivate();
		}
	}

	public string PrivateName
	{
		get
		{
			return this._privateName;
		}
		set
		{
			this._privateName = value;
		}
	}

	public string Public
	{
		get
		{
			return this.getPublic();
		}
	}

	public string PublicName
	{
		get
		{
			return this._publicName;
		}
		set
		{
			this._publicName = value;
		}
	}

	public string SuffixComment
	{
		get
		{
			return this._suffixComment;
		}
		set
		{
			this._suffixComment = value;
		}
	}

	public string VariableName
	{
		get
		{
			return this._variableName;
		}
		set
		{
			this._variableName = value;
		}
	}

	public ArrayList XmlComments
	{
		get
		{
			if (this._xmlComments.Count == 0)
			{
				return this._defaultXmlComments;
			}
			return this._xmlComments;
		}
		set
		{
			this._xmlComments = value;
		}
	}

	public Entry(MainFormModel parent)
	{
		this._privateName = "";
		this._publicName = "";
		this._line = "";
		this._accessModifier = "public";
		this._dataType = "string";
		this._variableName = "";
		this._defaultValue = "";
		this._suffixComment = "";
		this._xmlComments = null;
		this._attributes = null;
		this._comments = null;
		this._defaultXmlComments = null;
		
		this._parent = parent;
		this._defaultXmlComments = new ArrayList();
		this._xmlComments = new ArrayList();
		this._attributes = new ArrayList();
		this._comments = new ArrayList();
		this._defaultXmlComments.Add("///<summary> TODO: Documentation</summary>");
	}

	public bool AddLine(string line)
	{
		bool flag = false;
		if (line.Length >= 3 && line.Substring(0, 3) == "///")
		{
			this._xmlComments.Add(line);
		}
		else
		{
			if (line.Length >= 2 && line.Substring(0, 2) == "//")
			{
				this._comments.Add(line);
			}
			else
			{
				if (line.Substring(0, 1) == "[")
				{
					this._attributes.Add(line);
				}
				else
				{
					this.parseLine(line);
					flag = true;
				}
			}
		}
		return flag;
	}

	private string getPrivate()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < this._comments.Count; i++)
		{
			stringBuilder.Append(this._comments[i]);
			stringBuilder.AppendLine();
		}
		if (this._privateName.Length > 0)
		{
			stringBuilder.AppendFormat("private {0} {1}", this._dataType, this._privateName);
			if (this._defaultValue.Length > 0)
			{
				stringBuilder.AppendFormat(" = {0}", this._defaultValue);
			}
			stringBuilder.Append(";");
			if (this._suffixComment.Length > 0)
			{
				stringBuilder.Append(this._suffixComment);
			}
		}
		return stringBuilder.ToString();
	}

	private string getPublic()
	{
		int i;
		StringBuilder stringBuilder = new StringBuilder();
		if (this._publicName.Length > 0)
		{
			if (this._xmlComments.Count == 0)
			{
				for (i = 0; i < this._defaultXmlComments.Count; i++)
				{
					stringBuilder.Append(this._defaultXmlComments[i]);
					stringBuilder.AppendLine();
				}
			}
			else
			{
				for (i = 0; i < this._xmlComments.Count; i++)
				{
					stringBuilder.Append(this._xmlComments[i]);
					stringBuilder.AppendLine();
				}
			}
			i = 0;
			while (i < this._attributes.Count)
			{
				stringBuilder.Append(this._attributes[i]);
				stringBuilder.AppendLine();
				i++;
			}
			if (!string.IsNullOrEmpty(this._parent.AttributeDecorator) && !string.IsNullOrEmpty(this._parent.AttributeDecorator))
			{
				string attributeDecorator = this._parent.AttributeDecorator;
				attributeDecorator = attributeDecorator.Replace("<%=public%>", this._publicName);
				attributeDecorator = attributeDecorator.Replace("<%=type%>", this._dataType);
				stringBuilder.AppendLine(attributeDecorator);
			}
			stringBuilder.AppendFormat("{0} {1} {2}", (this._accessModifier == "private" ? "public" : this._accessModifier), this._dataType, this._publicName);
			stringBuilder.AppendLine();
			stringBuilder.Append("{");
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("\tget{{return {0};}}", this._privateName);
			stringBuilder.AppendLine();
			if (this._parent.IsINotifyPropertyChanged)
			{
				stringBuilder.AppendLine("\tset");
				stringBuilder.AppendLine("\t{");
				stringBuilder.AppendFormat("\t\tif (value != {0})", this._privateName);
				stringBuilder.AppendLine();
				stringBuilder.AppendLine("\t\t{");
				stringBuilder.AppendFormat("\t\t\t{0} = value;", this._privateName);
				stringBuilder.AppendLine();
				stringBuilder.AppendFormat("\t\t\tNotifyPropertyChanged(\"{0}\");", this._publicName).AppendLine();
				stringBuilder.AppendLine("\t\t}");
				stringBuilder.AppendLine("\t}");
			}
			else
			{
				stringBuilder.AppendFormat("\tset{{{0} = value;}}", this._privateName);
				stringBuilder.AppendLine();
			}
			stringBuilder.Append("}");
		}
		return stringBuilder.ToString();
	}

	private void parseLine(string line)
	{
		string[] strArrays1 = line.Split(new char[] { (char)59 }, 2);
		if ((int)strArrays1.Length > 1)
		{
			this._suffixComment = strArrays1[1];
		}
        string[] strArrays2 = strArrays1[0].Split(new char[] { (char)61 }, 2);
		if ((int)strArrays2.Length > 1)
		{
			this._defaultValue = strArrays2[1];
		}
        string[] strArrays3 = strArrays2[0].Trim().Split(new char[] { (char)32 }, 3);
		this._variableName = strArrays3[(int)strArrays3.Length - 1];
		if (this._variableName.Length >= 2 && this._variableName.Substring(0, 2) == "m_")
		{
			this._variableName = this._variableName.Substring(2);
		}
		if (this._variableName.Length >= 1 && this._variableName.Substring(0, 1) == "_")
		{
			this._variableName = this._variableName.Substring(1);
		}
		if (this._variableName.Length > 1)
		{
			if (char.IsUpper(this._variableName, 1))
			{
				this._privateName = string.Concat("_", this._variableName);
				this._publicName = this._variableName;
			}
			else
			{
				this._variableName = string.Concat(this._variableName.Substring(0, 1).ToUpper(), this._variableName.Substring(1));
				this._privateName = string.Concat("_", this._variableName.Substring(0, 1).ToLower(), this._variableName.Substring(1));
				this._publicName = this._variableName;
			}
		}
		else
		{
			this._variableName = this._variableName.ToUpper();
			this._privateName = string.Concat("_", this._variableName.ToLower());
			this._publicName = this._variableName;
		}
		if ((int)strArrays3.Length >= 2)
		{
			this._dataType = strArrays3[(int)strArrays3.Length - 2];
		}
		if ((int)strArrays3.Length >= 3)
		{
			this._accessModifier = strArrays3[0];
		}
	}
}
}