using PostmanLibrary;

namespace PostmanUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.SelectedItem = "GET";
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API";
        resultsText.Text = "";

        //Validate API URL
        if (api.isValidUrl(apiText.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        //Call API
        HttpAction action;
        if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP verb";
            return;
        }

        try
        {
            resultsText.Text = await api.CallApiAsync(apiText.Text, true, action);
            callData.SelectedTab = resultsTab;
            resultsTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
