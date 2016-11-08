using System;

namespace TestApplication1
{

  public class Trainer
  {
    void Operate()
    {
      var dog = new Poodle();
      dog.HasSpoken += dog_HasSpoken;
    }

    void dog_HasSpoken(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }

  public partial class Dog
  {
    //properties hold values
    // short form
    public string Name { get; set; }
    // long form
    private string _name;
    public string Name
    {
      get { return _name; }
      private set { _name = value; }
    }

    public event EventHandler HasSpoken;

    public void Speak(string what = "bark")
    {
      if (HasSpoken != null)
        HasSpoken(this, EventArgs.Empty);
    }

    public void Speak(int times, string what = "bark", bool sit = true)
    {

    }

    //only this class
    private void Foo() { }

    //only this and derived classes
    protected void Bar() { }

    // only in this asembly
    internal void Daw() { }
  }

  class Poodle: Dog
  {
    void x()
    {
      this.Speak(2, sit:true);
    }
  }
}
