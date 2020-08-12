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

    public partial class SecretAgents : ComponentBase
    {
        [Inject]
        private HttpClient _client { get; set; }

        [Inject]
        private NavigationManager NavManager { get; set; }
        SecretAgent[] agents;

        protected override async Task OnInitializedAsync()
        {
            agents = await _client.GetFromJsonAsync<SecretAgent[]>("api/secretagent");
        }

        void EditAgent(int id)
        {
            NavManager.NavigateTo($"/secretagent/{id}/edit");
        }
        void CreateAgent()
        {
            NavManager.NavigateTo($"/secretagent/create");

        }
    }
}
