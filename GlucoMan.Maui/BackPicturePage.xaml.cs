namespace GlucoMan.Maui;

public partial class BackPicturePage : ContentPage
{
    public bool edit = false;
    public double[,] macr_posizioni = new double[130, 2];
    public int i=0;
    public string filePath = "C:/Users/christian.pastori/Desktop/glucoman/GlucoProgs/GlucoMan.Maui/Resources/Raw/dati_array.txt";
    public BackPicturePage()
	{
		InitializeComponent();
	}
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        // Position relative to the container view (the image).
        // The origin point is at the top-left corner of the image.
        Point? relativeToContainerPosition = e.GetPosition((View)sender);
        if (relativeToContainerPosition.HasValue)
        {
            double x = relativeToContainerPosition.Value.X;
            double y = relativeToContainerPosition.Value.Y;
            if(edit == true)
            {
                macr_posizioni[i, 0] = x;
                macr_posizioni[i, 1] = y;
                i++;
            }
        }
    }

    

    private void Save_Pressed(object sender, EventArgs e)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for(int j = 0; j<i; j++)
            {
                writer.WriteLine(macr_posizioni[j,0] + "\t" + macr_posizioni[j,1]); // Scrive ogni dato su una nuova riga nel file
            }
        }
        for(int j = 0;j<i; j++)
        {
            macr_posizioni[j, 0] = 0;
            macr_posizioni[j, 1] = 0;
        }
        i = 0;
        edit = false;
    }

    private void Edit_Pressed(object sender, EventArgs e)
    {
        edit = true;
    }
}