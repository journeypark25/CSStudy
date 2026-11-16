using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CSStudy;

class MyArea: Form
{
    public Label label = new Label();
    public MyArea()
    {
        this.MouseClick += delegate{MyAreaClicked();};
        label.Text ="";
    

    }
    public delegate void ClickDelegate(object sender);
    public ClickDelegate MyClick;

    void MyAreaClicked(){
    if(MyClick!= null) MyClick(this);
    }
    static void Afterclick(object sender)
    {
        // area.Text+="AfterClick 클릭";
    }
    static void Area_Click(object sender)
    {
        // area.Text ="My Area 클릭";
    }
}