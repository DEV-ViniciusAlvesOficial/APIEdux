﻿using APIEdux.Domains;
using APIEdux.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEdux.Repositories
{
    public class CursoRepository : ICurso
    {
        private readonly CursoRepository _cursoRepository;

        public CursoRepository()
        {
            _cursoRepository = new CursoRepository();
        }

        public void Adicionar(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Curso BuscarID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Curso Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Curso> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
