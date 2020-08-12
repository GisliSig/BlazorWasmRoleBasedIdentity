using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWasmRoleBasedIdentity.Shared;
using IdentityServer4.EntityFramework.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmRoleBasedIdentity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretAgentController : ControllerBase
    {
        private static List<SecretAgent> Agents = new List<SecretAgent>()
      {
            new SecretAgent()
            {
                Id = 1,
                Name ="John",
                Alias = "The Menace"
            },
            new SecretAgent()
            {
                Id = 2,
                Name="Paul",
                Alias = "The Tool"
            }
        };
        [HttpGet]
        public List<SecretAgent> Get()
        {
            return Agents;
        }

        [HttpGet, Route("{Id}")]
        public SecretAgent GetOne(int Id)
        {
            return Agents.SingleOrDefault(x => x.Id == Id);
        }

        [HttpPut]
        [Authorize(Policy = "CanEditAgent")]
        public void EditAgent(SecretAgentRequest agent)
        {
            var selectedagent = Agents.SingleOrDefault(x => x.Id == agent.Id);
            if (selectedagent != null)
            {
                selectedagent.Name = agent.Name;
                selectedagent.Alias = agent.Alias;
            }
        }

        [HttpPost]
        [Authorize(Policy = "CanEditAgent")]
        public void Create(SecretAgent agent)
        {
            Agents.Add(new SecretAgent() { Id = Agents.Max(x => x.Id) + 1, Name = agent.Name, Alias = agent.Alias });
        }

    }
}
