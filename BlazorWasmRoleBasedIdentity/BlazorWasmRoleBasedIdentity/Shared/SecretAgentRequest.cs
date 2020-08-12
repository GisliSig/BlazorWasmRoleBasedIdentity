using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace BlazorWasmRoleBasedIdentity.Shared
{
    public class SecretAgentRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name may not be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Alias may not be empty")]
        public string Alias { get; set; }
    }
}
