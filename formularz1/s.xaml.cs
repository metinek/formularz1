namespace formularz1;

public partial class s : ContentPage
{
	public s()
	{
		InitializeComponent();
	}

	private void czyOk(object sender, EventArgs e)
	{
		string? ent = emailEnt.Text;
		bool czyOk = true;
		int liczMalpa = 0;
		if (ent == null) czyOk = false;

		if (czyOk == true)
		{
			for (int i = 0; i < ent.Length; i++)
			{
				if (ent[i] == '@') liczMalpa++;
			}

			if (ent.IndexOf('@') == 0 || ent.IndexOf('@') == ent.Length-1) czyOk = false;
			if (liczMalpa != 1) czyOk = false;
		}

		if (czyOk) weryfikacjaLbl.Text = "poprawny";
		else weryfikacjaLbl.Text = "z³y";

    }
}