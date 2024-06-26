﻿using Cliente.Domain.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Cliente.CrossCutting.Commands
{
    public class CreateClienteCommand : IRequest<ClienteDTO>
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public string? Observacao { get; set; }
    }
}
