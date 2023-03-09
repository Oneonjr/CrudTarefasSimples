using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CRUDTarefas.models
{
    public class Tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Newtonsoft.Json.JsonIgnore]
        public int idTarefa { get; set; }
        public string nomeTarefa { get; set; }
        public string descricaoTarefa { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
        public status Status { get; set; } = status.pendente;
    }
}