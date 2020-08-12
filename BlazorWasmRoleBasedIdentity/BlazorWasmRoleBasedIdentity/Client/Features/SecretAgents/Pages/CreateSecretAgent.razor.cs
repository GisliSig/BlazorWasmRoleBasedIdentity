using BlazorWasmRoleBasedIdentity.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWasmRoleBasedIdentity.Client.Features.SecretAgents.Pages
{
    [Authorize(Policy = "CanEdit")]
    public partial class CreateSecretAgent : ComponentBase
    {
        [Inject]
        private HttpClient _client { get; set; }

        [Inject]
        private NavigationManager NavManager { get; set; }
        SecretAgentRequest _request = new SecretAgentRequest();

        async Task Create()
        {
            await _client.PostAsJsonAsync("api/secretagent", _request);
            NavManager.NavigateTo("/secretagent");
        }

    }
}
