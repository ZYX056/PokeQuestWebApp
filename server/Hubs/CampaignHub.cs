using Microsoft.AspNetCore.SignalR;

public class  CampaignHub : Hub
{
    // Called when a trainer opens a campaign
    public async Task JoinCampaign(string campaignId)
    {
        // Each campaign is a "group" in SignalR
        // Groups isolate messages between campaigns
        await Groups.AddToGroupAsync(
            Context.ConnectionId, // Unique socket connection
            campaignId            // Campaign scope
            ); 
    }

    // Called when a trainer leaves or disconnects
    public async Task LeaveCampaign(string campaignId)
    {
        // Removes this connection from the campaign group
        await Groups.RemoveFromGroupAsync(
            Context.ConnectionId,
            campaignId
            );
    }
}