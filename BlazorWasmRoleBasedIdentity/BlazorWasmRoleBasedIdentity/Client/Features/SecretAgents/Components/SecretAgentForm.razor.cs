using BlazorWasmRoleBasedIdentity.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmRoleBasedIdentity.Client.Features.SecretAgents.Components
{
    public partial class SecretAgentForm
    {
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public SecretAgentRequest Agent { get; set; }

        [Parameter]
        public EventCallback<SecretAgentRequest> OnSave { get; set; }

        [Parameter]
        public bool IsEdit { get; set; } = false;

        Task Save()
        {
            return OnSave.InvokeAsync(Agent);
        }
    }
}
