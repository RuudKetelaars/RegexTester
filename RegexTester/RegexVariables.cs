using System.Text.RegularExpressions;

namespace RegexTester
{
  class RegexVariables
  {
    private RegexOptions _regexOptions;
    private string _regexPattern;
    private string _regexReplace;
    private string _regexText;
    private bool _regexGlobal;

    public RegexOptions RegexOptions
    {
      get { return _regexOptions; }
      set { _regexOptions = value; }
    }

    public string RegexPattern
    {
      get { return _regexPattern; }
      set { _regexPattern = value; }
    }

    public string RegexReplace
    {
      get { return _regexReplace; }
      set { _regexReplace = value; }
    }

    public string RegexText
    {
      get { return _regexText; }
      set { _regexText = value; }
    }

    public bool RegexGlobal
    {
      get { return _regexGlobal; }
      set { _regexGlobal = value; }
    }
  }
}
