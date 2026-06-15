using System.Collections.Generic;
using Teste.Models;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

List<Pessoa> pessoas = [
    new Pessoa("Geremias", 10),
    new Pessoa("Carlitos maia", 100)
];

app.MapGet("/pessoas/exibir", () => pessoas);

app.MapDelete("/pessoas/excluir/{index}", (int index) => pessoas.RemoveAt(index));

app.UseSwaggerUI();

app.Run(); 
