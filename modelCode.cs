using System;

public class Model
{
    private IView view;
    private IController controller;
    private string _data;

    // Getter und Setter Eigenschaft
    public string Data
    {
        get => _data;
        set
        {
            if (_data != value)
            {
                _data = value;
            
                view?.UpdateView(_data);
            }
        }
    }

    public Model()
    {
        _data = string.Empty;
    }

    public void SetView(IView view) => this.view = view;
    public void SetController(IController controller) => this.controller = controller;

    public void SendData()
    {
        if (!string.IsNullOrEmpty(_data))
        {
            controller?.ProcessSentData(_data);
        }
    }
}
