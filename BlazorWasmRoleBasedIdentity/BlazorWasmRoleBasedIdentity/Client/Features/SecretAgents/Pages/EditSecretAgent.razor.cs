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
    public partial class EditSecretAgent : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        private HttpClient _client { get; set; }
        [Inject]
        private NavigationManager NavManager { get; set; }
        SecretAgentRequest agent;

        protected override async Task OnInitializedAsync()
        {
            var selectedagent = await _client.GetFromJsonAsync<SecretAgent>($"api/secretagent/{Id}");
            agent = new SecretAgentRequest()
            {
                Id = selectedagent.Id,
                Name = selectedagent.Name,
                Alias = selectedagent.Alias
            };
        }

        async Task Update()
        {
            await _client.PutAsJsonAsync("api/secretagent", agent);
            NavManager.NavigateTo("/secretagent");
        }
    }
}
