class MyButton
{
    public string Text;

    public event EventHandler click
    {
        add
        {
            _click +=value;
        }
        remove
        {
            _click -= value;
        }
    }
    private EventHandler _click;

    public void MouseButtonDown()
    {
        if (this.click != null)
        {
            _click(this, EventArgs.Empty);
        }
    }

    static void btn_click()
    {
        
    }
}