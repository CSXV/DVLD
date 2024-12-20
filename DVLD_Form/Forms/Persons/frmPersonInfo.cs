using System.Windows.Forms;

namespace DVLD_Form.Forms {
  public partial class frmPersonInfo : Form {
    public frmPersonInfo(int PersonID) {
      InitializeComponent();

      cntrlPersonInfo1.SetID(PersonID);
      cntrlPersonInfo1.UpdateControl();

    }

  }
}
