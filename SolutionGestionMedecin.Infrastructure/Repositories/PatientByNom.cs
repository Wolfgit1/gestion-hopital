using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SolutionGestionMedecin.Core.Entities;
using SolutionGestionMedecin.SharedKernel.Interfaces;

namespace SolutionGestionMedecin.Infrastructure.Repositories
{
    public class PatientByNom : ISpecification<Patient>
    {
        public Expression<Func<Patient, bool>> Criteria { get; }
        public List<Expression<Func<Patient, object>>> Includes { get; } = new List<Expression<Func<Patient, object>>>();
        public List<string> IncludeStrings { get; } = new List<string>();
        public Expression<Func<Patient, object>> OrderBy { get; private set; }
        public Expression<Func<Patient, object>> OrderByDescending { get; private set; }
        public Expression<Func<Patient, object>> GroupBy { get; private set; }
        public int Take { get; private set; } = 0;
        public int Skip { get; private set; } = 0;
        public bool IsPagingEnabled { get; private set; } = false;

        public PatientByNom(string nom)
        {
            Criteria = p => p.Nom == nom; // Critère de recherche basé sur le nom
        }

        // Méthode pour ajouter des relations à inclure
        public void AddInclude(Expression<Func<Patient, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        // Méthode pour ajouter des relations à inclure via une chaîne
        public void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }

        // Méthode pour configurer un tri ascendant
        public void ApplyOrderBy(Expression<Func<Patient, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }

        // Méthode pour configurer un tri descendant
        public void ApplyOrderByDescending(Expression<Func<Patient, object>> orderByDescendingExpression)
        {
            OrderByDescending = orderByDescendingExpression;
        }

        // Méthode pour configurer un groupement
        public void ApplyGroupBy(Expression<Func<Patient, object>> groupByExpression)
        {
            GroupBy = groupByExpression;
        }

        // Méthode pour configurer la pagination
        public void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}
